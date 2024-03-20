using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCSharp02_ranGame
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        static int a;
        static string b;
        public Form1()
        {
            label1.Text = "가위바위보 시작";
            label2.Text = "";
            label3.Text = "";
            button1.Text = "가위";
            button2.Text = "바위";
            button3.Text = "보";
            a = r.Next(3) + 1; // 컴퓨터도 동시에 내도록
            if(a == 1)
            {
                string b = "가위";
            }
            if(a == 2)
            {
                string b = "바위";
            }
            if (a == 3)
            {
                string b = "보";
            }
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(b == "가위")
            {
                label3.Text = "무승부";
            }
            if(b == "바위")
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
