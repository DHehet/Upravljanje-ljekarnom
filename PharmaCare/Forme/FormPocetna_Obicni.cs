using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PharmaCare.Klase;

namespace PharmaCare
{
    public partial class FormPocetna_Obicni : Form
    {
        private Korisnik prijavljeniKorisnik;

        public FormPocetna_Obicni()
        {
            InitializeComponent();
        }

        public FormPocetna_Obicni(Korisnik korisnik)
        {
            InitializeComponent();

            prijavljeniKorisnik = korisnik;
        }

        private void FormPocetna_Obicni_Load(object sender, EventArgs e)
        {
            labelNazivPrijavljenogKorisnika.Text = $"{prijavljeniKorisnik.imeKorisnika} {prijavljeniKorisnik.prezimeKorisnika}";
            labelUlogaPrijavljenogKorisnika.Text = prijavljeniKorisnik.ulogaKorisnika.ToString();
            labelUlogaPrijavljenogKorisnika.ForeColor = Color.Green;
            labelDatumVrijeme.Text = DateTime.Now.ToString();

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

            button.BackColor = Color.Transparent;
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
