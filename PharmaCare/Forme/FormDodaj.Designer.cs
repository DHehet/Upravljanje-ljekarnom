namespace PharmaCare.Forme
{
    partial class FormDodaj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDodaj));
            this.labelNaziv = new System.Windows.Forms.Label();
            this.labelImeDobavljaca = new System.Windows.Forms.Label();
            this.labelCijena = new System.Windows.Forms.Label();
            this.labelStanjeZaliha = new System.Windows.Forms.Label();
            this.labelRokUporabe = new System.Windows.Forms.Label();
            this.labelOpis = new System.Windows.Forms.Label();
            this.labelDatumProizvodnje = new System.Windows.Forms.Label();
            this.labelProizvodac = new System.Windows.Forms.Label();
            this.tboxNaziv = new System.Windows.Forms.TextBox();
            this.tboxStanjeZaliha = new System.Windows.Forms.TextBox();
            this.tboxOpis = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.panelDodaj = new System.Windows.Forms.Panel();
            this.labelGreska = new System.Windows.Forms.Label();
            this.cmbProizvodac = new System.Windows.Forms.ComboBox();
            this.cmbDobavljac = new System.Windows.Forms.ComboBox();
            this.dtpDatumProizvodnje = new System.Windows.Forms.DateTimePicker();
            this.dtpRokUporabe = new System.Windows.Forms.DateTimePicker();
            this.nudCijena = new System.Windows.Forms.NumericUpDown();
            this.panelDodaj.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCijena)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNaziv
            // 
            this.labelNaziv.AutoSize = true;
            this.labelNaziv.Font = new System.Drawing.Font("Verdana", 12F);
            this.labelNaziv.ForeColor = System.Drawing.Color.Black;
            this.labelNaziv.Location = new System.Drawing.Point(16, 17);
            this.labelNaziv.Name = "labelNaziv";
            this.labelNaziv.Size = new System.Drawing.Size(60, 18);
            this.labelNaziv.TabIndex = 12;
            this.labelNaziv.Text = "Naziv:";
            // 
            // labelImeDobavljaca
            // 
            this.labelImeDobavljaca.AutoSize = true;
            this.labelImeDobavljaca.Font = new System.Drawing.Font("Verdana", 12F);
            this.labelImeDobavljaca.ForeColor = System.Drawing.Color.Black;
            this.labelImeDobavljaca.Location = new System.Drawing.Point(449, 72);
            this.labelImeDobavljaca.Name = "labelImeDobavljaca";
            this.labelImeDobavljaca.Size = new System.Drawing.Size(141, 18);
            this.labelImeDobavljaca.TabIndex = 13;
            this.labelImeDobavljaca.Text = "Ime dobavljaca:";
            // 
            // labelCijena
            // 
            this.labelCijena.AutoSize = true;
            this.labelCijena.Font = new System.Drawing.Font("Verdana", 12F);
            this.labelCijena.ForeColor = System.Drawing.Color.Black;
            this.labelCijena.Location = new System.Drawing.Point(16, 69);
            this.labelCijena.Name = "labelCijena";
            this.labelCijena.Size = new System.Drawing.Size(67, 18);
            this.labelCijena.TabIndex = 14;
            this.labelCijena.Text = "Cijena:";
            // 
            // labelStanjeZaliha
            // 
            this.labelStanjeZaliha.AutoSize = true;
            this.labelStanjeZaliha.Font = new System.Drawing.Font("Verdana", 12F);
            this.labelStanjeZaliha.ForeColor = System.Drawing.Color.Black;
            this.labelStanjeZaliha.Location = new System.Drawing.Point(16, 239);
            this.labelStanjeZaliha.Name = "labelStanjeZaliha";
            this.labelStanjeZaliha.Size = new System.Drawing.Size(123, 18);
            this.labelStanjeZaliha.TabIndex = 15;
            this.labelStanjeZaliha.Text = "Stanje zaliha:";
            // 
            // labelRokUporabe
            // 
            this.labelRokUporabe.AutoSize = true;
            this.labelRokUporabe.Font = new System.Drawing.Font("Verdana", 12F);
            this.labelRokUporabe.ForeColor = System.Drawing.Color.Black;
            this.labelRokUporabe.Location = new System.Drawing.Point(449, 17);
            this.labelRokUporabe.Name = "labelRokUporabe";
            this.labelRokUporabe.Size = new System.Drawing.Size(117, 18);
            this.labelRokUporabe.TabIndex = 16;
            this.labelRokUporabe.Text = "Rok uporabe:";
            // 
            // labelOpis
            // 
            this.labelOpis.AutoSize = true;
            this.labelOpis.Font = new System.Drawing.Font("Verdana", 12F);
            this.labelOpis.ForeColor = System.Drawing.Color.Black;
            this.labelOpis.Location = new System.Drawing.Point(16, 123);
            this.labelOpis.Name = "labelOpis";
            this.labelOpis.Size = new System.Drawing.Size(52, 18);
            this.labelOpis.TabIndex = 17;
            this.labelOpis.Text = "Opis:";
            // 
            // labelDatumProizvodnje
            // 
            this.labelDatumProizvodnje.AutoSize = true;
            this.labelDatumProizvodnje.Font = new System.Drawing.Font("Verdana", 12F);
            this.labelDatumProizvodnje.ForeColor = System.Drawing.Color.Black;
            this.labelDatumProizvodnje.Location = new System.Drawing.Point(449, 123);
            this.labelDatumProizvodnje.Name = "labelDatumProizvodnje";
            this.labelDatumProizvodnje.Size = new System.Drawing.Size(170, 18);
            this.labelDatumProizvodnje.TabIndex = 18;
            this.labelDatumProizvodnje.Text = "Datum proizvodnje:";
            // 
            // labelProizvodac
            // 
            this.labelProizvodac.AutoSize = true;
            this.labelProizvodac.Font = new System.Drawing.Font("Verdana", 12F);
            this.labelProizvodac.ForeColor = System.Drawing.Color.Black;
            this.labelProizvodac.Location = new System.Drawing.Point(449, 177);
            this.labelProizvodac.Name = "labelProizvodac";
            this.labelProizvodac.Size = new System.Drawing.Size(102, 18);
            this.labelProizvodac.TabIndex = 19;
            this.labelProizvodac.Text = "Proizvodac:";
            // 
            // tboxNaziv
            // 
            this.tboxNaziv.Font = new System.Drawing.Font("Verdana", 12F);
            this.tboxNaziv.Location = new System.Drawing.Point(145, 14);
            this.tboxNaziv.Name = "tboxNaziv";
            this.tboxNaziv.Size = new System.Drawing.Size(234, 27);
            this.tboxNaziv.TabIndex = 20;
            // 
            // tboxStanjeZaliha
            // 
            this.tboxStanjeZaliha.Font = new System.Drawing.Font("Verdana", 12F);
            this.tboxStanjeZaliha.Location = new System.Drawing.Point(145, 236);
            this.tboxStanjeZaliha.Name = "tboxStanjeZaliha";
            this.tboxStanjeZaliha.Size = new System.Drawing.Size(234, 27);
            this.tboxStanjeZaliha.TabIndex = 21;
            this.tboxStanjeZaliha.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tboxOpis
            // 
            this.tboxOpis.Font = new System.Drawing.Font("Verdana", 12F);
            this.tboxOpis.Location = new System.Drawing.Point(145, 120);
            this.tboxOpis.Multiline = true;
            this.tboxOpis.Name = "tboxOpis";
            this.tboxOpis.Size = new System.Drawing.Size(234, 91);
            this.tboxOpis.TabIndex = 23;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(186)))), ((int)(((byte)(36)))));
            this.btnDodaj.FlatAppearance.BorderSize = 0;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodaj.Font = new System.Drawing.Font("Verdana", 12F);
            this.btnDodaj.ForeColor = System.Drawing.Color.Black;
            this.btnDodaj.Location = new System.Drawing.Point(637, 310);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(120, 30);
            this.btnDodaj.TabIndex = 30;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            this.btnDodaj.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.btnDodaj.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnOdustani.FlatAppearance.BorderSize = 0;
            this.btnOdustani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdustani.Font = new System.Drawing.Font("Verdana", 12F);
            this.btnOdustani.ForeColor = System.Drawing.Color.Black;
            this.btnOdustani.Location = new System.Drawing.Point(767, 310);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(120, 30);
            this.btnOdustani.TabIndex = 31;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            this.btnOdustani.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.btnOdustani.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            // 
            // panelDodaj
            // 
            this.panelDodaj.BackColor = System.Drawing.Color.White;
            this.panelDodaj.Controls.Add(this.nudCijena);
            this.panelDodaj.Controls.Add(this.labelGreska);
            this.panelDodaj.Controls.Add(this.cmbProizvodac);
            this.panelDodaj.Controls.Add(this.cmbDobavljac);
            this.panelDodaj.Controls.Add(this.dtpDatumProizvodnje);
            this.panelDodaj.Controls.Add(this.dtpRokUporabe);
            this.panelDodaj.Controls.Add(this.tboxOpis);
            this.panelDodaj.Controls.Add(this.tboxStanjeZaliha);
            this.panelDodaj.Controls.Add(this.tboxNaziv);
            this.panelDodaj.Controls.Add(this.labelProizvodac);
            this.panelDodaj.Controls.Add(this.labelDatumProizvodnje);
            this.panelDodaj.Controls.Add(this.labelOpis);
            this.panelDodaj.Controls.Add(this.labelRokUporabe);
            this.panelDodaj.Controls.Add(this.labelStanjeZaliha);
            this.panelDodaj.Controls.Add(this.labelCijena);
            this.panelDodaj.Controls.Add(this.labelImeDobavljaca);
            this.panelDodaj.Controls.Add(this.labelNaziv);
            this.panelDodaj.Location = new System.Drawing.Point(12, 12);
            this.panelDodaj.Name = "panelDodaj";
            this.panelDodaj.Size = new System.Drawing.Size(875, 278);
            this.panelDodaj.TabIndex = 32;
            // 
            // labelGreska
            // 
            this.labelGreska.Font = new System.Drawing.Font("Verdana", 12F);
            this.labelGreska.Location = new System.Drawing.Point(430, 213);
            this.labelGreska.Name = "labelGreska";
            this.labelGreska.Size = new System.Drawing.Size(410, 50);
            this.labelGreska.TabIndex = 32;
            this.labelGreska.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbProizvodac
            // 
            this.cmbProizvodac.Font = new System.Drawing.Font("Verdana", 12F);
            this.cmbProizvodac.FormattingEnabled = true;
            this.cmbProizvodac.Location = new System.Drawing.Point(625, 174);
            this.cmbProizvodac.Name = "cmbProizvodac";
            this.cmbProizvodac.Size = new System.Drawing.Size(188, 26);
            this.cmbProizvodac.TabIndex = 31;
            // 
            // cmbDobavljac
            // 
            this.cmbDobavljac.Font = new System.Drawing.Font("Verdana", 12F);
            this.cmbDobavljac.FormattingEnabled = true;
            this.cmbDobavljac.Items.AddRange(new object[] {
            "Phoenix Farmacija",
            "Pliva",
            "Auctor",
            "Belupo",
            "Medika",
            "Oktal Pharma"});
            this.cmbDobavljac.Location = new System.Drawing.Point(625, 73);
            this.cmbDobavljac.Name = "cmbDobavljac";
            this.cmbDobavljac.Size = new System.Drawing.Size(188, 26);
            this.cmbDobavljac.TabIndex = 30;
            // 
            // dtpDatumProizvodnje
            // 
            this.dtpDatumProizvodnje.Font = new System.Drawing.Font("Verdana", 12F);
            this.dtpDatumProizvodnje.Location = new System.Drawing.Point(625, 120);
            this.dtpDatumProizvodnje.Name = "dtpDatumProizvodnje";
            this.dtpDatumProizvodnje.Size = new System.Drawing.Size(234, 27);
            this.dtpDatumProizvodnje.TabIndex = 29;
            // 
            // dtpRokUporabe
            // 
            this.dtpRokUporabe.Font = new System.Drawing.Font("Verdana", 12F);
            this.dtpRokUporabe.Location = new System.Drawing.Point(625, 14);
            this.dtpRokUporabe.Name = "dtpRokUporabe";
            this.dtpRokUporabe.Size = new System.Drawing.Size(234, 27);
            this.dtpRokUporabe.TabIndex = 28;
            // 
            // nudCijena
            // 
            this.nudCijena.DecimalPlaces = 2;
            this.nudCijena.Font = new System.Drawing.Font("Verdana", 12F);
            this.nudCijena.Location = new System.Drawing.Point(145, 63);
            this.nudCijena.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            131072});
            this.nudCijena.Name = "nudCijena";
            this.nudCijena.Size = new System.Drawing.Size(234, 27);
            this.nudCijena.TabIndex = 37;
            this.nudCijena.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FormDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(899, 359);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.panelDodaj);
            this.Controls.Add(this.btnDodaj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDodaj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj lijek";
            this.Load += new System.EventHandler(this.FormDodaj_Load);
            this.panelDodaj.ResumeLayout(false);
            this.panelDodaj.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCijena)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelNaziv;
        private System.Windows.Forms.Label labelImeDobavljaca;
        private System.Windows.Forms.Label labelCijena;
        private System.Windows.Forms.Label labelStanjeZaliha;
        private System.Windows.Forms.Label labelRokUporabe;
        private System.Windows.Forms.Label labelOpis;
        private System.Windows.Forms.Label labelDatumProizvodnje;
        private System.Windows.Forms.Label labelProizvodac;
        private System.Windows.Forms.TextBox tboxNaziv;
        private System.Windows.Forms.TextBox tboxStanjeZaliha;
        private System.Windows.Forms.TextBox tboxOpis;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Panel panelDodaj;
        private System.Windows.Forms.DateTimePicker dtpDatumProizvodnje;
        private System.Windows.Forms.DateTimePicker dtpRokUporabe;
        private System.Windows.Forms.ComboBox cmbDobavljac;
        private System.Windows.Forms.ComboBox cmbProizvodac;
        private System.Windows.Forms.Label labelGreska;
        private System.Windows.Forms.NumericUpDown nudCijena;
    }
}