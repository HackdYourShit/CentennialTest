using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
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
using Windows.Data.Xml.Dom;
using Windows.Storage;
using Windows.UI.Notifications;


namespace wpfsavefile
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern uint GetCurrentPackageFullName(ref int length, [param: MarshalAs(UnmanagedType.LPWStr), Out()] out string name);

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        static extern int GetCurrentPackageFullName(ref int packageFullNameLength, ref StringBuilder packageFullName);

        const uint APPMODEL_ERROR_NO_PACKAGE = 15700;
        const uint ERROR_INSUFFICIENT_BUFFER = 122;

        public MainWindow()
        {
            InitializeComponent();
        
            try
            {
                var type = "ApplicationData";
                var prop = "Current";
                if (Windows.Foundation.Metadata.ApiInformation.IsPropertyPresent(type,prop))
                    if (ApplicationData.Current.LocalSettings.Values.ContainsKey("lastfilepath"))
                        label.Content = ApplicationData.Current.LocalSettings.Values["lastfilepath"] ;
               label.Content += Directory.GetCurrentDirectory();

            }
            catch (Exception ex)
            {
                label.Content += ex.GetType() + "\n" + ex.Message ;
            }
           
        }

        private void saveToLocal_Click(object sender, RoutedEventArgs e)
        {
            string fileName = @"c:\output\SomeTextFile" + Guid.NewGuid().ToString() + ".txt";
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

                    string toastStr =
                                    "<toast>" +
                                    "   <visual>" +
                                    "       <binding template = 'ToastGeneric'>" +
                                    "       <image src='ms-appx:///Assets/SplashScreen.png' alt='Splash'/>" +
                                    "          <text>Cool Notification</text>" +
                                    "          <text>Select snooze time.</text>" +
                                    "          </binding>" +
                                    "   </visual>" +
                                    "   <actions>" +
                                    "       <input id = 'snoozeTime' type = 'selection' defaultSelection = '10' >" +
                                    "           <selection id = '1' content = '1 minute' />" +
                                    "           <selection id = '5' content = '5 minutes' />" +
                                    "           <selection id = '10' content = '10 minutes' />" +
                                    "           <selection id = '30' content = '30 minutes' />" +
                                    "           <selection id = '60' content = '1 hour' />" +
                                    "       </input>" +
                                    "       <action activationType = 'system' arguments = 'snooze' hint-inputId = 'snoozeTime' content = '' />" +
                                    "       <action activationType = 'system' arguments = 'dismiss' content = '' />" +
                                    "   </actions>" +
                                    "</toast>";

                    XmlDocument toastXml = new XmlDocument();
                    toastXml.LoadXml(toastStr);

                    ToastNotification toast = new ToastNotification(toastXml);

                    ToastNotificationManager.CreateToastNotifier().Show(toast);

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
      

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Windows.Storage.StorageFolder localCacheFolder = Windows.Storage.ApplicationData.Current.LocalCacheFolder;

            Task.Run(async() => localCacheFolder.CreateFileAsync("dataFile.txt", CreationCollisionOption.ReplaceExisting)).Wait();
            
            label.Content = localCacheFolder.Path;
        }

        private void GetCurrentDirectory_Click(object sender, RoutedEventArgs e)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            label.Content = currentDirectory;

           
        }

        private void CheckIdentity_Click(object sender, RoutedEventArgs e)
        {
            int length = 0;
            StringBuilder name = new StringBuilder();
            int rc = GetCurrentPackageFullName(ref length, ref name);

            if (rc != ERROR_INSUFFICIENT_BUFFER)
            {
                if (rc == APPMODEL_ERROR_NO_PACKAGE)
                    label.Content = "Process has no package identity [15700]\n";
                                   
            }
            else
            {
                label.Content = "GetCurrentPackageFullName got length: " + "\n" + length;
                name = new StringBuilder(length+1);
                GetCurrentPackageFullName(ref length, ref name);
                label.Content += "\n" + name;
            }
        }

        private void CheckIdentity_V2_Click(object sender, RoutedEventArgs e)
        {
            int length = 0;
            String name = "";
            uint rc = GetCurrentPackageFullName( ref length, out name);

            if (rc != ERROR_INSUFFICIENT_BUFFER)
            {
                if (rc == APPMODEL_ERROR_NO_PACKAGE)
                    label.Content = "Process has no package identity [15700]\n";

            }
            else
            {
                label.Content = "GetCurrentPackageFullName got length: " + "\n" + length;
                GetCurrentPackageFullName(ref length, out name);
                label.Content += "\n" + name;
            }
        }
    }
   
}
