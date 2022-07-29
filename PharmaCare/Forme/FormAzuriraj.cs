using PharmaCare.Baza;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PharmaCare.Forme
{
    public partial class FormAzuriraj : Form
    {
        private lijek odabraniLijek;
        int idProizvodac;

        public FormAzuriraj(lijek lijek)
        {
            InitializeComponent();

            odabraniLijek = lijek;
        }

        private void FormaAzuriraj_Load(object sender, EventArgs e)
        {
            using (var context = new PharmaCare_DBEntities())
            {
                var query = from p in context.proizvodac
                            select p.naziv;

                cmbProizvodac.DataSource = query.ToList();
                context.lijek.Attach(odabraniLijek);
                tboxNaziv.Text = odabraniLijek.naziv;
                tboxStanjeZaliha.Text = odabraniLijek.stanje_zaliha.ToString();
                nudCijena.Value = odabraniLijek.cijena__HRK_;
                tboxOpis.Text = odabraniLijek.opis;
                dtpRokUporabe.Value = odabraniLijek.rok_uporabe;
                cmbDobavljac.SelectedItem = odabraniLijek.ime_dobavljaca;
                dtpDatumProizvodnje.Value = odabraniLijek.datum_proizvodnje;
                cmbProizvodac.SelectedItem = odabraniLijek.proizvodac.naziv;
                nudCijena.Value = odabraniLijek.cijena__HRK_;
            }
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

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            string naziv = tboxNaziv.Text;
            decimal cijenaLijeka = nudCijena.Value;
            string opis = tboxOpis.Text;
            bool stanjeZalihaParsiraj = int.TryParse(tboxStanjeZaliha.Text, out int stanjeZaliha);
            DateTime rokUporabe = dtpRokUporabe.Value.Date;
            string imeDobavljaca = cmbDobavljac.SelectedItem.ToString();
            DateTime datumProizvodnje = dtpDatumProizvodnje.Value.Date;
            string imeProizvodaca = cmbProizvodac.SelectedItem.ToString();
            if (cijenaLijeka >= 10000)
            {
                labelGreska.Show();
                labelGreska.Text = "Nije moguće ažurirati lijek, cijena je izvan dosega";
            }
            else if (naziv.Length == 0 || stanjeZalihaParsiraj == false || opis.Length == 0 || cmbDobavljac.SelectedItem == null || cmbProizvodac.SelectedItem == null)
            {
                labelGreska.Show();
                labelGreska.Text = "Neuspješno ažuriranje lijeka.Sva polja moraju biti popunjena";
            }
            else
            {
                using (var context = new PharmaCare_DBEntities())
                {
                    context.lijek.Attach(odabraniLijek);
                    var query = from p in context.proizvodac
                                where p.naziv.Equals(imeProizvodaca)
                                select p;
                    foreach (var item in query)
                    {
                        if (item.naziv.Equals(imeProizvodaca))
                        {
                            idProizvodac = item.proizvodac_id;
                            break;
                        }
                    }

                    odabraniLijek.naziv = naziv;
                    odabraniLijek.stanje_zaliha = stanjeZaliha;
                    odabraniLijek.cijena__HRK_ = cijenaLijeka;
                    odabraniLijek.opis = opis;
                    odabraniLijek.rok_uporabe = rokUporabe;
                    odabraniLijek.ime_dobavljaca = imeDobavljaca;
                    odabraniLijek.datum_proizvodnje = datumProizvodnje;
                    odabraniLijek.proizvodac_id = idProizvodac;

                    context.SaveChanges();
                    Close();
                }
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
