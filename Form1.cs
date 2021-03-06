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
    public partial class SetUp : Form
    {
        public SetUp()
        {
            InitializeComponent();
        }

        private void SetUp_Load(object sender, EventArgs e)
        {

            for (int i = 0; i<24; i++)
            {
                this.comboBoxHours.Items.Add(i.ToString());
            }
            this.comboBoxHours.SelectedIndex = 0;
            for(int i = 0; i<60; i++)
            {
                this.comboBoxMinutes.Items.Add(i.ToString());
            }
            this.comboBoxMinutes.SelectedIndex = 1;
        }

        private int totalMinutes;
        private int hoursToMinutes;

        private void buttonStart_Click(object sender, EventArgs e)
        {

            hoursToMinutes = int.Parse(this.comboBoxHours.SelectedItem.ToString())*60;
            totalMinutes = hoursToMinutes + int.Parse(this.comboBoxMinutes.SelectedItem.ToString());


            Countdown c = new Countdown(totalMinutes,textBox.Text.ToString());
            c.FormBorderStyle = FormBorderStyle.None;
            c.WindowState = FormWindowState.Maximized;
            c.TopMost = true;

            


            c.ShowDialog();
        }
    }
}
