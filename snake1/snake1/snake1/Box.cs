using System;
using System.Collections.Generic;
using System.Text;

namespace snake1
{
    class Box:shap
    {
        public Box(int x, int y, int w,int h)
            : base(x,y,w,h)
        {
        }
        public override double area()
        {
            return W * H;
        }
        public override void Draw()
        {
            G.DrawRectangle(pen, x, y, W, H);
        }
    }
}
