using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCSharp04_ex6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 레이블과 링크 레이블을 생성합니다.
            Label label = new Label();
            {
                label.Text = "글자";
                label.Location = new Point(10, 10);
            }
            LinkLabel linkLabel = new LinkLabel();
            {
                linkLabel.Text = "글자";
                linkLabel.Location = new Point(10, 50);
            }

            // 요소에 이벤트 연결
            linkLabel.Click += LabelClick;

            // 요소를 화면에 추가
            Controls.Add(label);
            Controls.Add(linkLabel);
        }

        private void LabelClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://hanb.co.kr"); // 웹 페이지로 링크
            // System.Diagnostics.Process.Start("notepad.exe"); // 응용 프로그램으로 링크
        }

    }
}
