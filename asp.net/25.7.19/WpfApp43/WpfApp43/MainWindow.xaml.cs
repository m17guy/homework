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

namespace WpfApp43
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		List<Person> people = new List<Person>();
		public MainWindow()
		{
			InitializeComponent();
			people.Add(new Person { Name = "chavitoosh", Age = 3 });
			people.Add( new Person { Name = "dodli", Age = 45 });
			this.lb.ItemsSource = people;
			this.cb.ItemsSource = people;
		}
	}
	class Person
	{
		public string Name { get; set; }
		public int Age { get; set; }
		public override string ToString()
		{
			return Name + "is " + Age + " years old";
		}


	}
}
