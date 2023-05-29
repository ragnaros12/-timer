using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Таймер
{
    public partial class Form1 : Form
    {
        int secTime = 0;
        int Msec = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Zapusk_S_Click(object sender, EventArgs e)
        {
            timerSec.Start();
        }

        private void timerSec_Tick(object sender, EventArgs e)
        {
            Msec += 1;
            Sec_S.Text = Convert.ToString(Msec / 100 % 60);
            if (checkChas.Checked == true)
            {
                Chas.Text = Convert.ToString(Msec / 100 / 60 / 60);
            }
            if (MSec.Checked == true)
            {
                MelSec.Text = Convert.ToString(Msec % 1000);
            }
            Min_S.Text = Convert.ToString(Msec / 100 / 60 % 60);
        }

        private void Stop_S_Click(object sender, EventArgs e)
        {
            timerSec.Stop();
        }

        private void Zapis_Click(object sender, EventArgs e)
        {
            Vevod.Text += Convert.ToString(Chas.Text) + ":" + Convert.ToString(Min_S.Text) + ":" + Convert.ToString(Sec_S.Text) + ":" + Convert.ToString(MelSec.Text) + "\r\n";
        }

        private void Sbros_Click(object sender, EventArgs e)
        {
            Msec = 0;
            Chas.Text = "0";
            Min_S.Text = "0";
            Sec_S.Text = "0";
            MelSec.Text = "0";
            timerSec.Stop();
        }

        private void Ochistit_Click(object sender, EventArgs e)
        {
            Vevod.Text = " ";
        }

        private void Zapusk_T_Click(object sender, EventArgs e)
        {
            if (secTime == 0)
            {
                secTime = Convert.ToInt32(Min_T.Text) * 60 + Convert.ToInt32(Sec_T.Text);
            }
            timerTay.Start();
        }

        private void timerTay_Tick(object sender, EventArgs e)
        {
            secTime--;
            Min_T.Text = Convert.ToString(secTime / 60);
            Sec_T.Text = Convert.ToString(secTime % 60);
            if (secTime == 0)
            {
                timerTay.Stop();
                MessageBox.Show("Время вышло");
            }
        }

        private void Del_Click(object sender, EventArgs e)
        {
            timerTay.Stop();
            secTime = 0;
            Min_T.Text = "0";
            Sec_T.Text = "0";
        }

        private void Stop_T_Click(object sender, EventArgs e)
        {
            timerTay.Stop();
        }

        private void timerBud_Tick(object sender, EventArgs e)
        {
            label10.Text = DateTime.Now.ToString("HH:mm:ss");
            checkTime(maskedTextBox1, DateTime.Now);
            checkTime(maskedTextBox2, DateTime.Now);
            checkTime(maskedTextBox4, DateTime.Now);
        }

        public void checkTime(MaskedTextBox text, DateTime time)
        {
            if (text.Text.Length != 8)
                return;

            DateTime bud = DateTime.ParseExact(text.Text, "HH:mm:ss", CultureInfo.InvariantCulture);

            if(time >= bud)
            {
                text.Text = "";
                MessageBox.Show("Пора вставать");
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            timerBud.Enabled = !timerBud.Enabled;
            if (timerBud.Enabled)
            {
                Start.Text = "Закончить";
            }
            else
            {
                Start.Text = "Начать";
            }
        }
    }
}
