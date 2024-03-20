using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCSharp02_ranSen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Text = "생성하기";
            label1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<String> strings = new List<String>();
            strings.Add("안녕");
            strings.Add("hi");
            strings.Add("hello");
            strings.Add("반가워");
            strings.Add("ㅎㅎ");
            strings.Add("ㄴㄴ");

            label1.Text = strings[new Random().Next(strings.Count)];
        }
    }
}
