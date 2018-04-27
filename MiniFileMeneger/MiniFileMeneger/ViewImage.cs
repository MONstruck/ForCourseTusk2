using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace MiniFileMeneger
{
   public class ViewImage
    {
        public string[] format = new string[] { ".jpg", ".png", ".gif", ".swf", ".jpeg", ".ico" };
        public static  bool Check(ListView listView)
        {
            
            ViewImage viewImage = new ViewImage();
            bool check = false;
           string  way = Convert.ToString(listView.SelectedItem);
            if (listView.SelectedItem != null)
            {
                string checkFormat = way.Substring(way.Length - 5);
                for (int i = 0; i < viewImage.format.Length; i++)
                {
                    check = checkFormat.Contains(viewImage.format[i]);
                    if (check)

                    {

                        break;

                    }
                }
            }
            return check;
        }
        public static void Show (ListView listView, Image image)
            {
            string way = Convert.ToString(listView.SelectedItem);
            way = way.Replace('\\', '/');
            
            if (Check(listView) && way != null)
            {
                
                var uriSource = new Uri(way);
                image.Source = new BitmapImage(uriSource);

                image.Visibility = Visibility.Visible;
            }
            else
            {
               
                image.Visibility = Visibility.Hidden;
            }
        }

        

           
        
    }
}
