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

namespace HelloCSharp02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //프로그램 실행 하면 텍스트 초기화
            label1.Text = "";
            label2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int[] lotto = new int[6];
            for (int i = 0; i < lotto.Length; i++)
            {
                int num = random.Next(45) + 1;
                if (lotto.Contains(num)) // num이 lotto안에 이미 있는 경우
                {
                    i--;
                    continue;
                }
                lotto[i] = num;
            }
            int bns = random.Next(45) + 1;
            while(lotto.Contains(bns))
            {
                bns = random.Next(45) + 1;
            }
            Array.Sort(lotto); // 오름차순정렬
            label1.Text = string.Join(",", lotto);
            label2.Text += " 보너스 번호 : " + bns;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 버튼 클릭시 임시 텍스트 박스가 생성
            TextBox temp = new TextBox();
            temp.Text = "임시 텍스트 박스";
            temp.Location = new Point(100, 100); // 텍스트 박스 위치 지정
            Controls.Add(temp);
            // controls 는 component(button, textbox, label...) 들을 관리
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}