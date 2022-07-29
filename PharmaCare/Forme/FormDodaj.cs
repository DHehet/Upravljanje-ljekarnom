using PharmaCare.Baza;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PharmaCare.Forme
{
    public partial class FormDodaj : Form
    {
        int idProizvodac;
        public FormDodaj()
        {
            InitializeComponent();
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

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string naziv = tboxNaziv.Text;
            bool stanjeZalihaParsiraj = int.TryParse(tboxStanjeZaliha.Text, out int stanjeZaliha);
            decimal cijenaLijeka = nudCijena.Value;
            string opis = tboxOpis.Text;
            DateTime rokUporabe = dtpRokUporabe.Value.Date;
            string imeDobavljaca = "";
            DateTime datumProizvodnje = dtpDatumProizvodnje.Value.Date;
            string odabraniProizvodac = "";
            if (cijenaLijeka >= 10000)
            {
                labelGreska.Show();
                labelGreska.Text = "Nije moguće dodati lijek, cijena je izvan dosega";
            }
            else if (naziv.Length == 0 || stanjeZalihaParsiraj == false || opis.Length == 0 || cmbDobavljac.SelectedItem == null || cmbProizvodac.SelectedItem == null)
            {
                labelGreska.Show();
                labelGreska.Text = "Neuspješno dodavanje lijeka.Sva polja moraju biti popunjena";
            }
            else
            {
                imeDobavljaca = cmbDobavljac.SelectedItem.ToString();
                odabraniProizvodac = cmbProizvodac.SelectedItem.ToString();
                using (var context = new PharmaCare_DBEntities())
                {
                    var query = from p in context.proizvodac
                                where p.naziv.Equals(odabraniProizvodac)
                                select p;

                    List<proizvodac> listaProizvodaca = query.ToList();
                    foreach (var proizvodac in listaProizvodaca)
                    {
                        if (proizvodac.naziv.Equals(odabraniProizvodac))
                        {
                            idProizvodac = proizvodac.proizvodac_id;
                            break;
                        }
                    }


                    lijek noviLijek = new lijek
                    {
                        naziv = naziv,
                        stanje_zaliha = stanjeZaliha,
                        cijena__HRK_ = cijenaLijeka,
                        opis = opis,
                        rok_uporabe = rokUporabe,
                        ime_dobavljaca = imeDobavljaca,
                        datum_proizvodnje = datumProizvodnje,
                        proizvodac_id = idProizvodac
                    };

                    context.lijek.Add(noviLijek);
                    context.SaveChanges();
                    Close();
                }
            }
        }
        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormDodaj_Load(object sender, EventArgs e)
        {
            using (var context = new PharmaCare_DBEntities())
            {
                var query = from p in context.proizvodac
                            select p.naziv;

                cmbProizvodac.DataSource = query.ToList();
            }
        }
    }
}
