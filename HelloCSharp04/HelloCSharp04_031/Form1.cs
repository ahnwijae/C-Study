using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCSharp04_031
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<Product> products = new List<Product>();
            products.Add(new Product() { Name = "고구마", Price = 1000 });
            products.Add(new Product() { Name = "파", Price = 100 });
            products.Add(new Product() { Name = "감자", Price = 500 });
            int i = 0;
            products.Sort();
            foreach (Product product in products)
            {
                Label l = new Label();
                l.Location = new Point(10, 10 + (30) * i);
                //l.Text = product.Name + " : " + product.Price;
                l.Text = product.ToString();
                l.AutoSize = true;
                Controls.Add(l);
                i++;
            }
            i = 0;
            products.Sort();
            foreach (Product product in products)
            {
                Label l = new Label();
                l.Location = new Point(170, 10 + (30) * i);
                l.Text = product.Name + " : " + product.Price;
                l.AutoSize = true;
                Controls.Add(l);
                i++;
            }

            // 다형성 응용하기
            IComparable<Product> p = new Product();
            // 왼쪽 인터페이스 = 오른쪽 클래스(해당 인터페이스를 구현한 클래스)
        }
    }
}
