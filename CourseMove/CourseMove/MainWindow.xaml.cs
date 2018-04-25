using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
namespace CourseMove
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        
           
        public   Moove moove = new Moove();
        GlobalValue globalValue = new GlobalValue();

        public MainWindow()
        {
            InitializeComponent();
            moove.SetGlobalValues(ourImage);
            MessageBox.Show("To move the picture you can use the keys WASD, or 'swipe' with the mouse. To call this help, press F1");
        }

 
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            
            switch (e.Key)
            {
                case Key.W:
                    moove.MoveUp(ourImage);
                    break;
                case Key.A:
                    moove.MoveLeft(ourImage);
                    break;
                case Key.S:
                    moove.MoveDown(ourImage,ourGrid);
                    break;
                case Key.D:
                    moove.MoveRight(ourImage,ourGrid);
                    break;
                case Key.F1:
                    MessageBox.Show("To move the picture you can use the keys WASD, or 'swipe' with the mouse. To call this help, press F1");
                    break;

            }
        }

     

      
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            globalValue.X = e.GetPosition(null).X;
            globalValue.Y = e.GetPosition(null).Y;
            
        }

        private void Window_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            
            
            globalValue.Y = globalValue.Y - e.GetPosition(null).Y;
            globalValue.X = globalValue.X - e.GetPosition(null).X;
            moove.Swype(ourImage, globalValue.X, globalValue.Y,ourGrid);

        }

    }
}
