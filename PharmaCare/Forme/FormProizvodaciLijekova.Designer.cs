namespace PharmaCare.Forme
{
    partial class FormProizvodaciLijekova
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProizvodaciLijekova));
            this.panelIzbornik = new System.Windows.Forms.Panel();
            this.btnIzdavanjeRacuna = new System.Windows.Forms.Button();
            this.btnZaposlenici = new System.Windows.Forms.Button();
            this.btnProizvodaci = new System.Windows.Forms.Button();
            this.btnKlijenti = new System.Windows.Forms.Button();
            this.btnLijekovi = new System.Windows.Forms.Button();
            this.btnPocetna = new System.Windows.Forms.Button();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.labelDatumVrijeme = new System.Windows.Forms.Label();
            this.labelUlogaPrijavljenogKorisnika = new System.Windows.Forms.Label();
            this.pBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelNazivPrijavljenogKorisnika = new System.Windows.Forms.Label();
            this.labelLogo = new System.Windows.Forms.Label();
            this.dgvProizvodaci = new System.Windows.Forms.DataGridView();
            this.labelOpis = new System.Windows.Forms.Label();
            this.labelNaziv = new System.Windows.Forms.Label();
            this.tboxNaziv = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.labelDrzava = new System.Windows.Forms.Label();
            this.cboxZemlja = new System.Windows.Forms.ComboBox();
            this.tboxAdresa = new System.Windows.Forms.TextBox();
            this.labelAdresa = new System.Windows.Forms.Label();
            this.labelKontaktBroj = new System.Windows.Forms.Label();
            this.mtboxKontaktBroj = new System.Windows.Forms.MaskedTextBox();
            this.labelGreska = new System.Windows.Forms.Label();
            this.btnOcisti = new System.Windows.Forms.Button();
            this.labelPomoc = new System.Windows.Forms.Label();
            this.panelIzbornik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodaci)).BeginInit();
            this.SuspendLayout();
            // 
            // panelIzbornik
            // 
            this.panelIzbornik.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelIzbornik.Controls.Add(this.btnIzdavanjeRacuna);
            this.panelIzbornik.Controls.Add(this.btnZaposlenici);
            this.panelIzbornik.Controls.Add(this.btnProizvodaci);
            this.panelIzbornik.Controls.Add(this.btnKlijenti);
            this.panelIzbornik.Controls.Add(this.btnLijekovi);
            this.panelIzbornik.Controls.Add(this.btnPocetna);
            this.panelIzbornik.Controls.Add(this.btnOdjava);
            this.panelIzbornik.Location = new System.Drawing.Point(0, 87);
            this.panelIzbornik.Name = "panelIzbornik";
            this.panelIzbornik.Size = new System.Drawing.Size(298, 594);
            this.panelIzbornik.TabIndex = 19;
            // 
            // btnIzdavanjeRacuna
            // 
            this.btnIzdavanjeRacuna.FlatAppearance.BorderSize = 0;
            this.btnIzdavanjeRacuna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzdavanjeRacuna.Font = new System.Drawing.Font("Verdana", 14F);
            this.btnIzdavanjeRacuna.ForeColor = System.Drawing.Color.Black;
            this.btnIzdavanjeRacuna.Location = new System.Drawing.Point(-8, 270);
            this.btnIzdavanjeRacuna.Name = "btnIzdavanjeRacuna";
            this.btnIzdavanjeRacuna.Size = new System.Drawing.Size(309, 50);
            this.btnIzdavanjeRacuna.TabIndex = 15;
            this.btnIzdavanjeRacuna.Text = "Izdavanje računa";
            this.btnIzdavanjeRacuna.UseVisualStyleBackColor = true;
            this.btnIzdavanjeRacuna.Click += new System.EventHandler(this.btnIzdavanjeRacuna_Click);
            this.btnIzdavanjeRacuna.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.btnIzdavanjeRacuna.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.btnIzdavanjeRacuna.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            // 
            // btnZaposlenici
            // 
            this.btnZaposlenici.FlatAppearance.BorderSize = 0;
            this.btnZaposlenici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZaposlenici.Font = new System.Drawing.Font("Verdana", 14F);
            this.btnZaposlenici.ForeColor = System.Drawing.Color.Black;
            this.btnZaposlenici.Location = new System.Drawing.Point(-8, 220);
            this.btnZaposlenici.Name = "btnZaposlenici";
            this.btnZaposlenici.Size = new System.Drawing.Size(309, 50);
            this.btnZaposlenici.TabIndex = 14;
            this.btnZaposlenici.Text = "Zaposlenici";
            this.btnZaposlenici.UseVisualStyleBackColor = true;
            this.btnZaposlenici.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.btnZaposlenici.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.btnZaposlenici.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            // 
            // btnProizvodaci
            // 
            this.btnProizvodaci.BackColor = System.Drawing.Color.White;
            this.btnProizvodaci.FlatAppearance.BorderSize = 0;
            this.btnProizvodaci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProizvodaci.Font = new System.Drawing.Font("Verdana", 14F);
            this.btnProizvodaci.ForeColor = System.Drawing.Color.Black;
            this.btnProizvodaci.Location = new System.Drawing.Point(-8, 170);
            this.btnProizvodaci.Name = "btnProizvodaci";
            this.btnProizvodaci.Size = new System.Drawing.Size(309, 50);
            this.btnProizvodaci.TabIndex = 13;
            this.btnProizvodaci.Text = "Proizvođači lijekova";
            this.btnProizvodaci.UseVisualStyleBackColor = false;
            // 
            // btnKlijenti
            // 
            this.btnKlijenti.FlatAppearance.BorderSize = 0;
            this.btnKlijenti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKlijenti.Font = new System.Drawing.Font("Verdana", 14F);
            this.btnKlijenti.ForeColor = System.Drawing.Color.Black;
            this.btnKlijenti.Location = new System.Drawing.Point(-8, 120);
            this.btnKlijenti.Name = "btnKlijenti";
            this.btnKlijenti.Size = new System.Drawing.Size(309, 50);
            this.btnKlijenti.TabIndex = 12;
            this.btnKlijenti.Text = "Klijenti";
            this.btnKlijenti.UseVisualStyleBackColor = true;
            this.btnKlijenti.Click += new System.EventHandler(this.btnKlijenti_Click);
            this.btnKlijenti.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.btnKlijenti.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.btnKlijenti.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            // 
            // btnLijekovi
            // 
            this.btnLijekovi.FlatAppearance.BorderSize = 0;
            this.btnLijekovi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLijekovi.Font = new System.Drawing.Font("Verdana", 14F);
            this.btnLijekovi.ForeColor = System.Drawing.Color.Black;
            this.btnLijekovi.Location = new System.Drawing.Point(-8, 70);
            this.btnLijekovi.Name = "btnLijekovi";
            this.btnLijekovi.Size = new System.Drawing.Size(309, 50);
            this.btnLijekovi.TabIndex = 11;
            this.btnLijekovi.Text = "Lijekovi";
            this.btnLijekovi.UseVisualStyleBackColor = true;
            this.btnLijekovi.Click += new System.EventHandler(this.btnLijekovi_Click);
            this.btnLijekovi.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.btnLijekovi.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.btnLijekovi.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            // 
            // btnPocetna
            // 
            this.btnPocetna.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPocetna.FlatAppearance.BorderSize = 0;
            this.btnPocetna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPocetna.Font = new System.Drawing.Font("Verdana", 14F);
            this.btnPocetna.ForeColor = System.Drawing.Color.Black;
            this.btnPocetna.Location = new System.Drawing.Point(-8, 20);
            this.btnPocetna.Name = "btnPocetna";
            this.btnPocetna.Size = new System.Drawing.Size(309, 50);
            this.btnPocetna.TabIndex = 10;
            this.btnPocetna.Text = "Početna stranica";
            this.btnPocetna.UseVisualStyleBackColor = false;
            this.btnPocetna.Click += new System.EventHandler(this.btnPocetna_Click);
            this.btnPocetna.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.btnPocetna.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.btnPocetna.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            // 
            // btnOdjava
            // 
            this.btnOdjava.FlatAppearance.BorderSize = 0;
            this.btnOdjava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdjava.Font = new System.Drawing.Font("Verdana", 14F);
            this.btnOdjava.ForeColor = System.Drawing.Color.Black;
            this.btnOdjava.Location = new System.Drawing.Point(-8, 532);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(309, 50);
            this.btnOdjava.TabIndex = 9;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            this.btnOdjava.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.btnOdjava.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.btnOdjava.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            // 
            // labelDatumVrijeme
            // 
            this.labelDatumVrijeme.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDatumVrijeme.Location = new System.Drawing.Point(1055, 55);
            this.labelDatumVrijeme.Name = "labelDatumVrijeme";
            this.labelDatumVrijeme.Size = new System.Drawing.Size(197, 32);
            this.labelDatumVrijeme.TabIndex = 24;
            this.labelDatumVrijeme.Text = "_";
            this.labelDatumVrijeme.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelUlogaPrijavljenogKorisnika
            // 
            this.labelUlogaPrijavljenogKorisnika.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUlogaPrijavljenogKorisnika.Location = new System.Drawing.Point(1058, 32);
            this.labelUlogaPrijavljenogKorisnika.Name = "labelUlogaPrijavljenogKorisnika";
            this.labelUlogaPrijavljenogKorisnika.Size = new System.Drawing.Size(194, 32);
            this.labelUlogaPrijavljenogKorisnika.TabIndex = 23;
            this.labelUlogaPrijavljenogKorisnika.Text = "_";
            this.labelUlogaPrijavljenogKorisnika.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pBoxLogo
            // 
            this.pBoxLogo.Image = global::PharmaCare.Properties.Resources.PharmaCareLogo;
            this.pBoxLogo.ImageLocation = "";
            this.pBoxLogo.Location = new System.Drawing.Point(12, 12);
            this.pBoxLogo.Name = "pBoxLogo";
            this.pBoxLogo.Size = new System.Drawing.Size(75, 75);
            this.pBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxLogo.TabIndex = 21;
            this.pBoxLogo.TabStop = false;
            // 
            // labelNazivPrijavljenogKorisnika
            // 
            this.labelNazivPrijavljenogKorisnika.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNazivPrijavljenogKorisnika.Location = new System.Drawing.Point(1055, 9);
            this.labelNazivPrijavljenogKorisnika.Name = "labelNazivPrijavljenogKorisnika";
            this.labelNazivPrijavljenogKorisnika.Size = new System.Drawing.Size(200, 32);
            this.labelNazivPrijavljenogKorisnika.TabIndex = 22;
            this.labelNazivPrijavljenogKorisnika.Text = "_";
            this.labelNazivPrijavljenogKorisnika.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLogo.Location = new System.Drawing.Point(87, 36);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(200, 32);
            this.labelLogo.TabIndex = 20;
            this.labelLogo.Text = "PharmaCare";
            // 
            // dgvProizvodaci
            // 
            this.dgvProizvodaci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProizvodaci.BackgroundColor = System.Drawing.Color.White;
            this.dgvProizvodaci.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProizvodaci.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProizvodaci.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProizvodaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProizvodaci.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProizvodaci.Location = new System.Drawing.Point(333, 357);
            this.dgvProizvodaci.Name = "dgvProizvodaci";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProizvodaci.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProizvodaci.Size = new System.Drawing.Size(900, 299);
            this.dgvProizvodaci.TabIndex = 25;
            this.dgvProizvodaci.SelectionChanged += new System.EventHandler(this.dgvProizvodaci_SelectionChanged);
            // 
            // labelOpis
            // 
            this.labelOpis.AutoSize = true;
            this.labelOpis.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOpis.Location = new System.Drawing.Point(640, 18);
            this.labelOpis.Name = "labelOpis";
            this.labelOpis.Size = new System.Drawing.Size(194, 23);
            this.labelOpis.TabIndex = 26;
            this.labelOpis.Text = "Podaci proizvođača";
            // 
            // labelNaziv
            // 
            this.labelNaziv.AutoSize = true;
            this.labelNaziv.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNaziv.Location = new System.Drawing.Point(333, 100);
            this.labelNaziv.Name = "labelNaziv";
            this.labelNaziv.Size = new System.Drawing.Size(60, 18);
            this.labelNaziv.TabIndex = 0;
            this.labelNaziv.Text = "Naziv:";
            // 
            // tboxNaziv
            // 
            this.tboxNaziv.Font = new System.Drawing.Font("Verdana", 12F);
            this.tboxNaziv.Location = new System.Drawing.Point(488, 97);
            this.tboxNaziv.Name = "tboxNaziv";
            this.tboxNaziv.Size = new System.Drawing.Size(200, 27);
            this.tboxNaziv.TabIndex = 1;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(186)))), ((int)(((byte)(36)))));
            this.btnDodaj.FlatAppearance.BorderSize = 0;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodaj.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodaj.ForeColor = System.Drawing.Color.Black;
            this.btnDodaj.Location = new System.Drawing.Point(333, 307);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(120, 30);
            this.btnDodaj.TabIndex = 5;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodajIliAzuriraj_Click);
            this.btnDodaj.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.btnDodaj.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(186)))), ((int)(((byte)(36)))));
            this.btnAzuriraj.FlatAppearance.BorderSize = 0;
            this.btnAzuriraj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAzuriraj.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAzuriraj.ForeColor = System.Drawing.Color.Black;
            this.btnAzuriraj.Location = new System.Drawing.Point(473, 307);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(120, 30);
            this.btnAzuriraj.TabIndex = 6;
            this.btnAzuriraj.Text = "Promijeni";
            this.btnAzuriraj.UseVisualStyleBackColor = false;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnDodajIliAzuriraj_Click);
            this.btnAzuriraj.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.btnAzuriraj.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.Firebrick;
            this.btnObrisi.FlatAppearance.BorderSize = 0;
            this.btnObrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisi.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObrisi.ForeColor = System.Drawing.Color.White;
            this.btnObrisi.Location = new System.Drawing.Point(613, 307);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(120, 30);
            this.btnObrisi.TabIndex = 7;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            this.btnObrisi.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.btnObrisi.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            // 
            // labelDrzava
            // 
            this.labelDrzava.AutoSize = true;
            this.labelDrzava.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDrzava.Location = new System.Drawing.Point(803, 103);
            this.labelDrzava.Name = "labelDrzava";
            this.labelDrzava.Size = new System.Drawing.Size(149, 18);
            this.labelDrzava.TabIndex = 31;
            this.labelDrzava.Text = "Zemlja porijekla:";
            // 
            // cboxZemlja
            // 
            this.cboxZemlja.AutoCompleteCustomSource.AddRange(new string[] {
            "ALBANIJA",
            "ANTIGVA I BARBUDA",
            "ARGENTINA",
            "ARMENIJA",
            "ARUBA",
            "AUSTRALIJA",
            "AUSTRIJA",
            "AZERBAJDŽAN",
            "BELGIJA",
            "BJELORUSIJA",
            "BOCVANA",
            "BOSNA I HERCEGOVINA",
            "BRAZIL",
            "BUGARSKA",
            "BUTAN",
            "CIPAR",
            "CRNA GORA",
            "ČAD",
            "ČEŠKA",
            "ČILE",
            "DANSKA",
            "EGIPAT",
            "EKVADOR",
            "ESTONIJA",
            "ETIOPIJA",
            "FINSKA",
            "FRANCUSKA",
            "GABON",
            "GANA",
            "GRČKA",
            "HRVATSKA",
            "INDIJA",
            "INDONEZIJA",
            "IRAN",
            "IRSKA",
            "ITALIJA",
            "IZRAEL",
            "JAPAN",
            "KAJMANSKI OTOCI",
            "KANADA",
            "KATAR",
            "KAZAHSTAN",
            "KENIJA",
            "KINA",
            "KOREJA, JUŽNA",
            "KUVAJT",
            "LAOS",
            "LESOTO",
            "LETONIJA",
            "LIBIJA",
            "LITVA",
            "LUKSEMBURG",
            "MADAGASKAR",
            "MAĐARSKA",
            "MAKEDONIJA",
            "MALDIVI",
            "MALEZIJA",
            "MALTA",
            "MAROKO",
            "MEKSIKO",
            "MOLDAVIJA",
            "MONGOLIJA",
            "NIZOZEMSKA",
            "NIZOZEMSKI ANTILI",
            "NORVEŠKA",
            "NOVI ZELAND",
            "NJEMAČKA",
            "OMAN",
            "PAKISTAN",
            "PANAMA",
            "PARAGVAJ",
            "PERU",
            "POLJSKA",
            "PORTUGAL",
            "RUANDA",
            "RUMUNJSKA",
            "RUSKA FEDERACIJA",
            "S.A.D.",
            "SALVADOR",
            "SAUDIJSKA ARABIJA",
            "SINGAPUR",
            "SLOVAČKA",
            "SLOVENIJA",
            "SRBIJA",
            "S. KRISTO. I NEVIS",
            "ŠPANJOLSKA",
            "ŠVEDSKA",
            "ŠVICARSKA",
            "TAJLAND",
            "TANZANIJA",
            "TURSKA",
            "UJED.ARAP.EMIRATI",
            "UKRAJINA",
            "UZBEKISTAN",
            "VELIKA BRITANIJA",
            "VENEZUELA",
            "ZIMBABVE"});
            this.cboxZemlja.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxZemlja.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboxZemlja.Font = new System.Drawing.Font("Verdana", 12F);
            this.cboxZemlja.FormattingEnabled = true;
            this.cboxZemlja.Items.AddRange(new object[] {
            "ALBANIJA",
            "ANTIGVA I BARBUDA",
            "ARGENTINA",
            "ARMENIJA",
            "ARUBA",
            "AUSTRALIJA",
            "AUSTRIJA",
            "AZERBAJDŽAN",
            "BELGIJA",
            "BJELORUSIJA",
            "BOCVANA",
            "BOSNA I HERCEGOVINA",
            "BRAZIL",
            "BUGARSKA",
            "BUTAN",
            "CIPAR",
            "CRNA GORA",
            "ČAD",
            "ČEŠKA",
            "ČILE",
            "DANSKA",
            "EGIPAT",
            "EKVADOR",
            "ESTONIJA",
            "ETIOPIJA",
            "FINSKA",
            "FRANCUSKA",
            "GABON",
            "GANA",
            "GRČKA",
            "HRVATSKA",
            "INDIJA",
            "INDONEZIJA",
            "IRAN",
            "IRSKA",
            "ITALIJA",
            "IZRAEL",
            "JAPAN",
            "KAJMANSKI OTOCI",
            "KANADA",
            "KATAR",
            "KAZAHSTAN",
            "KENIJA",
            "KINA",
            "KOREJA, JUŽNA",
            "KUVAJT",
            "LAOS",
            "LESOTO",
            "LETONIJA",
            "LIBIJA",
            "LITVA",
            "LUKSEMBURG",
            "MADAGASKAR",
            "MAĐARSKA",
            "MAKEDONIJA",
            "MALDIVI",
            "MALEZIJA",
            "MALTA",
            "MAROKO",
            "MEKSIKO",
            "MOLDAVIJA",
            "MONGOLIJA",
            "NIZOZEMSKA",
            "NIZOZEMSKI ANTILI",
            "NORVEŠKA",
            "NOVI ZELAND",
            "NJEMAČKA",
            "OMAN",
            "PAKISTAN",
            "PANAMA",
            "PARAGVAJ",
            "PERU",
            "POLJSKA",
            "PORTUGAL",
            "RUANDA",
            "RUMUNJSKA",
            "RUSKA FEDERACIJA",
            "S.A.D.",
            "SALVADOR",
            "SAUDIJSKA ARABIJA",
            "SINGAPUR",
            "SLOVAČKA",
            "SLOVENIJA",
            "SRBIJA",
            "S. KRISTO. I NEVIS",
            "ŠPANJOLSKA",
            "ŠVEDSKA",
            "ŠVICARSKA",
            "TAJLAND",
            "TANZANIJA",
            "TURSKA",
            "UJED.ARAP.EMIRATI",
            "UKRAJINA",
            "UZBEKISTAN",
            "VELIKA BRITANIJA",
            "VENEZUELA",
            "ZIMBABVE"});
            this.cboxZemlja.Location = new System.Drawing.Point(958, 100);
            this.cboxZemlja.Name = "cboxZemlja";
            this.cboxZemlja.Size = new System.Drawing.Size(200, 26);
            this.cboxZemlja.TabIndex = 2;
            // 
            // tboxAdresa
            // 
            this.tboxAdresa.Font = new System.Drawing.Font("Verdana", 12F);
            this.tboxAdresa.Location = new System.Drawing.Point(488, 157);
            this.tboxAdresa.Name = "tboxAdresa";
            this.tboxAdresa.Size = new System.Drawing.Size(200, 27);
            this.tboxAdresa.TabIndex = 3;
            // 
            // labelAdresa
            // 
            this.labelAdresa.AutoSize = true;
            this.labelAdresa.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAdresa.Location = new System.Drawing.Point(333, 165);
            this.labelAdresa.Name = "labelAdresa";
            this.labelAdresa.Size = new System.Drawing.Size(71, 18);
            this.labelAdresa.TabIndex = 34;
            this.labelAdresa.Text = "Adresa:";
            // 
            // labelKontaktBroj
            // 
            this.labelKontaktBroj.AutoSize = true;
            this.labelKontaktBroj.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKontaktBroj.Location = new System.Drawing.Point(803, 160);
            this.labelKontaktBroj.Name = "labelKontaktBroj";
            this.labelKontaktBroj.Size = new System.Drawing.Size(116, 18);
            this.labelKontaktBroj.TabIndex = 36;
            this.labelKontaktBroj.Text = "Kontakt broj:";
            // 
            // mtboxKontaktBroj
            // 
            this.mtboxKontaktBroj.Font = new System.Drawing.Font("Verdana", 12F);
            this.mtboxKontaktBroj.Location = new System.Drawing.Point(958, 157);
            this.mtboxKontaktBroj.Mask = "+000 \\90 000 0000";
            this.mtboxKontaktBroj.Name = "mtboxKontaktBroj";
            this.mtboxKontaktBroj.Size = new System.Drawing.Size(200, 27);
            this.mtboxKontaktBroj.TabIndex = 4;
            // 
            // labelGreska
            // 
            this.labelGreska.AutoSize = true;
            this.labelGreska.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGreska.ForeColor = System.Drawing.Color.Red;
            this.labelGreska.Location = new System.Drawing.Point(869, 189);
            this.labelGreska.Name = "labelGreska";
            this.labelGreska.Size = new System.Drawing.Size(0, 18);
            this.labelGreska.TabIndex = 37;
            this.labelGreska.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOcisti
            // 
            this.btnOcisti.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnOcisti.FlatAppearance.BorderSize = 0;
            this.btnOcisti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOcisti.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOcisti.ForeColor = System.Drawing.Color.Black;
            this.btnOcisti.Location = new System.Drawing.Point(333, 207);
            this.btnOcisti.Name = "btnOcisti";
            this.btnOcisti.Size = new System.Drawing.Size(120, 30);
            this.btnOcisti.TabIndex = 38;
            this.btnOcisti.Text = "Očisti";
            this.btnOcisti.UseVisualStyleBackColor = false;
            this.btnOcisti.Click += new System.EventHandler(this.btnOcisti_Click);
            this.btnOcisti.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.btnOcisti.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            // 
            // labelPomoc
            // 
            this.labelPomoc.AutoSize = true;
            this.labelPomoc.BackColor = System.Drawing.Color.LimeGreen;
            this.labelPomoc.Font = new System.Drawing.Font("Verdana", 9F);
            this.labelPomoc.Location = new System.Drawing.Point(11, 0);
            this.labelPomoc.Name = "labelPomoc";
            this.labelPomoc.Size = new System.Drawing.Size(76, 14);
            this.labelPomoc.TabIndex = 68;
            this.labelPomoc.Text = "F1 - Pomoć";
            // 
            // FormProizvodaciLijekova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.labelPomoc);
            this.Controls.Add(this.btnOcisti);
            this.Controls.Add(this.labelGreska);
            this.Controls.Add(this.mtboxKontaktBroj);
            this.Controls.Add(this.labelKontaktBroj);
            this.Controls.Add(this.tboxAdresa);
            this.Controls.Add(this.labelAdresa);
            this.Controls.Add(this.cboxZemlja);
            this.Controls.Add(this.labelDrzava);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.tboxNaziv);
            this.Controls.Add(this.labelNaziv);
            this.Controls.Add(this.labelOpis);
            this.Controls.Add(this.dgvProizvodaci);
            this.Controls.Add(this.panelIzbornik);
            this.Controls.Add(this.labelDatumVrijeme);
            this.Controls.Add(this.labelUlogaPrijavljenogKorisnika);
            this.Controls.Add(this.pBoxLogo);
            this.Controls.Add(this.labelNazivPrijavljenogKorisnika);
            this.Controls.Add(this.labelLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormProizvodaciLijekova";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proizvođači lijekova";
            this.Load += new System.EventHandler(this.FormProizvodaciLijekova_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormProizvodaciLijekova_KeyDown);
            this.panelIzbornik.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodaci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelIzbornik;
        private System.Windows.Forms.Button btnIzdavanjeRacuna;
        private System.Windows.Forms.Button btnZaposlenici;
        private System.Windows.Forms.Button btnProizvodaci;
        private System.Windows.Forms.Button btnKlijenti;
        private System.Windows.Forms.Button btnLijekovi;
        private System.Windows.Forms.Button btnPocetna;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Label labelDatumVrijeme;
        private System.Windows.Forms.Label labelUlogaPrijavljenogKorisnika;
        private System.Windows.Forms.PictureBox pBoxLogo;
        private System.Windows.Forms.Label labelNazivPrijavljenogKorisnika;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.DataGridView dgvProizvodaci;
        private System.Windows.Forms.Label labelOpis;
        private System.Windows.Forms.Label labelNaziv;
        private System.Windows.Forms.TextBox tboxNaziv;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Label labelDrzava;
        private System.Windows.Forms.ComboBox cboxZemlja;
        private System.Windows.Forms.TextBox tboxAdresa;
        private System.Windows.Forms.Label labelAdresa;
        private System.Windows.Forms.Label labelKontaktBroj;
        private System.Windows.Forms.MaskedTextBox mtboxKontaktBroj;
        private System.Windows.Forms.Label labelGreska;
        private System.Windows.Forms.Button btnOcisti;
        private System.Windows.Forms.Label labelPomoc;
    }
}