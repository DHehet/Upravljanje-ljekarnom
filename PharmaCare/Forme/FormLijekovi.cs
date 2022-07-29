using PharmaCare.Baza;
using PharmaCare.Klase;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PharmaCare.Forme
{
    public partial class FormLijekovi : Form
    {
        private Korisnik prijavljeniKorisnik;

        public FormLijekovi()
        {
            InitializeComponent();
        }

        public FormLijekovi(Korisnik korisnik)
        {
            InitializeComponent();
            prijavljeniKorisnik = korisnik;
        }

        private void FormLijekovi_Load(object sender, EventArgs e)
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

            btnNaruci.Enabled = false;
            OsvjeziLijekove();
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

            if (button != btnDodaj && button != btnAzuriraj && button != btnObrisi &&
                button != btnResetiraj && button != btnTrazi && button != btnNaruci)
                button.BackColor = Color.Transparent;

            Cursor = Cursors.Default;
        }

        private void button_MouseMove(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;

            Cursor = Cursors.Hand;
        }

        private void btnPocetna_Click(object sender, EventArgs e)
        {
            FormPocetna pocetnaForma = new FormPocetna(prijavljeniKorisnik);
            this.Hide();
            pocetnaForma.Closed += (s, args) => this.Close();
            pocetnaForma.Show();
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
        private void OsvjeziLijekove()
        {
            using (var context = new PharmaCare_DBEntities())
            {
                var query = from l in context.lijek
                            select l;

                dgvLijekovi.DataSource = query.ToList();
                dgvLijekovi.Columns["proizvodac"].Visible = false;
                dgvLijekovi.Columns["stavka_racuna"].Visible = false;
                dgvLijekovi.Columns["klijent"].Visible = false;
            }
        }
        private lijek DohvatiLijek()
        {
            return dgvLijekovi.CurrentRow.DataBoundItem as lijek;
        }
        private void btnTrazi_Click(object sender, EventArgs e)
        {
            string trazi = txtTrazi.Text;

            using (var context = new PharmaCare_DBEntities())
            {
                var query = from l in context.lijek
                            where l.naziv.Contains(trazi)
                            select l;

                dgvLijekovi.DataSource = query.ToList();
                dgvLijekovi.Columns["proizvodac"].Visible = false;
                dgvLijekovi.Columns["stavka_racuna"].Visible = false;
                dgvLijekovi.Columns["klijent"].Visible = false;
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FormDodaj formaDodaj = new FormDodaj();
            formaDodaj.ShowDialog();
            OsvjeziLijekove(); 
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            lijek odabraniLijek = DohvatiLijek();

            using (var context = new PharmaCare_DBEntities())
            {
                context.lijek.Attach(odabraniLijek);
                context.lijek.Remove(odabraniLijek);
                context.SaveChanges();
                OsvjeziLijekove();
            }
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            lijek odabraniLijek = DohvatiLijek();
            FormAzuriraj formaAzuriraj = new FormAzuriraj(odabraniLijek);
            formaAzuriraj.ShowDialog();
            OsvjeziLijekove();
        }

        private void dgvLijekovi_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if ((int)dgvLijekovi.CurrentRow.Cells["stanje_zaliha"].Value < 5)
            {
                btnNaruci.Enabled = true;
            }

            else
                btnNaruci.Enabled = false;
        }

        private void btnNaruci_Click(object sender, EventArgs e)
        {
            lijek lijek = dgvLijekovi.CurrentRow.DataBoundItem as lijek;

            FormNarucivanje formNarucivanje = new FormNarucivanje(lijek);
            formNarucivanje.ShowDialog();

            OsvjeziLijekove();
        }

        private void btnResetiraj_Click(object sender, EventArgs e)
        {
            OsvjeziLijekove();
            txtTrazi.Clear();
        }

        private void FormLijekovi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string putanja = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "");
                putanja += "Help\\PharmaCarePrirucnik.chm";
                Help.ShowHelp(this, putanja, HelpNavigator.Topic, "Popis_lijekova.htm");
            }
        }
    }
}
