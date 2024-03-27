using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCSharp04_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = "";
            foreach(var item in Controls)
            {
                if(item is RadioButton)
                {
                    if((item as RadioButton).Checked)
                    {
                        text += (item as RadioButton).Text;
                    }
                }
            }
            MessageBox.Show(textBox1.Text + "님 : " + text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string test = "";
            foreach(var item in Controls)
            {
                if(item is GroupBox) // GroupBox 1
                {
                    foreach(var innerItem in (item as GroupBox).Controls)
                    {
                        if(innerItem is GroupBox) // GroupBox 2, GroupBox3
                        {
                            foreach(var inItem in (innerItem as GroupBox).Controls)
                            {
                                if(inItem is RadioButton) // 라디오버튼이면
                                {
                                    if((inItem as RadioButton).Checked) // 버튼이 체크되어있으면
                                    { 
                                    test += (inItem as RadioButton).Text + " "; // test에 저장
                                    }
                                }
                            }
                        }
                    }
                }
            }
            MessageBox.Show(textBox2.Text+"님: " + test);
        }
    }
}
