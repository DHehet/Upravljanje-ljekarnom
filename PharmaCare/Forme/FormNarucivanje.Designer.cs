namespace PharmaCare.Forme
{
    partial class FormNarucivanje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNarucivanje));
            this.tboxNaziv = new System.Windows.Forms.TextBox();
            this.labelNaziv = new System.Windows.Forms.Label();
            this.tboxImeDobavljaca = new System.Windows.Forms.TextBox();
            this.labelImeDobavljaca = new System.Windows.Forms.Label();
            this.tboxStanjeZaliha = new System.Windows.Forms.TextBox();
            this.labelStanjeZaliha = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnKontaktiraj = new System.Windows.Forms.Button();
            this.labelKolicinaNaruci = new System.Windows.Forms.Label();
            this.labelRazdjelnik = new System.Windows.Forms.Label();
            this.mtboxKolicinaNaruci = new System.Windows.Forms.MaskedTextBox();
            this.labelGreska = new System.Windows.Forms.Label();
            this.labelPomoc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tboxNaziv
            // 
            this.tboxNaziv.Enabled = false;
            this.tboxNaziv.Font = new System.Drawing.Font("Verdana", 12F);
            this.tboxNaziv.Location = new System.Drawing.Point(166, 21);
            this.tboxNaziv.Name = "tboxNaziv";
            this.tboxNaziv.Size = new System.Drawing.Size(234, 27);
            this.tboxNaziv.TabIndex = 22;
            // 
            // labelNaziv
            // 
            this.labelNaziv.AutoSize = true;
            this.labelNaziv.Font = new System.Drawing.Font("Verdana", 12F);
            this.labelNaziv.ForeColor = System.Drawing.Color.Black;
            this.labelNaziv.Location = new System.Drawing.Point(19, 24);
            this.labelNaziv.Name = "labelNaziv";
            this.labelNaziv.Size = new System.Drawing.Size(60, 18);
            this.labelNaziv.TabIndex = 21;
            this.labelNaziv.Text = "Naziv:";
            // 
            // tboxImeDobavljaca
            // 
            this.tboxImeDobavljaca.Enabled = false;
            this.tboxImeDobavljaca.Font = new System.Drawing.Font("Verdana", 12F);
            this.tboxImeDobavljaca.Location = new System.Drawing.Point(166, 71);
            this.tboxImeDobavljaca.Name = "tboxImeDobavljaca";
            this.tboxImeDobavljaca.Size = new System.Drawing.Size(234, 27);
            this.tboxImeDobavljaca.TabIndex = 24;
            // 
            // labelImeDobavljaca
            // 
            this.labelImeDobavljaca.AutoSize = true;
            this.labelImeDobavljaca.Font = new System.Drawing.Font("Verdana", 12F);
            this.labelImeDobavljaca.ForeColor = System.Drawing.Color.Black;
            this.labelImeDobavljaca.Location = new System.Drawing.Point(19, 74);
            this.labelImeDobavljaca.Name = "labelImeDobavljaca";
            this.labelImeDobavljaca.Size = new System.Drawing.Size(141, 18);
            this.labelImeDobavljaca.TabIndex = 23;
            this.labelImeDobavljaca.Text = "Ime dobavljača:";
            // 
            // tboxStanjeZaliha
            // 
            this.tboxStanjeZaliha.Enabled = false;
            this.tboxStanjeZaliha.Font = new System.Drawing.Font("Verdana", 12F);
            this.tboxStanjeZaliha.Location = new System.Drawing.Point(329, 125);
            this.tboxStanjeZaliha.Name = "tboxStanjeZaliha";
            this.tboxStanjeZaliha.Size = new System.Drawing.Size(71, 27);
            this.tboxStanjeZaliha.TabIndex = 26;
            this.tboxStanjeZaliha.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelStanjeZaliha
            // 
            this.labelStanjeZaliha.AutoSize = true;
            this.labelStanjeZaliha.Font = new System.Drawing.Font("Verdana", 12F);
            this.labelStanjeZaliha.ForeColor = System.Drawing.Color.Black;
            this.labelStanjeZaliha.Location = new System.Drawing.Point(19, 128);
            this.labelStanjeZaliha.Name = "labelStanjeZaliha";
            this.labelStanjeZaliha.Size = new System.Drawing.Size(123, 18);
            this.labelStanjeZaliha.TabIndex = 25;
            this.labelStanjeZaliha.Text = "Stanje zaliha:";
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnOdustani.FlatAppearance.BorderSize = 0;
            this.btnOdustani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdustani.Font = new System.Drawing.Font("Verdana", 12F);
            this.btnOdustani.Location = new System.Drawing.Point(280, 289);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(120, 30);
            this.btnOdustani.TabIndex = 36;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            this.btnOdustani.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.btnOdustani.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            // 
            // btnKontaktiraj
            // 
            this.btnKontaktiraj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(186)))), ((int)(((byte)(36)))));
            this.btnKontaktiraj.FlatAppearance.BorderSize = 0;
            this.btnKontaktiraj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKontaktiraj.Font = new System.Drawing.Font("Verdana", 12F);
            this.btnKontaktiraj.Location = new System.Drawing.Point(150, 289);
            this.btnKontaktiraj.Name = "btnKontaktiraj";
            this.btnKontaktiraj.Size = new System.Drawing.Size(120, 30);
            this.btnKontaktiraj.TabIndex = 35;
            this.btnKontaktiraj.Text = "Kontaktiraj";
            this.btnKontaktiraj.UseVisualStyleBackColor = false;
            this.btnKontaktiraj.Click += new System.EventHandler(this.btnKontaktiraj_Click);
            this.btnKontaktiraj.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.btnKontaktiraj.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            // 
            // labelKolicinaNaruci
            // 
            this.labelKolicinaNaruci.AutoSize = true;
            this.labelKolicinaNaruci.Font = new System.Drawing.Font("Verdana", 12F);
            this.labelKolicinaNaruci.ForeColor = System.Drawing.Color.Black;
            this.labelKolicinaNaruci.Location = new System.Drawing.Point(19, 188);
            this.labelKolicinaNaruci.Name = "labelKolicinaNaruci";
            this.labelKolicinaNaruci.Size = new System.Drawing.Size(102, 36);
            this.labelKolicinaNaruci.TabIndex = 37;
            this.labelKolicinaNaruci.Text = "Količina za \r\nnaručiti:";
            // 
            // labelRazdjelnik
            // 
            this.labelRazdjelnik.BackColor = System.Drawing.Color.Black;
            this.labelRazdjelnik.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelRazdjelnik.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRazdjelnik.ForeColor = System.Drawing.Color.White;
            this.labelRazdjelnik.Location = new System.Drawing.Point(20, 172);
            this.labelRazdjelnik.Name = "labelRazdjelnik";
            this.labelRazdjelnik.Size = new System.Drawing.Size(380, 2);
            this.labelRazdjelnik.TabIndex = 48;
            this.labelRazdjelnik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mtboxKolicinaNaruci
            // 
            this.mtboxKolicinaNaruci.Font = new System.Drawing.Font("Verdana", 12F);
            this.mtboxKolicinaNaruci.Location = new System.Drawing.Point(329, 188);
            this.mtboxKolicinaNaruci.Mask = "99";
            this.mtboxKolicinaNaruci.Name = "mtboxKolicinaNaruci";
            this.mtboxKolicinaNaruci.Size = new System.Drawing.Size(71, 27);
            this.mtboxKolicinaNaruci.TabIndex = 65;
            this.mtboxKolicinaNaruci.ValidatingType = typeof(int);
            this.mtboxKolicinaNaruci.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mtboxKolicinaNaruci_KeyUp);
            // 
            // labelGreska
            // 
            this.labelGreska.AutoSize = true;
            this.labelGreska.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGreska.ForeColor = System.Drawing.Color.Red;
            this.labelGreska.Location = new System.Drawing.Point(19, 245);
            this.labelGreska.Name = "labelGreska";
            this.labelGreska.Size = new System.Drawing.Size(0, 18);
            this.labelGreska.TabIndex = 66;
            this.labelGreska.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPomoc
            // 
            this.labelPomoc.AutoSize = true;
            this.labelPomoc.BackColor = System.Drawing.Color.LimeGreen;
            this.labelPomoc.Font = new System.Drawing.Font("Verdana", 9F);
            this.labelPomoc.Location = new System.Drawing.Point(0, 0);
            this.labelPomoc.Name = "labelPomoc";
            this.labelPomoc.Size = new System.Drawing.Size(76, 14);
            this.labelPomoc.TabIndex = 68;
            this.labelPomoc.Text = "F1 - Pomoć";
            // 
            // FormNarucivanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(425, 340);
            this.Controls.Add(this.labelPomoc);
            this.Controls.Add(this.labelGreska);
            this.Controls.Add(this.mtboxKolicinaNaruci);
            this.Controls.Add(this.labelRazdjelnik);
            this.Controls.Add(this.labelKolicinaNaruci);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnKontaktiraj);
            this.Controls.Add(this.tboxStanjeZaliha);
            this.Controls.Add(this.labelStanjeZaliha);
            this.Controls.Add(this.tboxImeDobavljaca);
            this.Controls.Add(this.labelImeDobavljaca);
            this.Controls.Add(this.tboxNaziv);
            this.Controls.Add(this.labelNaziv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormNarucivanje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Naruči lijek";
            this.Load += new System.EventHandler(this.FormNarucivanje_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormNarucivanje_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxNaziv;
        private System.Windows.Forms.Label labelNaziv;
        private System.Windows.Forms.TextBox tboxImeDobavljaca;
        private System.Windows.Forms.Label labelImeDobavljaca;
        private System.Windows.Forms.TextBox tboxStanjeZaliha;
        private System.Windows.Forms.Label labelStanjeZaliha;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnKontaktiraj;
        private System.Windows.Forms.Label labelKolicinaNaruci;
        private System.Windows.Forms.Label labelRazdjelnik;
        private System.Windows.Forms.MaskedTextBox mtboxKolicinaNaruci;
        private System.Windows.Forms.Label labelGreska;
        private System.Windows.Forms.Label labelPomoc;
    }
}