namespace PharmaCare.Forme
{
    partial class FormKlijenti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKlijenti));
            this.panelIzbornik = new System.Windows.Forms.Panel();
            this.btnZaposlenici = new System.Windows.Forms.Button();
            this.btnIzdavanjeRacuna = new System.Windows.Forms.Button();
            this.btnProizvodaci = new System.Windows.Forms.Button();
            this.btnKlijenti = new System.Windows.Forms.Button();
            this.btnLijekovi = new System.Windows.Forms.Button();
            this.btnPocetna = new System.Windows.Forms.Button();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.labelDatumVrijeme = new System.Windows.Forms.Label();
            this.labelUlogaPrijavljenogKorisnika = new System.Windows.Forms.Label();
            this.labelNazivPrijavljenogKorisnika = new System.Windows.Forms.Label();
            this.pBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelLogo = new System.Windows.Forms.Label();
            this.dgvKlijenti = new System.Windows.Forms.DataGridView();
            this.btnZdravKarton = new System.Windows.Forms.Button();
            this.labelOpis = new System.Windows.Forms.Label();
            this.panelIzbornik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijenti)).BeginInit();
            this.SuspendLayout();
            // 
            // panelIzbornik
            // 
            this.panelIzbornik.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelIzbornik.Controls.Add(this.btnZaposlenici);
            this.panelIzbornik.Controls.Add(this.btnIzdavanjeRacuna);
            this.panelIzbornik.Controls.Add(this.btnProizvodaci);
            this.panelIzbornik.Controls.Add(this.btnKlijenti);
            this.panelIzbornik.Controls.Add(this.btnLijekovi);
            this.panelIzbornik.Controls.Add(this.btnPocetna);
            this.panelIzbornik.Controls.Add(this.btnOdjava);
            this.panelIzbornik.Location = new System.Drawing.Point(0, 87);
            this.panelIzbornik.Name = "panelIzbornik";
            this.panelIzbornik.Size = new System.Drawing.Size(298, 594);
            this.panelIzbornik.TabIndex = 5;
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
            this.btnZaposlenici.TabIndex = 16;
            this.btnZaposlenici.Text = "Zaposlenici";
            this.btnZaposlenici.UseVisualStyleBackColor = true;
            this.btnZaposlenici.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.btnZaposlenici.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
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
            this.btnKlijenti.BackColor = System.Drawing.Color.White;
            this.btnKlijenti.FlatAppearance.BorderSize = 0;
            this.btnKlijenti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKlijenti.Font = new System.Drawing.Font("Verdana", 14F);
            this.btnKlijenti.ForeColor = System.Drawing.Color.Black;
            this.btnKlijenti.Location = new System.Drawing.Point(-8, 120);
            this.btnKlijenti.Name = "btnKlijenti";
            this.btnKlijenti.Size = new System.Drawing.Size(309, 50);
            this.btnKlijenti.TabIndex = 12;
            this.btnKlijenti.Text = "Klijenti";
            this.btnKlijenti.UseVisualStyleBackColor = false;
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
            this.labelDatumVrijeme.TabIndex = 10;
            this.labelDatumVrijeme.Text = "_";
            this.labelDatumVrijeme.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelUlogaPrijavljenogKorisnika
            // 
            this.labelUlogaPrijavljenogKorisnika.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUlogaPrijavljenogKorisnika.Location = new System.Drawing.Point(1058, 32);
            this.labelUlogaPrijavljenogKorisnika.Name = "labelUlogaPrijavljenogKorisnika";
            this.labelUlogaPrijavljenogKorisnika.Size = new System.Drawing.Size(194, 32);
            this.labelUlogaPrijavljenogKorisnika.TabIndex = 9;
            this.labelUlogaPrijavljenogKorisnika.Text = "_";
            this.labelUlogaPrijavljenogKorisnika.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelNazivPrijavljenogKorisnika
            // 
            this.labelNazivPrijavljenogKorisnika.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNazivPrijavljenogKorisnika.Location = new System.Drawing.Point(1055, 9);
            this.labelNazivPrijavljenogKorisnika.Name = "labelNazivPrijavljenogKorisnika";
            this.labelNazivPrijavljenogKorisnika.Size = new System.Drawing.Size(200, 32);
            this.labelNazivPrijavljenogKorisnika.TabIndex = 8;
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
            this.pBoxLogo.TabIndex = 7;
            this.pBoxLogo.TabStop = false;
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLogo.Location = new System.Drawing.Point(87, 36);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(200, 32);
            this.labelLogo.TabIndex = 6;
            this.labelLogo.Text = "PharmaCare";
            // 
            // dgvKlijenti
            // 
            this.dgvKlijenti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvKlijenti.BackgroundColor = System.Drawing.Color.White;
            this.dgvKlijenti.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvKlijenti.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKlijenti.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKlijenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKlijenti.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKlijenti.Location = new System.Drawing.Point(333, 357);
            this.dgvKlijenti.Name = "dgvKlijenti";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKlijenti.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKlijenti.Size = new System.Drawing.Size(900, 299);
            this.dgvKlijenti.TabIndex = 11;
            // 
            // btnZdravKarton
            // 
            this.btnZdravKarton.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnZdravKarton.FlatAppearance.BorderSize = 0;
            this.btnZdravKarton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZdravKarton.Font = new System.Drawing.Font("Verdana", 12F);
            this.btnZdravKarton.ForeColor = System.Drawing.Color.Black;
            this.btnZdravKarton.Location = new System.Drawing.Point(1033, 307);
            this.btnZdravKarton.Name = "btnZdravKarton";
            this.btnZdravKarton.Size = new System.Drawing.Size(200, 30);
            this.btnZdravKarton.TabIndex = 12;
            this.btnZdravKarton.Text = "Zdravstveni karton";
            this.btnZdravKarton.UseVisualStyleBackColor = false;
            this.btnZdravKarton.Click += new System.EventHandler(this.btnZdravKarton_Click);
            this.btnZdravKarton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.btnZdravKarton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            // 
            // labelOpis
            // 
            this.labelOpis.AutoSize = true;
            this.labelOpis.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOpis.Location = new System.Drawing.Point(675, 18);
            this.labelOpis.Name = "labelOpis";
            this.labelOpis.Size = new System.Drawing.Size(193, 23);
            this.labelOpis.TabIndex = 28;
            this.labelOpis.Text = "Podaci o klijentima";
            // 
            // FormKlijenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.labelOpis);
            this.Controls.Add(this.btnZdravKarton);
            this.Controls.Add(this.dgvKlijenti);
            this.Controls.Add(this.panelIzbornik);
            this.Controls.Add(this.labelDatumVrijeme);
            this.Controls.Add(this.labelUlogaPrijavljenogKorisnika);
            this.Controls.Add(this.labelNazivPrijavljenogKorisnika);
            this.Controls.Add(this.pBoxLogo);
            this.Controls.Add(this.labelLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormKlijenti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Klijenti";
            this.Load += new System.EventHandler(this.FormKlijenti_Load);
            this.panelIzbornik.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelIzbornik;
        private System.Windows.Forms.Button btnIzdavanjeRacuna;
        private System.Windows.Forms.Button btnProizvodaci;
        private System.Windows.Forms.Button btnKlijenti;
        private System.Windows.Forms.Button btnLijekovi;
        private System.Windows.Forms.Button btnPocetna;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Label labelDatumVrijeme;
        private System.Windows.Forms.Label labelUlogaPrijavljenogKorisnika;
        private System.Windows.Forms.Label labelNazivPrijavljenogKorisnika;
        private System.Windows.Forms.PictureBox pBoxLogo;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.DataGridView dgvKlijenti;
        private System.Windows.Forms.Button btnZdravKarton;
        private System.Windows.Forms.Button btnZaposlenici;
        private System.Windows.Forms.Label labelOpis;
    }
}