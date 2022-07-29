 using PharmaCare.Baza;
using PharmaCare.Klase;
using System;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;

namespace PharmaCare
{
    public partial class FormPrijava : Form
    {
        public FormPrijava()
        {
            InitializeComponent();
        }

        public FormPrijava(string poruka)
        {
            InitializeComponent();

            if (poruka == "odjava")
                labelOdjava.Text = "Uspješna odjava!";

            var t = new Timer();
            t.Interval = 3000;      //trajanje od 3 sekunde

            t.Tick += (s, e) =>
            {
                labelOdjava.Hide();
                t.Stop();
            };
            t.Start();
        }

        private void btnPrijaviObicnog_Click(object sender, EventArgs e)
        {
            PrijaviKorisnika("dhehet", "lozinka123");
        }

        private void btnPrijaviAdmina_Click(object sender, EventArgs e)
        {
            PrijaviKorisnika("lcanzar", "pass123");
        }

        private void PrijaviKorisnika(string korisnickoIme, string lozinka)
        {
            Korisnik prijavljeniKorisnik = new Korisnik();

            using (var baza = new PharmaCare_DBEntities())
            {
                var korisnik = baza.korisnik.FirstOrDefault(k => k.korisnicko_ime == korisnickoIme && k.lozinka == lozinka);

                if (korisnik != null)
                {
                    prijavljeniKorisnik.idKorisnika = korisnik.korisnik_id;
                    prijavljeniKorisnik.korisnickoImeKorisnika = korisnik.korisnicko_ime;
                    prijavljeniKorisnik.lozinkaKorisnika = korisnik.lozinka;
                    prijavljeniKorisnik.imeKorisnika = korisnik.ime;
                    prijavljeniKorisnik.prezimeKorisnika = korisnik.prezime;

                    if (korisnik.uloga.naziv_uloge == "obicni korisnik")
                        prijavljeniKorisnik.ulogaKorisnika = UlogaKorisnika.ObicniKorisnik;

                    else
                        prijavljeniKorisnik.ulogaKorisnika = UlogaKorisnika.Administrator;
                }

                else
                    MessageBox.Show("Nije pronađen taj korisnik");
            }

            FormPocetna pocetnaForma = new FormPocetna(prijavljeniKorisnik);
            this.Hide();
            pocetnaForma.Closed += (s, args) => this.Close();
            pocetnaForma.Show();
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

        private void FormPrijava_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string putanja = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "");
                putanja += "Help\\PharmaCarePrirucnik.chm";
                Help.ShowHelp(this, putanja, HelpNavigator.Topic, "Prijava.htm");
            }
        }
    }
}
