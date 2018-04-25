using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace CourseFigure
{
    public class Cube : Logic
    {

        private double height;
        private double width;
        private double length;
        public void inCircle(TextBox height, TextBox width, TextBox lenght, TextBox diametrWindow)
        {
            this.height = double.Parse(height.Text);
            this.width = double.Parse(width.Text);
            this.length = double.Parse(lenght.Text);
            if (CircleInput(Diagonal(this.width, this.height), double.Parse(diametrWindow.Text)) ||
               CircleInput(Diagonal(this.width, this.length), double.Parse(diametrWindow.Text)) ||
               CircleInput(Diagonal(this.length, this.height), double.Parse(diametrWindow.Text)))
            {
                MessageBox.Show("Cube fit in");
            }
            else
            {
                MessageBox.Show("Cube not fit");
            }

        }

        public void InRectangle(TextBox height, TextBox width, TextBox lenght, TextBox widthWindow, TextBox heightWindow)
        {
            this.height = double.Parse(height.Text);
            this.width = double.Parse(width.Text);
            this.length = double.Parse(lenght.Text);
            if ((RectangleInput(this.height, double.Parse(heightWindow.Text), double.Parse(widthWindow.Text))) &&
             (RectangleInput(this.width, double.Parse(heightWindow.Text), double.Parse(widthWindow.Text))) ||
                  (RectangleInput(this.width, double.Parse(heightWindow.Text), double.Parse(widthWindow.Text)) &&
                 RectangleInput(this.length, double.Parse(heightWindow.Text), double.Parse(widthWindow.Text))) ||
                  (RectangleInput(this.height, double.Parse(heightWindow.Text), double.Parse(widthWindow.Text)) &&
                  RectangleInput(this.length, double.Parse(heightWindow.Text), double.Parse(widthWindow.Text))))
            {

                MessageBox.Show("Cube fit in");
            }
            else
            {
                MessageBox.Show("Cube not fit");
            }

        }
    }
}