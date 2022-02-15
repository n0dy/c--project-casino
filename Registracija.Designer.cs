namespace Kladionica
{
    partial class Registracija
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registracija));
            this.pBoxGore = new System.Windows.Forms.PictureBox();
            this.pBoxIzlaz = new System.Windows.Forms.PictureBox();
            this.lblDobrodoslica = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tBoxUsernameR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tBoxImeR = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tBoxPrezimeR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBoxPasswordR = new System.Windows.Forms.TextBox();
            this.btnRegistracija = new System.Windows.Forms.Button();
            this.btnPocetna = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.TimerGasenja = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxGore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxIzlaz)).BeginInit();
            this.SuspendLayout();
            // 
            // pBoxGore
            // 
            this.pBoxGore.BackColor = System.Drawing.Color.Black;
            this.pBoxGore.Location = new System.Drawing.Point(15, 15);
            this.pBoxGore.Name = "pBoxGore";
            this.pBoxGore.Size = new System.Drawing.Size(370, 25);
            this.pBoxGore.TabIndex = 2;
            this.pBoxGore.TabStop = false;
            // 
            // pBoxIzlaz
            // 
            this.pBoxIzlaz.BackColor = System.Drawing.Color.Black;
            this.pBoxIzlaz.BackgroundImage = global::Kladionica.Properties.Resources.ApplicationClose;
            this.pBoxIzlaz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBoxIzlaz.Location = new System.Drawing.Point(361, 16);
            this.pBoxIzlaz.Name = "pBoxIzlaz";
            this.pBoxIzlaz.Size = new System.Drawing.Size(23, 23);
            this.pBoxIzlaz.TabIndex = 3;
            this.pBoxIzlaz.TabStop = false;
            this.pBoxIzlaz.Click += new System.EventHandler(this.pBoxIzlaz_Click);
            // 
            // lblDobrodoslica
            // 
            this.lblDobrodoslica.BackColor = System.Drawing.Color.Transparent;
            this.lblDobrodoslica.Font = new System.Drawing.Font("Pristina", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDobrodoslica.Location = new System.Drawing.Point(15, 41);
            this.lblDobrodoslica.Name = "lblDobrodoslica";
            this.lblDobrodoslica.Size = new System.Drawing.Size(369, 45);
            this.lblDobrodoslica.TabIndex = 4;
            this.lblDobrodoslica.Text = "Registracija";
            this.lblDobrodoslica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Pristina", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(15, 92);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(369, 33);
            this.lblUsername.TabIndex = 7;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tBoxUsernameR
            // 
            this.tBoxUsernameR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBoxUsernameR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxUsernameR.Location = new System.Drawing.Point(110, 128);
            this.tBoxUsernameR.MaxLength = 24;
            this.tBoxUsernameR.Name = "tBoxUsernameR";
            this.tBoxUsernameR.Size = new System.Drawing.Size(180, 22);
            this.tBoxUsernameR.TabIndex = 8;
            this.tBoxUsernameR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Pristina", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ime";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tBoxImeR
            // 
            this.tBoxImeR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBoxImeR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxImeR.Location = new System.Drawing.Point(110, 186);
            this.tBoxImeR.MaxLength = 24;
            this.tBoxImeR.Name = "tBoxImeR";
            this.tBoxImeR.Size = new System.Drawing.Size(180, 22);
            this.tBoxImeR.TabIndex = 10;
            this.tBoxImeR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Pristina", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(369, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Prezime";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tBoxPrezimeR
            // 
            this.tBoxPrezimeR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBoxPrezimeR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxPrezimeR.Location = new System.Drawing.Point(110, 243);
            this.tBoxPrezimeR.MaxLength = 24;
            this.tBoxPrezimeR.Name = "tBoxPrezimeR";
            this.tBoxPrezimeR.Size = new System.Drawing.Size(180, 22);
            this.tBoxPrezimeR.TabIndex = 12;
            this.tBoxPrezimeR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Pristina", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(369, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tBoxPasswordR
            // 
            this.tBoxPasswordR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBoxPasswordR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxPasswordR.Location = new System.Drawing.Point(110, 300);
            this.tBoxPasswordR.MaxLength = 24;
            this.tBoxPasswordR.Name = "tBoxPasswordR";
            this.tBoxPasswordR.PasswordChar = '*';
            this.tBoxPasswordR.Size = new System.Drawing.Size(180, 22);
            this.tBoxPasswordR.TabIndex = 14;
            this.tBoxPasswordR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnRegistracija
            // 
            this.btnRegistracija.BackColor = System.Drawing.Color.Black;
            this.btnRegistracija.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistracija.FlatAppearance.BorderSize = 0;
            this.btnRegistracija.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistracija.ForeColor = System.Drawing.Color.White;
            this.btnRegistracija.Location = new System.Drawing.Point(110, 328);
            this.btnRegistracija.Name = "btnRegistracija";
            this.btnRegistracija.Size = new System.Drawing.Size(180, 25);
            this.btnRegistracija.TabIndex = 15;
            this.btnRegistracija.Text = "Registracija";
            this.btnRegistracija.UseVisualStyleBackColor = false;
            this.btnRegistracija.Click += new System.EventHandler(this.btnRegistracija_Click);
            // 
            // btnPocetna
            // 
            this.btnPocetna.BackColor = System.Drawing.Color.Black;
            this.btnPocetna.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPocetna.FlatAppearance.BorderSize = 0;
            this.btnPocetna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPocetna.ForeColor = System.Drawing.Color.White;
            this.btnPocetna.Location = new System.Drawing.Point(110, 356);
            this.btnPocetna.Name = "btnPocetna";
            this.btnPocetna.Size = new System.Drawing.Size(180, 25);
            this.btnPocetna.TabIndex = 16;
            this.btnPocetna.Text = "Pocetna";
            this.btnPocetna.UseVisualStyleBackColor = false;
            this.btnPocetna.Click += new System.EventHandler(this.btnPocetna_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.White;
            this.lblInfo.ForeColor = System.Drawing.Color.Red;
            this.lblInfo.Location = new System.Drawing.Point(12, 384);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(376, 13);
            this.lblInfo.TabIndex = 17;
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInfo.Visible = false;
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
            this.lblNaslov.TabIndex = 18;
            this.lblNaslov.Text = "Discardo - Registracija";
            this.lblNaslov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimerGasenja
            // 
            this.TimerGasenja.Interval = 10000;
            this.TimerGasenja.Tick += new System.EventHandler(this.TimerGasenja_Tick);
            // 
            // Registracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kladionica.Properties.Resources.Pozadina400x400;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnPocetna);
            this.Controls.Add(this.btnRegistracija);
            this.Controls.Add(this.tBoxPasswordR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tBoxPrezimeR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBoxImeR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBoxUsernameR);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblDobrodoslica);
            this.Controls.Add(this.pBoxIzlaz);
            this.Controls.Add(this.pBoxGore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registracija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discardo - Registracija";
            ((System.ComponentModel.ISupportInitialize)(this.pBoxGore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxIzlaz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBoxGore;
        private System.Windows.Forms.PictureBox pBoxIzlaz;
        private System.Windows.Forms.Label lblDobrodoslica;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox tBoxUsernameR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxImeR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBoxPrezimeR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBoxPasswordR;
        private System.Windows.Forms.Button btnRegistracija;
        private System.Windows.Forms.Button btnPocetna;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Timer TimerGasenja;
    }
}