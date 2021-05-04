<<<<<<< HEAD
﻿using System;

using System.Drawing;

using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        //2 способа
        int x = 0;
        int  y = 0;
        int  w = 134;
       
        int countLabel = 1;
        int countButton = 1;
        int countTextBox = 1;
        public Form1()
        {
            InitializeComponent();
            Color color = Color.FromArgb(245, 222, 179);
            this.BackColor = color;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //получаем ссылку на кнопку, на которую мы нажали
            Button b = (Button)sender;
            //Создаем новую кнопку
            Button temp = new Button();

            temp.Text = "КОПИЯ";
            temp.Size = b.Size;
            
            temp.BackColor = b.BackColor;
            temp.ForeColor = b.ForeColor;
            temp.Font = b.Font;
            
            //Размещаем ее правее (на 10px) кнопки, на которую мы нажали
            temp.Location = new Point(b.Location.X + b.Width + 10, b.Location.Y);
           
            //Добавляем событие нажатия на новую кнопку 
            //(то же что и при нажатии на исходную)
             temp.Click += new EventHandler(button1_Click);
            //Добавляем элемент на форму
            this.Controls.Add(temp);
           //считаем сколько элементов
            countButton++;
            label6.Text = Convert.ToString(countButton);
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Label b = (Label) sender;
            Label lbl1 = new Label();
           
            
            lbl1.Location = new Point(b.Location.X + b.Width + 100, b.Location.Y);

            lbl1.Text = "КОПИЯ";
            lbl1.BackColor = b.BackColor;
            lbl1.ForeColor = b.ForeColor;
            lbl1.Font = b.Font;
            
            Controls.Add(lbl1);
            lbl1.Click += new System.EventHandler(label1_Click);
           
            countLabel++;
            label5.Text = Convert.ToString(countLabel);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            TextBox b = (TextBox)sender;
            TextBox textBox = new TextBox();
            textBox.Parent = this;
          // TextBox.Location= new Point(x,140);
            textBox.Location= new Point(b.Location.X+x + b.Width + w, b.Location.Y);
           // textBox.Size = new Size(w,h);
            textBox.Size = b.Size;
            textBox.BackColor= b.BackColor;
           
            x = x + 10;
            y = y + 20; 
            w = w + 100; 


            countTextBox++;
            label7.Text = Convert.ToString(countTextBox);
        }
    }
}
=======
﻿using System;

using System.Drawing;

using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        //2 способа
        int x = 0;
        int  y = 0;
        int  w = 134;
       
        int countLabel = 1;
        int countButton = 1;
        int countTextBox = 1;
        public Form1()
        {
            InitializeComponent();
            Color color = Color.FromArgb(245, 222, 179);
            this.BackColor = color;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //получаем ссылку на кнопку, на которую мы нажали
            Button b = (Button)sender;
            //Создаем новую кнопку
            Button temp = new Button();

            temp.Text = "КОПИЯ";
            temp.Size = b.Size;
            
            temp.BackColor = b.BackColor;
            temp.ForeColor = b.ForeColor;
            temp.Font = b.Font;
            
            //Размещаем ее правее (на 10px) кнопки, на которую мы нажали
            temp.Location = new Point(b.Location.X + b.Width + 10, b.Location.Y);
           
            //Добавляем событие нажатия на новую кнопку 
            //(то же что и при нажатии на исходную)
             temp.Click += new EventHandler(button1_Click);
            //Добавляем элемент на форму
            this.Controls.Add(temp);
           //считаем сколько элементов
            countButton++;
            label6.Text = Convert.ToString(countButton);
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Label b = (Label) sender;
            Label lbl1 = new Label();
           
            
            lbl1.Location = new Point(b.Location.X + b.Width + 100, b.Location.Y);

            lbl1.Text = "КОПИЯ";
            lbl1.BackColor = b.BackColor;
            lbl1.ForeColor = b.ForeColor;
            lbl1.Font = b.Font;
            
            Controls.Add(lbl1);
            lbl1.Click += new System.EventHandler(label1_Click);
           
            countLabel++;
            label5.Text = Convert.ToString(countLabel);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            TextBox b = (TextBox)sender;
            TextBox textBox = new TextBox();
            textBox.Parent = this;
          // TextBox.Location= new Point(x,140);
            textBox.Location= new Point(b.Location.X+x + b.Width + w, b.Location.Y);
           // textBox.Size = new Size(w,h);
            textBox.Size = b.Size;
            textBox.BackColor= b.BackColor;
           
            x = x + 10;
            y = y + 20; 
            w = w + 100; 


            countTextBox++;
            label7.Text = Convert.ToString(countTextBox);
        }
    }
}
>>>>>>> 83612dc093834b5e7df9a30590d774f478d2aa22
