namespace Kladionica
{
    partial class Slot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Slot));
            this.pBoxGore = new System.Windows.Forms.PictureBox();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.pBoxIzlaz = new System.Windows.Forms.PictureBox();
            this.lblSlotStanje = new System.Windows.Forms.Label();
            this.btnPocetna = new System.Windows.Forms.Button();
            this.tBoxUlog = new System.Windows.Forms.TextBox();
            this.lblSlotUlozeno = new System.Windows.Forms.Label();
            this.lblSlotDobitak = new System.Windows.Forms.Label();
            this.btnSpin = new System.Windows.Forms.Button();
            this.pBox1 = new System.Windows.Forms.PictureBox();
            this.pBox2 = new System.Windows.Forms.PictureBox();
            this.pBox3 = new System.Windows.Forms.PictureBox();
            this.TimerSlot = new System.Windows.Forms.Timer(this.components);
            this.TimerSlotUkupan = new System.Windows.Forms.Timer(this.components);
            this.lblDobitak = new System.Windows.Forms.Label();
            this.TimerVracanje = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxGore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxIzlaz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox3)).BeginInit();
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
            this.lblNaslov.Text = "Discardo - Slot";
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
            this.pBoxIzlaz.TabIndex = 22;
            this.pBoxIzlaz.TabStop = false;
            this.pBoxIzlaz.Click += new System.EventHandler(this.pBoxIzlaz_Click);
            // 
            // lblSlotStanje
            // 
            this.lblSlotStanje.Location = new System.Drawing.Point(15, 45);
            this.lblSlotStanje.Name = "lblSlotStanje";
            this.lblSlotStanje.Size = new System.Drawing.Size(212, 20);
            this.lblSlotStanje.TabIndex = 54;
            this.lblSlotStanje.Text = "Stanje na računu:";
            this.lblSlotStanje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPocetna
            // 
            this.btnPocetna.BackColor = System.Drawing.Color.Black;
            this.btnPocetna.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPocetna.FlatAppearance.BorderSize = 0;
            this.btnPocetna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPocetna.ForeColor = System.Drawing.Color.Transparent;
            this.btnPocetna.Location = new System.Drawing.Point(386, 45);
            this.btnPocetna.Name = "btnPocetna";
            this.btnPocetna.Size = new System.Drawing.Size(199, 25);
            this.btnPocetna.TabIndex = 65;
            this.btnPocetna.Text = "Početna";
            this.btnPocetna.UseVisualStyleBackColor = false;
            this.btnPocetna.Click += new System.EventHandler(this.btnPocetna_Click);
            // 
            // tBoxUlog
            // 
            this.tBoxUlog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBoxUlog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxUlog.Location = new System.Drawing.Point(158, 346);
            this.tBoxUlog.MaxLength = 9;
            this.tBoxUlog.Name = "tBoxUlog";
            this.tBoxUlog.Size = new System.Drawing.Size(129, 22);
            this.tBoxUlog.TabIndex = 66;
            this.tBoxUlog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBoxUlog.TextChanged += new System.EventHandler(this.tBoxUlog_TextChanged);
            // 
            // lblSlotUlozeno
            // 
            this.lblSlotUlozeno.Location = new System.Drawing.Point(15, 70);
            this.lblSlotUlozeno.Name = "lblSlotUlozeno";
            this.lblSlotUlozeno.Size = new System.Drawing.Size(212, 20);
            this.lblSlotUlozeno.TabIndex = 67;
            this.lblSlotUlozeno.Text = "Uloženo: ";
            this.lblSlotUlozeno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSlotDobitak
            // 
            this.lblSlotDobitak.Location = new System.Drawing.Point(15, 95);
            this.lblSlotDobitak.Name = "lblSlotDobitak";
            this.lblSlotDobitak.Size = new System.Drawing.Size(212, 20);
            this.lblSlotDobitak.TabIndex = 68;
            this.lblSlotDobitak.Text = "Dobitak: ";
            this.lblSlotDobitak.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSpin
            // 
            this.btnSpin.BackColor = System.Drawing.Color.Black;
            this.btnSpin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSpin.FlatAppearance.BorderSize = 0;
            this.btnSpin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSpin.ForeColor = System.Drawing.Color.Transparent;
            this.btnSpin.Location = new System.Drawing.Point(293, 346);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(133, 22);
            this.btnSpin.TabIndex = 69;
            this.btnSpin.Text = "Spin";
            this.btnSpin.UseVisualStyleBackColor = false;
            this.btnSpin.Click += new System.EventHandler(this.btnSpin_Click);
            // 
            // pBox1
            // 
            this.pBox1.Location = new System.Drawing.Point(104, 199);
            this.pBox1.Name = "pBox1";
            this.pBox1.Size = new System.Drawing.Size(104, 76);
            this.pBox1.TabIndex = 70;
            this.pBox1.TabStop = false;
            // 
            // pBox2
            // 
            this.pBox2.Location = new System.Drawing.Point(244, 199);
            this.pBox2.Name = "pBox2";
            this.pBox2.Size = new System.Drawing.Size(104, 76);
            this.pBox2.TabIndex = 71;
            this.pBox2.TabStop = false;
            // 
            // pBox3
            // 
            this.pBox3.Location = new System.Drawing.Point(387, 199);
            this.pBox3.Name = "pBox3";
            this.pBox3.Size = new System.Drawing.Size(104, 76);
            this.pBox3.TabIndex = 72;
            this.pBox3.TabStop = false;
            // 
            // TimerSlot
            // 
            this.TimerSlot.Interval = 1000;
            this.TimerSlot.Tick += new System.EventHandler(this.TimerSlot_Tick);
            // 
            // TimerSlotUkupan
            // 
            this.TimerSlotUkupan.Interval = 1000;
            this.TimerSlotUkupan.Tick += new System.EventHandler(this.TimerSlotUkupan_Tick);
            // 
            // lblDobitak
            // 
            this.lblDobitak.BackColor = System.Drawing.Color.White;
            this.lblDobitak.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDobitak.Location = new System.Drawing.Point(299, 110);
            this.lblDobitak.Name = "lblDobitak";
            this.lblDobitak.Size = new System.Drawing.Size(285, 65);
            this.lblDobitak.TabIndex = 95;
            this.lblDobitak.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDobitak.Visible = false;
            // 
            // TimerVracanje
            // 
            this.TimerVracanje.Interval = 5000;
            this.TimerVracanje.Tick += new System.EventHandler(this.TimerVracanja_Tick);
            // 
            // Slot
            // 
            this.AcceptButton = this.btnSpin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kladionica.Properties.Resources.Pozadina;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.lblDobitak);
            this.Controls.Add(this.pBox3);
            this.Controls.Add(this.pBox2);
            this.Controls.Add(this.pBox1);
            this.Controls.Add(this.btnSpin);
            this.Controls.Add(this.lblSlotDobitak);
            this.Controls.Add(this.lblSlotUlozeno);
            this.Controls.Add(this.tBoxUlog);
            this.Controls.Add(this.btnPocetna);
            this.Controls.Add(this.lblSlotStanje);
            this.Controls.Add(this.pBoxIzlaz);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.pBoxGore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Slot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discardo - Slot";
            ((System.ComponentModel.ISupportInitialize)(this.pBoxGore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxIzlaz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBoxGore;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.PictureBox pBoxIzlaz;
        private System.Windows.Forms.Label lblSlotStanje;
        private System.Windows.Forms.Button btnPocetna;
        private System.Windows.Forms.TextBox tBoxUlog;
        private System.Windows.Forms.Label lblSlotUlozeno;
        private System.Windows.Forms.Label lblSlotDobitak;
        private System.Windows.Forms.Button btnSpin;
        private System.Windows.Forms.PictureBox pBox1;
        private System.Windows.Forms.PictureBox pBox2;
        private System.Windows.Forms.PictureBox pBox3;
        private System.Windows.Forms.Timer TimerSlot;
        private System.Windows.Forms.Timer TimerSlotUkupan;
        private System.Windows.Forms.Label lblDobitak;
        private System.Windows.Forms.Timer TimerVracanje;
    }
}