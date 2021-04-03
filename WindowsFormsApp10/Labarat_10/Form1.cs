using System;

using System.Windows.Forms;

namespace Labarat_10
{
    public partial class Form1 : Form
    {
       
        int hour, minute, second ;
        
        public Form1()
        {
            InitializeComponent();
           
        }

        private void timer1_Tick(object sender, EventArgs e)//++
        {
            string time_h = "";
            string time_m = "";
            string time_s = "";
            second = second -1;
            if (second == -1)
            {
                if(minute>0)
                minute=minute-1;
                second = 59;
            }
        
            if (minute == -1)
            {
                
                hour= hour-1;
                minute = 59;
            }
            if (hour < 10)
            {
                time_h = "0" + hour;
                label1.Text = Convert.ToString(time_h);
            }
            else label1.Text = Convert.ToString(hour);

            if (minute < 10)
            {
                time_m += "0" + minute;
                label2.Text = Convert.ToString(time_m);
            }
            else label2.Text = Convert.ToString(minute);
            if (second < 10)
            {
                time_s += "0" + second;
                label3.Text = Convert.ToString(time_s);
            }
            else label3.Text = Convert.ToString(second);




            if (hour==0 && minute==0 && second == 0)
            {
                timer1.Stop();
                MessageBox.Show("Time's up!");
            }
          
           

            


        }


        private void Start_Click(object sender, EventArgs e)//++
        {
            hour = Convert.ToInt32(textBox1.Text);
            minute = Convert.ToInt32(textBox2.Text);
            second = Convert.ToInt32(textBox3.Text);
            
            timer1.Start();
            
            if (hour == 0 && minute == 0 && second == 0)
            {
                timer1.Stop();
                MessageBox.Show("The timer value is not set!");
            }
            
           


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Tick += new EventHandler(timer_Tick);
        }
        void timer_Tick(object sender, EventArgs e)
        {
            label9.Text ="Date: "+ DateTime.Now.ToShortDateString() + " AND Time: " + DateTime.Now.ToLongTimeString();
           
        }

        private void Stop_Click(object sender, EventArgs e)//++
        {
            timer1.Stop();
            hour = Convert.ToInt32(label1.Text);
            minute = Convert.ToInt32(label2.Text);
            second = Convert.ToInt32(label3.Text);
            textBox1.Text = hour.ToString();
            textBox2.Text = minute.ToString();
            textBox3.Text = second.ToString();

        }

        private void Reset_Click(object sender, EventArgs e)//++
        {
            timer1.Stop();
            label1.Text = "00";
            label2.Text = "00";
            label3.Text = "00";
        }
    }
}
