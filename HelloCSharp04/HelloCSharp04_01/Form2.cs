using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace HelloCSharp04_01
{
    public partial class Form2 : Form
    {
        public Form2()
        {

        }
        public Form2(string txt)
        {
            StartPosition = FormStartPosition.CenterScreen; // 실행시 화면 중앙에 위치시키는 코드
            InitializeComponent();
            if (txt.Equals("red")) // 스트링 비교할때는 equals로 비교
            {
                BackColor = Color.Red;
            }
            else if (txt.Equals("blue"))
            {
                BackColor= Color.Blue;
            }
        }
    }
}
