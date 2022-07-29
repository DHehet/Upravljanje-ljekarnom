using PharmaCare.Baza;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PharmaCare.Forme
{
    public partial class FormNarucivanje : Form
    {
        private lijek odabraniLijek;
        private string imeLijeka, imeDobavljaca;
        private int lijekId, stanjeZaliha, kolicinaZaNaruciti;

        public FormNarucivanje()
        {
            InitializeComponent();
        }

        public FormNarucivanje(lijek lijek)
        {
            InitializeComponent();

            odabraniLijek = lijek;
        }

        private void FormNarucivanje_Load(object sender, System.EventArgs e)
        {
            imeLijeka = odabraniLijek.naziv;
            imeDobavljaca = odabraniLijek.ime_dobavljaca;
            stanjeZaliha = odabraniLijek.stanje_zaliha;
            lijekId = odabraniLijek.lijek_id;

            tboxNaziv.Text = imeLijeka;
            tboxImeDobavljaca.Text = imeDobavljaca;
            tboxStanjeZaliha.Text = stanjeZaliha.ToString();

            btnKontaktiraj.Enabled = false;
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

        private void mtboxKolicinaNaruci_KeyUp(object sender, KeyEventArgs e)
        {
            if (mtboxKolicinaNaruci.MaskCompleted && mtboxKolicinaNaruci.Text != "")
            {
                labelGreska.Hide();
                btnKontaktiraj.Enabled = true;
            }

            if (mtboxKolicinaNaruci.Text == "0" || mtboxKolicinaNaruci.Text == "00" ||
                mtboxKolicinaNaruci.Text == "" || mtboxKolicinaNaruci.Text == " 0")
            {
                labelGreska.Show();
                btnKontaktiraj.Enabled = false;

                labelGreska.Text = "Količina ne smije biti prazna ili 0!";
            }
        }

        private void btnKontaktiraj_Click(object sender, System.EventArgs e)
        {
            Random random = new Random();
            int slucajanOdabir = random.Next(2);

            if (slucajanOdabir == 1)
            {
                kolicinaZaNaruciti = int.Parse(mtboxKolicinaNaruci.Text);

                using (var baza = new PharmaCare_DBEntities())
                {
                    lijek upit = (from l in baza.lijek
                                  where l.lijek_id == lijekId
                                  select l).First();

                    upit.stanje_zaliha += kolicinaZaNaruciti;

                    baza.SaveChanges();
                }

                MessageBox.Show($"Dobavljač {imeDobavljaca} je dostavio {kolicinaZaNaruciti} količina lijeka {imeLijeka}.",
                    "Količina dostavljena");
            }

            else
            {
                MessageBox.Show("Dobavljač nije u stanju dostaviti zalihe.\nPokušajte ponovno kasnije.",
                    "Dobavljač zauzet");
                btnKontaktiraj.Enabled = false;
            }

            OsvjeziLijek();
        }

        private void OsvjeziLijek()
        {
            using (var baza = new PharmaCare_DBEntities())
            {
                lijek upit = (from l in baza.lijek
                              where l.lijek_id == lijekId
                              select l).First();

                tboxNaziv.Text = upit.naziv;
                tboxImeDobavljaca.Text = upit.ime_dobavljaca;
                tboxStanjeZaliha.Text = upit.stanje_zaliha.ToString();
            }

            mtboxKolicinaNaruci.Text = "";
        }

        private void btnOdustani_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void FormNarucivanje_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string putanja = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "");
                putanja += "Help\\PharmaCarePrirucnik.chm";
                Help.ShowHelp(this, putanja, HelpNavigator.Topic, "Narucivanje_lijeka.htm");
            }
        }
    }
}
