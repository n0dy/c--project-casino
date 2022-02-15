namespace Kladionica
{
    partial class MBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MBox));
            this.pBoxIzlaz = new System.Windows.Forms.PictureBox();
            this.pBoxGore = new System.Windows.Forms.PictureBox();
            this.lblTekst = new System.Windows.Forms.Label();
            this.pBoxOkvir1 = new System.Windows.Forms.PictureBox();
            this.pBoxOkvir2 = new System.Windows.Forms.PictureBox();
            this.pBoxOkvir3 = new System.Windows.Forms.PictureBox();
            this.pBoxOkvir4 = new System.Windows.Forms.PictureBox();
            this.lblNaslov = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxIzlaz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxGore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxOkvir1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxOkvir2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxOkvir3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxOkvir4)).BeginInit();
            this.SuspendLayout();
            // 
            // pBoxIzlaz
            // 
            this.pBoxIzlaz.BackColor = System.Drawing.Color.Black;
            this.pBoxIzlaz.BackgroundImage = global::Kladionica.Properties.Resources.ApplicationClose;
            this.pBoxIzlaz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBoxIzlaz.Location = new System.Drawing.Point(261, 16);
            this.pBoxIzlaz.Name = "pBoxIzlaz";
            this.pBoxIzlaz.Size = new System.Drawing.Size(23, 23);
            this.pBoxIzlaz.TabIndex = 4;
            this.pBoxIzlaz.TabStop = false;
            this.pBoxIzlaz.Click += new System.EventHandler(this.pBoxIzlaz_Click);
            // 
            // pBoxGore
            // 
            this.pBoxGore.BackColor = System.Drawing.Color.Black;
            this.pBoxGore.Location = new System.Drawing.Point(15, 15);
            this.pBoxGore.Name = "pBoxGore";
            this.pBoxGore.Size = new System.Drawing.Size(270, 25);
            this.pBoxGore.TabIndex = 3;
            this.pBoxGore.TabStop = false;
            // 
            // lblTekst
            // 
            this.lblTekst.BackColor = System.Drawing.Color.Transparent;
            this.lblTekst.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTekst.Location = new System.Drawing.Point(15, 56);
            this.lblTekst.Name = "lblTekst";
            this.lblTekst.Size = new System.Drawing.Size(270, 25);
            this.lblTekst.TabIndex = 8;
            this.lblTekst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pBoxOkvir1
            // 
            this.pBoxOkvir1.BackColor = System.Drawing.Color.Black;
            this.pBoxOkvir1.Location = new System.Drawing.Point(0, 0);
            this.pBoxOkvir1.Name = "pBoxOkvir1";
            this.pBoxOkvir1.Size = new System.Drawing.Size(300, 5);
            this.pBoxOkvir1.TabIndex = 9;
            this.pBoxOkvir1.TabStop = false;
            // 
            // pBoxOkvir2
            // 
            this.pBoxOkvir2.BackColor = System.Drawing.Color.Black;
            this.pBoxOkvir2.Location = new System.Drawing.Point(0, 95);
            this.pBoxOkvir2.Name = "pBoxOkvir2";
            this.pBoxOkvir2.Size = new System.Drawing.Size(300, 5);
            this.pBoxOkvir2.TabIndex = 10;
            this.pBoxOkvir2.TabStop = false;
            // 
            // pBoxOkvir3
            // 
            this.pBoxOkvir3.BackColor = System.Drawing.Color.Black;
            this.pBoxOkvir3.Location = new System.Drawing.Point(0, 0);
            this.pBoxOkvir3.Name = "pBoxOkvir3";
            this.pBoxOkvir3.Size = new System.Drawing.Size(5, 100);
            this.pBoxOkvir3.TabIndex = 11;
            this.pBoxOkvir3.TabStop = false;
            // 
            // pBoxOkvir4
            // 
            this.pBoxOkvir4.BackColor = System.Drawing.Color.Black;
            this.pBoxOkvir4.Location = new System.Drawing.Point(295, 0);
            this.pBoxOkvir4.Name = "pBoxOkvir4";
            this.pBoxOkvir4.Size = new System.Drawing.Size(5, 100);
            this.pBoxOkvir4.TabIndex = 12;
            this.pBoxOkvir4.TabStop = false;
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
            this.lblNaslov.Text = "Discardo";
            this.lblNaslov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 100);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.pBoxOkvir4);
            this.Controls.Add(this.pBoxOkvir3);
            this.Controls.Add(this.pBoxOkvir2);
            this.Controls.Add(this.pBoxOkvir1);
            this.Controls.Add(this.lblTekst);
            this.Controls.Add(this.pBoxIzlaz);
            this.Controls.Add(this.pBoxGore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discardo - Greška";
            ((System.ComponentModel.ISupportInitialize)(this.pBoxIzlaz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxGore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxOkvir1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxOkvir2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxOkvir3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxOkvir4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pBoxGore;
        private System.Windows.Forms.PictureBox pBoxIzlaz;
        private System.Windows.Forms.Label lblTekst;
        private System.Windows.Forms.PictureBox pBoxOkvir1;
        private System.Windows.Forms.PictureBox pBoxOkvir2;
        private System.Windows.Forms.PictureBox pBoxOkvir3;
        private System.Windows.Forms.PictureBox pBoxOkvir4;
        private System.Windows.Forms.Label lblNaslov;
    }
}