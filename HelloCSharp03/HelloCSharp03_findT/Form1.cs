using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCSharp03_findT
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        int gold;
        int mytime = 0;
        int LIMIT = 10;
        public Form1()
        {
            InitializeComponent();
            gold = r.Next(30) + 1;
            button1.Text = "1";
            button2.Text = "2";
            button3.Text = "3";
            button4.Text = "4";
            button5.Text = "5";
            button6.Text = "6";
            button7.Text = "7";
            button8.Text = "8";
            button9.Text = "9";
            button10.Text = "10";
            button11.Text = "11";
            button12.Text = "12";
            button13.Text = "13";
            button14.Text = "14";
            button15.Text = "15";
            button16.Text = "16";
            button17.Text = "17";
            button18.Text = "18";
            button19.Text = "19";
            button20.Text = "20";
            button21.Text = "21";
            button22.Text = "22";
            button23.Text = "23";
            button24.Text = "24";
            button25.Text = "25";
            button26.Text = "26";
            button27.Text = "27";
            button28.Text = "28";
            button29.Text = "29";
            button30.Text = "30";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(int.Parse(button1.Text) == gold)
            {
                MessageBox.Show("승리");
                gold = r.Next(30) + 1;
                button1.Text = "1";
            }
            else
            {
                button1.Text = "꽝";
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (int.Parse(button2.Text) == gold)
            {
                MessageBox.Show("승리");
                gold = r.Next(30) + 1;
                button2.Text = "2";
            }
            else
            {
                button2.Text = "꽝";
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (int.Parse(button3.Text) == gold)
            {
                MessageBox.Show("승리");
                gold = r.Next(30) + 1;
                button3.Text = "3";
            }
            else
            {
                button3.Text = "꽝";
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (int.Parse(button4.Text) == gold)
            {
                MessageBox.Show("승리");
                gold = r.Next(30) + 1;
                button4.Text = "4";
            }
            else
            {
                button4.Text = "꽝";
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (int.Parse(button5.Text) == gold)
            {
                MessageBox.Show("승리");
                gold = r.Next(30) + 1;
                button5.Text = "5";
            }
            else
            {
                button5.Text = "꽝";
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (int.Parse(button6.Text) == gold)
            {
                MessageBox.Show("승리");
                gold = r.Next(30) + 1;
                button6.Text = "6";
            }
            else
            {
                button6.Text = "꽝";
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            if (int.Parse(button7.Text) == gold)
            {
                MessageBox.Show("승리");
                gold = r.Next(30) + 1;
                button7.Text = "7";
            }
            else
            {
                button7.Text = "꽝";
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            if (int.Parse(button8.Text) == gold)
            {
                MessageBox.Show("승리");
                gold = r.Next(30) + 1;
                button8.Text = "8";
            }
            else
            {
                button8.Text = "꽝";
            }
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            if (int.Parse(button9.Text) == gold)
            {
                MessageBox.Show("승리");
                gold = r.Next(30) + 1;
                button9.Text = "9";
            }
            else
            {
                button9.Text = "꽝";
            }
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            if (int.Parse(button10.Text) == gold)
            {
                MessageBox.Show("승리");
                gold = r.Next(30) + 1;
                button10.Text = "10";
            }
            else
            {
                button10.Text = "꽝";
            }
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            if (int.Parse(button11.Text) == gold)
            {
                MessageBox.Show("승리");
                gold = r.Next(30) + 1;
                button11.Text = "11";
            }
            else
            {
                button11.Text = "꽝";
            }
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            if (int.Parse(button14.Text) == gold)
            {
                MessageBox.Show("승리");
                gold = r.Next(30) + 1;
                button14.Text = "14";
            }
            else
            {
                button14.Text = "꽝";
            }
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            if (int.Parse(button13.Text) == gold)
            {
                MessageBox.Show("승리");
                gold = r.Next(30) + 1;
                button13.Text = "13";
            }
            else
            {
                button13.Text = "꽝";
            }
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            if (int.Parse(button12.Text) == gold)
            {
                MessageBox.Show("승리");
                gold = r.Next(30) + 1;
                button12.Text = "12";
            }
            else
            {
                button12.Text = "꽝";
            }
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            if (int.Parse(button15.Text) == gold)
            {
                MessageBox.Show("승리");
                gold = r.Next(30) + 1;
                button15.Text = "15";
            }
            else
            {
                button15.Text = "꽝";
            }
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            if (int.Parse(button16.Text) == gold)
            {
                MessageBox.Show("승리");
                gold = r.Next(30) + 1;
                button16.Text = "16";
            }
            else
            {
                button16.Text = "꽝";
            }
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            if (int.Parse(button17.Text) == gold)
            {
                MessageBox.Show("승리");
                gold = r.Next(30) + 1;
                button17.Text = "17";
            }
            else
            {
                button17.Text = "꽝";
            }
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            if (int.Parse(button18.Text) == gold)
            {
                MessageBox.Show("승리");
                gold = r.Next(30) + 1;
                button18.Text = "18";
            }
            else
            {
                button18.Text = "꽝";
            }
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            if (int.Parse(button19.Text) == gold)
            {
                MessageBox.Show("승리");
                gold = r.Next(30) + 1;
                button19.Text = "19";
            }
            else
            {
                button19.Text = "꽝";
            }
        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            if (int.Parse(button20.Text) == gold)
            {
                MessageBox.Show("승리");
                gold = r.Next(30) + 1;
                button20.Text = "20";
            }
            else
            {
                button20.Text = "꽝";
            }
        }

        private void button21_Click_1(object sender, EventArgs e)
        {
            if (int.Parse(button21.Text) == gold)
            {
                MessageBox.Show("승리");
                gold = r.Next(30) + 1;
                button21.Text = "21";
            }
            else
            {
                button21.Text = "꽝";
            }
        }

        private void button22_Click_1(object sender, EventArgs e)
        {
            if (int.Parse(button22.Text) == gold)
            {
                MessageBox.Show("승리");
                gold = r.Next(30) + 1;
                button22.Text = "22";
            }
            else
            {
                button22.Text = "꽝";
            }
        }

        private void button23_Click_1(object sender, EventArgs e)
        {
            if (int.Parse(button23.Text) == gold)
            {
                MessageBox.Show("승리");
                gold = r.Next(30) + 1;
                button23.Text = "23";
            }
            else
            {
                button23.Text = "꽝";
            }
        }

        private void button24_Click_1(object sender, EventArgs e)
        {
            if (int.Parse(button24.Text) == gold)
            {
                MessageBox.Show("승리");
                gold = r.Next(30) + 1;
                button24.Text = "24";
            }
            else
            {
                button24.Text = "꽝";
            }
        }

        private void button25_Click_1(object sender, EventArgs e)
        {
            if (int.Parse(button25.Text) == gold)
            {
                MessageBox.Show("승리");
                gold = r.Next(30) + 1;
                button25.Text = "25";
            }
            else
            {
                button25.Text = "꽝";
            }
        }

        private void button26_Click_1(object sender, EventArgs e)
        {
            if (int.Parse(button26.Text) == gold)
            {
                MessageBox.Show("승리");
                gold = r.Next(30) + 1;
                button26.Text = "26";
            }
            else
            {
                button26.Text = "꽝";
            }
        }

        private void button27_Click_1(object sender, EventArgs e)
        {
            if (int.Parse(button27.Text) == gold)
            {
                MessageBox.Show("승리");
                gold = r.Next(30) + 1;
                button27.Text = "27";
            }
            else
            {
                button27.Text = "꽝";
            }
        }

        private void button28_Click_1(object sender, EventArgs e)
        {
            if (int.Parse(button28.Text) == gold)
            {
                MessageBox.Show("승리");
                gold = r.Next(30) + 1;
                button28.Text = "28";
            }
            else
            {
                button28.Text = "꽝";
            }
        }

        private void button29_Click_1(object sender, EventArgs e)
        {
            if (int.Parse(button29.Text) == gold)
            {
                MessageBox.Show("승리");
                gold = r.Next(30) + 1;
                button29.Text = "29";
            }
            else
            {
                button29.Text = "꽝";
            }
        }

        private void button30_Click_1(object sender, EventArgs e)
        {
            if (int.Parse(button30.Text) == gold)
            {
                MessageBox.Show("승리");
                gold = r.Next(30) + 1;
                button30.Text = "30";
            }
            else
            {
                button30.Text = "꽝";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            mytime++;
            if(mytime >= LIMIT)
            {
                label1.Text = "시간초과";
            }
            
            else
            {
                label1.Text = mytime + "초" + "/" + LIMIT;
            }
        }
    }
}
