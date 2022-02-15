namespace Kladionica
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.pBoxGore = new System.Windows.Forms.PictureBox();
            this.pBoxIzlaz = new System.Windows.Forms.PictureBox();
            this.tBoxUsername = new System.Windows.Forms.TextBox();
            this.lblOtvoriKorisnika = new System.Windows.Forms.Label();
            this.btnOtvori = new System.Windows.Forms.Button();
            this.rBoxKorisnik = new System.Windows.Forms.RichTextBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.btnPocetna = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.tBoxPocetniNovac = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSacuvajPN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxGore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxIzlaz)).BeginInit();
            this.SuspendLayout();
            // 
            // pBoxGore
            // 
            this.pBoxGore.BackColor = System.Drawing.Color.Black;
            this.pBoxGore.Location = new System.Drawing.Point(15, 15);
            this.pBoxGore.Name = "pBoxGore";
            this.pBoxGore.Size = new System.Drawing.Size(570, 25);
            this.pBoxGore.TabIndex = 2;
            this.pBoxGore.TabStop = false;
            // 
            // pBoxIzlaz
            // 
            this.pBoxIzlaz.BackColor = System.Drawing.Color.Black;
            this.pBoxIzlaz.BackgroundImage = global::Kladionica.Properties.Resources.ApplicationClose;
            this.pBoxIzlaz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBoxIzlaz.Location = new System.Drawing.Point(561, 16);
            this.pBoxIzlaz.Name = "pBoxIzlaz";
            this.pBoxIzlaz.Size = new System.Drawing.Size(23, 23);
            this.pBoxIzlaz.TabIndex = 3;
            this.pBoxIzlaz.TabStop = false;
            this.pBoxIzlaz.Click += new System.EventHandler(this.pBoxIzlaz_Click);
            // 
            // tBoxUsername
            // 
            this.tBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxUsername.Location = new System.Drawing.Point(15, 94);
            this.tBoxUsername.MaxLength = 24;
            this.tBoxUsername.Name = "tBoxUsername";
            this.tBoxUsername.Size = new System.Drawing.Size(180, 22);
            this.tBoxUsername.TabIndex = 6;
            this.tBoxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblOtvoriKorisnika
            // 
            this.lblOtvoriKorisnika.BackColor = System.Drawing.Color.Transparent;
            this.lblOtvoriKorisnika.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblOtvoriKorisnika.Font = new System.Drawing.Font("Pristina", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtvoriKorisnika.Location = new System.Drawing.Point(15, 46);
            this.lblOtvoriKorisnika.Name = "lblOtvoriKorisnika";
            this.lblOtvoriKorisnika.Size = new System.Drawing.Size(180, 45);
            this.lblOtvoriKorisnika.TabIndex = 7;
            this.lblOtvoriKorisnika.Text = "Otvori korisnika";
            this.lblOtvoriKorisnika.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOtvori
            // 
            this.btnOtvori.BackColor = System.Drawing.Color.Black;
            this.btnOtvori.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOtvori.FlatAppearance.BorderSize = 0;
            this.btnOtvori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtvori.ForeColor = System.Drawing.Color.Transparent;
            this.btnOtvori.Location = new System.Drawing.Point(15, 122);
            this.btnOtvori.Name = "btnOtvori";
            this.btnOtvori.Size = new System.Drawing.Size(180, 25);
            this.btnOtvori.TabIndex = 9;
            this.btnOtvori.Text = "Otvori";
            this.btnOtvori.UseVisualStyleBackColor = false;
            this.btnOtvori.Click += new System.EventHandler(this.btnOtvori_Click);
            // 
            // rBoxKorisnik
            // 
            this.rBoxKorisnik.Location = new System.Drawing.Point(15, 153);
            this.rBoxKorisnik.Name = "rBoxKorisnik";
            this.rBoxKorisnik.Size = new System.Drawing.Size(180, 165);
            this.rBoxKorisnik.TabIndex = 10;
            this.rBoxKorisnik.Text = "";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.Color.Black;
            this.btnSacuvaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSacuvaj.FlatAppearance.BorderSize = 0;
            this.btnSacuvaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSacuvaj.ForeColor = System.Drawing.Color.Transparent;
            this.btnSacuvaj.Location = new System.Drawing.Point(15, 324);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(180, 25);
            this.btnSacuvaj.TabIndex = 11;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // lblNaslov
            // 
            this.lblNaslov.BackColor = System.Drawing.Color.Black;
            this.lblNaslov.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblNaslov.Font = new System.Drawing.Font("Pristina", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.ForeColor = System.Drawing.Color.Red;
            this.lblNaslov.Location = new System.Drawing.Point(15, 15);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(180, 25);
            this.lblNaslov.TabIndex = 12;
            this.lblNaslov.Text = "Discardo - Admin panel";
            this.lblNaslov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPocetna
            // 
            this.btnPocetna.BackColor = System.Drawing.Color.Black;
            this.btnPocetna.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPocetna.FlatAppearance.BorderSize = 0;
            this.btnPocetna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPocetna.ForeColor = System.Drawing.Color.Transparent;
            this.btnPocetna.Location = new System.Drawing.Point(410, 46);
            this.btnPocetna.Name = "btnPocetna";
            this.btnPocetna.Size = new System.Drawing.Size(174, 25);
            this.btnPocetna.TabIndex = 13;
            this.btnPocetna.Text = "Početna";
            this.btnPocetna.UseVisualStyleBackColor = false;
            this.btnPocetna.Click += new System.EventHandler(this.btnPocetna_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.White;
            this.lblInfo.ForeColor = System.Drawing.Color.Red;
            this.lblInfo.Location = new System.Drawing.Point(15, 378);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(570, 13);
            this.lblInfo.TabIndex = 18;
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tBoxPocetniNovac
            // 
            this.tBoxPocetniNovac.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBoxPocetniNovac.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxPocetniNovac.Location = new System.Drawing.Point(206, 94);
            this.tBoxPocetniNovac.MaxLength = 9;
            this.tBoxPocetniNovac.Name = "tBoxPocetniNovac";
            this.tBoxPocetniNovac.Size = new System.Drawing.Size(180, 22);
            this.tBoxPocetniNovac.TabIndex = 19;
            this.tBoxPocetniNovac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBoxPocetniNovac.TextChanged += new System.EventHandler(this.tBoxPocetniNovac_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Pristina", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 45);
            this.label1.TabIndex = 20;
            this.label1.Text = "Pocetni novac";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSacuvajPN
            // 
            this.btnSacuvajPN.BackColor = System.Drawing.Color.Black;
            this.btnSacuvajPN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSacuvajPN.FlatAppearance.BorderSize = 0;
            this.btnSacuvajPN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSacuvajPN.ForeColor = System.Drawing.Color.Transparent;
            this.btnSacuvajPN.Location = new System.Drawing.Point(206, 122);
            this.btnSacuvajPN.Name = "btnSacuvajPN";
            this.btnSacuvajPN.Size = new System.Drawing.Size(180, 25);
            this.btnSacuvajPN.TabIndex = 21;
            this.btnSacuvajPN.Text = "Sačuvaj";
            this.btnSacuvajPN.UseVisualStyleBackColor = false;
            this.btnSacuvajPN.Click += new System.EventHandler(this.btnSacuvajPN_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kladionica.Properties.Resources.Pozadina;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.btnSacuvajPN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBoxPocetniNovac);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnPocetna);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.rBoxKorisnik);
            this.Controls.Add(this.btnOtvori);
            this.Controls.Add(this.lblOtvoriKorisnika);
            this.Controls.Add(this.tBoxUsername);
            this.Controls.Add(this.pBoxIzlaz);
            this.Controls.Add(this.pBoxGore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discardo - Admin";
            ((System.ComponentModel.ISupportInitialize)(this.pBoxGore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxIzlaz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBoxGore;
        private System.Windows.Forms.PictureBox pBoxIzlaz;
        private System.Windows.Forms.TextBox tBoxUsername;
        private System.Windows.Forms.Label lblOtvoriKorisnika;
        private System.Windows.Forms.Button btnOtvori;
        private System.Windows.Forms.RichTextBox rBoxKorisnik;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Button btnPocetna;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox tBoxPocetniNovac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSacuvajPN;
    }
}