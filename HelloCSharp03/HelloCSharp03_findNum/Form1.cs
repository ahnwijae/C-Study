using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCSharp03_findNum
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        int a;
        int mytime = 0;
        const int LIMIT = 10;
        public Form1()
        {
            InitializeComponent();
            a = r.Next(100) + 1;
            Console.WriteLine(a);
            button1.Text = "제출";
            label1.Text = "";
            label2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int answer;
            answer = int.Parse(textBox1.Text);
            if(answer == a)
            {
                label1.Text = "정답입니다";
                a = r.Next(100) + 1;
            }
            else if(answer < a)
            {
                label1.Text = "정답보다 작습니다";
            }
            else
            {
                label1.Text = "정답보다 큽니다";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            mytime++;
            if (mytime >= LIMIT)
            {
                label2.Text = "TimeOver";
            }
            else if(label1.Text == "정답입니다")
            {
                mytime = 0;
            }
            else
                label2.Text = mytime + "/" + LIMIT + "초 경과";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
