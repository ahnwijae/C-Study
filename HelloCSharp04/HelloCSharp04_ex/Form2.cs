﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCSharp04_ex
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string txt)
        {
            InitializeComponent();
            if (txt == "red")
            {
                BackColor = Color.Red;
            }
            else if(txt == "blue")
            {
                BackColor= Color.Blue;
            }
            else
            {
                BackColor = Control.DefaultBackColor;
            }
        }
    }
}
