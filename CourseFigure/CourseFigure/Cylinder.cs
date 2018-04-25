using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
namespace CourseFigure
{
  public  class Cylinder:Logic
    {
        private double height;
        
        private double diametr;

        public void inCircle(TextBox height,  TextBox diametr, TextBox diametrWindow)
        {
            this.height = double.Parse(height.Text);
            this.diametr = double.Parse(diametr.Text);
            if ( (CircleInput(this.diametr, double.Parse(diametrWindow.Text)))||
                (CircleInput(Diagonal(this.height, this.diametr), double.Parse(diametrWindow.Text))))

            {
                MessageBox.Show("Cylinder fit in");
            }
            else
            {
                MessageBox.Show("Cylinder not fit");
            }

        }

        public void InRectangle(TextBox height,  TextBox diametr, TextBox widthWindow, TextBox heightWindow)
        {
            this.height = double.Parse(height.Text);
            
            this.diametr = double.Parse(diametr.Text);
            if ((RectangleInput(this.diametr, double.Parse(heightWindow.Text), double.Parse(widthWindow.Text)))||

                (RectangleInput(this.height, double.Parse(heightWindow.Text), double.Parse(widthWindow.Text)) &&
             RectangleInput(this.diametr, double.Parse(heightWindow.Text), double.Parse(widthWindow.Text))) )
                
            {

                MessageBox.Show("Cylinder fit in");
            }
            else
            {
                MessageBox.Show("Cylinder not fit");
            }

        }
    }
}
