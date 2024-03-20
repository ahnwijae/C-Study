using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCSharp02_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<Student> students = new List<Student>();
            students.Add(new Student() { name = "이동준", grade = 1 });
            students.Add(new Student() { name = "동준이", grade = 2 });
            students.Add(new Student() { name = "준동이", grade = 3 });
            students.Add(new Student() { name = "준준이", grade = 4 });
            students.Add(new Student() { name = "동동이", grade = 1 });
            students.Add(new Student() { name = "이이이", grade = 2 });

            for(int i = 0; i < students.Count; i++) 
            {
                Label label = new Label(); // 코드상으로 label 생성
                // label의 텍스트 지정
                label.Text = $"{students[i].grade}학년 {students[i].name} 학생";
                label.AutoSize = true; // label크기보다 긴 문장이 들어갈 시 자동으로 크기 조절
                label.Location = new Point(13, 13 + (23 + 3) * i);
                Controls.Add(label); // 화면에 나타내는 코드
            }

            for(int i = students.Count - 1; i>= 0; i--)  
                // 역순으로 지우지 않을 시 배열의 크기가 바뀌어 index에러가 날 수 있음
            {
                if (students[i].grade > 1)
                {
                    students.RemoveAt(i);
                }
            }

            for (int i = 0; i < students.Count;i++) 
            {
                Label label = new Label();
                label.Text = $"{students[i].grade}학년 {students[i].name} 학생";
                label.AutoSize = true; 
                label.Location = new Point(130, 13 + (23 + 3) * i);
                Controls.Add(label);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
