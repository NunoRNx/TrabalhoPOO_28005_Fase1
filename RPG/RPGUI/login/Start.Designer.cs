using System.ComponentModel;

namespace RPGUI
{
    partial class Start
    {
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;

        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            ((ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(286, 322);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(96, 376);
            button1.Name = "button1";
            button1.Size = new Size(102, 48);
            button1.TabIndex = 1;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(96, 460);
            button2.Name = "button2";
            button2.Size = new Size(102, 48);
            button2.TabIndex = 2;
            button2.Text = "Create Account";
            button2.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            ClientSize = new Size(310, 551);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "MainMenu";
            ((ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }
    }
}