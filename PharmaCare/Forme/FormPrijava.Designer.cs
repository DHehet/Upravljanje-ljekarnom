namespace PharmaCare
{
    partial class FormPrijava
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrijava));
            this.labelLogo = new System.Windows.Forms.Label();
            this.btnPrijaviObicnog = new System.Windows.Forms.Button();
            this.btnPrijaviAdmina = new System.Windows.Forms.Button();
            this.pBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelOdjava = new System.Windows.Forms.Label();
            this.labelPomoc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLogo.Location = new System.Drawing.Point(250, 50);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(200, 32);
            this.labelLogo.TabIndex = 2;
            this.labelLogo.Text = "PharmaCare";
            // 
            // btnPrijaviObicnog
            // 
            this.btnPrijaviObicnog.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPrijaviObicnog.FlatAppearance.BorderSize = 0;
            this.btnPrijaviObicnog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrijaviObicnog.Font = new System.Drawing.Font("Verdana", 12F);
            this.btnPrijaviObicnog.ForeColor = System.Drawing.Color.Black;
            this.btnPrijaviObicnog.Location = new System.Drawing.Point(158, 135);
            this.btnPrijaviObicnog.Name = "btnPrijaviObicnog";
            this.btnPrijaviObicnog.Size = new System.Drawing.Size(309, 50);
            this.btnPrijaviObicnog.TabIndex = 11;
            this.btnPrijaviObicnog.Text = "Obični korisnik:\r\ndhehet | lozinka123\r\n\r\n";
            this.btnPrijaviObicnog.UseVisualStyleBackColor = false;
            this.btnPrijaviObicnog.Click += new System.EventHandler(this.btnPrijaviObicnog_Click);
            this.btnPrijaviObicnog.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.btnPrijaviObicnog.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            // 
            // btnPrijaviAdmina
            // 
            this.btnPrijaviAdmina.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPrijaviAdmina.FlatAppearance.BorderSize = 0;
            this.btnPrijaviAdmina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrijaviAdmina.Font = new System.Drawing.Font("Verdana", 12F);
            this.btnPrijaviAdmina.ForeColor = System.Drawing.Color.Black;
            this.btnPrijaviAdmina.Location = new System.Drawing.Point(158, 210);
            this.btnPrijaviAdmina.Name = "btnPrijaviAdmina";
            this.btnPrijaviAdmina.Size = new System.Drawing.Size(309, 50);
            this.btnPrijaviAdmina.TabIndex = 12;
            this.btnPrijaviAdmina.Text = "Administrator:\r\nlcanzar | pass123\r\n";
            this.btnPrijaviAdmina.UseVisualStyleBackColor = false;
            this.btnPrijaviAdmina.Click += new System.EventHandler(this.btnPrijaviAdmina_Click);
            this.btnPrijaviAdmina.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.btnPrijaviAdmina.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            // 
            // pBoxLogo
            // 
            this.pBoxLogo.Image = global::PharmaCare.Properties.Resources.PharmaCareLogo;
            this.pBoxLogo.ImageLocation = "";
            this.pBoxLogo.Location = new System.Drawing.Point(175, 26);
            this.pBoxLogo.Name = "pBoxLogo";
            this.pBoxLogo.Size = new System.Drawing.Size(75, 75);
            this.pBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxLogo.TabIndex = 3;
            this.pBoxLogo.TabStop = false;
            // 
            // labelOdjava
            // 
            this.labelOdjava.AutoSize = true;
            this.labelOdjava.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOdjava.ForeColor = System.Drawing.Color.Green;
            this.labelOdjava.Location = new System.Drawing.Point(468, 9);
            this.labelOdjava.Name = "labelOdjava";
            this.labelOdjava.Size = new System.Drawing.Size(0, 18);
            this.labelOdjava.TabIndex = 13;
            this.labelOdjava.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPomoc
            // 
            this.labelPomoc.AutoSize = true;
            this.labelPomoc.BackColor = System.Drawing.Color.LimeGreen;
            this.labelPomoc.Font = new System.Drawing.Font("Verdana", 9F);
            this.labelPomoc.Location = new System.Drawing.Point(12, 9);
            this.labelPomoc.Name = "labelPomoc";
            this.labelPomoc.Size = new System.Drawing.Size(76, 14);
            this.labelPomoc.TabIndex = 60;
            this.labelPomoc.Text = "F1 - Pomoć";
            // 
            // FormPrijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(624, 321);
            this.Controls.Add(this.labelPomoc);
            this.Controls.Add(this.labelOdjava);
            this.Controls.Add(this.btnPrijaviAdmina);
            this.Controls.Add(this.btnPrijaviObicnog);
            this.Controls.Add(this.pBoxLogo);
            this.Controls.Add(this.labelLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormPrijava";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijavi se";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPrijava_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBoxLogo;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.Button btnPrijaviObicnog;
        private System.Windows.Forms.Button btnPrijaviAdmina;
        private System.Windows.Forms.Label labelOdjava;
        private System.Windows.Forms.Label labelPomoc;
    }
}