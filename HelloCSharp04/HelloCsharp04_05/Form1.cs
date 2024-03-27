using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCsharp04_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            dataGridView3.Columns[0].HeaderText = "학번";
            dataGridView3.Columns[1].HeaderText = "이름";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 데이터 열을 직접 편집해서 추가했음
            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 클릭 시 데이터 열 생성
            dataGridView2.Columns.Add(textBox3.Text,textBox4.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 클릭 시 데이터 열 생성2
            try
            {
                dataGridView2.Rows.Add(textBox4.Text);
                dataGridView2.Rows.Add(textBox1.Text, textBox4.Text);
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // 데이터 바인딩
            studentBindingSource.Add(new Student() { name = textBox6.Text , hakbeon = textBox7.Text });
        }


        List<Student> students = new List<Student>();
        private void button5_Click(object sender, EventArgs e)
        {
            // 리스트 생성후 데이터 삽입
            students.Add(new Student() { name = textBox9.Text, hakbeon = textBox8.Text , age = int.Parse(textBox10.Text)});
            dataGridView4.DataSource = null;
            dataGridView4.DataSource = students;

        }
    }
}
