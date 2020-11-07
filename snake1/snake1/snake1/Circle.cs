using System;
using System.Collections.Generic;
using System.Text;

namespace snake1
{
    class Circle:shap
    {
        const double pi = Math.PI;
        public Circle(int x,int y,int w)
            : base(x,y,w,w)
        {
        }
        public override double area()
        {
            return pi * Math.Pow(W, 2);
        }
        public override void Draw()
        {
            G.DrawEllipse(pen, x, y, W, H);
        }

    }
}
