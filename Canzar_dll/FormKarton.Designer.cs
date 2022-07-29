namespace Canzar_dll
{
    partial class FormKarton
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKarton));
            this.labelIme = new System.Windows.Forms.Label();
            this.labelPrezime = new System.Windows.Forms.Label();
            this.labelMobilniBroj = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelStarost = new System.Windows.Forms.Label();
            this.labelBodovi = new System.Windows.Forms.Label();
            this.panelKarton = new System.Windows.Forms.Panel();
            this.mtboxMobilniBroj = new System.Windows.Forms.MaskedTextBox();
            this.chboxClan = new System.Windows.Forms.CheckBox();
            this.tboxBodovi = new System.Windows.Forms.TextBox();
            this.tboxEmail = new System.Windows.Forms.TextBox();
            this.tboxStarost = new System.Windows.Forms.TextBox();
            this.tboxPrezime = new System.Windows.Forms.TextBox();
            this.tboxIme = new System.Windows.Forms.TextBox();
            this.labelClan = new System.Windows.Forms.Label();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.labelPomoc = new System.Windows.Forms.Label();
            this.panelKarton.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelIme
            // 
            this.labelIme.AutoSize = true;
            this.labelIme.Font = new System.Drawing.Font("Verdana", 12F);
            this.labelIme.ForeColor = System.Drawing.Color.Black;
            this.labelIme.Location = new System.Drawing.Point(16, 62);
            this.labelIme.Name = "labelIme";
            this.labelIme.Size = new System.Drawing.Size(47, 18);
            this.labelIme.TabIndex = 10;
            this.labelIme.Text = "Ime:";
            // 
            // labelPrezime
            // 
            this.labelPrezime.AutoSize = true;
            this.labelPrezime.Font = new System.Drawing.Font("Verdana", 12F);
            this.labelPrezime.ForeColor = System.Drawing.Color.Black;
            this.labelPrezime.Location = new System.Drawing.Point(16, 114);
            this.labelPrezime.Name = "labelPrezime";
            this.labelPrezime.Size = new System.Drawing.Size(80, 18);
            this.labelPrezime.TabIndex = 11;
            this.labelPrezime.Text = "Prezime:";
            // 
            // labelMobilniBroj
            // 
            this.labelMobilniBroj.AutoSize = true;
            this.labelMobilniBroj.Font = new System.Drawing.Font("Verdana", 12F);
            this.labelMobilniBroj.ForeColor = System.Drawing.Color.Black;
            this.labelMobilniBroj.Location = new System.Drawing.Point(16, 217);
            this.labelMobilniBroj.Name = "labelMobilniBroj";
            this.labelMobilniBroj.Size = new System.Drawing.Size(111, 18);
            this.labelMobilniBroj.TabIndex = 12;
            this.labelMobilniBroj.Text = "Mobilni broj:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Verdana", 12F);
            this.labelEmail.ForeColor = System.Drawing.Color.Black;
            this.labelEmail.Location = new System.Drawing.Point(16, 268);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(60, 18);
            this.labelEmail.TabIndex = 13;
            this.labelEmail.Text = "Email:";
            // 
            // labelStarost
            // 
            this.labelStarost.AutoSize = true;
            this.labelStarost.Font = new System.Drawing.Font("Verdana", 12F);
            this.labelStarost.ForeColor = System.Drawing.Color.Black;
            this.labelStarost.Location = new System.Drawing.Point(16, 166);
            this.labelStarost.Name = "labelStarost";
            this.labelStarost.Size = new System.Drawing.Size(74, 18);
            this.labelStarost.TabIndex = 14;
            this.labelStarost.Text = "Starost:";
            // 
            // labelBodovi
            // 
            this.labelBodovi.AutoSize = true;
            this.labelBodovi.Font = new System.Drawing.Font("Verdana", 12F);
            this.labelBodovi.ForeColor = System.Drawing.Color.Black;
            this.labelBodovi.Location = new System.Drawing.Point(296, 14);
            this.labelBodovi.Name = "labelBodovi";
            this.labelBodovi.Size = new System.Drawing.Size(70, 18);
            this.labelBodovi.TabIndex = 16;
            this.labelBodovi.Text = "Bodovi:";
            // 
            // panelKarton
            // 
            this.panelKarton.BackColor = System.Drawing.Color.White;
            this.panelKarton.Controls.Add(this.mtboxMobilniBroj);
            this.panelKarton.Controls.Add(this.chboxClan);
            this.panelKarton.Controls.Add(this.tboxBodovi);
            this.panelKarton.Controls.Add(this.tboxEmail);
            this.panelKarton.Controls.Add(this.tboxStarost);
            this.panelKarton.Controls.Add(this.tboxPrezime);
            this.panelKarton.Controls.Add(this.tboxIme);
            this.panelKarton.Controls.Add(this.labelStarost);
            this.panelKarton.Controls.Add(this.labelBodovi);
            this.panelKarton.Controls.Add(this.labelClan);
            this.panelKarton.Controls.Add(this.labelEmail);
            this.panelKarton.Controls.Add(this.labelMobilniBroj);
            this.panelKarton.Controls.Add(this.labelPrezime);
            this.panelKarton.Controls.Add(this.labelIme);
            this.panelKarton.Location = new System.Drawing.Point(12, 12);
            this.panelKarton.Name = "panelKarton";
            this.panelKarton.Size = new System.Drawing.Size(560, 316);
            this.panelKarton.TabIndex = 18;
            // 
            // mtboxMobilniBroj
            // 
            this.mtboxMobilniBroj.Enabled = false;
            this.mtboxMobilniBroj.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.mtboxMobilniBroj.Location = new System.Drawing.Point(133, 214);
            this.mtboxMobilniBroj.Name = "mtboxMobilniBroj";
            this.mtboxMobilniBroj.Size = new System.Drawing.Size(400, 27);
            this.mtboxMobilniBroj.TabIndex = 26;
            this.mtboxMobilniBroj.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chboxClan
            // 
            this.chboxClan.AutoCheck = false;
            this.chboxClan.Enabled = false;
            this.chboxClan.Font = new System.Drawing.Font("Verdana", 12F);
            this.chboxClan.ForeColor = System.Drawing.Color.Black;
            this.chboxClan.Location = new System.Drawing.Point(203, 11);
            this.chboxClan.Name = "chboxClan";
            this.chboxClan.Size = new System.Drawing.Size(20, 20);
            this.chboxClan.TabIndex = 25;
            this.chboxClan.UseVisualStyleBackColor = true;
            // 
            // tboxBodovi
            // 
            this.tboxBodovi.Enabled = false;
            this.tboxBodovi.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.tboxBodovi.Location = new System.Drawing.Point(387, 11);
            this.tboxBodovi.Name = "tboxBodovi";
            this.tboxBodovi.Size = new System.Drawing.Size(146, 27);
            this.tboxBodovi.TabIndex = 23;
            this.tboxBodovi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tboxEmail
            // 
            this.tboxEmail.Enabled = false;
            this.tboxEmail.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.tboxEmail.Location = new System.Drawing.Point(133, 265);
            this.tboxEmail.Name = "tboxEmail";
            this.tboxEmail.Size = new System.Drawing.Size(400, 27);
            this.tboxEmail.TabIndex = 22;
            // 
            // tboxStarost
            // 
            this.tboxStarost.Enabled = false;
            this.tboxStarost.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.tboxStarost.Location = new System.Drawing.Point(133, 163);
            this.tboxStarost.Name = "tboxStarost";
            this.tboxStarost.Size = new System.Drawing.Size(400, 27);
            this.tboxStarost.TabIndex = 21;
            this.tboxStarost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tboxPrezime
            // 
            this.tboxPrezime.Enabled = false;
            this.tboxPrezime.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.tboxPrezime.Location = new System.Drawing.Point(133, 111);
            this.tboxPrezime.Name = "tboxPrezime";
            this.tboxPrezime.Size = new System.Drawing.Size(400, 27);
            this.tboxPrezime.TabIndex = 19;
            // 
            // tboxIme
            // 
            this.tboxIme.Enabled = false;
            this.tboxIme.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.tboxIme.Location = new System.Drawing.Point(133, 59);
            this.tboxIme.Name = "tboxIme";
            this.tboxIme.Size = new System.Drawing.Size(400, 27);
            this.tboxIme.TabIndex = 18;
            // 
            // labelClan
            // 
            this.labelClan.AutoSize = true;
            this.labelClan.Font = new System.Drawing.Font("Verdana", 12F);
            this.labelClan.ForeColor = System.Drawing.Color.Black;
            this.labelClan.Location = new System.Drawing.Point(16, 11);
            this.labelClan.Name = "labelClan";
            this.labelClan.Size = new System.Drawing.Size(181, 18);
            this.labelClan.TabIndex = 15;
            this.labelClan.Text = "Član kluba vjernosti?";
            // 
            // btnZatvori
            // 
            this.btnZatvori.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnZatvori.FlatAppearance.BorderSize = 0;
            this.btnZatvori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZatvori.Font = new System.Drawing.Font("Verdana", 12F);
            this.btnZatvori.Location = new System.Drawing.Point(451, 343);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(120, 30);
            this.btnZatvori.TabIndex = 20;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = false;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            this.btnZatvori.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.btnZatvori.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            // 
            // labelPomoc
            // 
            this.labelPomoc.AutoSize = true;
            this.labelPomoc.BackColor = System.Drawing.Color.LimeGreen;
            this.labelPomoc.Font = new System.Drawing.Font("Verdana", 9F);
            this.labelPomoc.Location = new System.Drawing.Point(0, 0);
            this.labelPomoc.Name = "labelPomoc";
            this.labelPomoc.Size = new System.Drawing.Size(76, 14);
            this.labelPomoc.TabIndex = 70;
            this.labelPomoc.Text = "F1 - Pomoć";
            // 
            // FormKarton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 391);
            this.Controls.Add(this.labelPomoc);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.panelKarton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormKarton";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zdravstveni karton ";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormKarton_KeyDown);
            this.panelKarton.ResumeLayout(false);
            this.panelKarton.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelIme;
        private System.Windows.Forms.Label labelPrezime;
        private System.Windows.Forms.Label labelMobilniBroj;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelStarost;
        private System.Windows.Forms.Label labelBodovi;
        private System.Windows.Forms.Panel panelKarton;
        private System.Windows.Forms.TextBox tboxBodovi;
        private System.Windows.Forms.TextBox tboxEmail;
        private System.Windows.Forms.TextBox tboxStarost;
        private System.Windows.Forms.TextBox tboxPrezime;
        private System.Windows.Forms.TextBox tboxIme;
        private System.Windows.Forms.MaskedTextBox mtboxMobilniBroj;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.CheckBox chboxClan;
        private System.Windows.Forms.Label labelClan;
        private System.Windows.Forms.Label labelPomoc;
    }
}