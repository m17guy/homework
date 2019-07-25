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

namespace WpfApp38
{
	/// <summary>
	/// Interaction logic for MailControl.xaml
	/// </summary>
	public partial class MailControl : UserControl
	{
		public string MailTitle { get; set; }
		public bool IsValidMail { get; set; }

		public string  Mail { get; set; }
		public MailControl()
		{
			InitializeComponent();
			IsValidMail = false;
		}

		private void UserControl_Loaded(object sender, RoutedEventArgs e)
		{
			this.mailHeading.Text = MailTitle;
		}

		private void Mail1_TextChanged(object sender, TextChangedEventArgs e)
		{
			if(mail1.Text.Equals(""))
			{
				this.IsValidMail = false;
				return;
			}

			if(mail1.Text.Equals(mail2.Text))
			{
				this.IsValidMail = true;
				this.Mail = mail1.Text;
				return;
			}

			this.IsValidMail = false;
			return;
	
		}
	}
}
