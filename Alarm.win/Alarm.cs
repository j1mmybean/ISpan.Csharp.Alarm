using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm.win
{
    public partial class Alarm : Form
    {
        public Alarm()
        {
            InitializeComponent();
            timerInstantTime.Enabled = true;
        }
        int count = 0;
        void Neon()
        {
            if (count % 2 == 0)
                this.BackColor = Color.Red;
            else
                this.BackColor = Color.Black;
        }
        private void timerInstantTime_Tick(object sender, EventArgs e)
        {
            labInstantTime.Text = DateTime.Now.ToString("HH:mm:ss");
            string InstantTime = DateTime.Now.ToString("HH時mm分ss秒");
            if (cbSetAlarm.Checked && mtxtAlarmTime.Text == InstantTime && count < 5)
            {
                count++;
                Neon();
            }
            else if (!cbSetAlarm.Checked)
                this.BackColor = Color.White;
            else
                count = 0;
        }
        private void mtxtAlarmTime_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            mtxtAlarmTime.SelectAll();
        }
    }
}
