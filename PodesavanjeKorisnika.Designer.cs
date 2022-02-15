namespace Kladionica
{
    partial class PodesavanjeKorisnika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PodesavanjeKorisnika));
            this.pBoxGore = new System.Windows.Forms.PictureBox();
            this.pBoxIzlaz = new System.Windows.Forms.PictureBox();
            this.lblDobrodoslica = new System.Windows.Forms.Label();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.tBoxUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.tBoxIme = new System.Windows.Forms.TextBox();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.tBoxPrezime = new System.Windows.Forms.TextBox();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.tBoxLozinka = new System.Windows.Forms.TextBox();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.tBoxPinKod = new System.Windows.Forms.TextBox();
            this.lblPinKod = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnPocetna = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxGore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxIzlaz)).BeginInit();
            this.SuspendLayout();
            // 
            // pBoxGore
            // 
            this.pBoxGore.BackColor = System.Drawing.Color.Black;
            this.pBoxGore.Location = new System.Drawing.Point(15, 15);
            this.pBoxGore.Name = "pBoxGore";
            this.pBoxGore.Size = new System.Drawing.Size(220, 25);
            this.pBoxGore.TabIndex = 2;
            this.pBoxGore.TabStop = false;
            // 
            // pBoxIzlaz
            // 
            this.pBoxIzlaz.BackColor = System.Drawing.Color.Black;
            this.pBoxIzlaz.BackgroundImage = global::Kladionica.Properties.Resources.ApplicationClose;
            this.pBoxIzlaz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBoxIzlaz.Location = new System.Drawing.Point(211, 16);
            this.pBoxIzlaz.Name = "pBoxIzlaz";
            this.pBoxIzlaz.Size = new System.Drawing.Size(23, 23);
            this.pBoxIzlaz.TabIndex = 3;
            this.pBoxIzlaz.TabStop = false;
            this.pBoxIzlaz.Click += new System.EventHandler(this.pBoxIzlaz_Click);
            // 
            // lblDobrodoslica
            // 
            this.lblDobrodoslica.BackColor = System.Drawing.Color.Transparent;
            this.lblDobrodoslica.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDobrodoslica.Font = new System.Drawing.Font("Pristina", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDobrodoslica.Location = new System.Drawing.Point(15, 43);
            this.lblDobrodoslica.Name = "lblDobrodoslica";
            this.lblDobrodoslica.Size = new System.Drawing.Size(220, 45);
            this.lblDobrodoslica.TabIndex = 4;
            this.lblDobrodoslica.Text = "Podesavanje";
            this.lblDobrodoslica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lblNaslov.TabIndex = 13;
            this.lblNaslov.Text = "Discardo - Profil";
            this.lblNaslov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tBoxUsername
            // 
            this.tBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxUsername.Location = new System.Drawing.Point(15, 116);
            this.tBoxUsername.MaxLength = 24;
            this.tBoxUsername.Name = "tBoxUsername";
            this.tBoxUsername.ReadOnly = true;
            this.tBoxUsername.Size = new System.Drawing.Size(220, 22);
            this.tBoxUsername.TabIndex = 14;
            this.tBoxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblUsername
            // 
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblUsername.Font = new System.Drawing.Font("Pristina", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(15, 88);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(220, 25);
            this.lblUsername.TabIndex = 15;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIme
            // 
            this.lblIme.BackColor = System.Drawing.Color.Transparent;
            this.lblIme.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblIme.Font = new System.Drawing.Font("Pristina", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIme.Location = new System.Drawing.Point(15, 141);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(220, 25);
            this.lblIme.TabIndex = 16;
            this.lblIme.Text = "Ime";
            this.lblIme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tBoxIme
            // 
            this.tBoxIme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBoxIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxIme.Location = new System.Drawing.Point(15, 169);
            this.tBoxIme.MaxLength = 24;
            this.tBoxIme.Name = "tBoxIme";
            this.tBoxIme.ReadOnly = true;
            this.tBoxIme.Size = new System.Drawing.Size(220, 22);
            this.tBoxIme.TabIndex = 17;
            this.tBoxIme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPrezime
            // 
            this.lblPrezime.BackColor = System.Drawing.Color.Transparent;
            this.lblPrezime.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPrezime.Font = new System.Drawing.Font("Pristina", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrezime.Location = new System.Drawing.Point(15, 194);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(220, 25);
            this.lblPrezime.TabIndex = 18;
            this.lblPrezime.Text = "Prezime";
            this.lblPrezime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tBoxPrezime
            // 
            this.tBoxPrezime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBoxPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxPrezime.Location = new System.Drawing.Point(15, 222);
            this.tBoxPrezime.MaxLength = 24;
            this.tBoxPrezime.Name = "tBoxPrezime";
            this.tBoxPrezime.ReadOnly = true;
            this.tBoxPrezime.Size = new System.Drawing.Size(220, 22);
            this.tBoxPrezime.TabIndex = 19;
            this.tBoxPrezime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLozinka
            // 
            this.lblLozinka.BackColor = System.Drawing.Color.Transparent;
            this.lblLozinka.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblLozinka.Font = new System.Drawing.Font("Pristina", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLozinka.Location = new System.Drawing.Point(15, 247);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(220, 25);
            this.lblLozinka.TabIndex = 20;
            this.lblLozinka.Text = "Lozinka";
            this.lblLozinka.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tBoxLozinka
            // 
            this.tBoxLozinka.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBoxLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxLozinka.Location = new System.Drawing.Point(15, 275);
            this.tBoxLozinka.MaxLength = 24;
            this.tBoxLozinka.Name = "tBoxLozinka";
            this.tBoxLozinka.Size = new System.Drawing.Size(220, 22);
            this.tBoxLozinka.TabIndex = 21;
            this.tBoxLozinka.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.BackColor = System.Drawing.Color.Black;
            this.btnPotvrdi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPotvrdi.FlatAppearance.BorderSize = 0;
            this.btnPotvrdi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPotvrdi.ForeColor = System.Drawing.Color.Transparent;
            this.btnPotvrdi.Location = new System.Drawing.Point(15, 375);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(220, 25);
            this.btnPotvrdi.TabIndex = 22;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = false;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // tBoxPinKod
            // 
            this.tBoxPinKod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBoxPinKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxPinKod.Location = new System.Drawing.Point(15, 347);
            this.tBoxPinKod.MaxLength = 4;
            this.tBoxPinKod.Name = "tBoxPinKod";
            this.tBoxPinKod.Size = new System.Drawing.Size(220, 22);
            this.tBoxPinKod.TabIndex = 23;
            this.tBoxPinKod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPinKod
            // 
            this.lblPinKod.BackColor = System.Drawing.Color.Transparent;
            this.lblPinKod.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPinKod.Font = new System.Drawing.Font("Pristina", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPinKod.Location = new System.Drawing.Point(15, 319);
            this.lblPinKod.Name = "lblPinKod";
            this.lblPinKod.Size = new System.Drawing.Size(220, 25);
            this.lblPinKod.TabIndex = 24;
            this.lblPinKod.Text = "Potvrdite PinKodom!";
            this.lblPinKod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.White;
            this.lblInfo.ForeColor = System.Drawing.Color.Red;
            this.lblInfo.Location = new System.Drawing.Point(15, 431);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(220, 13);
            this.lblInfo.TabIndex = 25;
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInfo.Visible = false;
            // 
            // btnPocetna
            // 
            this.btnPocetna.BackColor = System.Drawing.Color.Black;
            this.btnPocetna.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPocetna.FlatAppearance.BorderSize = 0;
            this.btnPocetna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPocetna.ForeColor = System.Drawing.Color.Transparent;
            this.btnPocetna.Location = new System.Drawing.Point(15, 403);
            this.btnPocetna.Name = "btnPocetna";
            this.btnPocetna.Size = new System.Drawing.Size(220, 25);
            this.btnPocetna.TabIndex = 26;
            this.btnPocetna.Text = "Početna";
            this.btnPocetna.UseVisualStyleBackColor = false;
            this.btnPocetna.Click += new System.EventHandler(this.btnPocetna_Click);
            // 
            // PodesavanjeKorisnika
            // 
            this.AcceptButton = this.btnPotvrdi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kladionica.Properties.Resources.Pozadina250x450;
            this.ClientSize = new System.Drawing.Size(250, 450);
            this.Controls.Add(this.btnPocetna);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblPinKod);
            this.Controls.Add(this.tBoxPinKod);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.tBoxLozinka);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.tBoxPrezime);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.tBoxIme);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.tBoxUsername);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.lblDobrodoslica);
            this.Controls.Add(this.pBoxIzlaz);
            this.Controls.Add(this.pBoxGore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PodesavanjeKorisnika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discardo - Profil";
            ((System.ComponentModel.ISupportInitialize)(this.pBoxGore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxIzlaz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBoxGore;
        private System.Windows.Forms.PictureBox pBoxIzlaz;
        private System.Windows.Forms.Label lblDobrodoslica;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.TextBox tBoxUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox tBoxIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.TextBox tBoxPrezime;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.TextBox tBoxLozinka;
        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.TextBox tBoxPinKod;
        private System.Windows.Forms.Label lblPinKod;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnPocetna;
    }
}