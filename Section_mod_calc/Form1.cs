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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Section_mod_calc
{
    public partial class Form1 : Form
    {
        Form2 Form_HPeqvL;

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

        private bool IsValidPositiveDouble(string text, out double result)
        {
            return double.TryParse(text, out result) && result >= 0;
        }


        private void button_calculate_Click(object sender, EventArgs e)
        {
            // Dictionary to hold the TextBox controls and their corresponding parsed values
            Dictionary<System.Windows.Forms.TextBox, double> values = new Dictionary<System.Windows.Forms.TextBox, double>
            {
                { textBox_t_p, 0.0 },
                { textBox_w_s, 0.0 },
                { textBox_h, 0.0 },
                { textBox_t_w, 0.0 },
                { textBox_w_b, 0.0 },
                { textBox_t_f, 0.0 }
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
                textBox_results.Text = "";
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
            double plate_t_p = values[textBox_t_p];
            double plate_w = values[textBox_w_s];
            double stiff_height = values[textBox_h];
            double stiff_webthk = values[textBox_t_w];
            double stiff_flgwidth = values[textBox_w_b];
            double stiff_flgthk = values[textBox_t_f];



            //________________________________________________________________________
            // Bottom plate 
            double A1 = plate_t_p * plate_w;
            double A1_xcg = plate_w * 0.5;
            double A1_ycg = plate_t_p * 0.5;


            // Stiffener web
            double A2 = stiff_webthk * (stiff_height - stiff_flgthk);
            double A2_xcg = plate_w * 0.5;
            double A2_ycg = plate_t_p + ((stiff_height - stiff_flgthk) * 0.5);


            // Stiffener flange
            double A3 = stiff_flgwidth * stiff_flgthk;
            double A3_xcg = 0.0;
            double A3_ycg = plate_t_p + (stiff_height - stiff_flgthk) + (stiff_flgthk * 0.5);


            if (comboBox1.SelectedIndex == 0)
            {
                // L Stiffener
                A3_xcg = (plate_w * 0.5) + (stiff_flgwidth * 0.5);
            }
            else
            {
                // T Stiffener
                A3_xcg = (plate_w * 0.5);
            }

            // Total area
            double tota_area = A1 + A2 + A3;


            // First Area moment
            double x_first_area_moment = (A1 * A1_xcg) + (A2 * A2_xcg) + (A3 * A3_xcg);
            double y_first_area_moment = (A1 * A1_ycg) + (A2 * A2_ycg) + (A3 * A3_ycg);

            // Center of gravity
            double x_cog = (x_first_area_moment / tota_area);
            double y_cog = (y_first_area_moment / tota_area);


            // A*x^2, A*y^2
            double Ax_2 = (A1 * Math.Pow( (A1_xcg - x_cog),2)) + 
                (A2 * Math.Pow((A2_xcg - x_cog), 2)) + 
                (A3 * Math.Pow((A3_xcg - x_cog), 2));

            double Ay_2 = (A1 * Math.Pow((A1_ycg - y_cog), 2)) +
                (A2 * Math.Pow((A2_ycg - y_cog), 2)) +
                (A3 * Math.Pow((A3_ycg - y_cog), 2));


            // b*d^3 /12.0
            double x_bd3_12 = 0.0;
            double y_bd3_12 = 0.0;

            string section_type = "";

            if (comboBox1.SelectedIndex == 0)
            {
                // L Stiffener 
                section_type = "L Stiffener";

                double xbd3_12_1 = plate_t_p * Math.Pow(plate_w, 3);
                double xbd3_12_2 = (stiff_height - (stiff_webthk * 0.5)) * Math.Pow(stiff_webthk, 3);
                double xbd3_12_3 = stiff_flgthk * Math.Pow(stiff_flgwidth + (stiff_flgthk * 0.5), 3);

                x_bd3_12 = (xbd3_12_1  + xbd3_12_2 + xbd3_12_3) / 12.0;


                double ybd3_12_1 = plate_w * Math.Pow(plate_t_p, 3);
                double ybd3_12_2 = stiff_webthk * Math.Pow(stiff_height - (stiff_webthk*0.5), 3);
                double ybd3_12_3 = (stiff_flgwidth + (stiff_flgthk * 0.5)) * Math.Pow(stiff_flgthk, 3);

                y_bd3_12 = (ybd3_12_1 + ybd3_12_2 + ybd3_12_3) / 12.0;

            }
            else
            {
                // T Stiffener
                section_type = "T Stiffener";

                double xbd3_12_1 = plate_t_p * Math.Pow(plate_w, 3);
                double xbd3_12_2 = (stiff_height - stiff_flgthk) * Math.Pow(stiff_webthk, 3);
                double xbd3_12_3 = stiff_flgthk * Math.Pow(stiff_flgwidth, 3);

                x_bd3_12 = (xbd3_12_1 + xbd3_12_2 + xbd3_12_3) / 12.0;


                double ybd3_12_1 = plate_w * Math.Pow(plate_t_p, 3);
                double ybd3_12_2 = stiff_webthk * Math.Pow(stiff_height - stiff_flgthk, 3);
                double ybd3_12_3 = stiff_flgwidth * Math.Pow(stiff_flgthk, 3);

                y_bd3_12 = (ybd3_12_1 + ybd3_12_2 + ybd3_12_3) / 12.0;

            }

            // Second moment of area
            double I_yy = Ax_2 + x_bd3_12;
            double I_xx = Ay_2 + y_bd3_12;

            // Section modulus x-x
            double Z_xx = I_xx / Math.Max(y_cog, (plate_t_p + stiff_height) - y_cog);

            textBox_results.Text = $"{section_type} {Environment.NewLine}" + 
                      $"Cross-Section Area = {tota_area:F2} mm\u00B2 {Environment.NewLine}" +
                      $"X - COG = {x_cog:F2} mm {Environment.NewLine}" +
                      $"Y - COG = {y_cog:F2} mm {Environment.NewLine}" +
                      $"Second moment of area Ixx = {I_xx:F2} mm\u2074  {Environment.NewLine}" +
                      $"Second moment of area Iyy = {I_yy:F2} mm\u2074  {Environment.NewLine}" +
                      $"Section modulus Zxx = {Z_xx:F2} mm\u00B3";

        }

        private void button_hpL_Click(object sender, EventArgs e)
        {
            Form_HPeqvL = new Form2();

            // Open Convert HP Bulb Profile -> Equivalent Angle Form
            Form_HPeqvL.Show();
        }
    }
}
