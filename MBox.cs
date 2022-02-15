using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kladionica
{
    public partial class MBox : Form
    {
        public MBox(string Text, string Naslov)
        {
            InitializeComponent();
            lblTekst.Text = Text;
            lblNaslov.Text += " - " + Naslov;
        }

        private void pBoxIzlaz_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
