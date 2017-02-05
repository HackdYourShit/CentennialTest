using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUWPNuget
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Windows.Storage.StorageFolder localCacheFolder = Windows.Storage.ApplicationData.Current.LocalCacheFolder;
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
                    }
        }
    }
}
