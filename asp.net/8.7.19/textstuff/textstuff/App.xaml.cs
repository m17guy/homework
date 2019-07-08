using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace textstuff
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup_1(object sender, StartupEventArgs e)
        {
            MainWindow win = new MainWindow();
            string text= "";
            foreach(string a in e.Args)
            {
                text += a+" ";
            }
            win.block.Text = win.Title = text;
            win.Show();
        }
       
    }
}
