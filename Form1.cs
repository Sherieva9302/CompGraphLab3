using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //построение кривой Безье второго порядка
        public void curve3(Graphics graphic, Pen pen)
        {
            float x, y, x_, y_;
            int x1 = int.Parse(textBox1.Text);
            int y1 = int.Parse(textBox2.Text);
            int x2 = int.Parse(textBox3.Text);
            int y2 = int.Parse(textBox4.Text);
            int x3 = int.Parse(textBox5.Text);
            int y3 = int.Parse(textBox6.Text);
            x = x1;
            y = y1;
            for (float t = 0; t < 1; t += 0.0005f)
            {
                x_ = (1 - t) * (1 - t) * x1 + 2 * t * (1 - t) * x2 + t * t * x3;
                y_ = (1 - t) * (1 - t) * y1 + 2 * t * (1 - t) * y2 + t * t * y3;
                graphic.DrawLine(pen, x, y, x_, y_);
                x = x_;
                y = y_;
            }
        }

        //построение кривой Безье третьего порядка
        public void curve4(Graphics graphic, Pen pen)
        {
            float x, y, x_, y_;
            int x1 = int.Parse(textBox1.Text);
            int y1 = int.Parse(textBox2.Text);
            int x2 = int.Parse(textBox3.Text);
            int y2 = int.Parse(textBox4.Text);
            int x3 = int.Parse(textBox5.Text);
            int y3 = int.Parse(textBox6.Text);
            int x4 = int.Parse(textBox7.Text);
            int y4 = int.Parse(textBox8.Text);
            x = x1;
            y = y1;
            for (float t = 0; t < 1; t += 0.0005f)
            {
                x_ = (1 - t) * (1 - t) * (1 - t) * x1 + 3 * t * (1 - t) * (1 - t) * x2 +
                3 * t * t * (1 - t) * x3 + t * t * t * x4;
                y_ = (1 - t) * (1 - t) * (1 - t) * y1 + 3 * t * (1 - t) * (1 - t) * y2 +
                3 * t * t * (1 - t) * y3 + t * t * t * y4; ;
                graphic.DrawLine(pen, x, y, x_, y_);
                x = x_;
                y = y_;
            }
        }

        //построение кривой Безье четвертого порядка
        public void curve5(Graphics graphic, Pen pen)
        {
            float x, y, x_, y_;
            int x1 = int.Parse(textBox1.Text);
            int y1 = int.Parse(textBox2.Text);
            int x2 = int.Parse(textBox3.Text);
            int y2 = int.Parse(textBox4.Text);
            int x3 = int.Parse(textBox5.Text);
            int y3 = int.Parse(textBox6.Text);
            int x4 = int.Parse(textBox7.Text);
            int y4 = int.Parse(textBox8.Text);
            int x5 = int.Parse(textBox9.Text);
            int y5 = int.Parse(textBox10.Text);
            x = x1;
            y = y1;

            for (float t = 0; t < 1; t += 0.0005f)
            {
               x_ = (1 - t) * (1 - t) * (1 - t) * (1 - t) * x1 + 4 * t * (1 - t) * (1 -
               t) * (1 - t) * x2
                + 6 * t * t * (1 - t) * (1 - t) * x3 + 4 * t * t * t * (1 - t) * x4 +
               t * t * t * t * x5;
               y_ = (1 - t) * (1 - t) * (1 - t) * (1 - t) * y1 + 4 * t * (1 - t) * (1 -
               t) * (1 - t) * y2 + 6 * t * t * (1 - t) * (1 - t) * y3 + 4 * t * t * t * (1 - t) * y4 +
               t * t * t * t * y5;
               graphic.DrawLine(pen, x, y, x_, y_);
               x = x_;
               y = y_;
            }

        }
        public void Draw(Graphics graphic, Pen pen)
        {
            
            if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "") ||
                (textBox4.Text == "") || (textBox5.Text == "") || (textBox6.Text == ""))
                MessageBox.Show("Недостаточно точек для построения кривой Безье второго порядка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                if ((textBox7.Text == "")||(textBox8.Text == ""))
                    curve3(graphic, pen);
                else
                    if ((textBox9.Text == "") || (textBox10.Text == ""))
                        curve4(graphic, pen);
                    else
                        curve5(graphic, pen);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Graphics graphic = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Green);
            
            graphic.Clear(Color.Black);
            Draw(graphic, pen);
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = ""; 
            textBox10.Text = "";

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
