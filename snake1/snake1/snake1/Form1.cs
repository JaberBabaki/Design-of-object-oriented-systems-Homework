using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace snake1
{
    public partial class Form1 : Form
    {
        shap SHAP;
        shap[] arr;
        int i = 0;
        public Form1()
        {
            InitializeComponent();
            shap.color = Color.Red;
            arr = new shap[10];
            //SHAP = new shap();//Error
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Int32.Parse(textBox1.Text.Trim());
            int y = Int32.Parse(textBox2.Text.Trim());
            int w = Int32.Parse(textBox3.Text.Trim());
            int h = Int32.Parse(textBox4.Text.Trim());
            SHAP = new Circle(x,y,w);
           label8.Text=String.Format("{0:0.000}",SHAP.area());
           SHAP.setpaint(panel1);
           SHAP.Draw();
           arr[i] = SHAP;
           i++;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = Int32.Parse(textBox1.Text.Trim());
            int y = Int32.Parse(textBox2.Text.Trim());
            int w = Int32.Parse(textBox3.Text.Trim());
            int h = Int32.Parse(textBox4.Text.Trim());
            SHAP = new Box(x, y, w,h);
            label8.Text = String.Format("{0:0.000}", SHAP.area());
            SHAP.setpaint(panel1);
            SHAP.Draw();
            arr[i] = SHAP;
            i++;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            shap.color = cd.Color;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SHAP.move(arr);
        }
    }
}
