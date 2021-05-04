using System;

using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form1 : Form
    {
        
      char who ;
       short movement = 0;
        public Form1()
        {
            InitializeComponent();
             comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }
        void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = comboBox1.SelectedItem.ToString();
           
        }
        private void button10_Click(object sender, EventArgs e)
        {
           
             movement = 0;
            b1.Enabled = true; b1.Text = "";
            b2.Enabled = true; b2.Text = "";
            b3.Enabled = true; b3.Text = "";
            b4.Enabled = true; b4.Text = "";
            b5.Enabled = true; b5.Text = "";
            b6.Enabled = true; b6.Text = "";
            b7.Enabled = true; b7.Text = "";
            b8.Enabled = true; b8.Text = "";
            b9.Enabled = true; b9.Text = "";
          
        }
        private void button_Click(object sender, EventArgs e)
        {
            if (movement < 1)
            {
                switch (comboBox1.Text)
                {
                    case "нолик":
                        who = 'O';
                        break;
                    case "крестик":
                        who = 'X';
                        break;
                }
            }
            Button B =  sender as Button;
            B.Enabled = false;
            if (who == 'O' )
            {
                B.Text = "O";
                if ((b1.Text == b2.Text && b2.Text== b3.Text && b2.Text != "") ||
                    (b4.Text == b5.Text && b5.Text == b6.Text && b5.Text != "") ||
                    (b7.Text == b8.Text && b8.Text == b9.Text && b8.Text != "") ||
                    (b1.Text == b4.Text && b4.Text == b7.Text && b4.Text != "") ||
                    (b2.Text == b5.Text && b5.Text == b8.Text && b5.Text != "") ||
                    (b3.Text == b6.Text && b6.Text == b9.Text && b6.Text != "") ||
                    (b1.Text == b5.Text && b5.Text == b9.Text && b5.Text != "") ||
                    (b3.Text == b5.Text && b5.Text == b7.Text && b5.Text != ""))
                {
                    MessageBox.Show(($"Победил - {who.ToString().ToUpper()}"));
                 
                }
                else if (movement == 8)

                {
                    MessageBox.Show("Победила дружба!");
                }
                who = 'X';
            }
            else if (who == 'X')
            {
                B.Text = "X";
                if ((b1.Text == b2.Text && b2.Text == b3.Text && b2.Text != "") ||
                    (b4.Text == b5.Text && b5.Text == b6.Text && b5.Text != "") ||
                    (b7.Text == b8.Text && b8.Text == b9.Text && b8.Text != "") ||
                    (b1.Text == b4.Text && b4.Text == b7.Text && b4.Text != "") ||
                    (b2.Text == b5.Text && b5.Text == b8.Text && b5.Text != "") ||
                    (b3.Text == b6.Text && b6.Text == b9.Text && b6.Text != "") ||
                    (b1.Text == b5.Text && b5.Text == b9.Text && b5.Text != "") ||
                    (b3.Text == b5.Text && b5.Text == b7.Text && b5.Text != ""))
                {
                    MessageBox.Show(($"Победил - {who.ToString().ToUpper()}"));
                  
                }
              else if (movement == 8)
               

                {
                    MessageBox.Show("Победила дружба!");
                }
                
                who = 'O';
            }
            movement++; 
        }

        
    }
}
