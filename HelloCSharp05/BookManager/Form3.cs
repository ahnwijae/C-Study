﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManager
{
    public partial class Form3 : Form
    {
        public Form3()
        {
           InitializeComponent();
            Text = "사용자 관리";

            // 데이터 그리드 설정
            dataGridView1.DataSource = DataManager.Users;
            dataGridView1.CurrentCellChanged += dataGridView1_CurrentCellChanged;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 추가 버튼
            try
            {
                if (DataManager.Users.Exists((x) => x.Id == int.Parse(textBox1.Text)))
                {
                    MessageBox.Show("사용자 ID가 겹칩니다");
                }
                else
                {
                    User user = new User()
                    {
                        Id = int.Parse(textBox1.Text),
                        Name = textBox2.Text
                    };
                    DataManager.Users.Add(user);

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = DataManager.Users;
                    DataManager.Save();
                }
            }
            catch (Exception exception)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 수정 버튼
            try
            {
                User user = DataManager.Users.Single((x) => x.Id == int.Parse(textBox1.Text));
                user.Name = textBox2.Text;

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = DataManager.Users;
            }
            catch (Exception exception)
            {
                MessageBox.Show("존재하지 않는 사용자입니다");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 수정 버튼
            try
            {
                User user = DataManager.Users.Single((x) => x.Id == int.Parse(textBox1.Text));
                DataManager.Users.Remove(user);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = DataManager.Users;
                DataManager.Save();
            }
            catch (Exception exception)
            {
                MessageBox.Show("존재하지 않는 사용자입니다");
            }
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                // 그리드의 셀이 선택되면 텍스트 박스에 글자 지정
                User user = dataGridView1.CurrentRow.DataBoundItem as User;
                textBox1.Text = user.Id.ToString();
                textBox2.Text = user.Name;
            }
            catch (Exception exception)
            {

            }
        }
    }
}
