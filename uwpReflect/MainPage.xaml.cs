using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace uwpReflect
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void test1()
        {
            Status.Text += "\ntest1 method is invoked!";
        }

        private void test2()
        {
            Status.Text += "\ntest2 method is invoked!";
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            Type mytype = this.GetType();
            mytype.GetTypeInfo().GetDeclaredMethod("test1").Invoke(this, null);

            Type type = this.GetType();
            //BindingFlags.Instance表示是实例方法，也就是不是static方法
            MethodInfo Haha = type.GetMethod("test2", BindingFlags.NonPublic | BindingFlags.Instance);
            Haha.Invoke(this, null);

            Status.Text +="\n"+  Directory.GetCurrentDirectory();

        }
    }
}
