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
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            listBox4 = new ListBox();
            listBox5 = new ListBox();
            listBox6 = new ListBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button2 = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(53, 120);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 104);
            listBox1.TabIndex = 1;
            listBox1.Visible = false;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(53, 249);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(150, 104);
            listBox2.TabIndex = 2;
            listBox2.Visible = false;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.Location = new Point(53, 391);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(150, 104);
            listBox3.TabIndex = 3;
            listBox3.Visible = false;
            // 
            // listBox4
            // 
            listBox4.FormattingEnabled = true;
            listBox4.Location = new Point(775, 120);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(150, 104);
            listBox4.TabIndex = 6;
            listBox4.Visible = false;
            // 
            // listBox5
            // 
            listBox5.FormattingEnabled = true;
            listBox5.Location = new Point(775, 249);
            listBox5.Name = "listBox5";
            listBox5.Size = new Size(150, 104);
            listBox5.TabIndex = 5;
            listBox5.Visible = false;
            // 
            // listBox6
            // 
            listBox6.FormattingEnabled = true;
            listBox6.Location = new Point(775, 391);
            listBox6.Name = "listBox6";
            listBox6.Size = new Size(150, 104);
            listBox6.TabIndex = 4;
            listBox6.Visible = false;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(65, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 7;
            textBox1.Text = "Username";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.Visible = false;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(785, 87);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 8;
            textBox2.Text = "Username";
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(65, 25);
            button1.Name = "button1";
            button1.Size = new Size(125, 47);
            button1.TabIndex = 9;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(65, 501);
            button3.Name = "button3";
            button3.Size = new Size(125, 43);
            button3.TabIndex = 11;
            button3.Text = "Edit Presets";
            button3.UseVisualStyleBackColor = true;
            button3.Visible = false;
            // 
            // button4
            // 
            button4.Location = new Point(785, 501);
            button4.Name = "button4";
            button4.Size = new Size(125, 43);
            button4.TabIndex = 12;
            button4.Text = "Edit Presets";
            button4.UseVisualStyleBackColor = true;
            button4.Visible = false;
            // 
            // button5
            // 
            button5.Location = new Point(427, 348);
            button5.Name = "button5";
            button5.Size = new Size(120, 60);
            button5.TabIndex = 14;
            button5.Text = "Start";
            button5.UseVisualStyleBackColor = true;
            button5.Visible = false;
            // 
            // button6
            // 
            button6.Location = new Point(427, 435);
            button6.Name = "button6";
            button6.Size = new Size(120, 60);
            button6.TabIndex = 13;
            button6.Text = "Scoreboard";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button2
            // 
            button2.Location = new Point(785, 25);
            button2.Name = "button2";
            button2.Size = new Size(125, 47);
            button2.TabIndex = 10;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(209, 162);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(18, 17);
            checkBox1.TabIndex = 15;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.Visible = false;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(209, 290);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(18, 17);
            checkBox2.TabIndex = 16;
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.Visible = false;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(209, 435);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(18, 17);
            checkBox3.TabIndex = 17;
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.Visible = false;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(751, 162);
            checkBox4.Name = "checkBox4";
            checkBox4.RightToLeft = RightToLeft.Yes;
            checkBox4.Size = new Size(18, 17);
            checkBox4.TabIndex = 20;
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.Visible = false;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(751, 290);
            checkBox5.Name = "checkBox5";
            checkBox5.RightToLeft = RightToLeft.Yes;
            checkBox5.Size = new Size(18, 17);
            checkBox5.TabIndex = 19;
            checkBox5.UseVisualStyleBackColor = true;
            checkBox5.Visible = false;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(751, 435);
            checkBox6.Name = "checkBox6";
            checkBox6.RightToLeft = RightToLeft.Yes;
            checkBox6.Size = new Size(18, 17);
            checkBox6.TabIndex = 18;
            checkBox6.UseVisualStyleBackColor = true;
            checkBox6.Visible = false;
            // 
            // Menu
            // 
            ClientSize = new Size(980, 610);
            Controls.Add(checkBox4);
            Controls.Add(checkBox5);
            Controls.Add(checkBox6);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(listBox4);
            Controls.Add(listBox5);
            Controls.Add(listBox6);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Name = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private ListBox listBox4;
        private ListBox listBox5;
        private ListBox listBox6;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button2;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
    }
}