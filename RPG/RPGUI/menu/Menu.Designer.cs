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
            contextMenuStrip1 = new ContextMenuStrip(components);
            textBoxUser1 = new TextBox();
            button1 = new Button();
            buttonEdit1 = new Button();
            StartButton = new Button();
            buttonScoreboard = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox4 = new TextBox();
            pictureBox2 = new PictureBox();
            textBox5 = new TextBox();
            pictureBox3 = new PictureBox();
            textBox2 = new TextBox();
            pictureBox4 = new PictureBox();
            textBox6 = new TextBox();
            pictureBox5 = new PictureBox();
            textBox3 = new TextBox();
            pictureBox6 = new PictureBox();
            buttonEdit2 = new Button();
            textBoxUser2 = new TextBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
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
            // textBoxUser1
            // 
            textBoxUser1.Enabled = false;
            textBoxUser1.Location = new Point(39, 237);
            textBoxUser1.Name = "textBoxUser1";
            textBoxUser1.Size = new Size(125, 27);
            textBoxUser1.TabIndex = 7;
            textBoxUser1.Text = "Username";
            textBoxUser1.TextAlign = HorizontalAlignment.Center;
            textBoxUser1.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(39, 297);
            button1.Name = "button1";
            button1.Size = new Size(127, 47);
            button1.TabIndex = 9;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            // 
            // buttonEdit1
            // 
            buttonEdit1.Location = new Point(206, 512);
            buttonEdit1.Name = "buttonEdit1";
            buttonEdit1.Size = new Size(120, 43);
            buttonEdit1.TabIndex = 11;
            buttonEdit1.Text = "Edit Team";
            buttonEdit1.UseVisualStyleBackColor = true;
            buttonEdit1.Visible = false;
            // 
            // StartButton
            // 
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
            button2.Location = new Point(814, 296);
            button2.Name = "button2";
            button2.Size = new Size(127, 47);
            button2.TabIndex = 10;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(215, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(206, 166);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(120, 27);
            textBox1.TabIndex = 18;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.Visible = false;
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(658, 166);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(120, 27);
            textBox4.TabIndex = 20;
            textBox4.TextAlign = HorizontalAlignment.Center;
            textBox4.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(215, 211);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 100);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // textBox5
            // 
            textBox5.Enabled = false;
            textBox5.Location = new Point(658, 317);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(120, 27);
            textBox5.TabIndex = 22;
            textBox5.TextAlign = HorizontalAlignment.Center;
            textBox5.Visible = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(215, 364);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 100);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 21;
            pictureBox3.TabStop = false;
            pictureBox3.Visible = false;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(206, 316);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(120, 27);
            textBox2.TabIndex = 30;
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.Visible = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(667, 60);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(100, 100);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 29;
            pictureBox4.TabStop = false;
            pictureBox4.Visible = false;
            // 
            // textBox6
            // 
            textBox6.Enabled = false;
            textBox6.Location = new Point(658, 470);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(120, 27);
            textBox6.TabIndex = 28;
            textBox6.TextAlign = HorizontalAlignment.Center;
            textBox6.Visible = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(667, 211);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(100, 100);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 27;
            pictureBox5.TabStop = false;
            pictureBox5.Visible = false;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(206, 469);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(120, 27);
            textBox3.TabIndex = 26;
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.Visible = false;
            // 
            // pictureBox6
            // 
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
            buttonEdit2.Location = new Point(658, 513);
            buttonEdit2.Name = "buttonEdit2";
            buttonEdit2.Size = new Size(120, 43);
            buttonEdit2.TabIndex = 24;
            buttonEdit2.Text = "Edit Team";
            buttonEdit2.UseVisualStyleBackColor = true;
            buttonEdit2.Visible = false;
            // 
            // textBoxUser2
            // 
            textBoxUser2.Enabled = false;
            textBoxUser2.Location = new Point(814, 238);
            textBoxUser2.Name = "textBoxUser2";
            textBoxUser2.Size = new Size(127, 27);
            textBoxUser2.TabIndex = 23;
            textBoxUser2.Text = "Username";
            textBoxUser2.TextAlign = HorizontalAlignment.Center;
            textBoxUser2.Visible = false;
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
            pictureBox8.Enabled = false;
            pictureBox8.Image = Properties.Resources.game;
            pictureBox8.Location = new Point(410, 88);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(150, 150);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 31;
            pictureBox8.TabStop = false;
            // 
            // Menu
            // 
            BackColor = Color.Gray;
            ClientSize = new Size(980, 610);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox8);
            Controls.Add(textBox2);
            Controls.Add(pictureBox4);
            Controls.Add(textBox6);
            Controls.Add(pictureBox5);
            Controls.Add(textBox3);
            Controls.Add(pictureBox6);
            Controls.Add(buttonEdit2);
            Controls.Add(textBoxUser2);
            Controls.Add(textBox5);
            Controls.Add(pictureBox3);
            Controls.Add(textBox4);
            Controls.Add(pictureBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(StartButton);
            Controls.Add(buttonScoreboard);
            Controls.Add(buttonEdit1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBoxUser1);
            Name = "Menu";
            ((ISupportInitialize)pictureBox1).EndInit();
            ((ISupportInitialize)pictureBox2).EndInit();
            ((ISupportInitialize)pictureBox3).EndInit();
            ((ISupportInitialize)pictureBox4).EndInit();
            ((ISupportInitialize)pictureBox5).EndInit();
            ((ISupportInitialize)pictureBox6).EndInit();
            ((ISupportInitialize)pictureBox7).EndInit();
            ((ISupportInitialize)pictureBox8).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox textBoxUser1;
        private Button button1;
        private Button StartButton;
        private Button buttonScoreboard;
        private Button button2;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox4;
        private PictureBox pictureBox2;
        private TextBox textBox5;
        private PictureBox pictureBox3;
        private TextBox textBox2;
        private PictureBox pictureBox4;
        private TextBox textBox6;
        private PictureBox pictureBox5;
        private TextBox textBox3;
        private PictureBox pictureBox6;
        private Button buttonEdit2;
        private TextBox textBoxUser2;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private Button buttonEdit1;
    }
}