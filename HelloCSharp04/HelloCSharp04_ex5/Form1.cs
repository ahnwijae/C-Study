using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCSharp04_ex5
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            button1.Text = "파일에 적기";
            label1.Text = "경로";
            button2.Text = "파일에서 읽기";
            label_readText.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string directory1 = "c:\\test\\test1.txt";
            string directory2 = @"c:\test\test2.txt";

            File.WriteAllText(textBox_directory.Text, textBox_contents.Text);
            File.WriteAllText(directory1, textBox_contents.Text);
            File.WriteAllText(directory2, textBox_contents.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 스트림으로 쓰기

            /*            using (StreamWriter writer = new StreamWriter(textBox_directory.Text))
                        {
                            writer.WriteLine("C# 과목");
                            writer.WriteLine("정말 매");
                            writer.WriteLine("우 재미있습니다.");

                            for (int i = 0;i<10;i++)
                            {
                                writer.WriteLine($"프로그래밍이 재미있습니다. - {i + 1}");
                            }
                        }
                        label_readText.Text = File.ReadAllText(textBox_directory.Text);*/

            // 스트림으로 읽기
            label_readText.Text = "";
            using (StreamReader reader = new StreamReader(textBox_directory.Text))
            {
                string line;
                while((line = reader.ReadLine()) != null) // 한 줄씩 읽는 코드
                {
                    label_readText.Text += line + Environment.NewLine; // 한 줄씩 읽고 label에 쓴다
                }
            }

        }
        

        
    }
}
