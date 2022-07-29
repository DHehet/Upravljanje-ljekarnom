using PharmaCare.Baza;
using PharmaCare.Forme;
using PharmaCare.Klase;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PharmaCare
{
    public partial class FormPocetna : Form
    {
        private Korisnik prijavljeniKorisnik;

        public FormPocetna()
        {
            InitializeComponent();
        }

        public FormPocetna(Korisnik korisnik)
        {
            InitializeComponent();

            prijavljeniKorisnik = korisnik;
        }

        private void FormPocetna_Load(object sender, EventArgs e)
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

            DohvatiStanje();
        }

        private void DohvatiStanje()
        {
            List<lijek> lijekovi;
            List<korisnik> korisnici;
            List<proizvodac> proizvodaci;
            List<klijent> klijenti;

            using (var context = new PharmaCare_DBEntities())
            {
                lijekovi = context.lijek.ToList();
                korisnici = context.korisnik.ToList();
                proizvodaci = context.proizvodac.ToList();
                klijenti = context.klijent.ToList();
            }

            int brojKlijenata = klijenti.Count();
            int brojKorisnika = korisnici.Count();
            int brojProizvodaca = proizvodaci.Count();
            int brojLijekova = lijekovi.Count();

            txtKlijenti.Text = brojKlijenata.ToString();
            txtLijekovi.Text = brojLijekova.ToString();
            txtProizvodaci.Text = brojProizvodaca.ToString();
            txtZaposleni.Text = brojKorisnika.ToString();
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

            button.BackColor = Color.Transparent;
            Cursor = Cursors.Default;
        }

        private void button_MouseMove(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;

            Cursor = Cursors.Hand;
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

        private void FormPocetna_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string putanja = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "");
                putanja += "Help\\PharmaCarePrirucnik.chm";
                Help.ShowHelp(this, putanja, HelpNavigator.Topic, "Pocetna.htm");
            }
        }
    }
}
