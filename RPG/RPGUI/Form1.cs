using System.Runtime.InteropServices;
using RPG;
namespace RPGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = Image.FromFile("imgs\\Warrior.jpeg"); // Load an image
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;  // Adjust the size mode
            Controls.Add(pictureBox); // Add the PictureBox to the form
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e, Class charecter)
        {
            
        }
    }
}
