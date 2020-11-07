using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace snake1
{
    abstract class shap
    {
        protected int x;
        protected int y;
        protected int H;
        protected int W;
        protected int DX;
        protected int DY;
        protected Graphics G;
        public static Color color;
        protected Panel panel1;
        protected Pen pen;
        public shap(int x,int y,int h,int w)
        {
            this.x = x;
            this.y = y;
            this.W = w;
            this.H = h;
            DX = DY = 3;

        }
        public abstract double area();
        public void setpaint(Panel p1)
        {
            panel1 = p1;
            G = panel1.CreateGraphics();
            pen = new Pen(color);
        }
        public abstract void Draw();
        public void move(shap[] arr)
        {
            int i = 0;
           foreach(shap sh in arr){
               if (sh != null)
               {
                   sh.x += DX;
                   sh.y += DY;
                   sh.pen.Color = color;
                   sh.Draw();
                   arr[i]= junc(sh);
                   i++;
               }
               else
                break;
              
           }
        }
        shap junc(shap sh)
        {
            if (sh.x<=0 || sh.x>=panel1.Width)
                sh.DX*=-1;
            if (sh.y<=0 || sh.y>=panel1.Height)
                sh.DY *= -1;
            return sh;
        }

    }
}
