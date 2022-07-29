using Canzar_dll;
using PharmaCare.Baza;
using PharmaCare.Klase;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PharmaCare.Forme
{
    public partial class FormKlijenti : Form
    {
        private Korisnik prijavljeniKorisnik;

        public FormKlijenti()
        {
            InitializeComponent();
        }

        public FormKlijenti(Korisnik korisnik)
        {
            InitializeComponent();

            prijavljeniKorisnik = korisnik;
        }

        private void FormKlijenti_Load(object sender, EventArgs e)
        {
            using (var context = new PharmaCare_DBEntities())
            {
                var query = from k in context.klijent
                            select new Klijent
                            {
                                idKlijenta = k.klijent_id,
                                imeKlijenta = k.ime,
                                prezimeKlijenta = k.prezime,
                                kontaktBroj = k.kontakt_broj,
                                email = k.email_adresa,
                                starost = k.starost,
                                clan = k.clan,
                                bodovi = k.bodovi
                            };

                dgvKlijenti.DataSource = query.ToList();

            }

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

            if (button != btnZdravKarton)
                button.BackColor = Color.Transparent;

            Cursor = Cursors.Default;
        }

        private void button_MouseMove(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;

            Cursor = Cursors.Hand;
        }
        private Klijent DohvatiKlijenta()
        {
            return dgvKlijenti.CurrentRow.DataBoundItem as Klijent;
        }
        private void btnZdravKarton_Click(object sender, EventArgs e)
        {
            Klijent odabraniKlijent = DohvatiKlijenta();
            UpraviteljKlijentima manager = new UpraviteljKlijentima();
            manager.OtvoriZdravstveniKartonKlijenta(odabraniKlijent);
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
    }
}
