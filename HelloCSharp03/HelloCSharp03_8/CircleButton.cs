﻿using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCSharp03_8
{
    internal class CircleButton : Button
    {
        // Button 클래스에 있는 OnPaint를 덮어쓰는중
        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath g = new GraphicsPath();
            g.AddEllipse(0,0,ClientSize.Width,ClientSize.Height);
            this.Region = new System.Drawing.Region(g);
            base.OnPaint(pevent);
        }
    }
}
