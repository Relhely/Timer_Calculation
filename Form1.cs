using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Clock_calculater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            time_in.KeyPress += Time_in_KeyPress;
            //time_in.ImeMode = ImeMode.Alpha;
        }

        public class Globel
        {
            public static int[] total_time = new int[3] { 0, 0, 0 };
            public static int times = 1;
        }
        private void Calculate_time()
        {
            if (time_in.Text.Length == 4)
            {

                int min = 10*(time_in.Text[0]- '0') + (time_in.Text[1] - '0');
                int sec = 10 * (time_in.Text[2] - '0') + (time_in.Text[3] - '0');

                Globel.total_time[1] += min;
                Globel.total_time[2] += sec;

                if (Globel.total_time[2] > 60)
                {
                    Globel.total_time[2] -= 60;
                    Globel.total_time[1]++;
                }
                if (Globel.total_time[1] > 60)
                {
                    Globel.total_time[1] -= 60;
                    Globel.total_time[0]++;
                }

                Outbox.Text += Globel.times + ":";
                Outbox.Text += "輸入時間" + min + ":" + sec + "            ";
                Outbox.Text += "總時間" + Globel.total_time[0] + ":" + Globel.total_time[1] + ":" + Globel.total_time[2] + Environment.NewLine;
                Outbox.Text += "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~" + Environment.NewLine;

                Globel.times++;
            }
        }



        public void Time_in_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                e.Handled = true;
                Calculate_time();
            }
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            Calculate_time();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Outbox.Text = "";
            time_in.Text = "";
            Globel.times = 1;
            for (int i = 0; i < 2; i++) {
                Globel.total_time[i] = 0;
            }
        }

        private void Num0_Click(object sender, EventArgs e)
        {
            time_in.AppendText("0");
        }

        private void Num1_Click(object sender, EventArgs e)
        {
            time_in.AppendText("1");
        }

        private void Num2_Click(object sender, EventArgs e)
        {
            time_in.AppendText("2");
        }

        private void Num3_Click(object sender, EventArgs e)
        {
            time_in.AppendText("3");
        }

        private void Num4_Click(object sender, EventArgs e)
        {
            time_in.AppendText("4");
        }

        private void Num5_Click(object sender, EventArgs e)
        {
            time_in.AppendText("5");
        }

        private void Num6_Click(object sender, EventArgs e)
        {
            time_in.AppendText("6");
        }

        private void Num7_Click(object sender, EventArgs e)
        {
            time_in.AppendText("7");
        }

        private void Num8_Click(object sender, EventArgs e)
        {
            time_in.AppendText("8");
        }

        private void Num9_Click(object sender, EventArgs e)
        {
            time_in.AppendText("9");
        }

        private void Num_enter_Click(object sender, EventArgs e)
        {
            Calculate_time();
        }

        private void pgup_Click(object sender, EventArgs e)
        {

            time_in.Text = time_in.Text.Remove((time_in.Text.Length-1));
        }
    }
}
