namespace PharmaCare
{
    partial class FormPocetna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPocetna));
            this.panelIzbornik = new System.Windows.Forms.Panel();
            this.btnIzdavanjeRacuna = new System.Windows.Forms.Button();
            this.btnZaposlenici = new System.Windows.Forms.Button();
            this.btnProizvodaci = new System.Windows.Forms.Button();
            this.btnKlijenti = new System.Windows.Forms.Button();
            this.btnLijekovi = new System.Windows.Forms.Button();
            this.btnPocetna = new System.Windows.Forms.Button();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.labelLogo = new System.Windows.Forms.Label();
            this.labelDatumVrijeme = new System.Windows.Forms.Label();
            this.labelUlogaPrijavljenogKorisnika = new System.Windows.Forms.Label();
            this.labelNazivPrijavljenogKorisnika = new System.Windows.Forms.Label();
            this.pBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelPodaci = new System.Windows.Forms.Label();
            this.labelLijekovi = new System.Windows.Forms.Label();
            this.labelKlijenti = new System.Windows.Forms.Label();
            this.labelProizvodaci = new System.Windows.Forms.Label();
            this.labelKorisnici = new System.Windows.Forms.Label();
            this.txtLijekovi = new System.Windows.Forms.TextBox();
            this.txtProizvodaci = new System.Windows.Forms.TextBox();
            this.txtKlijenti = new System.Windows.Forms.TextBox();
            this.txtZaposleni = new System.Windows.Forms.TextBox();
            this.labelNaslov = new System.Windows.Forms.Label();
            this.panelStatistika = new System.Windows.Forms.Panel();
            this.rtxPoruka = new System.Windows.Forms.RichTextBox();
            this.labelPomoc = new System.Windows.Forms.Label();
            this.panelIzbornik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo)).BeginInit();
            this.panelStatistika.SuspendLayout();
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
            this.panelIzbornik.TabIndex = 0;
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
            this.btnPocetna.BackColor = System.Drawing.Color.White;
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
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLogo.Location = new System.Drawing.Point(87, 36);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(200, 32);
            this.labelLogo.TabIndex = 0;
            this.labelLogo.Text = "PharmaCare";
            // 
            // labelDatumVrijeme
            // 
            this.labelDatumVrijeme.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDatumVrijeme.Location = new System.Drawing.Point(1055, 55);
            this.labelDatumVrijeme.Name = "labelDatumVrijeme";
            this.labelDatumVrijeme.Size = new System.Drawing.Size(197, 32);
            this.labelDatumVrijeme.TabIndex = 18;
            this.labelDatumVrijeme.Text = "_";
            this.labelDatumVrijeme.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelUlogaPrijavljenogKorisnika
            // 
            this.labelUlogaPrijavljenogKorisnika.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUlogaPrijavljenogKorisnika.Location = new System.Drawing.Point(1058, 32);
            this.labelUlogaPrijavljenogKorisnika.Name = "labelUlogaPrijavljenogKorisnika";
            this.labelUlogaPrijavljenogKorisnika.Size = new System.Drawing.Size(194, 32);
            this.labelUlogaPrijavljenogKorisnika.TabIndex = 17;
            this.labelUlogaPrijavljenogKorisnika.Text = "_";
            this.labelUlogaPrijavljenogKorisnika.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelNazivPrijavljenogKorisnika
            // 
            this.labelNazivPrijavljenogKorisnika.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNazivPrijavljenogKorisnika.Location = new System.Drawing.Point(1055, 9);
            this.labelNazivPrijavljenogKorisnika.Name = "labelNazivPrijavljenogKorisnika";
            this.labelNazivPrijavljenogKorisnika.Size = new System.Drawing.Size(200, 32);
            this.labelNazivPrijavljenogKorisnika.TabIndex = 16;
            this.labelNazivPrijavljenogKorisnika.Text = "_";
            this.labelNazivPrijavljenogKorisnika.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pBoxLogo
            // 
            this.pBoxLogo.Image = global::PharmaCare.Properties.Resources.PharmaCareLogo;
            this.pBoxLogo.ImageLocation = "";
            this.pBoxLogo.Location = new System.Drawing.Point(12, 12);
            this.pBoxLogo.Name = "pBoxLogo";
            this.pBoxLogo.Size = new System.Drawing.Size(75, 75);
            this.pBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxLogo.TabIndex = 1;
            this.pBoxLogo.TabStop = false;
            // 
            // labelPodaci
            // 
            this.labelPodaci.Font = new System.Drawing.Font("Verdana", 15F);
            this.labelPodaci.Location = new System.Drawing.Point(332, 246);
            this.labelPodaci.Name = "labelPodaci";
            this.labelPodaci.Size = new System.Drawing.Size(277, 40);
            this.labelPodaci.TabIndex = 19;
            this.labelPodaci.Text = "Podaci o sustavu:";
            // 
            // labelLijekovi
            // 
            this.labelLijekovi.Font = new System.Drawing.Font("Verdana", 14F);
            this.labelLijekovi.Location = new System.Drawing.Point(35, 19);
            this.labelLijekovi.Name = "labelLijekovi";
            this.labelLijekovi.Size = new System.Drawing.Size(148, 26);
            this.labelLijekovi.TabIndex = 20;
            this.labelLijekovi.Text = "Broj lijekova: ";
            // 
            // labelKlijenti
            // 
            this.labelKlijenti.Font = new System.Drawing.Font("Verdana", 14F);
            this.labelKlijenti.Location = new System.Drawing.Point(35, 78);
            this.labelKlijenti.Name = "labelKlijenti";
            this.labelKlijenti.Size = new System.Drawing.Size(170, 26);
            this.labelKlijenti.TabIndex = 21;
            this.labelKlijenti.Text = "Broj klijenata: ";
            // 
            // labelProizvodaci
            // 
            this.labelProizvodaci.Font = new System.Drawing.Font("Verdana", 14F);
            this.labelProizvodaci.Location = new System.Drawing.Point(307, 20);
            this.labelProizvodaci.Name = "labelProizvodaci";
            this.labelProizvodaci.Size = new System.Drawing.Size(186, 26);
            this.labelProizvodaci.TabIndex = 22;
            this.labelProizvodaci.Text = "Broj proizvođača: ";
            // 
            // labelKorisnici
            // 
            this.labelKorisnici.Font = new System.Drawing.Font("Verdana", 14F);
            this.labelKorisnici.Location = new System.Drawing.Point(307, 78);
            this.labelKorisnici.Name = "labelKorisnici";
            this.labelKorisnici.Size = new System.Drawing.Size(186, 26);
            this.labelKorisnici.TabIndex = 23;
            this.labelKorisnici.Text = "Broj zaposlenih: ";
            // 
            // txtLijekovi
            // 
            this.txtLijekovi.Enabled = false;
            this.txtLijekovi.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.txtLijekovi.Location = new System.Drawing.Point(189, 19);
            this.txtLijekovi.Name = "txtLijekovi";
            this.txtLijekovi.Size = new System.Drawing.Size(39, 27);
            this.txtLijekovi.TabIndex = 24;
            this.txtLijekovi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtProizvodaci
            // 
            this.txtProizvodaci.Enabled = false;
            this.txtProizvodaci.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.txtProizvodaci.Location = new System.Drawing.Point(499, 19);
            this.txtProizvodaci.Name = "txtProizvodaci";
            this.txtProizvodaci.Size = new System.Drawing.Size(39, 27);
            this.txtProizvodaci.TabIndex = 25;
            this.txtProizvodaci.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKlijenti
            // 
            this.txtKlijenti.Enabled = false;
            this.txtKlijenti.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.txtKlijenti.Location = new System.Drawing.Point(189, 78);
            this.txtKlijenti.Name = "txtKlijenti";
            this.txtKlijenti.Size = new System.Drawing.Size(39, 27);
            this.txtKlijenti.TabIndex = 26;
            this.txtKlijenti.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtZaposleni
            // 
            this.txtZaposleni.Enabled = false;
            this.txtZaposleni.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.txtZaposleni.Location = new System.Drawing.Point(499, 77);
            this.txtZaposleni.Name = "txtZaposleni";
            this.txtZaposleni.Size = new System.Drawing.Size(39, 27);
            this.txtZaposleni.TabIndex = 27;
            this.txtZaposleni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelNaslov
            // 
            this.labelNaslov.Font = new System.Drawing.Font("Verdana", 20.27F, System.Drawing.FontStyle.Bold);
            this.labelNaslov.Location = new System.Drawing.Point(552, 18);
            this.labelNaslov.Name = "labelNaslov";
            this.labelNaslov.Size = new System.Drawing.Size(433, 46);
            this.labelNaslov.TabIndex = 28;
            this.labelNaslov.Text = "Dobrodošli u PharmaCare";
            // 
            // panelStatistika
            // 
            this.panelStatistika.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelStatistika.Controls.Add(this.txtZaposleni);
            this.panelStatistika.Controls.Add(this.txtKlijenti);
            this.panelStatistika.Controls.Add(this.txtProizvodaci);
            this.panelStatistika.Controls.Add(this.txtLijekovi);
            this.panelStatistika.Controls.Add(this.labelKorisnici);
            this.panelStatistika.Controls.Add(this.labelProizvodaci);
            this.panelStatistika.Controls.Add(this.labelKlijenti);
            this.panelStatistika.Controls.Add(this.labelLijekovi);
            this.panelStatistika.Location = new System.Drawing.Point(337, 278);
            this.panelStatistika.Name = "panelStatistika";
            this.panelStatistika.Size = new System.Drawing.Size(569, 129);
            this.panelStatistika.TabIndex = 29;
            // 
            // rtxPoruka
            // 
            this.rtxPoruka.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxPoruka.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rtxPoruka.Location = new System.Drawing.Point(333, 100);
            this.rtxPoruka.Name = "rtxPoruka";
            this.rtxPoruka.Size = new System.Drawing.Size(724, 100);
            this.rtxPoruka.TabIndex = 30;
            this.rtxPoruka.Text = "PharmaCare je sustav namijenjen za upravljanje ljekarnom. S lijeve strane se nala" +
    "zi navigacija kroz sustav, a ispod se nalaze informacije o podacima u sustavu.\n";
            // 
            // labelPomoc
            // 
            this.labelPomoc.AutoSize = true;
            this.labelPomoc.BackColor = System.Drawing.Color.LimeGreen;
            this.labelPomoc.Font = new System.Drawing.Font("Verdana", 9F);
            this.labelPomoc.Location = new System.Drawing.Point(11, 0);
            this.labelPomoc.Name = "labelPomoc";
            this.labelPomoc.Size = new System.Drawing.Size(76, 14);
            this.labelPomoc.TabIndex = 61;
            this.labelPomoc.Text = "F1 - Pomoć";
            // 
            // FormPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.labelPomoc);
            this.Controls.Add(this.rtxPoruka);
            this.Controls.Add(this.panelStatistika);
            this.Controls.Add(this.labelNaslov);
            this.Controls.Add(this.labelDatumVrijeme);
            this.Controls.Add(this.panelIzbornik);
            this.Controls.Add(this.labelUlogaPrijavljenogKorisnika);
            this.Controls.Add(this.pBoxLogo);
            this.Controls.Add(this.labelNazivPrijavljenogKorisnika);
            this.Controls.Add(this.labelLogo);
            this.Controls.Add(this.labelPodaci);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormPocetna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Početna";
            this.Load += new System.EventHandler(this.FormPocetna_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPocetna_KeyDown);
            this.panelIzbornik.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo)).EndInit();
            this.panelStatistika.ResumeLayout(false);
            this.panelStatistika.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelIzbornik;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.PictureBox pBoxLogo;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Button btnPocetna;
        private System.Windows.Forms.Button btnLijekovi;
        private System.Windows.Forms.Button btnKlijenti;
        private System.Windows.Forms.Button btnProizvodaci;
        private System.Windows.Forms.Button btnZaposlenici;
        private System.Windows.Forms.Button btnIzdavanjeRacuna;
        private System.Windows.Forms.Label labelDatumVrijeme;
        private System.Windows.Forms.Label labelUlogaPrijavljenogKorisnika;
        private System.Windows.Forms.Label labelNazivPrijavljenogKorisnika;
        private System.Windows.Forms.Label labelPodaci;
        private System.Windows.Forms.Label labelLijekovi;
        private System.Windows.Forms.Label labelKlijenti;
        private System.Windows.Forms.Label labelProizvodaci;
        private System.Windows.Forms.Label labelKorisnici;
        private System.Windows.Forms.TextBox txtLijekovi;
        private System.Windows.Forms.TextBox txtProizvodaci;
        private System.Windows.Forms.TextBox txtKlijenti;
        private System.Windows.Forms.TextBox txtZaposleni;
        private System.Windows.Forms.Label labelNaslov;
        private System.Windows.Forms.Panel panelStatistika;
        private System.Windows.Forms.RichTextBox rtxPoruka;
        private System.Windows.Forms.Label labelPomoc;
    }
}

