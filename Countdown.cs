using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Countdown : Form
    {
        public Countdown(int min,String lab)
        {
            InitializeComponent();
            labelRemainTime.Text = lab;
            totalMinutesF2 = min;
            labelTime.Text = totalMinutesF2 + " minutes remaining";
            timer.Start();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int totalMinutesF2;

        private void timer_Tick(object sender, EventArgs e)
        {
            if (totalMinutesF2 > 1)
            {
                totalMinutesF2--;
                labelTime.Text = totalMinutesF2 + " minutes remaining";
            }
            else
            {
                timer.Stop();
                labelTime.Text = "Time is up!";
            }
        }

        /*
        private void flash_Tick(object sender, EventArgs e)
        {
            /*
            if (labelTime.ForeColor == Color.Black)
                labelTime.ForeColor = Color.Red;
            else //if (labelTime.BackColor == Color.Red)
                labelTime.ForeColor = Color.Black;
            */
          /*  while (totalMinutesF2 >= 5)
            {

                if (labelTime.ForeColor == Color.Black)
                {
                    labelTime.ForeColor = Color.Red;
                    blink.Start();
                    flash.Stop();
                }
            }  
          
        }

        private void blink_Tick(object sender, EventArgs e)
        {*/
            /*
            labelTime.ForeColor = Color.Red;
            */
            /*
            if (labelTime.ForeColor == Color.Red)
            {
                labelTime.ForeColor = Color.Black;
                flash.Start();
                blink.Stop();
            }
        }*/
    }
}
