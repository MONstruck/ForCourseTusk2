using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Microsoft.Office.Interop.Word;
using System.Windows.Media.Imaging;
using System.Windows.Xps.Packaging;
using System.Windows.Controls;
using System.Windows;

namespace MiniFileMeneger
{
    class ViewDoc
    {
    
        /*  Microsoft.Office.Interop.Word.Application
                  wordApplication = new Microsoft.Office.Interop.Word.Application();
          Document doc = new Document();
          public  XpsDocument ConvertWordDocToXPSDoc(string wordDocName, string xpsDocName)
          {

              wordApplication.Documents.Add(wordDocName);


              try
              {
                  doc = wordApplication.ActiveDocument;
                  doc.SaveAs(xpsDocName, WdSaveFormat.wdFormatXPS);


                  XpsDocument xpsDoc = new XpsDocument(xpsDocName, System.IO.FileAccess.Read);
                  return xpsDoc;
              }
              catch (Exception exp)
              {
                  MessageBox.Show(Convert.ToString(exp));
              }
              return null;
          }*/
          public string format = ".txt" ;
          public static bool Check(ListView listView)
          {

              ViewDoc viewDoc = new ViewDoc();
              bool check = false;
              string way = Convert.ToString(listView.SelectedItem);
            if (listView.SelectedItem != null)
            {
                string checkFormat = way.Substring(way.Length - 5);

                check = checkFormat.Contains(viewDoc.format);

                return check;
            }
            return check;
          }
          public static void Show(ListView listView, TextBox textBox)
          {

              ViewDoc viewDoc = new ViewDoc();
              string way = Convert.ToString(listView.SelectedItem);
              way = way.Replace('\\', '/');
             
              if (Check(listView) && way != null)
              {

                textBox.Visibility = Visibility.Visible;
                textBox.Text = File.ReadAllText(way);
                     
              }
              else{ 
            //  Delete(Convert.ToString(newXPSDocumentName));
            textBox.Visibility = Visibility.Hidden;
              }
         /* public static void Delete(string file)
          {
              File.Delete(file);
          }*/
          }


    }

    }

