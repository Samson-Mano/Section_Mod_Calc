namespace Section_mod_calc
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_t_p = new System.Windows.Forms.TextBox();
            this.textBox_w_s = new System.Windows.Forms.TextBox();
            this.textBox_h = new System.Windows.Forms.TextBox();
            this.textBox_t_w = new System.Windows.Forms.TextBox();
            this.textBox_w_b = new System.Windows.Forms.TextBox();
            this.textBox_t_f = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_calculate = new System.Windows.Forms.Button();
            this.textBox_results = new System.Windows.Forms.TextBox();
            this.button_hpL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bottom plate thickness t_p: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stiffener spacing w_s: ";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "L - Stiffener",
            "T - Stiffener"});
            this.comboBox1.Location = new System.Drawing.Point(175, 90);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(119, 23);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Web height h: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Web thickness t_w: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Flange width w_b: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Flange thickness t_f: ";
            // 
            // textBox_t_p
            // 
            this.textBox_t_p.Location = new System.Drawing.Point(194, 27);
            this.textBox_t_p.Name = "textBox_t_p";
            this.textBox_t_p.Size = new System.Drawing.Size(100, 23);
            this.textBox_t_p.TabIndex = 7;
            this.textBox_t_p.Text = "12";
            // 
            // textBox_w_s
            // 
            this.textBox_w_s.Location = new System.Drawing.Point(194, 57);
            this.textBox_w_s.Name = "textBox_w_s";
            this.textBox_w_s.Size = new System.Drawing.Size(100, 23);
            this.textBox_w_s.TabIndex = 8;
            this.textBox_w_s.Text = "600";
            // 
            // textBox_h
            // 
            this.textBox_h.Location = new System.Drawing.Point(194, 127);
            this.textBox_h.Name = "textBox_h";
            this.textBox_h.Size = new System.Drawing.Size(100, 23);
            this.textBox_h.TabIndex = 9;
            this.textBox_h.Text = "125";
            // 
            // textBox_t_w
            // 
            this.textBox_t_w.Location = new System.Drawing.Point(194, 157);
            this.textBox_t_w.Name = "textBox_t_w";
            this.textBox_t_w.Size = new System.Drawing.Size(100, 23);
            this.textBox_t_w.TabIndex = 10;
            this.textBox_t_w.Text = "8";
            // 
            // textBox_w_b
            // 
            this.textBox_w_b.Location = new System.Drawing.Point(194, 187);
            this.textBox_w_b.Name = "textBox_w_b";
            this.textBox_w_b.Size = new System.Drawing.Size(100, 23);
            this.textBox_w_b.TabIndex = 11;
            this.textBox_w_b.Text = "75";
            // 
            // textBox_t_f
            // 
            this.textBox_t_f.Location = new System.Drawing.Point(194, 217);
            this.textBox_t_f.Name = "textBox_t_f";
            this.textBox_t_f.Size = new System.Drawing.Size(100, 23);
            this.textBox_t_f.TabIndex = 12;
            this.textBox_t_f.Text = "8";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Section_mod_calc.Properties.Resources.LGpic;
            this.pictureBox1.Location = new System.Drawing.Point(302, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(420, 291);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // button_calculate
            // 
            this.button_calculate.Location = new System.Drawing.Point(129, 258);
            this.button_calculate.Name = "button_calculate";
            this.button_calculate.Size = new System.Drawing.Size(165, 45);
            this.button_calculate.TabIndex = 14;
            this.button_calculate.Text = "Calculate";
            this.button_calculate.UseVisualStyleBackColor = true;
            this.button_calculate.Click += new System.EventHandler(this.button_calculate_Click);
            // 
            // textBox_results
            // 
            this.textBox_results.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_results.Location = new System.Drawing.Point(12, 319);
            this.textBox_results.Multiline = true;
            this.textBox_results.Name = "textBox_results";
            this.textBox_results.Size = new System.Drawing.Size(710, 180);
            this.textBox_results.TabIndex = 15;
            // 
            // button_hpL
            // 
            this.button_hpL.Location = new System.Drawing.Point(12, 258);
            this.button_hpL.Name = "button_hpL";
            this.button_hpL.Size = new System.Drawing.Size(111, 44);
            this.button_hpL.TabIndex = 16;
            this.button_hpL.Text = "HP Stiff -> L Stiff";
            this.button_hpL.UseVisualStyleBackColor = true;
            this.button_hpL.Click += new System.EventHandler(this.button_hpL_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 511);
            this.Controls.Add(this.button_hpL);
            this.Controls.Add(this.textBox_results);
            this.Controls.Add(this.button_calculate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox_t_f);
            this.Controls.Add(this.textBox_w_b);
            this.Controls.Add(this.textBox_t_w);
            this.Controls.Add(this.textBox_h);
            this.Controls.Add(this.textBox_w_s);
            this.Controls.Add(this.textBox_t_p);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(750, 550);
            this.Name = "Form1";
            this.Text = "Section Modulus Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_t_p;
        private System.Windows.Forms.TextBox textBox_w_s;
        private System.Windows.Forms.TextBox textBox_h;
        private System.Windows.Forms.TextBox textBox_t_w;
        private System.Windows.Forms.TextBox textBox_w_b;
        private System.Windows.Forms.TextBox textBox_t_f;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_calculate;
        private System.Windows.Forms.TextBox textBox_results;
        private System.Windows.Forms.Button button_hpL;
    }
}

