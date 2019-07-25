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

namespace data
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        mydataEntities context = new mydataEntities();
        public MainWindow()
        {
            InitializeComponent();
            dgrid.ItemsSource = context.Tables.ToList();
            combob.ItemsSource = context.Tables.ToList();
            listb.ItemsSource = context.Tables.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = ((Table)this.listb.SelectedItem).name;
            int age = ((Table)combob.SelectedItem).age;
            var result = context.Tables.Where(Tables => Tables.name == name && age == Tables.age).ToList();
            if (result.ToList().Count == 0)
                MessageBox.Show("wrong");
            else
                MessageBox.Show("good");
        }
    }
}
