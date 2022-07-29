namespace PharmaCare.Forme
{
    partial class FormIzdavanjeRacuna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIzdavanjeRacuna));
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
            this.labelNazivPrijavljenogKorisnika = new System.Windows.Forms.Label();
            this.labelLogo = new System.Windows.Forms.Label();
            this.labelOpis = new System.Windows.Forms.Label();
            this.dgvStavkeRacuna = new System.Windows.Forms.DataGridView();
            this.id_lijeka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naziv_lijeka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jedinicna_cijena_lijeka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicina_lijeka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ukupna_cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelStavkeRacuna = new System.Windows.Forms.Label();
            this.cboxNazivLijeka = new System.Windows.Forms.ComboBox();
            this.labelNazivLijeka = new System.Windows.Forms.Label();
            this.tboxStanjeZaliha = new System.Windows.Forms.TextBox();
            this.labelNaziv = new System.Windows.Forms.Label();
            this.tboxCijena = new System.Windows.Forms.TextBox();
            this.labelCijena = new System.Windows.Forms.Label();
            this.labelKolicina = new System.Windows.Forms.Label();
            this.cboxNazivKlijenta = new System.Windows.Forms.ComboBox();
            this.labelNazivKlijenta = new System.Windows.Forms.Label();
            this.tboxBodovi = new System.Windows.Forms.TextBox();
            this.labelBodovi = new System.Windows.Forms.Label();
            this.tboxClan = new System.Windows.Forms.TextBox();
            this.labelClan = new System.Windows.Forms.Label();
            this.labelRazdjelnik = new System.Windows.Forms.Label();
            this.tboxUkupnaCijena = new System.Windows.Forms.TextBox();
            this.labelUkupnaCijena = new System.Windows.Forms.Label();
            this.btnUkloni = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnIzdaj = new System.Windows.Forms.Button();
            this.tboxTotal = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelPopust = new System.Windows.Forms.Label();
            this.btnPopisRacuna = new System.Windows.Forms.Button();
            this.tboxIdKlijenta = new System.Windows.Forms.TextBox();
            this.labelIdKlijenta = new System.Windows.Forms.Label();
            this.tboxIdLijeka = new System.Windows.Forms.TextBox();
            this.labelIdLijeka = new System.Windows.Forms.Label();
            this.labelGreska = new System.Windows.Forms.Label();
            this.mtboxKolicina = new System.Windows.Forms.MaskedTextBox();
            this.btnIzracunaj = new System.Windows.Forms.Button();
            this.pBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelPomoc = new System.Windows.Forms.Label();
            this.panelIzbornik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeRacuna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo)).BeginInit();
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
            this.btnIzdavanjeRacuna.BackColor = System.Drawing.Color.White;
            this.btnIzdavanjeRacuna.FlatAppearance.BorderSize = 0;
            this.btnIzdavanjeRacuna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzdavanjeRacuna.Font = new System.Drawing.Font("Verdana", 14F);
            this.btnIzdavanjeRacuna.ForeColor = System.Drawing.Color.Black;
            this.btnIzdavanjeRacuna.Location = new System.Drawing.Point(-8, 270);
            this.btnIzdavanjeRacuna.Name = "btnIzdavanjeRacuna";
            this.btnIzdavanjeRacuna.Size = new System.Drawing.Size(309, 50);
            this.btnIzdavanjeRacuna.TabIndex = 15;
            this.btnIzdavanjeRacuna.Text = "Izdavanje računa";
            this.btnIzdavanjeRacuna.UseVisualStyleBackColor = false;
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
            this.btnProizvodaci.FlatAppearance.BorderSize = 0;
            this.btnProizvodaci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProizvodaci.Font = new System.Drawing.Font("Verdana", 14F);
            this.btnProizvodaci.ForeColor = System.Drawing.Color.Black;
            this.btnProizvodaci.Location = new System.Drawing.Point(-8, 170);
            this.btnProizvodaci.Name = "btnProizvodaci";
            this.btnProizvodaci.Size = new System.Drawing.Size(309, 50);
            this.btnProizvodaci.TabIndex = 13;
            this.btnProizvodaci.Text = "Proizvođači lijekova";
            this.btnProizvodaci.UseVisualStyleBackColor = true;
            this.btnProizvodaci.Click += new System.EventHandler(this.btnProizvodaci_Click);
            this.btnProizvodaci.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.btnProizvodaci.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.btnProizvodaci.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
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
            // labelOpis
            // 
            this.labelOpis.AutoSize = true;
            this.labelOpis.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOpis.Location = new System.Drawing.Point(613, 18);
            this.labelOpis.Name = "labelOpis";
            this.labelOpis.Size = new System.Drawing.Size(269, 23);
            this.labelOpis.TabIndex = 27;
            this.labelOpis.Text = "Podaci za izdavanje računa";
            // 
            // dgvStavkeRacuna
            // 
            this.dgvStavkeRacuna.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvStavkeRacuna.BackgroundColor = System.Drawing.Color.White;
            this.dgvStavkeRacuna.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStavkeRacuna.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStavkeRacuna.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStavkeRacuna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkeRacuna.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_lijeka,
            this.naziv_lijeka,
            this.jedinicna_cijena_lijeka,
            this.kolicina_lijeka,
            this.ukupna_cijena});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStavkeRacuna.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStavkeRacuna.Location = new System.Drawing.Point(333, 417);
            this.dgvStavkeRacuna.Name = "dgvStavkeRacuna";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStavkeRacuna.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStavkeRacuna.Size = new System.Drawing.Size(900, 184);
            this.dgvStavkeRacuna.TabIndex = 28;
            this.dgvStavkeRacuna.SelectionChanged += new System.EventHandler(this.dgvStavkeRacuna_SelectionChanged);
            // 
            // id_lijeka
            // 
            this.id_lijeka.HeaderText = "id_lijeka";
            this.id_lijeka.Name = "id_lijeka";
            this.id_lijeka.Width = 89;
            // 
            // naziv_lijeka
            // 
            this.naziv_lijeka.HeaderText = "naziv_lijeka";
            this.naziv_lijeka.Name = "naziv_lijeka";
            this.naziv_lijeka.Width = 112;
            // 
            // jedinicna_cijena_lijeka
            // 
            this.jedinicna_cijena_lijeka.HeaderText = "jedinicna_cijena_lijeka";
            this.jedinicna_cijena_lijeka.Name = "jedinicna_cijena_lijeka";
            this.jedinicna_cijena_lijeka.Width = 185;
            // 
            // kolicina_lijeka
            // 
            this.kolicina_lijeka.HeaderText = "kolicina_lijeka";
            this.kolicina_lijeka.Name = "kolicina_lijeka";
            this.kolicina_lijeka.Width = 128;
            // 
            // ukupna_cijena
            // 
            this.ukupna_cijena.HeaderText = "ukupna_cijena";
            this.ukupna_cijena.Name = "ukupna_cijena";
            this.ukupna_cijena.Width = 128;
            // 
            // labelStavkeRacuna
            // 
            this.labelStavkeRacuna.AutoSize = true;
            this.labelStavkeRacuna.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelStavkeRacuna.Location = new System.Drawing.Point(669, 375);
            this.labelStavkeRacuna.Name = "labelStavkeRacuna";
            this.labelStavkeRacuna.Size = new System.Drawing.Size(149, 18);
            this.labelStavkeRacuna.TabIndex = 29;
            this.labelStavkeRacuna.Text = "Stavke na računu";
            // 
            // cboxNazivLijeka
            // 
            this.cboxNazivLijeka.AutoCompleteCustomSource.AddRange(new string[] {
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
            this.cboxNazivLijeka.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxNazivLijeka.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxNazivLijeka.Font = new System.Drawing.Font("Verdana", 12F);
            this.cboxNazivLijeka.FormattingEnabled = true;
            this.cboxNazivLijeka.Location = new System.Drawing.Point(911, 142);
            this.cboxNazivLijeka.Name = "cboxNazivLijeka";
            this.cboxNazivLijeka.Size = new System.Drawing.Size(261, 26);
            this.cboxNazivLijeka.TabIndex = 32;
            this.cboxNazivLijeka.SelectedIndexChanged += new System.EventHandler(this.cboxNazivLijeka_SelectedIndexChanged);
            // 
            // labelNazivLijeka
            // 
            this.labelNazivLijeka.AutoSize = true;
            this.labelNazivLijeka.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNazivLijeka.Location = new System.Drawing.Point(774, 145);
            this.labelNazivLijeka.Name = "labelNazivLijeka";
            this.labelNazivLijeka.Size = new System.Drawing.Size(111, 18);
            this.labelNazivLijeka.TabIndex = 33;
            this.labelNazivLijeka.Text = "Naziv lijeka:";
            // 
            // tboxStanjeZaliha
            // 
            this.tboxStanjeZaliha.Enabled = false;
            this.tboxStanjeZaliha.Font = new System.Drawing.Font("Verdana", 12F);
            this.tboxStanjeZaliha.Location = new System.Drawing.Point(911, 184);
            this.tboxStanjeZaliha.Name = "tboxStanjeZaliha";
            this.tboxStanjeZaliha.Size = new System.Drawing.Size(65, 27);
            this.tboxStanjeZaliha.TabIndex = 35;
            // 
            // labelNaziv
            // 
            this.labelNaziv.AutoSize = true;
            this.labelNaziv.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNaziv.Location = new System.Drawing.Point(774, 187);
            this.labelNaziv.Name = "labelNaziv";
            this.labelNaziv.Size = new System.Drawing.Size(123, 18);
            this.labelNaziv.TabIndex = 34;
            this.labelNaziv.Text = "Stanje zaliha:";
            // 
            // tboxCijena
            // 
            this.tboxCijena.Enabled = false;
            this.tboxCijena.Font = new System.Drawing.Font("Verdana", 12F);
            this.tboxCijena.Location = new System.Drawing.Point(1073, 184);
            this.tboxCijena.Name = "tboxCijena";
            this.tboxCijena.Size = new System.Drawing.Size(99, 27);
            this.tboxCijena.TabIndex = 37;
            this.tboxCijena.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelCijena
            // 
            this.labelCijena.AutoSize = true;
            this.labelCijena.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCijena.Location = new System.Drawing.Point(1000, 187);
            this.labelCijena.Name = "labelCijena";
            this.labelCijena.Size = new System.Drawing.Size(67, 18);
            this.labelCijena.TabIndex = 36;
            this.labelCijena.Text = "Cijena:";
            // 
            // labelKolicina
            // 
            this.labelKolicina.AutoSize = true;
            this.labelKolicina.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKolicina.Location = new System.Drawing.Point(774, 233);
            this.labelKolicina.Name = "labelKolicina";
            this.labelKolicina.Size = new System.Drawing.Size(78, 18);
            this.labelKolicina.TabIndex = 38;
            this.labelKolicina.Text = "Količina:";
            // 
            // cboxNazivKlijenta
            // 
            this.cboxNazivKlijenta.AutoCompleteCustomSource.AddRange(new string[] {
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
            this.cboxNazivKlijenta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboxNazivKlijenta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboxNazivKlijenta.Font = new System.Drawing.Font("Verdana", 12F);
            this.cboxNazivKlijenta.FormattingEnabled = true;
            this.cboxNazivKlijenta.Location = new System.Drawing.Point(467, 142);
            this.cboxNazivKlijenta.Name = "cboxNazivKlijenta";
            this.cboxNazivKlijenta.Size = new System.Drawing.Size(227, 26);
            this.cboxNazivKlijenta.TabIndex = 40;
            this.cboxNazivKlijenta.SelectedIndexChanged += new System.EventHandler(this.cboxNazivKlijenta_SelectedIndexChanged);
            // 
            // labelNazivKlijenta
            // 
            this.labelNazivKlijenta.AutoSize = true;
            this.labelNazivKlijenta.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNazivKlijenta.Location = new System.Drawing.Point(333, 145);
            this.labelNazivKlijenta.Name = "labelNazivKlijenta";
            this.labelNazivKlijenta.Size = new System.Drawing.Size(128, 18);
            this.labelNazivKlijenta.TabIndex = 41;
            this.labelNazivKlijenta.Text = "Naziv klijenta:";
            // 
            // tboxBodovi
            // 
            this.tboxBodovi.Enabled = false;
            this.tboxBodovi.Font = new System.Drawing.Font("Verdana", 12F);
            this.tboxBodovi.Location = new System.Drawing.Point(629, 184);
            this.tboxBodovi.Name = "tboxBodovi";
            this.tboxBodovi.Size = new System.Drawing.Size(65, 27);
            this.tboxBodovi.TabIndex = 43;
            // 
            // labelBodovi
            // 
            this.labelBodovi.AutoSize = true;
            this.labelBodovi.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBodovi.Location = new System.Drawing.Point(553, 187);
            this.labelBodovi.Name = "labelBodovi";
            this.labelBodovi.Size = new System.Drawing.Size(70, 18);
            this.labelBodovi.TabIndex = 42;
            this.labelBodovi.Text = "Bodovi:";
            // 
            // tboxClan
            // 
            this.tboxClan.Enabled = false;
            this.tboxClan.Font = new System.Drawing.Font("Verdana", 12F);
            this.tboxClan.Location = new System.Drawing.Point(467, 184);
            this.tboxClan.Name = "tboxClan";
            this.tboxClan.Size = new System.Drawing.Size(54, 27);
            this.tboxClan.TabIndex = 45;
            // 
            // labelClan
            // 
            this.labelClan.AutoSize = true;
            this.labelClan.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelClan.Location = new System.Drawing.Point(333, 187);
            this.labelClan.Name = "labelClan";
            this.labelClan.Size = new System.Drawing.Size(128, 18);
            this.labelClan.TabIndex = 44;
            this.labelClan.Text = "Član kluba vj.:";
            // 
            // labelRazdjelnik
            // 
            this.labelRazdjelnik.BackColor = System.Drawing.Color.Black;
            this.labelRazdjelnik.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelRazdjelnik.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRazdjelnik.ForeColor = System.Drawing.Color.White;
            this.labelRazdjelnik.Location = new System.Drawing.Point(777, 275);
            this.labelRazdjelnik.Name = "labelRazdjelnik";
            this.labelRazdjelnik.Size = new System.Drawing.Size(390, 2);
            this.labelRazdjelnik.TabIndex = 47;
            this.labelRazdjelnik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tboxUkupnaCijena
            // 
            this.tboxUkupnaCijena.Enabled = false;
            this.tboxUkupnaCijena.Font = new System.Drawing.Font("Verdana", 12F);
            this.tboxUkupnaCijena.Location = new System.Drawing.Point(911, 299);
            this.tboxUkupnaCijena.Name = "tboxUkupnaCijena";
            this.tboxUkupnaCijena.Size = new System.Drawing.Size(256, 27);
            this.tboxUkupnaCijena.TabIndex = 49;
            this.tboxUkupnaCijena.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelUkupnaCijena
            // 
            this.labelUkupnaCijena.AutoSize = true;
            this.labelUkupnaCijena.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUkupnaCijena.Location = new System.Drawing.Point(774, 302);
            this.labelUkupnaCijena.Name = "labelUkupnaCijena";
            this.labelUkupnaCijena.Size = new System.Drawing.Size(131, 18);
            this.labelUkupnaCijena.TabIndex = 48;
            this.labelUkupnaCijena.Text = "Ukupna cijena:";
            // 
            // btnUkloni
            // 
            this.btnUkloni.BackColor = System.Drawing.Color.Firebrick;
            this.btnUkloni.FlatAppearance.BorderSize = 0;
            this.btnUkloni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUkloni.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUkloni.ForeColor = System.Drawing.Color.White;
            this.btnUkloni.Location = new System.Drawing.Point(1114, 369);
            this.btnUkloni.Name = "btnUkloni";
            this.btnUkloni.Size = new System.Drawing.Size(120, 30);
            this.btnUkloni.TabIndex = 51;
            this.btnUkloni.Text = "Ukloni";
            this.btnUkloni.UseVisualStyleBackColor = false;
            this.btnUkloni.Click += new System.EventHandler(this.btnUkloni_Click);
            this.btnUkloni.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.btnUkloni.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(186)))), ((int)(((byte)(36)))));
            this.btnDodaj.FlatAppearance.BorderSize = 0;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodaj.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodaj.ForeColor = System.Drawing.Color.Black;
            this.btnDodaj.Location = new System.Drawing.Point(974, 369);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(120, 30);
            this.btnDodaj.TabIndex = 50;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            this.btnDodaj.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.btnDodaj.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            // 
            // btnIzdaj
            // 
            this.btnIzdaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(186)))), ((int)(((byte)(36)))));
            this.btnIzdaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzdaj.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzdaj.ForeColor = System.Drawing.Color.Black;
            this.btnIzdaj.Location = new System.Drawing.Point(1113, 635);
            this.btnIzdaj.Name = "btnIzdaj";
            this.btnIzdaj.Size = new System.Drawing.Size(120, 30);
            this.btnIzdaj.TabIndex = 52;
            this.btnIzdaj.Text = "Izdaj";
            this.btnIzdaj.UseVisualStyleBackColor = false;
            this.btnIzdaj.Click += new System.EventHandler(this.btnIzdaj_Click);
            this.btnIzdaj.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.btnIzdaj.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            // 
            // tboxTotal
            // 
            this.tboxTotal.Enabled = false;
            this.tboxTotal.Font = new System.Drawing.Font("Verdana", 12F);
            this.tboxTotal.Location = new System.Drawing.Point(456, 638);
            this.tboxTotal.Name = "tboxTotal";
            this.tboxTotal.Size = new System.Drawing.Size(238, 27);
            this.tboxTotal.TabIndex = 54;
            this.tboxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTotal.Location = new System.Drawing.Point(330, 641);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(120, 18);
            this.labelTotal.TabIndex = 53;
            this.labelTotal.Text = "Ukupni iznos:";
            // 
            // labelPopust
            // 
            this.labelPopust.Font = new System.Drawing.Font("Verdana", 10F);
            this.labelPopust.ForeColor = System.Drawing.Color.Black;
            this.labelPopust.Location = new System.Drawing.Point(456, 617);
            this.labelPopust.Name = "labelPopust";
            this.labelPopust.Size = new System.Drawing.Size(238, 18);
            this.labelPopust.TabIndex = 55;
            this.labelPopust.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPopisRacuna
            // 
            this.btnPopisRacuna.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPopisRacuna.FlatAppearance.BorderSize = 0;
            this.btnPopisRacuna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPopisRacuna.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPopisRacuna.ForeColor = System.Drawing.Color.Black;
            this.btnPopisRacuna.Location = new System.Drawing.Point(333, 369);
            this.btnPopisRacuna.Name = "btnPopisRacuna";
            this.btnPopisRacuna.Size = new System.Drawing.Size(128, 30);
            this.btnPopisRacuna.TabIndex = 56;
            this.btnPopisRacuna.Text = "Popis računa";
            this.btnPopisRacuna.UseVisualStyleBackColor = false;
            this.btnPopisRacuna.Click += new System.EventHandler(this.btnPopisRacuna_Click);
            this.btnPopisRacuna.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.btnPopisRacuna.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            // 
            // tboxIdKlijenta
            // 
            this.tboxIdKlijenta.Enabled = false;
            this.tboxIdKlijenta.Font = new System.Drawing.Font("Verdana", 12F);
            this.tboxIdKlijenta.Location = new System.Drawing.Point(467, 97);
            this.tboxIdKlijenta.Name = "tboxIdKlijenta";
            this.tboxIdKlijenta.Size = new System.Drawing.Size(54, 27);
            this.tboxIdKlijenta.TabIndex = 60;
            // 
            // labelIdKlijenta
            // 
            this.labelIdKlijenta.AutoSize = true;
            this.labelIdKlijenta.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelIdKlijenta.Location = new System.Drawing.Point(333, 100);
            this.labelIdKlijenta.Name = "labelIdKlijenta";
            this.labelIdKlijenta.Size = new System.Drawing.Size(102, 18);
            this.labelIdKlijenta.TabIndex = 59;
            this.labelIdKlijenta.Text = "ID klijenta:";
            // 
            // tboxIdLijeka
            // 
            this.tboxIdLijeka.Enabled = false;
            this.tboxIdLijeka.Font = new System.Drawing.Font("Verdana", 12F);
            this.tboxIdLijeka.Location = new System.Drawing.Point(911, 97);
            this.tboxIdLijeka.Name = "tboxIdLijeka";
            this.tboxIdLijeka.Size = new System.Drawing.Size(54, 27);
            this.tboxIdLijeka.TabIndex = 62;
            // 
            // labelIdLijeka
            // 
            this.labelIdLijeka.AutoSize = true;
            this.labelIdLijeka.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelIdLijeka.Location = new System.Drawing.Point(774, 100);
            this.labelIdLijeka.Name = "labelIdLijeka";
            this.labelIdLijeka.Size = new System.Drawing.Size(85, 18);
            this.labelIdLijeka.TabIndex = 61;
            this.labelIdLijeka.Text = "ID lijeka:";
            // 
            // labelGreska
            // 
            this.labelGreska.AutoSize = true;
            this.labelGreska.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGreska.ForeColor = System.Drawing.Color.Red;
            this.labelGreska.Location = new System.Drawing.Point(333, 270);
            this.labelGreska.Name = "labelGreska";
            this.labelGreska.Size = new System.Drawing.Size(0, 18);
            this.labelGreska.TabIndex = 63;
            this.labelGreska.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mtboxKolicina
            // 
            this.mtboxKolicina.Font = new System.Drawing.Font("Verdana", 12F);
            this.mtboxKolicina.Location = new System.Drawing.Point(911, 230);
            this.mtboxKolicina.Mask = "99";
            this.mtboxKolicina.Name = "mtboxKolicina";
            this.mtboxKolicina.Size = new System.Drawing.Size(65, 27);
            this.mtboxKolicina.TabIndex = 64;
            this.mtboxKolicina.ValidatingType = typeof(int);
            this.mtboxKolicina.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mtboxKolicina_KeyUp);
            // 
            // btnIzracunaj
            // 
            this.btnIzracunaj.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnIzracunaj.FlatAppearance.BorderSize = 0;
            this.btnIzracunaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzracunaj.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzracunaj.ForeColor = System.Drawing.Color.Black;
            this.btnIzracunaj.Location = new System.Drawing.Point(716, 635);
            this.btnIzracunaj.Name = "btnIzracunaj";
            this.btnIzracunaj.Size = new System.Drawing.Size(120, 30);
            this.btnIzracunaj.TabIndex = 65;
            this.btnIzracunaj.Text = "Izračunaj";
            this.btnIzracunaj.UseVisualStyleBackColor = false;
            this.btnIzracunaj.Click += new System.EventHandler(this.btnIzracunaj_Click);
            this.btnIzracunaj.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.btnIzracunaj.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
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
            // labelPomoc
            // 
            this.labelPomoc.AutoSize = true;
            this.labelPomoc.BackColor = System.Drawing.Color.LimeGreen;
            this.labelPomoc.Font = new System.Drawing.Font("Verdana", 9F);
            this.labelPomoc.Location = new System.Drawing.Point(11, 0);
            this.labelPomoc.Name = "labelPomoc";
            this.labelPomoc.Size = new System.Drawing.Size(76, 14);
            this.labelPomoc.TabIndex = 66;
            this.labelPomoc.Text = "F1 - Pomoć";
            // 
            // FormIzdavanjeRacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.labelPomoc);
            this.Controls.Add(this.btnIzracunaj);
            this.Controls.Add(this.mtboxKolicina);
            this.Controls.Add(this.labelGreska);
            this.Controls.Add(this.tboxIdLijeka);
            this.Controls.Add(this.labelIdLijeka);
            this.Controls.Add(this.tboxIdKlijenta);
            this.Controls.Add(this.labelIdKlijenta);
            this.Controls.Add(this.btnPopisRacuna);
            this.Controls.Add(this.labelPopust);
            this.Controls.Add(this.tboxTotal);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.btnIzdaj);
            this.Controls.Add(this.btnUkloni);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.tboxUkupnaCijena);
            this.Controls.Add(this.labelUkupnaCijena);
            this.Controls.Add(this.labelRazdjelnik);
            this.Controls.Add(this.tboxClan);
            this.Controls.Add(this.labelClan);
            this.Controls.Add(this.tboxBodovi);
            this.Controls.Add(this.labelBodovi);
            this.Controls.Add(this.cboxNazivKlijenta);
            this.Controls.Add(this.labelNazivKlijenta);
            this.Controls.Add(this.labelKolicina);
            this.Controls.Add(this.tboxCijena);
            this.Controls.Add(this.labelCijena);
            this.Controls.Add(this.tboxStanjeZaliha);
            this.Controls.Add(this.labelNaziv);
            this.Controls.Add(this.cboxNazivLijeka);
            this.Controls.Add(this.labelNazivLijeka);
            this.Controls.Add(this.labelStavkeRacuna);
            this.Controls.Add(this.dgvStavkeRacuna);
            this.Controls.Add(this.labelOpis);
            this.Controls.Add(this.panelIzbornik);
            this.Controls.Add(this.labelDatumVrijeme);
            this.Controls.Add(this.labelUlogaPrijavljenogKorisnika);
            this.Controls.Add(this.pBoxLogo);
            this.Controls.Add(this.labelNazivPrijavljenogKorisnika);
            this.Controls.Add(this.labelLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormIzdavanjeRacuna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izdavanje računa";
            this.Load += new System.EventHandler(this.FormIzdavanjeRacuna_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormIzdavanjeRacuna_KeyDown);
            this.panelIzbornik.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeRacuna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo)).EndInit();
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
        private System.Windows.Forms.Label labelOpis;
        private System.Windows.Forms.DataGridView dgvStavkeRacuna;
        private System.Windows.Forms.Label labelStavkeRacuna;
        private System.Windows.Forms.ComboBox cboxNazivLijeka;
        private System.Windows.Forms.Label labelNazivLijeka;
        private System.Windows.Forms.TextBox tboxStanjeZaliha;
        private System.Windows.Forms.Label labelNaziv;
        private System.Windows.Forms.TextBox tboxCijena;
        private System.Windows.Forms.Label labelCijena;
        private System.Windows.Forms.Label labelKolicina;
        private System.Windows.Forms.ComboBox cboxNazivKlijenta;
        private System.Windows.Forms.Label labelNazivKlijenta;
        private System.Windows.Forms.TextBox tboxBodovi;
        private System.Windows.Forms.Label labelBodovi;
        private System.Windows.Forms.TextBox tboxClan;
        private System.Windows.Forms.Label labelClan;
        private System.Windows.Forms.Label labelRazdjelnik;
        private System.Windows.Forms.TextBox tboxUkupnaCijena;
        private System.Windows.Forms.Label labelUkupnaCijena;
        private System.Windows.Forms.Button btnUkloni;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzdaj;
        private System.Windows.Forms.TextBox tboxTotal;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelPopust;
        private System.Windows.Forms.Button btnPopisRacuna;
        private System.Windows.Forms.TextBox tboxIdKlijenta;
        private System.Windows.Forms.Label labelIdKlijenta;
        private System.Windows.Forms.TextBox tboxIdLijeka;
        private System.Windows.Forms.Label labelIdLijeka;
        private System.Windows.Forms.Label labelGreska;
        private System.Windows.Forms.MaskedTextBox mtboxKolicina;
        private System.Windows.Forms.Button btnIzracunaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_lijeka;
        private System.Windows.Forms.DataGridViewTextBoxColumn naziv_lijeka;
        private System.Windows.Forms.DataGridViewTextBoxColumn jedinicna_cijena_lijeka;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicina_lijeka;
        private System.Windows.Forms.DataGridViewTextBoxColumn ukupna_cijena;
        private System.Windows.Forms.Label labelPomoc;
    }
}