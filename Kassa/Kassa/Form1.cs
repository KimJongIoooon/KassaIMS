using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kassa
{
    public partial class Kassa : Form
    {
        public Kassa()
        {
            InitializeComponent();
            TotaalBedrag.Text = "€2525,68";
        }

        private void ProductNrTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                MessageBox.Show("Enter Key Pressed ");
            }
        }
    }
}
