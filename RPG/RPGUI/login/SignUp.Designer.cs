namespace RPGUI
{
    partial class SignUp
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(58, 127);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(58, 212);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(205, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(58, 94);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(72, 27);
            textBox3.TabIndex = 2;
            textBox3.Text = "username";
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.Enabled = false;

            // 
            // textBox4
            // 
            textBox4.Location = new Point(58, 179);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(72, 27);
            textBox4.TabIndex = 3;
            textBox4.Text = "password";
            textBox4.TextAlign = HorizontalAlignment.Center;
            textBox4.Enabled = false;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(58, 245);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(72, 27);
            textBox5.TabIndex = 5;
            textBox5.Text = "confirm";
            textBox5.TextAlign = HorizontalAlignment.Center;
            textBox5.Enabled = false;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(58, 278);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(205, 27);
            textBox6.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(99, 335);
            button1.Name = "button1";
            button1.Size = new Size(132, 65);
            button1.TabIndex = 8;
            button1.Text = "Create Account";
            button1.UseVisualStyleBackColor = true;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 463);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox6);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "SignUp";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button1;
    }
}