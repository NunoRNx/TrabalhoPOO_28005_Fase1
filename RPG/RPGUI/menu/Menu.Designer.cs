using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace RPGUI
{
    partial class Menu
    {
        private ContextMenuStrip contextMenuStrip1;
        private System.ComponentModel.IContainer components;

        private void InitializeComponent()
        {
            components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Menu));
            contextMenuStrip1 = new ContextMenuStrip(components);
            button1 = new Button();
            buttonEdit1 = new Button();
            StartButton = new Button();
            buttonScoreboard = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            buttonEdit2 = new Button();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            textBoxUser1 = new Label();
            textBoxUser2 = new Label();
            textBox4 = new Label();
            textBox5 = new Label();
            textBox6 = new Label();
            textBox3 = new Label();
            textBox2 = new Label();
            textBox1 = new Label();
            ((ISupportInitialize)pictureBox1).BeginInit();
            ((ISupportInitialize)pictureBox2).BeginInit();
            ((ISupportInitialize)pictureBox3).BeginInit();
            ((ISupportInitialize)pictureBox4).BeginInit();
            ((ISupportInitialize)pictureBox5).BeginInit();
            ((ISupportInitialize)pictureBox6).BeginInit();
            ((ISupportInitialize)pictureBox7).BeginInit();
            ((ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(39, 297);
            button1.Name = "button1";
            button1.Size = new Size(127, 47);
            button1.TabIndex = 9;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            // 
            // buttonEdit1
            // 
            buttonEdit1.Cursor = Cursors.Hand;
            buttonEdit1.Location = new Point(201, 513);
            buttonEdit1.Name = "buttonEdit1";
            buttonEdit1.Size = new Size(132, 43);
            buttonEdit1.TabIndex = 11;
            buttonEdit1.Text = "Edit Team";
            buttonEdit1.UseVisualStyleBackColor = true;
            buttonEdit1.Visible = false;
            // 
            // StartButton
            // 
            StartButton.Cursor = Cursors.Hand;
            StartButton.Location = new Point(429, 364);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(120, 60);
            StartButton.TabIndex = 14;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Visible = false;
            // 
            // buttonScoreboard
            // 
            buttonScoreboard.Cursor = Cursors.Hand;
            buttonScoreboard.Location = new Point(429, 451);
            buttonScoreboard.Name = "buttonScoreboard";
            buttonScoreboard.Size = new Size(120, 60);
            buttonScoreboard.TabIndex = 13;
            buttonScoreboard.Text = "Scoreboard";
            buttonScoreboard.UseVisualStyleBackColor = true;
            buttonScoreboard.Click += buttonScoreboard_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(814, 296);
            button2.Name = "button2";
            button2.Size = new Size(127, 47);
            button2.TabIndex = 10;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(215, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Location = new Point(215, 211);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 100);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Location = new Point(215, 364);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 100);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 21;
            pictureBox3.TabStop = false;
            pictureBox3.Visible = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Location = new Point(667, 60);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(100, 100);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 29;
            pictureBox4.TabStop = false;
            pictureBox4.Visible = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Location = new Point(667, 211);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(100, 100);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 27;
            pictureBox5.TabStop = false;
            pictureBox5.Visible = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Location = new Point(667, 364);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(100, 100);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 25;
            pictureBox6.TabStop = false;
            pictureBox6.Visible = false;
            // 
            // buttonEdit2
            // 
            buttonEdit2.Cursor = Cursors.Hand;
            buttonEdit2.Location = new Point(652, 513);
            buttonEdit2.Name = "buttonEdit2";
            buttonEdit2.Size = new Size(132, 43);
            buttonEdit2.TabIndex = 24;
            buttonEdit2.Text = "Edit Team";
            buttonEdit2.UseVisualStyleBackColor = true;
            buttonEdit2.Visible = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Transparent;
            pictureBox7.Enabled = false;
            pictureBox7.Image = Properties.Resources.title;
            pictureBox7.Location = new Point(382, 60);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(209, 48);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 32;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.Transparent;
            pictureBox8.Enabled = false;
            pictureBox8.Image = Properties.Resources.game;
            pictureBox8.Location = new Point(410, 88);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(150, 150);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 31;
            pictureBox8.TabStop = false;
            // 
            // textBoxUser1
            // 
            textBoxUser1.BackColor = Color.Transparent;
            textBoxUser1.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUser1.ForeColor = Color.White;
            textBoxUser1.Location = new Point(39, 238);
            textBoxUser1.Name = "textBoxUser1";
            textBoxUser1.Size = new Size(127, 25);
            textBoxUser1.TabIndex = 33;
            textBoxUser1.Text = "user";
            textBoxUser1.TextAlign = ContentAlignment.MiddleCenter;
            textBoxUser1.Visible = false;
            // 
            // textBoxUser2
            // 
            textBoxUser2.BackColor = Color.Transparent;
            textBoxUser2.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUser2.ForeColor = Color.White;
            textBoxUser2.Location = new Point(814, 238);
            textBoxUser2.Name = "textBoxUser2";
            textBoxUser2.Size = new Size(127, 25);
            textBoxUser2.TabIndex = 34;
            textBoxUser2.Text = "user";
            textBoxUser2.TextAlign = ContentAlignment.MiddleCenter;
            textBoxUser2.Visible = false;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Transparent;
            textBox4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            textBox4.ForeColor = Color.White;
            textBox4.Location = new Point(652, 164);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(132, 27);
            textBox4.TabIndex = 38;
            textBox4.Text = "character";
            textBox4.TextAlign = ContentAlignment.MiddleCenter;
            textBox4.Visible = false;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.Transparent;
            textBox5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            textBox5.ForeColor = Color.White;
            textBox5.Location = new Point(652, 314);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(132, 27);
            textBox5.TabIndex = 39;
            textBox5.Text = "character";
            textBox5.TextAlign = ContentAlignment.MiddleCenter;
            textBox5.Visible = false;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.Transparent;
            textBox6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            textBox6.ForeColor = Color.White;
            textBox6.Location = new Point(652, 467);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(132, 27);
            textBox6.TabIndex = 40;
            textBox6.Text = "character";
            textBox6.TextAlign = ContentAlignment.MiddleCenter;
            textBox6.Visible = false;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Transparent;
            textBox3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            textBox3.ForeColor = Color.White;
            textBox3.Location = new Point(201, 470);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(132, 27);
            textBox3.TabIndex = 37;
            textBox3.Text = "character";
            textBox3.TextAlign = ContentAlignment.MiddleCenter;
            textBox3.Visible = false;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Transparent;
            textBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(201, 317);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(132, 27);
            textBox2.TabIndex = 36;
            textBox2.Text = "character";
            textBox2.TextAlign = ContentAlignment.MiddleCenter;
            textBox2.Visible = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Transparent;
            textBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(201, 164);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(132, 27);
            textBox1.TabIndex = 35;
            textBox1.Text = "character";
            textBox1.TextAlign = ContentAlignment.MiddleCenter;
            textBox1.Visible = false;
            // 
            // Menu
            // 
            AcceptButton = StartButton;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.menu;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 613);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(textBoxUser2);
            Controls.Add(textBoxUser1);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox6);
            Controls.Add(buttonEdit2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(StartButton);
            Controls.Add(buttonScoreboard);
            Controls.Add(buttonEdit1);
            Controls.Add(button2);
            Controls.Add(button1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            ((ISupportInitialize)pictureBox1).EndInit();
            ((ISupportInitialize)pictureBox2).EndInit();
            ((ISupportInitialize)pictureBox3).EndInit();
            ((ISupportInitialize)pictureBox4).EndInit();
            ((ISupportInitialize)pictureBox5).EndInit();
            ((ISupportInitialize)pictureBox6).EndInit();
            ((ISupportInitialize)pictureBox7).EndInit();
            ((ISupportInitialize)pictureBox8).EndInit();
            ResumeLayout(false);
        }

        private Button button1;
        private Button StartButton;
        private Button buttonScoreboard;
        private Button button2;

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;

        private Button buttonEdit1;
        private Button buttonEdit2;
        
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        

        private Label textBoxUser1;
        private Label textBoxUser2;
        private Label textBox4;
        private Label textBox5;
        private Label textBox6;
        private Label textBox3;
        private Label textBox2;
        private Label textBox1;
    }
}