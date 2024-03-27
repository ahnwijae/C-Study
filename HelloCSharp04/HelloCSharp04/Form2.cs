using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCSharp04
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        // 생성자 오버로딩 적용
        // 커스터마이징 form의 장점
        // label 등의 컴포넌트 자유롭게 배열 가능
        // 텍스트 등의 데이터 등도 전달 가능하다
        public Form2(string text)
        {
            InitializeComponent(); // 필수
            label1.Text = text;
            label2.Text = text;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
