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

namespace CourseFigure
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Ball ball = new Ball();
        Cylinder cylinder = new Cylinder();
        Cube cube = new Cube();

        //Ony numbers input
        private static void NonSymbol(KeyEventArgs e)
        {
            var allowed = new[] { Key.D0, Key.D1, Key.D2, Key.D3, Key.D4, Key.D5, Key.D6,
Key.D7, Key.D8, Key.D9, Key.NumPad0, Key.NumPad1, Key.NumPad2, Key.NumPad3, Key.NumPad4,
Key.NumPad5, Key.NumPad6, Key.NumPad7, Key.NumPad8, Key.NumPad9, Key.Back, Key.OemComma};

            if (allowed.Contains(e.Key))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }


        public MainWindow()
        {
            InitializeComponent();
            // Select item
            listTypesFigure.SelectedItem = Ball;
            listWindowType.SelectedItem = Circle;
        }



        TextBox TextBox = new TextBox();

        private void Cube_Selected(object sender, RoutedEventArgs e)
        {
            figureType.Content = "You select cube";

            figureParamOne.Content = "First parametr input Figure";

            var uriSource = new Uri("/Resourses/Cube.png", UriKind.Relative);

            figureParamTwo.Visibility = Visibility.Visible;
            figureParamThree.Visibility = Visibility.Visible;

            secondParametrInputFigure.Visibility = Visibility.Visible;
            thridParametrInputFigure.Visibility = Visibility.Visible;

            figureImage.Source = new BitmapImage(uriSource);
        }

        private void Ball_Selected(object sender, RoutedEventArgs e)
        {
            figureType.Content = "You select ball";
            figureParamOne.Content = "Diameter";
            var uriSource = new Uri("/Resourses/Ball.png", UriKind.Relative);

            figureImage.Source = new BitmapImage(uriSource);

            figureParamTwo.Visibility = Visibility.Hidden;
            figureParamThree.Visibility = Visibility.Hidden;

            secondParametrInputFigure.Visibility = Visibility.Hidden;
            thridParametrInputFigure.Visibility = Visibility.Hidden;
        }

        private void Cylinder_Selected(object sender, RoutedEventArgs e)
        {
            figureType.Content = "You select cylinder";
            figureParamOne.Content = "Second parametr input Figure";

            var uriSource = new Uri("/Resourses/Cylinder.png", UriKind.Relative);

            figureParamTwo.Visibility = Visibility.Visible;
            figureParamThree.Visibility = Visibility.Hidden;


            figureImage.Source = new BitmapImage(uriSource);
            secondParametrInputFigure.Visibility = Visibility.Visible;
            thridParametrInputFigure.Visibility = Visibility.Hidden;
        }

        private void Circle_Selected(object sender, RoutedEventArgs e)
        {
            windowType.Content = "You select Circle Window";
            secondParametrWindow.Visibility = Visibility.Hidden;

            windowParamOne.Content = "Diameter";

            windowParamTwo.Visibility = Visibility.Hidden;

            var uriSource = new Uri("/Resourses/Circle.jpg", UriKind.Relative);


            windowImage.Source = new BitmapImage(uriSource);

        }

        private void Rectangle_Selected(object sender, RoutedEventArgs e)
        {
            windowType.Content = "You select Rectangle Window";

            windowParamOne.Content = "First parametr window";

            windowParamTwo.Visibility = Visibility.Visible;

            var uriSource = new Uri("/Resourses/Rectangle.gif", UriKind.Relative);

            secondParametrWindow.Visibility = Visibility.Visible;
            windowImage.Source = new BitmapImage(uriSource);


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Rectangle.IsSelected && Cube.IsSelected)
            {
                cube.InRectangle(firstParametrInputFigure, secondParametrInputFigure, thridParametrInputFigure, firstParametrWindow, secondParametrWindow);
            }
            else if (Rectangle.IsSelected && Ball.IsSelected)
            {
                ball.InRectangle(firstParametrInputFigure, firstParametrWindow, secondParametrWindow);
            }
            else if (Rectangle.IsSelected && Cylinder.IsSelected)
            {

                cylinder.InRectangle(firstParametrInputFigure, secondParametrInputFigure, firstParametrWindow, secondParametrWindow);
            }
            else if (Circle.IsSelected && Cube.IsSelected)
            {
                cube.inCircle(firstParametrInputFigure, secondParametrInputFigure, thridParametrInputFigure, firstParametrWindow);
            }
            else if (Circle.IsSelected && Ball.IsSelected)
            {
                ball.InCircle(firstParametrInputFigure, firstParametrWindow);
            }
            else if (Circle.IsSelected && Cylinder.IsSelected)
            {
                cylinder.inCircle(firstParametrInputFigure, secondParametrInputFigure, firstParametrWindow);
            }
        }

     

        private void firstParametrInputFigure_KeyDown(object sender, KeyEventArgs e)
        {
            NonSymbol(e);
        }

        private void secondParametrInputFigure_KeyDown(object sender, KeyEventArgs e)
        {
            NonSymbol(e);
        }

        private void thridParametrInputFigure_KeyDown(object sender, KeyEventArgs e)
        {
            NonSymbol(e);
        }

        private void firstParametrWindow_KeyDown(object sender, KeyEventArgs e)
        {
            NonSymbol(e);
        }

        private void secondParametrWindow_KeyDown(object sender, KeyEventArgs e)
        {
            NonSymbol(e);
        }
    }

}
