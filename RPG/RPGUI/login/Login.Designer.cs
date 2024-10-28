namespace RPGUI
{
    partial class Login
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
            button1 = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(49, 133);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(72, 27);
            textBox1.TabIndex = 0;
            textBox1.Text = "username";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(49, 166);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(234, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(49, 199);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(72, 27);
            textBox3.TabIndex = 2;
            textBox3.Text = "password";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(49, 232);
            textBox4.Name = "textBox4";
            textBox4.PasswordChar = '*';
            textBox4.Size = new Size(234, 27);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Enabled = false;
            textBox5.Location = new Point(49, 265);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(234, 27);
            textBox5.TabIndex = 4;
            textBox5.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(119, 338);
            button1.Name = "button1";
            button1.Size = new Size(112, 52);
            button1.TabIndex = 5;
            button1.Text = "login";
            button1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(289, 235);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(65, 24);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "show";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 509);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Login";
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
        private Button button1;
        private CheckBox checkBox1;
    }
}