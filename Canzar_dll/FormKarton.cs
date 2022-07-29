using System;
using System.Windows.Forms;

namespace Canzar_dll
{
    public partial class FormKarton : Form
    {
        private Klijent odabraniKlijent;

        public FormKarton(Klijent klijent)
        {
            InitializeComponent();

            odabraniKlijent = klijent;
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

        public void IspuniPodatke()
        {
            tboxIme.Text = odabraniKlijent.imeKlijenta;
            tboxPrezime.Text = odabraniKlijent.prezimeKlijenta;
            mtboxMobilniBroj.Text = odabraniKlijent.kontaktBroj;
            tboxStarost.Text = odabraniKlijent.starost.ToString();
            tboxEmail.Text = odabraniKlijent.email.ToString();
            tboxBodovi.Text = odabraniKlijent.bodovi.ToString();

            if (odabraniKlijent.clan == true)
                chboxClan.Checked = true;

            else
                chboxClan.Checked = false;
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormKarton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string putanja = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "");
                putanja += "Help\\PharmaCarePrirucnik.chm";
                Help.ShowHelp(this, putanja, HelpNavigator.Topic, "Zdravstveni_karton.htm");
            }
        }
    }
}
