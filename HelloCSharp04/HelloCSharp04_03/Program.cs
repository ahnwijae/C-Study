using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCSharp04_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < productlist1.Count; i++)
            {
                Label label = new Label();
                label.Location = new Point(10, 10 + (30 * i));
                label.Text = productlist[i].ToString();
                label.AutoSize = true;
                ControlStyles.Add(label);
            }
        }
    }
}
