using Section_mod_calc.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Section_mod_calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBox1.SelectedIndex = 0; // Set the default selected index to 0
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Combo box selected index change
            if(comboBox1.SelectedIndex == 0)
            {
                // L Stiffener picture
                pictureBox1.Image = Resources.LGpic;
            }
            else
            {
                // T Stiffener picture
                pictureBox1.Image = Resources.TGpic;

            }
        }
    }
}
