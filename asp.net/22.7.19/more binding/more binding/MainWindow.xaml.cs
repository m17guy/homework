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

namespace more_binding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Binding b = new Binding("Text");
            b.Source = twit;
            justcuz.SetBinding(TextBlock.TextProperty, b);
        }
        private void Twit_KeyDown(object sender, KeyEventArgs e)
        {
            int size = twit.Text.Length;
            if (size >= int.Parse(limit.Text))
            {
                MessageBox.Show("you have reched the limit");
            }
        }

        private void Twit_TextChanged(object sender, TextChangedEventArgs e)
        {
            int size = twit.Text.Length;
            if (size > int.Parse(limit.Text))
            {
                twit.Text = twit.Text.Substring(0, int.Parse(limit.Text));
                mynum.Text = (size - 1).ToString();
            }
            else
                mynum.Text = size.ToString();
        }
    }
}
