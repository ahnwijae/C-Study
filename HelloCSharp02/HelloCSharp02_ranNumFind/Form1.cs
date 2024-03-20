using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCSharp02_ranNumFind
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        static int a;
        public Form1()
        {
            InitializeComponent();
            label1.Text = "숫자를 입력하세요";
            label2.Text = "";
            button1.Text = "제출";
            a = r.Next(100) + 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox1.Text) == a)
            {
                label2.Text = "정답입니다.";
                a = r.Next(100) + 1;
                // MessageBox.Show("정답!");
            }
            else if (int.Parse(textBox1.Text) > a)
            {
                label2.Text = "입력한 숫자가 정답보다 큽니다.";
                // MessageBox.Show("입력한 숫자가 정답보다 큽니다.");
            }
            else
            {
                label2.Text = "입력한 숫자가 정답보다 작습니다.";
                // MessageBox.Show("입력한 숫자가 정답보다 작습니다.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
