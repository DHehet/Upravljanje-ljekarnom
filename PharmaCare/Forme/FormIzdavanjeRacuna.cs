using PharmaCare.Baza;
using PharmaCare.Klase;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PharmaCare.Forme
{
    public partial class FormIzdavanjeRacuna : Form
    {
        private Korisnik prijavljeniKorisnik;

        public FormIzdavanjeRacuna()
        {
            InitializeComponent();
        }

        public FormIzdavanjeRacuna(Korisnik korisnik)
        {
            InitializeComponent();

            prijavljeniKorisnik = korisnik;
        }

        private void FormIzdavanjeRacuna_Load(object sender, EventArgs e)
        {
            labelNazivPrijavljenogKorisnika.Text = $"{prijavljeniKorisnik.imeKorisnika} {prijavljeniKorisnik.prezimeKorisnika}";
            labelUlogaPrijavljenogKorisnika.Text = prijavljeniKorisnik.ulogaKorisnika.ToString();
            labelDatumVrijeme.Text = DateTime.Now.ToString();

            if (prijavljeniKorisnik.ulogaKorisnika == UlogaKorisnika.ObicniKorisnik)
            {
                btnZaposlenici.Visible = false;
                labelUlogaPrijavljenogKorisnika.ForeColor = Color.Green;
            }

            else
            {
                btnZaposlenici.Visible = true;
                labelUlogaPrijavljenogKorisnika.ForeColor = Color.Red;
            }

            Timer t = new Timer();
            t.Interval = 1000;
            t.Tick += new EventHandler(osvjeziVrijeme);
            t.Start();

            PopuniCombo();

            btnDodaj.Enabled = false;
            btnUkloni.Enabled = false;
            btnIzdaj.Enabled = false;
        }

        private void PopuniCombo()
        {
            using (var baza = new PharmaCare_DBEntities())
            {
                var upit = from k in baza.klijent
                           select k;

                cboxNazivKlijenta.DataSource = upit.ToList();

                var upit_2 = from l in baza.lijek
                             select l;

                cboxNazivLijeka.DataSource = upit_2.ToList();
            }
        }

        void osvjeziVrijeme(object sender, EventArgs e)
        {
            Invoke((MethodInvoker)(() =>
            {
                labelDatumVrijeme.Text = DateTime.Now.ToString();
            }));
        }

        private void button_MouseEnter(object sender, EventArgs e)
        {
            Button button = sender as Button;

            button.BackColor = Color.White;
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (button != btnDodaj && button != btnUkloni && button != btnPopisRacuna
                && button != btnIzracunaj && button != btnIzdaj)
                button.BackColor = Color.Transparent;

            Cursor = Cursors.Default;
        }

        private void button_MouseMove(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;

            Cursor = Cursors.Hand;
        }

        private void cboxNazivKlijenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            OsvjeziKlijenta();
        }

        private void cboxNazivLijeka_SelectedIndexChanged(object sender, EventArgs e)
        {
            OsvjeziLijek();
        }

        private void OsvjeziKlijenta()
        {
            string[] podaciKlijenta = cboxNazivKlijenta.Text.Split(' ');
            string imeKlijenta = podaciKlijenta[0];
            string prezimeKlijenta = podaciKlijenta[1];

            labelPopust.Text = "";
            tboxTotal.Text = "";
            tboxBodovi.Text = "";

            using (var baza = new PharmaCare_DBEntities())
            {
                var upit = from k in baza.klijent
                           where k.ime == imeKlijenta &&
                           k.prezime == prezimeKlijenta
                           select new
                           {
                               k.klijent_id,
                               k.clan,
                               k.bodovi
                           };

                foreach (var item in upit)
                {
                    tboxIdKlijenta.Text = item.klijent_id.ToString();

                    if (item.clan.ToString() == "True")
                        tboxClan.Text = "DA";

                    else
                        tboxClan.Text = "NE";

                    tboxBodovi.Text = item.bodovi.ToString();
                }
            }
        }

        private void OsvjeziLijek()
        {
            string nazivLijeka = cboxNazivLijeka.Text;

            mtboxKolicina.Text = "";
            tboxUkupnaCijena.Text = "";

            using (var baza = new PharmaCare_DBEntities())
            {
                var upit = from l in baza.lijek
                           where l.naziv == nazivLijeka
                           select new
                           {
                               l.lijek_id,
                               l.stanje_zaliha,
                               l.cijena__HRK_
                           };

                foreach (var item in upit)
                {
                    tboxIdLijeka.Text = item.lijek_id.ToString();
                    tboxStanjeZaliha.Text = item.stanje_zaliha.ToString();
                    tboxCijena.Text = item.cijena__HRK_.ToString();
                }
            }
        }

        private void btnPopisRacuna_Click(object sender, EventArgs e)
        {
            FormRacuni formRacuni = new FormRacuni(prijavljeniKorisnik);
            formRacuni.ShowDialog();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            int idLijeka = int.Parse(tboxIdLijeka.Text);
            string nazivLijeka = cboxNazivLijeka.Text;
            decimal jedinicnaCijena = decimal.Parse(tboxCijena.Text);
            int kolicina = int.Parse(mtboxKolicina.Text);
            decimal ukupnaCijena = decimal.Parse(tboxUkupnaCijena.Text);

            dgvStavkeRacuna.Rows.Add(idLijeka, nazivLijeka, jedinicnaCijena, kolicina, ukupnaCijena);

            labelPopust.Text = "";
            tboxTotal.Text = "";
            btnIzdaj.Enabled = true;

            int stanjeZaliha = int.Parse(tboxStanjeZaliha.Text);

            //lokalno
            if (kolicina <= stanjeZaliha)
            {
                btnDodaj.Enabled = true;

                stanjeZaliha -= kolicina;

                tboxStanjeZaliha.Text = stanjeZaliha.ToString();
            }

            if (stanjeZaliha == 0)
            {
                labelGreska.Show();
                btnDodaj.Enabled = false;

                labelGreska.Text = "Nema više lijeka na zalihi!";
                tboxUkupnaCijena.Text = "";
            }
        }

        private void mtboxKolicina_KeyUp(object sender, KeyEventArgs e)
        {
            if (mtboxKolicina.MaskCompleted && mtboxKolicina.Text != "")
            {
                labelGreska.Hide();
                btnDodaj.Enabled = true;

                if (int.Parse(mtboxKolicina.Text) <= int.Parse(tboxStanjeZaliha.Text))
                {
                    tboxUkupnaCijena.Text = (int.Parse(mtboxKolicina.Text) * decimal.Parse(tboxCijena.Text)).ToString();
                    btnDodaj.Enabled = true;
                }

                else
                {
                    labelGreska.Show();
                    btnDodaj.Enabled = false;

                    labelGreska.Text = "Količina lijeka premašuje zalihe!";
                    tboxUkupnaCijena.Text = "";
                }

            }

            if (mtboxKolicina.Text == "0" || mtboxKolicina.Text == "00" ||
                mtboxKolicina.Text == "" || mtboxKolicina.Text == " 0")
            {
                labelGreska.Show();
                btnDodaj.Enabled = false;

                labelGreska.Text = "Količina ne smije biti prazna ili 0!";
                tboxUkupnaCijena.Text = "";
            }
        }

        private void btnUkloni_Click(object sender, EventArgs e)
        {
            int indeksOdabranogReda = dgvStavkeRacuna.CurrentCell.RowIndex;

            int kolicina = (int)dgvStavkeRacuna.CurrentRow.Cells["kolicina_lijeka"].Value;

            if (indeksOdabranogReda > -1)
            {
                dgvStavkeRacuna.Rows.RemoveAt(indeksOdabranogReda);
                dgvStavkeRacuna.Refresh();
            }

            labelPopust.Text = "";
            tboxTotal.Text = "";

            //lokalno
            int stanjeZaliha = int.Parse(tboxStanjeZaliha.Text);
            stanjeZaliha += kolicina;

            tboxStanjeZaliha.Text = stanjeZaliha.ToString();
        }

        private void dgvStavkeRacuna_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvStavkeRacuna.CurrentRow.Cells["id_lijeka"].Value == null)
            {
                btnUkloni.Enabled = false;
                btnIzdaj.Enabled = false;
            }

            else
            {
                btnUkloni.Enabled = true;
                btnIzdaj.Enabled = true;
                btnDodaj.Enabled = true;
                labelGreska.Hide();
            }
        }

        private void btnIzracunaj_Click(object sender, EventArgs e)
        {
            IzracunajTotal();
        }

        private void IzracunajTotal()
        {
            decimal suma = 0;

            foreach (DataGridViewRow red in dgvStavkeRacuna.Rows)
            {
                if (red.Cells["ukupna_cijena"].Value != null)
                {
                    suma += decimal.Parse(red.Cells["ukupna_cijena"].Value.ToString());
                }
            }

            tboxTotal.Text = suma.ToString();

            if (tboxClan.Text == "DA" && int.Parse(tboxBodovi.Text) >= 200)
            {
                decimal popust = 10;
                decimal cijenaSPopustom = decimal.Parse(tboxTotal.Text);

                cijenaSPopustom -= cijenaSPopustom * (popust / 100);
                cijenaSPopustom = Math.Round(cijenaSPopustom, 2);

                tboxTotal.Text = cijenaSPopustom.ToString();

                labelPopust.ForeColor = Color.Green;
                labelPopust.Text = "Izračunat popust od 10%!";
            }

            else if (tboxClan.Text == "DA" && int.Parse(tboxBodovi.Text) < 200)
            {
                IzracunajBodove();
            }

            else
            {
                labelPopust.ForeColor = Color.Red;
                labelPopust.Text = "Klijent nije član kluba vjernosti.";
            }
        }

        private int IzracunajBodove()
        {
            string[] cijena = tboxTotal.Text.Split(',');
            int brojStecenihBodova = int.Parse(cijena[0]);

            labelPopust.ForeColor = Color.Green;
            labelPopust.Text = $"Kupnjom dobivate {brojStecenihBodova} bodova.";

            return brojStecenihBodova;
        }

        private void btnIzdaj_Click(object sender, EventArgs e)
        {
            //baza
            if (tboxTotal.Text == "")
                IzracunajTotal();

            int brojBodova = IzracunajBodove();

            decimal ukupniIznos = decimal.Parse(tboxTotal.Text);
            int klijentId = int.Parse(tboxIdKlijenta.Text);
            int korisnikId = prijavljeniKorisnik.idKorisnika;

            using (var baza = new PharmaCare_DBEntities())
            {
                racun racun = new racun
                {
                    ukupni_iznos__HRK_ = ukupniIznos,
                    datum_vrijeme_izdavanja = DateTime.Now,
                    klijent_id = klijentId,
                    korisnik_id = korisnikId
                };

                baza.racun.Add(racun);

                foreach (DataGridViewRow stavka in dgvStavkeRacuna.Rows)
                {
                    if (stavka.Cells["id_lijeka"].Value != null)
                    {
                        string nazivLijeka = stavka.Cells["naziv_lijeka"].Value.ToString();
                        int kolicina = (int)stavka.Cells["kolicina_lijeka"].Value;

                        lijek upitLijek = (from l in baza.lijek
                                           where l.naziv == nazivLijeka
                                           select l).First();

                        upitLijek.stanje_zaliha -= kolicina;
                    }
                }

                if (tboxClan.Text == "DA" && int.Parse(tboxBodovi.Text) < 200)
                {
                    klijent upitKlijent = (from k in baza.klijent
                                           where k.klijent_id == klijentId
                                           select k).First();

                    upitKlijent.bodovi += brojBodova;
                }

                else if (tboxClan.Text == "DA" && int.Parse(tboxBodovi.Text) >= 200)
                {
                    klijent upitKlijent = (from k in baza.klijent
                                           where k.klijent_id == klijentId
                                           select k).First();

                    upitKlijent.bodovi -= 200;
                }

                baza.SaveChanges();

                //dodaje zapis u M:M entitet
                racun racun_2 = baza.racun.Attach(racun);

                foreach (DataGridViewRow stavka in dgvStavkeRacuna.Rows)
                {
                    if (stavka.Cells["id_lijeka"].Value != null)
                    {
                        stavka_racuna stavkaRacuna = new stavka_racuna
                        {
                            racun_id = racun_2.racun_id,
                            lijek_id = (int)stavka.Cells["id_lijeka"].Value,
                            kolicina = (int)stavka.Cells["kolicina_lijeka"].Value
                        };

                        baza.stavka_racuna.Add(stavkaRacuna);
                    }
                }

                baza.SaveChanges();
            }

            OsvjeziLijek();
            OsvjeziKlijenta();
            dgvStavkeRacuna.Rows.Clear();
            btnUkloni.Enabled = false;
            btnDodaj.Enabled = false;
        }

        private void btnPocetna_Click(object sender, EventArgs e)
        {
            FormPocetna pocetnaForma = new FormPocetna(prijavljeniKorisnik);
            this.Hide();
            pocetnaForma.Closed += (s, args) => this.Close();
            pocetnaForma.Show();
        }

        private void btnLijekovi_Click(object sender, EventArgs e)
        {
            FormLijekovi formaLijekovi = new FormLijekovi(prijavljeniKorisnik);
            this.Hide();
            formaLijekovi.Closed += (s, args) => this.Close();
            formaLijekovi.Show();
        }

        private void btnKlijenti_Click(object sender, EventArgs e)
        {
            FormKlijenti formaKlijenti = new FormKlijenti(prijavljeniKorisnik);
            this.Hide();
            formaKlijenti.Closed += (s, args) => this.Close();
            formaKlijenti.Show();
        }

        private void btnProizvodaci_Click(object sender, EventArgs e)
        {
            FormProizvodaciLijekova proizvodaciForma = new FormProizvodaciLijekova(prijavljeniKorisnik);
            this.Hide();
            proizvodaciForma.Closed += (s, args) => this.Close();
            proizvodaciForma.Show();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            prijavljeniKorisnik = null;

            FormPrijava prijavaForma = new FormPrijava("odjava");
            this.Hide();
            prijavaForma.Closed += (s, args) => this.Close();
            prijavaForma.Show();
        }

        private void FormIzdavanjeRacuna_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string putanja = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "");
                putanja += "Help\\PharmaCarePrirucnik.chm";
                Help.ShowHelp(this, putanja, HelpNavigator.Topic, "Izdavanje_racuna.htm");
            }
        }
    }
}
