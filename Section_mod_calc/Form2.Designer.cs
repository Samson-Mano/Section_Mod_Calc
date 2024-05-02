namespace Section_mod_calc
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_h = new System.Windows.Forms.TextBox();
            this.textBox_thk = new System.Windows.Forms.TextBox();
            this.button_eqvL = new System.Windows.Forms.Button();
            this.textBox_eqvL = new System.Windows.Forms.TextBox();
            this.button_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bulb profile height: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bulb profile thickness: ";
            // 
            // textBox_h
            // 
            this.textBox_h.Location = new System.Drawing.Point(183, 38);
            this.textBox_h.Name = "textBox_h";
            this.textBox_h.Size = new System.Drawing.Size(65, 23);
            this.textBox_h.TabIndex = 2;
            this.textBox_h.Text = "140";
            // 
            // textBox_thk
            // 
            this.textBox_thk.Location = new System.Drawing.Point(183, 67);
            this.textBox_thk.Name = "textBox_thk";
            this.textBox_thk.Size = new System.Drawing.Size(65, 23);
            this.textBox_thk.TabIndex = 3;
            this.textBox_thk.Text = "10";
            // 
            // button_eqvL
            // 
            this.button_eqvL.Location = new System.Drawing.Point(104, 109);
            this.button_eqvL.Name = "button_eqvL";
            this.button_eqvL.Size = new System.Drawing.Size(144, 40);
            this.button_eqvL.TabIndex = 4;
            this.button_eqvL.Text = "Equivalent L Angle";
            this.button_eqvL.UseVisualStyleBackColor = true;
            this.button_eqvL.Click += new System.EventHandler(this.button_eqvL_Click);
            // 
            // textBox_eqvL
            // 
            this.textBox_eqvL.Location = new System.Drawing.Point(47, 169);
            this.textBox_eqvL.Multiline = true;
            this.textBox_eqvL.Name = "textBox_eqvL";
            this.textBox_eqvL.Size = new System.Drawing.Size(201, 109);
            this.textBox_eqvL.TabIndex = 5;
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(136, 295);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(112, 36);
            this.button_close.TabIndex = 6;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 351);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.textBox_eqvL);
            this.Controls.Add(this.button_eqvL);
            this.Controls.Add(this.textBox_thk);
            this.Controls.Add(this.textBox_h);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(390, 390);
            this.Name = "Form2";
            this.Text = "Convert HP Bulb Profile -> Equivalent Angle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_h;
        private System.Windows.Forms.TextBox textBox_thk;
        private System.Windows.Forms.Button button_eqvL;
        private System.Windows.Forms.TextBox textBox_eqvL;
        private System.Windows.Forms.Button button_close;
    }
}