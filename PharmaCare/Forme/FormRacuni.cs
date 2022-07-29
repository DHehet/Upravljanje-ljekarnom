using IspisPDF;
using PharmaCare.Baza;
using PharmaCare.Klase;
using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PharmaCare.Forme
{
    public partial class FormRacuni : Form
    {
        private Korisnik prijavljeniKorisnik;

        public FormRacuni()
        {
            InitializeComponent();
        }

        public FormRacuni(Korisnik korisnik)
        {
            InitializeComponent();

            prijavljeniKorisnik = korisnik;
        }

        private void FormRacuni_Load(object sender, EventArgs e)
        {
            OsvjeziRacune();
            OsvjeziStorniraneRacune();
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;

            Cursor = Cursors.Default;
        }

        private void button_MouseMove(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;

            Cursor = Cursors.Hand;
        }

        private void OsvjeziRacune()
        {
            using (var baza = new PharmaCare_DBEntities())
            {
                var upit = from r in baza.racun
                           join s_r in baza.stavka_racuna on r.racun_id equals s_r.racun_id
                           select new
                           {
                               r.racun_id,
                               r.klijent_id,
                               ImeKlijenta = r.klijent.ime + r.klijent.prezime,
                               s_r.lijek_id,
                               NazivLijeka = s_r.lijek.naziv,
                               s_r.kolicina,
                               r.ukupni_iznos__HRK_,
                               r.datum_vrijeme_izdavanja,
                               r.korisnik_id,
                               ImeKorisnika = r.korisnik.ime + r.korisnik.prezime
                           };

                dgvRacuni.DataSource = upit.ToList();
                dgvRacuni.Columns["ukupni_iznos__HRK_"].Visible = false;
                dgvRacuni.Columns["datum_vrijeme_izdavanja"].Visible = false;
                dgvRacuni.Columns["korisnik_id"].Visible = false;
                dgvRacuni.Columns["ImeKorisnika"].Visible = false;
                dgvRacuni.Columns["lijek_id"].Visible = false;
            }
        }

        private void OsvjeziStorniraneRacune()
        {
            using (var baza = new PharmaCare_DBEntities())
            {
                var upit = from r in baza.racun
                           where r.ukupni_iznos__HRK_ < 0
                           select new
                           {
                               r.racun_id,
                               r.klijent_id,
                               ImeKlijenta = r.klijent.ime + r.klijent.prezime,
                               r.ukupni_iznos__HRK_,
                               r.datum_vrijeme_izdavanja,
                               r.korisnik_id,
                               ImeKorisnika = r.korisnik.ime + r.korisnik.prezime
                           };

                dgvStorniraniRacuni.DataSource = upit.ToList();
                dgvStorniraniRacuni.Columns["ukupni_iznos__HRK_"].Visible = false;
                dgvStorniraniRacuni.Columns["datum_vrijeme_izdavanja"].Visible = false;
                dgvStorniraniRacuni.Columns["korisnik_id"].Visible = false;
                dgvStorniraniRacuni.Columns["ImeKorisnika"].Visible = false;
            }
        }

        private void dgvRacuni_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            btnIsprintaj.Enabled = true;
            btnStorniraj.Enabled = true;
            labelStorniran.Hide();

            string nazivKlijenta = dgvRacuni.CurrentRow.Cells["ImeKlijenta"].Value.ToString();
            string[] podaciKlijenta = Regex.Split(nazivKlijenta, @"(?<!^)(?=[A-Z])");
            tboxNazivKlijenta.Text = $"{podaciKlijenta[0]} {podaciKlijenta[1]}";

            string nazivKorisnika = dgvRacuni.CurrentRow.Cells["ImeKorisnika"].Value.ToString();
            string[] podaciKorisnika = Regex.Split(nazivKorisnika, @"(?<!^)(?=[A-Z])");
            tboxNazivKorisnika.Text = $"{podaciKorisnika[0]} {podaciKorisnika[1]}";

            tboxDatumVrijemeIzdavanja.Text = dgvRacuni.CurrentRow.Cells["datum_vrijeme_izdavanja"].Value.ToString();
            tboxUkupniIznos.Text = dgvRacuni.CurrentRow.Cells["ukupni_iznos__HRK_"].Value.ToString();
        }

        private void dgvStorniraniRacuni_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            btnIsprintaj.Enabled = false;
            btnStorniraj.Enabled = false;

            string nazivKlijenta = dgvStorniraniRacuni.CurrentRow.Cells["ImeKlijenta"].Value.ToString();
            string[] podaciKlijenta = Regex.Split(nazivKlijenta, @"(?<!^)(?=[A-Z])");
            tboxNazivKlijenta.Text = $"{podaciKlijenta[0]} {podaciKlijenta[1]}";

            string nazivKorisnika = dgvStorniraniRacuni.CurrentRow.Cells["ImeKorisnika"].Value.ToString();
            string[] podaciKorisnika = Regex.Split(nazivKorisnika, @"(?<!^)(?=[A-Z])");
            tboxNazivKorisnika.Text = $"{podaciKorisnika[0]} {podaciKorisnika[1]}";

            tboxDatumVrijemeIzdavanja.Text = dgvStorniraniRacuni.CurrentRow.Cells["datum_vrijeme_izdavanja"].Value.ToString();
            tboxUkupniIznos.Text = dgvStorniraniRacuni.CurrentRow.Cells["ukupni_iznos__HRK_"].Value.ToString();

            labelStorniran.Show();
            labelStorniran.Text = "Ovaj račun je storniran!";
        }

        private void btnStorniraj_Click(object sender, EventArgs e)
        {
            DialogResult potvrda = MessageBox.Show("Jeste li sigurni da želite stornirati račun?", "Potvrda",
                MessageBoxButtons.YesNo);

            if (potvrda == DialogResult.Yes)
            {
                using (var baza = new PharmaCare_DBEntities())
                {
                    int racunId = (int)dgvRacuni.CurrentRow.Cells["racun_id"].Value;
                    decimal ukupniIznos = (decimal)dgvRacuni.CurrentRow.Cells["ukupni_iznos__HRK_"].Value;
                    ukupniIznos *= -1;
                    int klijentId = (int)dgvRacuni.CurrentRow.Cells["klijent_id"].Value;
                    int korisnikId = prijavljeniKorisnik.idKorisnika;

                    racun storniraniRacun = new racun
                    {
                        racun_id = racunId,
                        ukupni_iznos__HRK_ = ukupniIznos,
                        datum_vrijeme_izdavanja = DateTime.Now,
                        klijent_id = klijentId,
                        korisnik_id = korisnikId
                    };

                    baza.racun.Add(storniraniRacun);

                    baza.SaveChanges();
                }
            }

            else if (potvrda == DialogResult.No)
            {
                //ništa
            }

            OsvjeziRacune();
            OsvjeziStorniraneRacune();
        }

        private void btnIsprintaj_Click(object sender, EventArgs e)
        {
            Ispis.IspisiTablicu(dgvRacuni);
        }

        private void FormRacuni_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string putanja = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "");
                putanja += "Help\\PharmaCarePrirucnik.chm";
                Help.ShowHelp(this, putanja, HelpNavigator.Topic, "Popis_racuna.htm");
            }
        }
    }
}
