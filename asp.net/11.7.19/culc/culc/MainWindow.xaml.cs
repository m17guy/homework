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

namespace culc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (thebox.Text.Contains(".") && (string)((Button)sender).Content== ".")
            {
                if (!thebox.Text.Substring(thebox.Text.LastIndexOf('.')).Contains('+'))
                    return;
            }
            if (thebox.Text != "")
            {
                if ((thebox.Text[thebox.Text.Length - 1] == '+' || thebox.Text[thebox.Text.Length - 1] == '-' || thebox.Text[thebox.Text.Length - 1] == '/' || thebox.Text[thebox.Text.Length - 1] == '*') && ((string)((Button)sender).Content == "+" || (string)((Button)sender).Content == "-" || (string)((Button)sender).Content == "/" || (string)((Button)sender).Content == "*"))
                return;
            }
            thebox.Text += (string)((Button)sender).Content;
        }

        //deliting every thing
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            thebox.Text = "";
        }
        //deliting 1 thing
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (thebox.Text == "")
                return;
            thebox.Text = thebox.Text.Substring(0, thebox.Text.Length - 1);
        }
        //doing the math
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            string[] parts = thebox.Text.Split('*');
            foreach (string s in parts)
            {
                //MessageBox.Show(s);
            }
            int ans = int.Parse(parts[0]) * int.Parse(parts[1]);
            MessageBox.Show(ans.ToString());
        }
    }
}
