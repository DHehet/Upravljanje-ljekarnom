using PharmaCare.Baza;
using PharmaCare.Klase;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PharmaCare.Forme
{
    public partial class FormProizvodaciLijekova : Form
    {
        private Korisnik prijavljeniKorisnik;
        private bool ucitana = false;

        public FormProizvodaciLijekova()
        {
            InitializeComponent();
        }

        public FormProizvodaciLijekova(Korisnik korisnik)
        {
            InitializeComponent();

            prijavljeniKorisnik = korisnik;
        }

        private void FormProizvodaciLijekova_Load(object sender, EventArgs e)
        {
            labelNazivPrijavljenogKorisnika.Text = $"{prijavljeniKorisnik.imeKorisnika} {prijavljeniKorisnik.prezimeKorisnika}";
            labelUlogaPrijavljenogKorisnika.Text = prijavljeniKorisnik.ulogaKorisnika.ToString();
            labelDatumVrijeme.Text = DateTime.Now.ToString();

            if (prijavljeniKorisnik.ulogaKorisnika == UlogaKorisnika.ObicniKorisnik)
            {
                btnZaposlenici.Visible = false;
                labelUlogaPrijavljenogKorisnika.ForeColor = Color.Green;

                btnDodaj.Enabled = false;
                btnAzuriraj.Enabled = false;
                btnObrisi.Enabled = false;
                btnOcisti.Enabled = false;
                tboxNaziv.Enabled = false;
                cboxZemlja.Enabled = false;
                tboxAdresa.Enabled = false;
                mtboxKontaktBroj.Enabled = false;
                dgvProizvodaci.Enabled = false;
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

            OsvjeziGUI();
            ucitana = true;

            if (dgvProizvodaci.SelectedRows.Count == 0)
                btnObrisi.Enabled = false;
        }

        private void osvjeziVrijeme(object sender, EventArgs e)
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

            if (button != btnDodaj && button != btnAzuriraj && button != btnObrisi &&
                button != btnOcisti)
                button.BackColor = Color.Transparent;

            Cursor = Cursors.Default;
        }

        private void button_MouseMove(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;

            Cursor = Cursors.Hand;
        }

        private void btnDodajIliAzuriraj_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            bool greska = false;

            string naziv = tboxNaziv.Text;
            string zemlja = "";
            string adresa = tboxAdresa.Text;
            string kontaktBroj = mtboxKontaktBroj.Text;

            if ((naziv == "" || adresa == "") || cboxZemlja.SelectedItem == null ||
                mtboxKontaktBroj.MaskCompleted == false)
            {
                labelGreska.Show();
                labelGreska.Text = "Naziv i adresa moraju biti popunjeni!\nMorate odabrati zemlju iz popisa!\n" +
                    "Mobilni broj mora biti ispravno formatiran!";
                greska = true;
            }

            else
            {
                zemlja = cboxZemlja.SelectedItem.ToString();
                greska = false;
                labelGreska.Hide();
            }

            if (!greska && button == btnDodaj)
            {
                using (var baza = new PharmaCare_DBEntities())
                {
                    proizvodac proizvodac = new proizvodac
                    {
                        naziv = naziv,
                        zemlja_porijekla = zemlja,
                        adresa = adresa,
                        kontakt_broj = kontaktBroj
                    };

                    baza.proizvodac.Add(proizvodac);
                    baza.SaveChanges();
                }

                OsvjeziGUI();
            }

            else if (!greska && button == btnAzuriraj)
            {
                proizvodac oznaceniProizvodac = DohvatiProizvodaca();

                using (var baza = new PharmaCare_DBEntities())
                {
                    baza.proizvodac.Attach(oznaceniProizvodac);
                    oznaceniProizvodac.naziv = naziv;
                    oznaceniProizvodac.zemlja_porijekla = zemlja;
                    oznaceniProizvodac.adresa = adresa;
                    oznaceniProizvodac.kontakt_broj = kontaktBroj;
                    baza.SaveChanges();
                }

                OsvjeziGUI();
            }
        }

        private void OsvjeziGUI()
        {
            using (var baza = new PharmaCare_DBEntities())
            {
                var upit = from p in baza.proizvodac select p;

                dgvProizvodaci.DataSource = upit.ToList();
                dgvProizvodaci.Columns["proizvodac_id"].Visible = false;
                dgvProizvodaci.Columns["lijek"].Visible = false;
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            proizvodac oznaceniProizvodac = DohvatiProizvodaca();

            if (oznaceniProizvodac != null)
            {
                using (var baza = new PharmaCare_DBEntities())
                {
                    baza.proizvodac.Attach(oznaceniProizvodac);
                    baza.proizvodac.Remove(oznaceniProizvodac);
                    baza.SaveChanges();
                }
            }

            OsvjeziGUI();
        }

        private void btnOcisti_Click(object sender, EventArgs e)
        {
            tboxNaziv.Clear();
            cboxZemlja.SelectedItem = null;
            tboxAdresa.Clear();
            mtboxKontaktBroj.Clear();

            labelGreska.Hide();
        }

        private void dgvProizvodaci_SelectionChanged(object sender, EventArgs e)
        {
            if (ucitana == true && dgvProizvodaci.SelectedCells.Count > 0)
            {
                proizvodac oznaceniProizvodac = DohvatiProizvodaca();

                tboxNaziv.Text = oznaceniProizvodac.naziv;
                cboxZemlja.SelectedItem = oznaceniProizvodac.zemlja_porijekla;
                tboxAdresa.Text = oznaceniProizvodac.adresa;
                mtboxKontaktBroj.Text = oznaceniProizvodac.kontakt_broj;

                labelGreska.Hide();
                btnObrisi.Enabled = true;
            }
        }

        private proizvodac DohvatiProizvodaca()
        {
            return dgvProizvodaci.CurrentRow.DataBoundItem as proizvodac;
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

        private void btnIzdavanjeRacuna_Click(object sender, EventArgs e)
        {
            FormIzdavanjeRacuna izdavanjeRacunaForm = new FormIzdavanjeRacuna(prijavljeniKorisnik);
            this.Hide();
            izdavanjeRacunaForm.Closed += (s, args) => this.Close();
            izdavanjeRacunaForm.Show();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            prijavljeniKorisnik = null;

            FormPrijava prijavaForma = new FormPrijava("odjava");
            this.Hide();
            prijavaForma.Closed += (s, args) => this.Close();
            prijavaForma.Show();
        }

        private void FormProizvodaciLijekova_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                if (prijavljeniKorisnik.ulogaKorisnika == UlogaKorisnika.ObicniKorisnik)
                {
                    string putanja = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "");
                    putanja += "Help\\PharmaCarePrirucnik.chm";
                    Help.ShowHelp(this, putanja, HelpNavigator.Topic, "Popis_proizvodaca_obicni.htm");
                }

                else if (prijavljeniKorisnik.ulogaKorisnika == UlogaKorisnika.Administrator)
                {
                    string putanja = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "");
                    putanja += "Help\\PharmaCarePrirucnik.chm";
                    Help.ShowHelp(this, putanja, HelpNavigator.Topic, "Popis_proizvodaca_administrator.htm");
                }
            }
        }
    }
}
