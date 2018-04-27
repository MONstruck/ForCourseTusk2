using System;
using System.Collections.Generic;
using System.Linq;

using System.Windows;
using System.Windows.Controls;

using System.IO;
using System.Windows.Forms;

using System.Text;
using System.Threading.Tasks;


using Microsoft.Office.Interop.Word;
using System.Windows.Media.Imaging;
using System.Windows.Xps.Packaging;





namespace MiniFileMeneger
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : System.Windows.Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            ShowFolder();

        }

        private void Files_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ViewImage.Show(Files, showImage);
           
            ViewDoc.Show(Files, showTxt);
           
        }
        private  void ShowFolder()
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            var directory = folderBrowserDialog.ShowDialog();


            string way = folderBrowserDialog.SelectedPath;


            try
            {
                string[] files = Directory.GetFileSystemEntries(way);
                Files.ItemsSource = files;
            }
            catch { }
        }
    }
}
