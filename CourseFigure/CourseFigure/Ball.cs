using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
namespace CourseFigure
{
    public class Ball :Logic
    {
        private double diametr;
        public double Diametr {
            get { return diametr; }
            set { diametr = value; }
        }

       public  void InCircle(TextBox diametr, TextBox diametrWindow) {
           this.diametr = double.Parse(diametr.Text);
            if (CircleInput(this.diametr, double.Parse(diametrWindow.Text)))
            {
                MessageBox.Show("Circle Fit In");
            }
            else {
                MessageBox.Show("Cirle Not Fit");
            }

        }

     public   void InRectangle(TextBox diametr, TextBox height, TextBox width) {
            this.diametr = double.Parse(diametr.Text);
            if (RectangleInput(this.diametr, double.Parse(height.Text), double.Parse(width.Text)))
            {
                MessageBox.Show("Circle Fit In");
            }
            else
            {
                MessageBox.Show("Cirle Not Fit");
            }
        }
    }
}
