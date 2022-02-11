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
        public Countdown()
        {
            InitializeComponent();
            timer.Start();
            labelRemainTime.Visible = false;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int totalMinutes = 10;

        private void timer_Tick(object sender, EventArgs e)
        {
            if (totalMinutes > 0)
            {
                totalMinutes--;
                labelTime.Text = totalMinutes + "minutes remaining";
            }
            else
            {
                timer.Stop();
                //labelRemainTime.Visible = false;
                labelTime.Text = "Time is up!";
            }
        }
    }
}
