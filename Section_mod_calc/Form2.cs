using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Section_mod_calc
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private bool IsValidPositiveDouble(string text, out double result)
        {
            return double.TryParse(text, out result) && result > 0;
        }



        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_eqvL_Click(object sender, EventArgs e)
        {
            // Dictionary to hold the TextBox controls and their corresponding parsed values
            Dictionary<System.Windows.Forms.TextBox, double> values = new Dictionary<System.Windows.Forms.TextBox, double>
            {
                { textBox_h, 0.0 },
                { textBox_thk, 0.0 }
            };

            // Validate and parse each TextBox
            bool allValid = true;
            foreach (var kvp in values.ToList())
            {
                if (IsValidPositiveDouble(kvp.Key.Text, out double parsedValue))
                {
                    values[kvp.Key] = parsedValue;  // Store the successfully parsed value
                }
                else
                {
                    allValid = false;
                    kvp.Key.BackColor = Color.Salmon;  // Highlight invalid TextBoxes
                }
            }

            if (!allValid)
            {
                textBox_eqvL.Text = "";
                MessageBox.Show("Some values are invalid. Please enter valid positive double numbers.");
                return;
            }
            else
            {
                // If all values are valid, reset TextBox colors (if previously set to Salmon)
                foreach (var kvp in values)
                {
                    kvp.Key.BackColor = SystemColors.Window;
                }
            }

            // Assign the values now that they have been validated and parsed
            double bulb_height = values[textBox_h];
            double bulb_thk = values[textBox_thk];


            // Find the co-efficient alpha
            double alpha = 1.0;

            if(bulb_height <= 120.0)
            {
                alpha = 1.1 + (Math.Pow(120.0 - bulb_height, 2) / 3000.00);
            }

            // Equivalent L - Angle
            double flg_thk = (bulb_height / 9.20) - 2.0;
            double stiff_height = bulb_height - ((bulb_height / 9.20) + 2.0) + flg_thk;
            double stiff_thk = bulb_thk;
            double flg_width = alpha * (bulb_thk + ((bulb_height / 6.70) - 2.0));

            textBox_eqvL.Text = $"Web height = {stiff_height:F2} mm {Environment.NewLine}" +
            $"Web thickness = {stiff_thk:F2} mm {Environment.NewLine}" +
            $"Flange width = {flg_width:F2} mm {Environment.NewLine}" +
            $"Flange thickness = {flg_thk:F2} mm{Environment.NewLine}{Environment.NewLine}" +
            $"L{stiff_height:F2}x{flg_width:F2}x{stiff_thk:F2}x{flg_thk:F2}";


        }
    }
}
