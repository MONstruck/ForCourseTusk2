using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;


namespace CourseMove
{
    public class GlobalValue
    {
        private UInt16 row;
        private UInt16 collumn;
        private double x;
        private double y;

        public UInt16 Row
        {
            get { return row; }
            set {row = value; }
        }
        public UInt16 Collumn
        {
            get { return collumn; }
            set { collumn = value; }
            }
     
        public double X
            {
                get { return x; }
                set { x = value; }
            }
        public double Y
            {
                get { return y; }
                set { y = value; }
            }
    }
}
