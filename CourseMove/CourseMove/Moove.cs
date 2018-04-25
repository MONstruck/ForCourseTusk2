using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace CourseMove
{
    public class Moove 
    {
        public GlobalValue globalValue = new GlobalValue();
        
       public void SetGlobalValues(Image image) {
            globalValue.Collumn = Convert.ToUInt16(Grid.GetColumn(image));
            globalValue.Row = Convert.ToUInt16(Grid.GetRow(image));

        }
        
     public void MoveUp(Image ourImage) {
            if (globalValue.Row != 0)
            {
                Grid.SetColumn(ourImage, globalValue.Collumn);
                Grid.SetRow(ourImage, --globalValue.Row);
                
            }
        }

        public void MoveDown(Image ourImage, Grid grid) {

            if (grid.RowDefinitions.Count > (globalValue.Row+1))
            {
                Grid.SetColumn(ourImage, globalValue.Collumn);
                Grid.SetRow(ourImage, ++globalValue.Row);
            }
        }

        public void MoveLeft(Image ourImage) {
            if (globalValue.Collumn != 0)
            {
                Grid.SetColumn(ourImage, --globalValue.Collumn);
                Grid.SetRow(ourImage, globalValue.Row);
            }
            

        }

        public void MoveRight(Image ourImage, Grid grid) {

            if (grid.ColumnDefinitions.Count > (globalValue.Collumn+1))
            {
                Grid.SetColumn(ourImage, ++globalValue.Collumn);
                Grid.SetRow(ourImage, globalValue.Row);
            }
        }

        public void Swype(Image ourImage, double x, double y, Grid ourGrid) {

            if (x > 0 && y < 50 && y > -50)//left
            {
                MoveLeft(ourImage);
            }
            else if (x < 0 && y < 50 && y > -50)//right
            {
                MoveRight(ourImage, ourGrid);
            }
            else
          if (y > 0 && x < 50 && x > -50)//Up
            {
                MoveUp(ourImage);
            }
            else if (y < 0 && x < 50 && x > -50)//down
            {
                MoveDown(ourImage, ourGrid);
            }
          

        }
    }
       
    }

