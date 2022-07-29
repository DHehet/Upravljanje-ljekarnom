namespace PharmaCare.Forme
{
    partial class FormRacuni
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRacuni));
            this.dgvRacuni = new System.Windows.Forms.DataGridView();
            this.labelRacuni = new System.Windows.Forms.Label();
            this.btnStorniraj = new System.Windows.Forms.Button();
            this.tboxNazivKlijenta = new System.Windows.Forms.TextBox();
            this.labelNazivKlijenta = new System.Windows.Forms.Label();
            this.tboxNazivKorisnika = new System.Windows.Forms.TextBox();
            this.labelNazivKorisnika = new System.Windows.Forms.Label();
            this.tboxUkupniIznos = new System.Windows.Forms.TextBox();
            this.labelUkupniIznos = new System.Windows.Forms.Label();
            this.tboxDatumVrijemeIzdavanja = new System.Windows.Forms.TextBox();
            this.labelDatumVrijemeIzdavanja = new System.Windows.Forms.Label();
            this.btnIsprintaj = new System.Windows.Forms.Button();
            this.dgvStorniraniRacuni = new System.Windows.Forms.DataGridView();
            this.labelStorniran = new System.Windows.Forms.Label();
            this.labelPomoc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacuni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorniraniRacuni)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRacuni
            // 
            this.dgvRacuni.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRacuni.BackgroundColor = System.Drawing.Color.White;
            this.dgvRacuni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRacuni.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRacuni.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRacuni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRacuni.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRacuni.Location = new System.Drawing.Point(40, 202);
            this.dgvRacuni.Name = "dgvRacuni";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRacuni.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRacuni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRacuni.Size = new System.Drawing.Size(854, 110);
            this.dgvRacuni.TabIndex = 29;
            this.dgvRacuni.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRacuni_CellEnter);
            // 
            // labelRacuni
            // 
            this.labelRacuni.AutoSize = true;
            this.labelRacuni.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRacuni.Location = new System.Drawing.Point(378, 15);
            this.labelRacuni.Name = "labelRacuni";
            this.labelRacuni.Size = new System.Drawing.Size(208, 23);
            this.labelRacuni.TabIndex = 30;
            this.labelRacuni.Text = "Popis izdanih računa";
            // 
            // btnStorniraj
            // 
            this.btnStorniraj.BackColor = System.Drawing.Color.Firebrick;
            this.btnStorniraj.FlatAppearance.BorderSize = 0;
            this.btnStorniraj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStorniraj.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStorniraj.ForeColor = System.Drawing.Color.White;
            this.btnStorniraj.Location = new System.Drawing.Point(774, 455);
            this.btnStorniraj.Name = "btnStorniraj";
            this.btnStorniraj.Size = new System.Drawing.Size(120, 30);
            this.btnStorniraj.TabIndex = 52;
            this.btnStorniraj.Text = "Storniraj";
            this.btnStorniraj.UseVisualStyleBackColor = false;
            this.btnStorniraj.Click += new System.EventHandler(this.btnStorniraj_Click);
            this.btnStorniraj.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.btnStorniraj.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            // 
            // tboxNazivKlijenta
            // 
            this.tboxNazivKlijenta.Enabled = false;
            this.tboxNazivKlijenta.Font = new System.Drawing.Font("Verdana", 12F);
            this.tboxNazivKlijenta.Location = new System.Drawing.Point(193, 64);
            this.tboxNazivKlijenta.Name = "tboxNazivKlijenta";
            this.tboxNazivKlijenta.Size = new System.Drawing.Size(219, 27);
            this.tboxNazivKlijenta.TabIndex = 54;
            // 
            // labelNazivKlijenta
            // 
            this.labelNazivKlijenta.AutoSize = true;
            this.labelNazivKlijenta.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNazivKlijenta.Location = new System.Drawing.Point(39, 67);
            this.labelNazivKlijenta.Name = "labelNazivKlijenta";
            this.labelNazivKlijenta.Size = new System.Drawing.Size(128, 18);
            this.labelNazivKlijenta.TabIndex = 53;
            this.labelNazivKlijenta.Text = "Naziv klijenta:";
            // 
            // tboxNazivKorisnika
            // 
            this.tboxNazivKorisnika.Enabled = false;
            this.tboxNazivKorisnika.Font = new System.Drawing.Font("Verdana", 12F);
            this.tboxNazivKorisnika.Location = new System.Drawing.Point(762, 67);
            this.tboxNazivKorisnika.Name = "tboxNazivKorisnika";
            this.tboxNazivKorisnika.Size = new System.Drawing.Size(134, 27);
            this.tboxNazivKorisnika.TabIndex = 56;
            // 
            // labelNazivKorisnika
            // 
            this.labelNazivKorisnika.AutoSize = true;
            this.labelNazivKorisnika.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNazivKorisnika.Location = new System.Drawing.Point(617, 70);
            this.labelNazivKorisnika.Name = "labelNazivKorisnika";
            this.labelNazivKorisnika.Size = new System.Drawing.Size(139, 18);
            this.labelNazivKorisnika.TabIndex = 55;
            this.labelNazivKorisnika.Text = "Naziv korisnika:";
            // 
            // tboxUkupniIznos
            // 
            this.tboxUkupniIznos.Enabled = false;
            this.tboxUkupniIznos.Font = new System.Drawing.Font("Verdana", 12F);
            this.tboxUkupniIznos.Location = new System.Drawing.Point(762, 109);
            this.tboxUkupniIznos.Name = "tboxUkupniIznos";
            this.tboxUkupniIznos.Size = new System.Drawing.Size(134, 27);
            this.tboxUkupniIznos.TabIndex = 58;
            this.tboxUkupniIznos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelUkupniIznos
            // 
            this.labelUkupniIznos.AutoSize = true;
            this.labelUkupniIznos.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUkupniIznos.Location = new System.Drawing.Point(617, 112);
            this.labelUkupniIznos.Name = "labelUkupniIznos";
            this.labelUkupniIznos.Size = new System.Drawing.Size(120, 18);
            this.labelUkupniIznos.TabIndex = 57;
            this.labelUkupniIznos.Text = "Ukupni iznos:";
            // 
            // tboxDatumVrijemeIzdavanja
            // 
            this.tboxDatumVrijemeIzdavanja.Enabled = false;
            this.tboxDatumVrijemeIzdavanja.Font = new System.Drawing.Font("Verdana", 12F);
            this.tboxDatumVrijemeIzdavanja.Location = new System.Drawing.Point(193, 115);
            this.tboxDatumVrijemeIzdavanja.Name = "tboxDatumVrijemeIzdavanja";
            this.tboxDatumVrijemeIzdavanja.Size = new System.Drawing.Size(219, 27);
            this.tboxDatumVrijemeIzdavanja.TabIndex = 60;
            // 
            // labelDatumVrijemeIzdavanja
            // 
            this.labelDatumVrijemeIzdavanja.AutoSize = true;
            this.labelDatumVrijemeIzdavanja.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDatumVrijemeIzdavanja.Location = new System.Drawing.Point(40, 118);
            this.labelDatumVrijemeIzdavanja.Name = "labelDatumVrijemeIzdavanja";
            this.labelDatumVrijemeIzdavanja.Size = new System.Drawing.Size(147, 18);
            this.labelDatumVrijemeIzdavanja.TabIndex = 59;
            this.labelDatumVrijemeIzdavanja.Text = "Datum i vrijeme:";
            // 
            // btnIsprintaj
            // 
            this.btnIsprintaj.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnIsprintaj.FlatAppearance.BorderSize = 0;
            this.btnIsprintaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIsprintaj.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIsprintaj.ForeColor = System.Drawing.Color.Black;
            this.btnIsprintaj.Location = new System.Drawing.Point(635, 455);
            this.btnIsprintaj.Name = "btnIsprintaj";
            this.btnIsprintaj.Size = new System.Drawing.Size(120, 30);
            this.btnIsprintaj.TabIndex = 61;
            this.btnIsprintaj.Text = "Isprintaj";
            this.btnIsprintaj.UseVisualStyleBackColor = false;
            this.btnIsprintaj.Click += new System.EventHandler(this.btnIsprintaj_Click);
            this.btnIsprintaj.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.btnIsprintaj.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            // 
            // dgvStorniraniRacuni
            // 
            this.dgvStorniraniRacuni.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvStorniraniRacuni.BackgroundColor = System.Drawing.Color.White;
            this.dgvStorniraniRacuni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStorniraniRacuni.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStorniraniRacuni.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStorniraniRacuni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStorniraniRacuni.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvStorniraniRacuni.Location = new System.Drawing.Point(40, 330);
            this.dgvStorniraniRacuni.Name = "dgvStorniraniRacuni";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStorniraniRacuni.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvStorniraniRacuni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStorniraniRacuni.Size = new System.Drawing.Size(854, 110);
            this.dgvStorniraniRacuni.TabIndex = 62;
            this.dgvStorniraniRacuni.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStorniraniRacuni_CellEnter);
            // 
            // labelStorniran
            // 
            this.labelStorniran.AutoSize = true;
            this.labelStorniran.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelStorniran.ForeColor = System.Drawing.Color.Red;
            this.labelStorniran.Location = new System.Drawing.Point(717, 165);
            this.labelStorniran.Name = "labelStorniran";
            this.labelStorniran.Size = new System.Drawing.Size(0, 18);
            this.labelStorniran.TabIndex = 64;
            this.labelStorniran.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPomoc
            // 
            this.labelPomoc.AutoSize = true;
            this.labelPomoc.BackColor = System.Drawing.Color.LimeGreen;
            this.labelPomoc.Font = new System.Drawing.Font("Verdana", 9F);
            this.labelPomoc.Location = new System.Drawing.Point(11, 0);
            this.labelPomoc.Name = "labelPomoc";
            this.labelPomoc.Size = new System.Drawing.Size(76, 14);
            this.labelPomoc.TabIndex = 69;
            this.labelPomoc.Text = "F1 - Pomoć";
            // 
            // FormRacuni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.labelPomoc);
            this.Controls.Add(this.labelStorniran);
            this.Controls.Add(this.dgvStorniraniRacuni);
            this.Controls.Add(this.btnIsprintaj);
            this.Controls.Add(this.tboxDatumVrijemeIzdavanja);
            this.Controls.Add(this.labelDatumVrijemeIzdavanja);
            this.Controls.Add(this.tboxUkupniIznos);
            this.Controls.Add(this.labelUkupniIznos);
            this.Controls.Add(this.tboxNazivKorisnika);
            this.Controls.Add(this.labelNazivKorisnika);
            this.Controls.Add(this.tboxNazivKlijenta);
            this.Controls.Add(this.labelNazivKlijenta);
            this.Controls.Add(this.btnStorniraj);
            this.Controls.Add(this.labelRacuni);
            this.Controls.Add(this.dgvRacuni);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormRacuni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Popis računa";
            this.Load += new System.EventHandler(this.FormRacuni_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormRacuni_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacuni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorniraniRacuni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRacuni;
        private System.Windows.Forms.Label labelRacuni;
        private System.Windows.Forms.Button btnStorniraj;
        private System.Windows.Forms.TextBox tboxNazivKlijenta;
        private System.Windows.Forms.Label labelNazivKlijenta;
        private System.Windows.Forms.TextBox tboxNazivKorisnika;
        private System.Windows.Forms.Label labelNazivKorisnika;
        private System.Windows.Forms.TextBox tboxUkupniIznos;
        private System.Windows.Forms.Label labelUkupniIznos;
        private System.Windows.Forms.TextBox tboxDatumVrijemeIzdavanja;
        private System.Windows.Forms.Label labelDatumVrijemeIzdavanja;
        private System.Windows.Forms.Button btnIsprintaj;
        private System.Windows.Forms.DataGridView dgvStorniraniRacuni;
        private System.Windows.Forms.Label labelStorniran;
        private System.Windows.Forms.Label labelPomoc;
    }
}