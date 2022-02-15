namespace Kladionica
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pBoxGore = new System.Windows.Forms.PictureBox();
            this.pBoxIzlaz = new System.Windows.Forms.PictureBox();
            this.lblDobrodoslica = new System.Windows.Forms.Label();
            this.tBoxUsername = new System.Windows.Forms.TextBox();
            this.tBoxPassword = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnRegistracija = new System.Windows.Forms.Button();
            this.btnZaboravljenaLozinka = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.tBoxPinKod = new System.Windows.Forms.TextBox();
            this.TimerGasenja = new System.Windows.Forms.Timer(this.components);
            this.lblNaslov = new System.Windows.Forms.Label();
            this.btnPrijava = new System.Windows.Forms.Button();
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
            this.pBoxGore.TabIndex = 0;
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
            this.pBoxIzlaz.TabIndex = 1;
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
            this.lblDobrodoslica.Size = new System.Drawing.Size(569, 45);
            this.lblDobrodoslica.TabIndex = 2;
            this.lblDobrodoslica.Text = "Dobrodošli u kladionicu Discardo";
            this.lblDobrodoslica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tBoxUsername
            // 
            this.tBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxUsername.Location = new System.Drawing.Point(209, 178);
            this.tBoxUsername.MaxLength = 24;
            this.tBoxUsername.Name = "tBoxUsername";
            this.tBoxUsername.Size = new System.Drawing.Size(180, 22);
            this.tBoxUsername.TabIndex = 4;
            this.tBoxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBoxPassword
            // 
            this.tBoxPassword.BackColor = System.Drawing.SystemColors.Window;
            this.tBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxPassword.Location = new System.Drawing.Point(209, 249);
            this.tBoxPassword.MaxLength = 24;
            this.tBoxPassword.Name = "tBoxPassword";
            this.tBoxPassword.PasswordChar = '*';
            this.tBoxPassword.Size = new System.Drawing.Size(180, 22);
            this.tBoxPassword.TabIndex = 5;
            this.tBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblUsername
            // 
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblUsername.Font = new System.Drawing.Font("Pristina", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(15, 132);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(569, 45);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPassword
            // 
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPassword.Font = new System.Drawing.Font("Pristina", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(15, 203);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(569, 45);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRegistracija
            // 
            this.btnRegistracija.BackColor = System.Drawing.Color.Black;
            this.btnRegistracija.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistracija.FlatAppearance.BorderSize = 0;
            this.btnRegistracija.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistracija.ForeColor = System.Drawing.Color.Transparent;
            this.btnRegistracija.Location = new System.Drawing.Point(306, 277);
            this.btnRegistracija.Name = "btnRegistracija";
            this.btnRegistracija.Size = new System.Drawing.Size(83, 25);
            this.btnRegistracija.TabIndex = 9;
            this.btnRegistracija.Text = "Registracija";
            this.btnRegistracija.UseVisualStyleBackColor = false;
            this.btnRegistracija.Click += new System.EventHandler(this.btnRegistracija_Click);
            // 
            // btnZaboravljenaLozinka
            // 
            this.btnZaboravljenaLozinka.BackColor = System.Drawing.Color.Red;
            this.btnZaboravljenaLozinka.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZaboravljenaLozinka.FlatAppearance.BorderSize = 0;
            this.btnZaboravljenaLozinka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZaboravljenaLozinka.ForeColor = System.Drawing.Color.Transparent;
            this.btnZaboravljenaLozinka.Location = new System.Drawing.Point(209, 308);
            this.btnZaboravljenaLozinka.Name = "btnZaboravljenaLozinka";
            this.btnZaboravljenaLozinka.Size = new System.Drawing.Size(180, 25);
            this.btnZaboravljenaLozinka.TabIndex = 10;
            this.btnZaboravljenaLozinka.Text = "Zaboravljena lozinka?";
            this.btnZaboravljenaLozinka.UseVisualStyleBackColor = false;
            this.btnZaboravljenaLozinka.Click += new System.EventHandler(this.btnZaboravljenaLozinka_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.White;
            this.lblInfo.ForeColor = System.Drawing.Color.Red;
            this.lblInfo.Location = new System.Drawing.Point(112, 378);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(376, 13);
            this.lblInfo.TabIndex = 18;
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInfo.Visible = false;
            // 
            // tBoxPinKod
            // 
            this.tBoxPinKod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBoxPinKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxPinKod.Location = new System.Drawing.Point(209, 353);
            this.tBoxPinKod.MaxLength = 4;
            this.tBoxPinKod.Name = "tBoxPinKod";
            this.tBoxPinKod.PasswordChar = '*';
            this.tBoxPinKod.Size = new System.Drawing.Size(180, 22);
            this.tBoxPinKod.TabIndex = 19;
            this.tBoxPinKod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBoxPinKod.Visible = false;
            this.tBoxPinKod.TextChanged += new System.EventHandler(this.tBoxPinKod_TextChanged);
            // 
            // TimerGasenja
            // 
            this.TimerGasenja.Interval = 10000;
            this.TimerGasenja.Tick += new System.EventHandler(this.TimerGasenja_Tick);
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
            this.lblNaslov.TabIndex = 20;
            this.lblNaslov.Text = "Discardo";
            this.lblNaslov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPrijava
            // 
            this.btnPrijava.BackColor = System.Drawing.Color.Black;
            this.btnPrijava.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrijava.FlatAppearance.BorderSize = 0;
            this.btnPrijava.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrijava.ForeColor = System.Drawing.Color.Transparent;
            this.btnPrijava.Location = new System.Drawing.Point(209, 277);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(83, 25);
            this.btnPrijava.TabIndex = 21;
            this.btnPrijava.Text = "Prijava";
            this.btnPrijava.UseVisualStyleBackColor = false;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click_1);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnPrijava;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kladionica.Properties.Resources.Pozadina;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.btnPrijava);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.tBoxPinKod);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnZaboravljenaLozinka);
            this.Controls.Add(this.btnRegistracija);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.tBoxPassword);
            this.Controls.Add(this.tBoxUsername);
            this.Controls.Add(this.lblDobrodoslica);
            this.Controls.Add(this.pBoxIzlaz);
            this.Controls.Add(this.pBoxGore);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discardo";
            ((System.ComponentModel.ISupportInitialize)(this.pBoxGore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxIzlaz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBoxGore;
        private System.Windows.Forms.PictureBox pBoxIzlaz;
        private System.Windows.Forms.Label lblDobrodoslica;
        private System.Windows.Forms.TextBox tBoxUsername;
        private System.Windows.Forms.TextBox tBoxPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnRegistracija;
        private System.Windows.Forms.Button btnZaboravljenaLozinka;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox tBoxPinKod;
        private System.Windows.Forms.Timer TimerGasenja;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Button btnPrijava;

    }
}

