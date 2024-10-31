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
            button1 = new Button();
            pictureBox4 = new PictureBox();
            panel1 = new Panel();
            textBoxUser = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            textBoxPass = new TextBox();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            textBoxConfirm = new TextBox();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(1, 235, 205);
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(110, 375);
            button1.Name = "button1";
            button1.Size = new Size(150, 42);
            button1.TabIndex = 5;
            button1.Text = "SignUp";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Enabled = false;
            pictureBox4.Image = Properties.Resources.title;
            pictureBox4.Location = new Point(82, 25);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(209, 48);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 24;
            pictureBox4.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(textBoxUser);
            panel1.Controls.Add(pictureBox3);
            panel1.Location = new Point(62, 237);
            panel1.Name = "panel1";
            panel1.Size = new Size(249, 36);
            panel1.TabIndex = 20;
            // 
            // textBoxUser
            // 
            textBoxUser.BorderStyle = BorderStyle.None;
            textBoxUser.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUser.ForeColor = Color.Gray;
            textBoxUser.Location = new Point(34, 5);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(214, 27);
            textBoxUser.TabIndex = 14;
            textBoxUser.Text = "username";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.Window;
            pictureBox3.Enabled = false;
            pictureBox3.Image = Properties.Resources.user;
            pictureBox3.Location = new Point(3, 7);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Enabled = false;
            pictureBox1.Image = Properties.Resources.game;
            pictureBox1.Location = new Point(110, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Window;
            panel3.Controls.Add(textBoxPass);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(62, 279);
            panel3.Name = "panel3";
            panel3.Size = new Size(249, 36);
            panel3.TabIndex = 22;
            // 
            // textBoxPass
            // 
            textBoxPass.BorderStyle = BorderStyle.None;
            textBoxPass.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPass.ForeColor = Color.Gray;
            textBoxPass.Location = new Point(32, 5);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.Size = new Size(214, 27);
            textBoxPass.TabIndex = 15;
            textBoxPass.Text = "password";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.Window;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.locked;
            pictureBox2.Location = new Point(3, 8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Window;
            panel2.Controls.Add(textBoxConfirm);
            panel2.Controls.Add(pictureBox5);
            panel2.Location = new Point(61, 323);
            panel2.Name = "panel2";
            panel2.Size = new Size(249, 36);
            panel2.TabIndex = 23;
            // 
            // textBoxConfirm
            // 
            textBoxConfirm.BorderStyle = BorderStyle.None;
            textBoxConfirm.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxConfirm.ForeColor = Color.Gray;
            textBoxConfirm.Location = new Point(32, 5);
            textBoxConfirm.Name = "textBoxConfirm";
            textBoxConfirm.Size = new Size(214, 27);
            textBoxConfirm.TabIndex = 15;
            textBoxConfirm.Text = "confirm password";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = SystemColors.Window;
            pictureBox5.Enabled = false;
            pictureBox5.Image = Properties.Resources.locked_old;
            pictureBox5.Location = new Point(3, 7);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(25, 24);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 9;
            pictureBox5.TabStop = false;
            // 
            // SignUp
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(372, 493);
            Controls.Add(panel2);
            Controls.Add(pictureBox4);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(panel3);
            Controls.Add(button1);
            Name = "SignUp";
            Text = "Sign Up";
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private PictureBox pictureBox4;
        private Panel panel1;
        private TextBox textBoxUser;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Panel panel3;
        private TextBox textBoxPass;
        private PictureBox pictureBox2;
        private Panel panel2;
        private TextBox textBoxConfirm;
        private PictureBox pictureBox5;
    }
}