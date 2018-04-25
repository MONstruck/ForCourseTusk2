using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace CourseFigure
{
   public  class Logic
    {
        //klass with math logic
      
        protected static bool RectangleInput(double length, double widthWindow, double heightWindow)
        {

            if (length < widthWindow || length < heightWindow)
            {
                return true;
            }
            else
            {
                return false;
            }



        }
        protected static bool CircleInput(double length, double diametr)
        {

            if (length < diametr )
            {
                return true;
            }
            else
            {
                return false;
            }



        }

        protected static double Diagonal(double height, double width)
{
            double diagonal;
            diagonal = Math.Sqrt(Math.Pow(height, 2) + Math.Pow(width, 2));
            return diagonal;

        }
       

    }
}
