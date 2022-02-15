namespace Kladionica
{
    partial class Utakmice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Utakmice));
            this.pBoxGore = new System.Windows.Forms.PictureBox();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.pBoxIzlaz = new System.Windows.Forms.PictureBox();
            this.btnPocetna = new System.Windows.Forms.Button();
            this.lblUtakmiceDobitak = new System.Windows.Forms.Label();
            this.lblUtakmiceUlozeno = new System.Windows.Forms.Label();
            this.lblUtakmiceStanje = new System.Windows.Forms.Label();
            this.lblDobitak = new System.Windows.Forms.Label();
            this.lblU1T1 = new System.Windows.Forms.Label();
            this.lblU1T2 = new System.Windows.Forms.Label();
            this.lblU2T2 = new System.Windows.Forms.Label();
            this.lblU2T1 = new System.Windows.Forms.Label();
            this.lblU1R = new System.Windows.Forms.Label();
            this.lblU2R = new System.Windows.Forms.Label();
            this.rbU11 = new System.Windows.Forms.RadioButton();
            this.rbU1X = new System.Windows.Forms.RadioButton();
            this.rbU12 = new System.Windows.Forms.RadioButton();
            this.rbU21 = new System.Windows.Forms.RadioButton();
            this.rbU2X = new System.Windows.Forms.RadioButton();
            this.rbU22 = new System.Windows.Forms.RadioButton();
            this.tBoxUlog = new System.Windows.Forms.TextBox();
            this.btnKladjenje = new System.Windows.Forms.Button();
            this.pnlGrupa1 = new System.Windows.Forms.Panel();
            this.pnlGrupa2 = new System.Windows.Forms.Panel();
            this.lblU1K = new System.Windows.Forms.Label();
            this.lblU2K = new System.Windows.Forms.Label();
            this.TimerVracanje = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxGore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxIzlaz)).BeginInit();
            this.pnlGrupa1.SuspendLayout();
            this.pnlGrupa2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pBoxGore
            // 
            this.pBoxGore.BackColor = System.Drawing.Color.Black;
            this.pBoxGore.Location = new System.Drawing.Point(15, 15);
            this.pBoxGore.Name = "pBoxGore";
            this.pBoxGore.Size = new System.Drawing.Size(570, 25);
            this.pBoxGore.TabIndex = 3;
            this.pBoxGore.TabStop = false;
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
            this.lblNaslov.Text = "Discardo - Utakmice";
            this.lblNaslov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pBoxIzlaz
            // 
            this.pBoxIzlaz.BackColor = System.Drawing.Color.Black;
            this.pBoxIzlaz.BackgroundImage = global::Kladionica.Properties.Resources.ApplicationClose;
            this.pBoxIzlaz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBoxIzlaz.Location = new System.Drawing.Point(561, 16);
            this.pBoxIzlaz.Name = "pBoxIzlaz";
            this.pBoxIzlaz.Size = new System.Drawing.Size(23, 23);
            this.pBoxIzlaz.TabIndex = 14;
            this.pBoxIzlaz.TabStop = false;
            this.pBoxIzlaz.Click += new System.EventHandler(this.pBoxIzlaz_Click);
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
            this.btnPocetna.TabIndex = 15;
            this.btnPocetna.Text = "Početna";
            this.btnPocetna.UseVisualStyleBackColor = false;
            this.btnPocetna.Click += new System.EventHandler(this.btnPocetna_Click);
            // 
            // lblUtakmiceDobitak
            // 
            this.lblUtakmiceDobitak.Location = new System.Drawing.Point(15, 95);
            this.lblUtakmiceDobitak.Name = "lblUtakmiceDobitak";
            this.lblUtakmiceDobitak.Size = new System.Drawing.Size(212, 20);
            this.lblUtakmiceDobitak.TabIndex = 72;
            this.lblUtakmiceDobitak.Text = "Dobitak: ";
            this.lblUtakmiceDobitak.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUtakmiceUlozeno
            // 
            this.lblUtakmiceUlozeno.Location = new System.Drawing.Point(15, 70);
            this.lblUtakmiceUlozeno.Name = "lblUtakmiceUlozeno";
            this.lblUtakmiceUlozeno.Size = new System.Drawing.Size(212, 20);
            this.lblUtakmiceUlozeno.TabIndex = 71;
            this.lblUtakmiceUlozeno.Text = "Uloženo: ";
            this.lblUtakmiceUlozeno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUtakmiceStanje
            // 
            this.lblUtakmiceStanje.Location = new System.Drawing.Point(15, 45);
            this.lblUtakmiceStanje.Name = "lblUtakmiceStanje";
            this.lblUtakmiceStanje.Size = new System.Drawing.Size(212, 20);
            this.lblUtakmiceStanje.TabIndex = 70;
            this.lblUtakmiceStanje.Text = "Stanje na računu:";
            this.lblUtakmiceStanje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDobitak
            // 
            this.lblDobitak.BackColor = System.Drawing.Color.White;
            this.lblDobitak.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDobitak.Location = new System.Drawing.Point(299, 95);
            this.lblDobitak.Name = "lblDobitak";
            this.lblDobitak.Size = new System.Drawing.Size(285, 65);
            this.lblDobitak.TabIndex = 95;
            this.lblDobitak.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDobitak.Visible = false;
            // 
            // lblU1T1
            // 
            this.lblU1T1.Location = new System.Drawing.Point(15, 278);
            this.lblU1T1.Name = "lblU1T1";
            this.lblU1T1.Size = new System.Drawing.Size(150, 20);
            this.lblU1T1.TabIndex = 96;
            this.lblU1T1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblU1T2
            // 
            this.lblU1T2.Location = new System.Drawing.Point(206, 278);
            this.lblU1T2.Name = "lblU1T2";
            this.lblU1T2.Size = new System.Drawing.Size(150, 20);
            this.lblU1T2.TabIndex = 97;
            this.lblU1T2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblU2T2
            // 
            this.lblU2T2.Location = new System.Drawing.Point(206, 314);
            this.lblU2T2.Name = "lblU2T2";
            this.lblU2T2.Size = new System.Drawing.Size(150, 20);
            this.lblU2T2.TabIndex = 99;
            this.lblU2T2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblU2T1
            // 
            this.lblU2T1.Location = new System.Drawing.Point(15, 314);
            this.lblU2T1.Name = "lblU2T1";
            this.lblU2T1.Size = new System.Drawing.Size(150, 20);
            this.lblU2T1.TabIndex = 98;
            this.lblU2T1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblU1R
            // 
            this.lblU1R.Location = new System.Drawing.Point(175, 278);
            this.lblU1R.Name = "lblU1R";
            this.lblU1R.Size = new System.Drawing.Size(20, 20);
            this.lblU1R.TabIndex = 102;
            this.lblU1R.Text = "-";
            this.lblU1R.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblU2R
            // 
            this.lblU2R.Location = new System.Drawing.Point(175, 314);
            this.lblU2R.Name = "lblU2R";
            this.lblU2R.Size = new System.Drawing.Size(20, 20);
            this.lblU2R.TabIndex = 103;
            this.lblU2R.Text = "-";
            this.lblU2R.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbU11
            // 
            this.rbU11.AutoSize = true;
            this.rbU11.BackColor = System.Drawing.Color.Transparent;
            this.rbU11.Location = new System.Drawing.Point(0, 0);
            this.rbU11.Name = "rbU11";
            this.rbU11.Size = new System.Drawing.Size(31, 17);
            this.rbU11.TabIndex = 105;
            this.rbU11.TabStop = true;
            this.rbU11.Text = "1";
            this.rbU11.UseVisualStyleBackColor = false;
            // 
            // rbU1X
            // 
            this.rbU1X.AutoSize = true;
            this.rbU1X.BackColor = System.Drawing.Color.Transparent;
            this.rbU1X.Location = new System.Drawing.Point(40, 0);
            this.rbU1X.Name = "rbU1X";
            this.rbU1X.Size = new System.Drawing.Size(32, 17);
            this.rbU1X.TabIndex = 106;
            this.rbU1X.TabStop = true;
            this.rbU1X.Text = "X";
            this.rbU1X.UseVisualStyleBackColor = false;
            // 
            // rbU12
            // 
            this.rbU12.AutoSize = true;
            this.rbU12.BackColor = System.Drawing.Color.Transparent;
            this.rbU12.Location = new System.Drawing.Point(80, 0);
            this.rbU12.Name = "rbU12";
            this.rbU12.Size = new System.Drawing.Size(31, 17);
            this.rbU12.TabIndex = 107;
            this.rbU12.TabStop = true;
            this.rbU12.Text = "2";
            this.rbU12.UseVisualStyleBackColor = false;
            // 
            // rbU21
            // 
            this.rbU21.AutoSize = true;
            this.rbU21.BackColor = System.Drawing.Color.Transparent;
            this.rbU21.Location = new System.Drawing.Point(0, 0);
            this.rbU21.Name = "rbU21";
            this.rbU21.Size = new System.Drawing.Size(31, 17);
            this.rbU21.TabIndex = 108;
            this.rbU21.TabStop = true;
            this.rbU21.Text = "1";
            this.rbU21.UseVisualStyleBackColor = false;
            // 
            // rbU2X
            // 
            this.rbU2X.AutoSize = true;
            this.rbU2X.BackColor = System.Drawing.Color.Transparent;
            this.rbU2X.Location = new System.Drawing.Point(40, 0);
            this.rbU2X.Name = "rbU2X";
            this.rbU2X.Size = new System.Drawing.Size(32, 17);
            this.rbU2X.TabIndex = 109;
            this.rbU2X.TabStop = true;
            this.rbU2X.Text = "X";
            this.rbU2X.UseVisualStyleBackColor = false;
            // 
            // rbU22
            // 
            this.rbU22.AutoSize = true;
            this.rbU22.BackColor = System.Drawing.Color.Transparent;
            this.rbU22.Location = new System.Drawing.Point(80, 0);
            this.rbU22.Name = "rbU22";
            this.rbU22.Size = new System.Drawing.Size(31, 17);
            this.rbU22.TabIndex = 110;
            this.rbU22.TabStop = true;
            this.rbU22.Text = "2";
            this.rbU22.UseVisualStyleBackColor = false;
            // 
            // tBoxUlog
            // 
            this.tBoxUlog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBoxUlog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxUlog.Location = new System.Drawing.Point(15, 366);
            this.tBoxUlog.MaxLength = 9;
            this.tBoxUlog.Name = "tBoxUlog";
            this.tBoxUlog.Size = new System.Drawing.Size(129, 22);
            this.tBoxUlog.TabIndex = 111;
            this.tBoxUlog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBoxUlog.TextChanged += new System.EventHandler(this.tBoxUlog_TextChanged);
            // 
            // btnKladjenje
            // 
            this.btnKladjenje.BackColor = System.Drawing.Color.Black;
            this.btnKladjenje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKladjenje.FlatAppearance.BorderSize = 0;
            this.btnKladjenje.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKladjenje.ForeColor = System.Drawing.Color.Transparent;
            this.btnKladjenje.Location = new System.Drawing.Point(150, 366);
            this.btnKladjenje.Name = "btnKladjenje";
            this.btnKladjenje.Size = new System.Drawing.Size(133, 22);
            this.btnKladjenje.TabIndex = 112;
            this.btnKladjenje.Text = "Potvrdi";
            this.btnKladjenje.UseVisualStyleBackColor = false;
            this.btnKladjenje.Click += new System.EventHandler(this.btnKladjenje_Click);
            // 
            // pnlGrupa1
            // 
            this.pnlGrupa1.BackColor = System.Drawing.Color.Transparent;
            this.pnlGrupa1.Controls.Add(this.rbU11);
            this.pnlGrupa1.Controls.Add(this.rbU1X);
            this.pnlGrupa1.Controls.Add(this.rbU12);
            this.pnlGrupa1.Location = new System.Drawing.Point(360, 280);
            this.pnlGrupa1.Name = "pnlGrupa1";
            this.pnlGrupa1.Size = new System.Drawing.Size(111, 15);
            this.pnlGrupa1.TabIndex = 113;
            // 
            // pnlGrupa2
            // 
            this.pnlGrupa2.BackColor = System.Drawing.Color.Transparent;
            this.pnlGrupa2.Controls.Add(this.rbU21);
            this.pnlGrupa2.Controls.Add(this.rbU2X);
            this.pnlGrupa2.Controls.Add(this.rbU22);
            this.pnlGrupa2.Location = new System.Drawing.Point(360, 315);
            this.pnlGrupa2.Name = "pnlGrupa2";
            this.pnlGrupa2.Size = new System.Drawing.Size(111, 15);
            this.pnlGrupa2.TabIndex = 114;
            // 
            // lblU1K
            // 
            this.lblU1K.Location = new System.Drawing.Point(477, 278);
            this.lblU1K.Name = "lblU1K";
            this.lblU1K.Size = new System.Drawing.Size(46, 20);
            this.lblU1K.TabIndex = 115;
            this.lblU1K.Text = "-";
            this.lblU1K.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblU2K
            // 
            this.lblU2K.Location = new System.Drawing.Point(477, 312);
            this.lblU2K.Name = "lblU2K";
            this.lblU2K.Size = new System.Drawing.Size(46, 20);
            this.lblU2K.TabIndex = 116;
            this.lblU2K.Text = "-";
            this.lblU2K.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimerVracanje
            // 
            this.TimerVracanje.Interval = 5000;
            this.TimerVracanje.Tick += new System.EventHandler(this.TimerVracanje_Tick);
            // 
            // Utakmice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kladionica.Properties.Resources.Pozadina;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.lblU2K);
            this.Controls.Add(this.lblU1K);
            this.Controls.Add(this.pnlGrupa2);
            this.Controls.Add(this.pnlGrupa1);
            this.Controls.Add(this.btnKladjenje);
            this.Controls.Add(this.tBoxUlog);
            this.Controls.Add(this.lblU2R);
            this.Controls.Add(this.lblU1R);
            this.Controls.Add(this.lblU2T2);
            this.Controls.Add(this.lblU2T1);
            this.Controls.Add(this.lblU1T2);
            this.Controls.Add(this.lblU1T1);
            this.Controls.Add(this.lblDobitak);
            this.Controls.Add(this.lblUtakmiceDobitak);
            this.Controls.Add(this.lblUtakmiceUlozeno);
            this.Controls.Add(this.lblUtakmiceStanje);
            this.Controls.Add(this.btnPocetna);
            this.Controls.Add(this.pBoxIzlaz);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.pBoxGore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Utakmice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discardo - Utakmice";
            ((System.ComponentModel.ISupportInitialize)(this.pBoxGore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxIzlaz)).EndInit();
            this.pnlGrupa1.ResumeLayout(false);
            this.pnlGrupa1.PerformLayout();
            this.pnlGrupa2.ResumeLayout(false);
            this.pnlGrupa2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBoxGore;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.PictureBox pBoxIzlaz;
        private System.Windows.Forms.Button btnPocetna;
        private System.Windows.Forms.Label lblUtakmiceDobitak;
        private System.Windows.Forms.Label lblUtakmiceUlozeno;
        private System.Windows.Forms.Label lblUtakmiceStanje;
        private System.Windows.Forms.Label lblDobitak;
        private System.Windows.Forms.Label lblU1T1;
        private System.Windows.Forms.Label lblU1T2;
        private System.Windows.Forms.Label lblU2T2;
        private System.Windows.Forms.Label lblU2T1;
        private System.Windows.Forms.Label lblU1R;
        private System.Windows.Forms.Label lblU2R;
        private System.Windows.Forms.RadioButton rbU11;
        private System.Windows.Forms.RadioButton rbU1X;
        private System.Windows.Forms.RadioButton rbU12;
        private System.Windows.Forms.RadioButton rbU21;
        private System.Windows.Forms.RadioButton rbU2X;
        private System.Windows.Forms.RadioButton rbU22;
        private System.Windows.Forms.TextBox tBoxUlog;
        private System.Windows.Forms.Button btnKladjenje;
        private System.Windows.Forms.Panel pnlGrupa1;
        private System.Windows.Forms.Panel pnlGrupa2;
        private System.Windows.Forms.Label lblU1K;
        private System.Windows.Forms.Label lblU2K;
        private System.Windows.Forms.Timer TimerVracanje;
    }
}