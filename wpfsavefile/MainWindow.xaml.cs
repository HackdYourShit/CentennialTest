using System;
using System.Collections.Generic;
using System.IO;
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
using Windows;
using Windows.Storage;

namespace wpfsavefile
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            try
            {
                if (ApplicationData.Current.LocalSettings.Values.ContainsKey("lastfilepath"))
                    label.Content = ApplicationData.Current.LocalSettings.Values["lastfilepath"] ;
            }
            catch(Exception ex)
            {
                label.Content = ex.Message;
            }
        }

        private void saveToLocal_Click(object sender, RoutedEventArgs e)
        {
            string fileName = @"F:\Output\SomeTextFile" + Guid.NewGuid().ToString() + ".txt";
            try
            {
                using (StreamWriter sw = new StreamWriter(fileName))
                {
                    sw.Write("Writing Text ");
                    sw.WriteLine("Here we go.");
                    sw.WriteLine("-------------------");
                    sw.Write("Today is is: " + DateTime.Now);
                    sw.WriteLine("Done");
                    label.Content = fileName;
                    ApplicationData.Current.LocalSettings.Values["lastfilepath"] = label.Content;
                }
            }
            catch (Exception ex)
            {
                label.Content = ex.Message;
            }
            
        }
        
        private void saveToUserLocal_Click(object sender, RoutedEventArgs e)
        {
            var pathWithEnv = @"%USERPROFILE%\AppData\Local\wpfsavefileApp";
            var filePath = Environment.ExpandEnvironmentVariables(pathWithEnv);

            // If directory does not exist, create it. 
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }

            var fileName = filePath + @"\test" + Guid.NewGuid().ToString() + ".txt"; 
            try
            {
                using (StreamWriter sw = new StreamWriter(fileName))
                {
                    sw.Write("Writing Text ");
                    sw.WriteLine("Here we go.");
                    sw.WriteLine("-------------------");
                    sw.Write("Today is is: " + DateTime.Now);
                    sw.WriteLine("Done");
                    label.Content = fileName;

                    ApplicationData.Current.LocalSettings.Values["lastfilepath"] = label.Content;

                }
            }
            catch(Exception ex)
            {
                label.Content = ex.Message;

            }
        }
    }
   
}
