using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCSharp03_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new CustomForm().Show(); // 버튼 클릭 시 커스텀한 폼 출력
        }

        private void circleButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("test");
        }
    }
}
