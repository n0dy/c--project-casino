namespace Kladionica
{
    partial class Pocetna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pocetna));
            this.pBoxGore = new System.Windows.Forms.PictureBox();
            this.pBoxIzlaz = new System.Windows.Forms.PictureBox();
            this.lblDobrodoslica = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.btnUtakmice = new System.Windows.Forms.Button();
            this.btnRulet = new System.Windows.Forms.Button();
            this.btnSlot = new System.Windows.Forms.Button();
            this.btnPsi = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnPodesavanja = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.lblInfo2 = new System.Windows.Forms.Label();
            this.TimerGasenja = new System.Windows.Forms.Timer(this.components);
            this.lblNaslov = new System.Windows.Forms.Label();
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
            this.pBoxGore.TabIndex = 1;
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
            this.pBoxIzlaz.TabIndex = 2;
            this.pBoxIzlaz.TabStop = false;
            this.pBoxIzlaz.Click += new System.EventHandler(this.pBoxIzlaz_Click);
            // 
            // lblDobrodoslica
            // 
            this.lblDobrodoslica.BackColor = System.Drawing.Color.Transparent;
            this.lblDobrodoslica.Font = new System.Drawing.Font("Pristina", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDobrodoslica.Location = new System.Drawing.Point(16, 43);
            this.lblDobrodoslica.Name = "lblDobrodoslica";
            this.lblDobrodoslica.Size = new System.Drawing.Size(569, 45);
            this.lblDobrodoslica.TabIndex = 3;
            this.lblDobrodoslica.Text = "Dobrodošli u kladionicu Discardo";
            this.lblDobrodoslica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.White;
            this.lblInfo.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(125, 88);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(350, 64);
            this.lblInfo.TabIndex = 4;
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOdjava
            // 
            this.btnOdjava.BackColor = System.Drawing.Color.Black;
            this.btnOdjava.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOdjava.FlatAppearance.BorderSize = 0;
            this.btnOdjava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdjava.ForeColor = System.Drawing.Color.Transparent;
            this.btnOdjava.Location = new System.Drawing.Point(259, 360);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(83, 25);
            this.btnOdjava.TabIndex = 10;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = false;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // btnUtakmice
            // 
            this.btnUtakmice.BackColor = System.Drawing.Color.Black;
            this.btnUtakmice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUtakmice.FlatAppearance.BorderSize = 0;
            this.btnUtakmice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUtakmice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUtakmice.ForeColor = System.Drawing.Color.Transparent;
            this.btnUtakmice.Location = new System.Drawing.Point(125, 187);
            this.btnUtakmice.Name = "btnUtakmice";
            this.btnUtakmice.Size = new System.Drawing.Size(170, 40);
            this.btnUtakmice.TabIndex = 11;
            this.btnUtakmice.Text = "Utakmice";
            this.btnUtakmice.UseVisualStyleBackColor = false;
            this.btnUtakmice.Click += new System.EventHandler(this.btnUtakmice_Click);
            // 
            // btnRulet
            // 
            this.btnRulet.BackColor = System.Drawing.Color.Black;
            this.btnRulet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRulet.FlatAppearance.BorderSize = 0;
            this.btnRulet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRulet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRulet.ForeColor = System.Drawing.Color.Transparent;
            this.btnRulet.Location = new System.Drawing.Point(305, 187);
            this.btnRulet.Name = "btnRulet";
            this.btnRulet.Size = new System.Drawing.Size(170, 40);
            this.btnRulet.TabIndex = 12;
            this.btnRulet.Text = "Rulet";
            this.btnRulet.UseVisualStyleBackColor = false;
            this.btnRulet.Click += new System.EventHandler(this.btnRulet_Click);
            // 
            // btnSlot
            // 
            this.btnSlot.BackColor = System.Drawing.Color.Black;
            this.btnSlot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSlot.FlatAppearance.BorderSize = 0;
            this.btnSlot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSlot.ForeColor = System.Drawing.Color.Transparent;
            this.btnSlot.Location = new System.Drawing.Point(125, 233);
            this.btnSlot.Name = "btnSlot";
            this.btnSlot.Size = new System.Drawing.Size(170, 40);
            this.btnSlot.TabIndex = 13;
            this.btnSlot.Text = "Slot";
            this.btnSlot.UseVisualStyleBackColor = false;
            this.btnSlot.Click += new System.EventHandler(this.btnSlot_Click);
            // 
            // btnPsi
            // 
            this.btnPsi.BackColor = System.Drawing.Color.Black;
            this.btnPsi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPsi.FlatAppearance.BorderSize = 0;
            this.btnPsi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPsi.ForeColor = System.Drawing.Color.Transparent;
            this.btnPsi.Location = new System.Drawing.Point(305, 233);
            this.btnPsi.Name = "btnPsi";
            this.btnPsi.Size = new System.Drawing.Size(170, 40);
            this.btnPsi.TabIndex = 14;
            this.btnPsi.Text = "Psi";
            this.btnPsi.UseVisualStyleBackColor = false;
            this.btnPsi.Click += new System.EventHandler(this.btnPsi_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.Black;
            this.btnInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.ForeColor = System.Drawing.Color.Transparent;
            this.btnInfo.Location = new System.Drawing.Point(170, 360);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(83, 25);
            this.btnInfo.TabIndex = 15;
            this.btnInfo.Text = "Info";
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnPodesavanja
            // 
            this.btnPodesavanja.BackColor = System.Drawing.Color.Black;
            this.btnPodesavanja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPodesavanja.FlatAppearance.BorderSize = 0;
            this.btnPodesavanja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPodesavanja.ForeColor = System.Drawing.Color.Transparent;
            this.btnPodesavanja.Location = new System.Drawing.Point(348, 360);
            this.btnPodesavanja.Name = "btnPodesavanja";
            this.btnPodesavanja.Size = new System.Drawing.Size(83, 25);
            this.btnPodesavanja.TabIndex = 16;
            this.btnPodesavanja.Text = "Podesavanja";
            this.btnPodesavanja.UseVisualStyleBackColor = false;
            this.btnPodesavanja.Click += new System.EventHandler(this.btnPodesavanja_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.Black;
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.ForeColor = System.Drawing.Color.Transparent;
            this.btnAdmin.Location = new System.Drawing.Point(501, 360);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(83, 25);
            this.btnAdmin.TabIndex = 17;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Visible = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // lblInfo2
            // 
            this.lblInfo2.BackColor = System.Drawing.Color.White;
            this.lblInfo2.ForeColor = System.Drawing.Color.Red;
            this.lblInfo2.Location = new System.Drawing.Point(125, 298);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(350, 13);
            this.lblInfo2.TabIndex = 18;
            this.lblInfo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInfo2.Visible = false;
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
            this.lblNaslov.TabIndex = 21;
            this.lblNaslov.Text = "Discardo";
            this.lblNaslov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kladionica.Properties.Resources.Pozadina;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.lblInfo2);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnPodesavanja);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnPsi);
            this.Controls.Add(this.btnSlot);
            this.Controls.Add(this.btnRulet);
            this.Controls.Add(this.btnUtakmice);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblDobrodoslica);
            this.Controls.Add(this.pBoxIzlaz);
            this.Controls.Add(this.pBoxGore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pocetna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discardo";
            ((System.ComponentModel.ISupportInitialize)(this.pBoxGore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxIzlaz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pBoxGore;
        private System.Windows.Forms.PictureBox pBoxIzlaz;
        private System.Windows.Forms.Label lblDobrodoslica;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Button btnUtakmice;
        private System.Windows.Forms.Button btnRulet;
        private System.Windows.Forms.Button btnSlot;
        private System.Windows.Forms.Button btnPsi;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnPodesavanja;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Label lblInfo2;
        private System.Windows.Forms.Timer TimerGasenja;
        private System.Windows.Forms.Label lblNaslov;
    }
}