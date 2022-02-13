using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Media;

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
            if (totalMinutesF2 != 0)
            {
                string mess = "Are you sure you want to close timer? ";
                string caption = "Warinig!";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;

                DialogResult r;

                r = MessageBox.Show(mess, caption, buttons);

                if (r == System.Windows.Forms.DialogResult.Yes)
                    this.Close();
            }
            else
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
                --totalMinutesF2;
                
                timer.Stop();
                
                labelTime.Text = "Time is up!";
                SystemSounds.Exclamation.Play();

                //SystemSounds.Beep.Play();
            }
        }

       
        private void flash_Tick(object sender, EventArgs e)
        {
            /*
            if (totalMinutesF2 <= 5)
            {
                Random random = new Random();
                int a = random.Next(0, 255);
                int b = random.Next(0, 255);
                int c = random.Next(0, 255);

                labelTime.ForeColor = System.Drawing.Color.FromArgb(a, b, c);

            }
            */
        }

        private void blink_Tick(object sender, EventArgs e)
        {
            if (totalMinutesF2 <= 5)
            {

                if (labelTime.ForeColor == Color.Black)
                    labelTime.ForeColor = Color.Red;
                else
                    labelTime.ForeColor = Color.Black;
            }
        }
    }
}
