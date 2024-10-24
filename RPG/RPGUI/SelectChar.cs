using System.Runtime.InteropServices;
using RPG;
namespace RPGUI
{
    public partial class SelectChar : Form
    {
        public SelectChar()
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
