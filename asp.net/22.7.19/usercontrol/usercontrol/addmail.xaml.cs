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

namespace usercontrol
{
    /// <summary>
    /// Interaction logic for addmail.xaml
    /// </summary>
    public partial class addmail : UserControl
    {
        public string fmail { get; set; }
        public string smail { get; set; }
        public bool same { get; set; }
        public addmail()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            this.one.Text = fmail;
            this.two.Text = smail;
            same = false;
        }
        private void Twob_LostFocus(object sender, RoutedEventArgs e)
        {
            if (oneb.Text != "")
            {
                if (oneb.Text == twob.Text)
                {
                    same = true;
                    return;
                }
            }
            same = false;
        }

        private void Oneb_LostFocus(object sender, RoutedEventArgs e)
        {
            if (oneb.Text != "")
            {
                if (oneb.Text == twob.Text)
                {
                    same = true;
                    return;
                }
            }
            same = false;
        }
    }
}
