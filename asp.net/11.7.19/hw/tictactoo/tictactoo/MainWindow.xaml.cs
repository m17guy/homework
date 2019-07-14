using Microsoft.Win32;
using System.Diagnostics;
using System.Windows.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;

namespace tictactoo
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
        
        int[] xplaces = { 0, 0, 0, 0, 0, 0 }; //1,2,3,a,b,c;
        int[] oplaces = { 0, 0, 0, 0, 0, 0 };

        private void openItem_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            if (of.ShowDialog() == true)
            {
                string setup = File.ReadAllText(of.FileName);
                char con = setup[setup.IndexOf("b1=") + 3];
                if(con != '-')
                {
                    b1.Content = con;
                }
                else
                {
                    b1.Content = "";
                }
                con = setup[setup.IndexOf("b2=") + 3];
                if (con != '-')
                {
                    b2.Content = con;
                }
                else
                {
                    b2.Content = "";
                }
                con = setup[setup.IndexOf("b3=") + 3];
                if (con != '-')
                {
                    b3.Content = con;
                }
                else
                {
                    b3.Content = "";
                }
                con = setup[setup.IndexOf("a1=") + 3];
                if (con != '-')
                {
                    a1.Content = con;
                }
                else
                {
                    a1.Content = "";
                }
                con = setup[setup.IndexOf("a2=") + 3];
                if (con != '-')
                {
                    a2.Content = con;
                }
                else
                {
                    a2.Content = "";
                }
                con = setup[setup.IndexOf("a3=") + 3];
                if (con != '-')
                {
                    a3.Content = con;
                }
                else
                {
                    a3.Content = "";
                }
                con = setup[setup.IndexOf("c1=") + 3];
                if (con != '-')
                {
                    c1.Content = con;
                }
                else
                {
                    c1.Content = "";
                }
                con = setup[setup.IndexOf("c2=") + 3];
                if (con != '-')
                {
                    c2.Content = con;
                }
                else
                {
                    c2.Content = "";
                }
                con = setup[setup.IndexOf("c3=") + 3];
                if (con != '-')
                {
                    c3.Content = con;
                }
                else
                {
                    c3.Content = "";
                }
                for(int i = 0; i < xplaces.Length; i++)
                {
                    xplaces[i] = int.Parse(setup[setup.IndexOf("xp") + (2 + i)].ToString());
                }
                for (int i = 0; i < oplaces.Length; i++)
                {
                    oplaces[i] = int.Parse(setup[setup.IndexOf("op") + (2 + i)].ToString());
                }
                if (setup[setup.IndexOf("xturn=") + 6] == 'T')
                {
                    xturn = true;
                }
                else
                {
                    xturn = false;
                }
            }
        }

        private void saveItem_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            if (of.ShowDialog() == true)
            {
                string position = "";
                position += "--b1=" + b1.Content;
                position += "--b2=" + b2.Content;
                position += "--b3=" + b3.Content;
                position += "--a1=" + a1.Content;
                position += "--a2=" + a2.Content;
                position += "--a3=" + a3.Content;
                position += "--c1=" + c1.Content;
                position += "--c2=" + c2.Content;
                position += "--c3=" + c3.Content;
                string temp = "";
                foreach(int i in xplaces)
                {
                    temp += i.ToString();
                }
                position += "--xp" + temp;
                temp = "";
                foreach (int i in oplaces)
                {
                    temp += i.ToString();
                }
                position += "--op" + temp;
                position += "--xturn=" + xturn;
                File.WriteAllText(of.FileName, position);
            }
        }
        private bool xturn = true;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if((((Button)sender).Content).ToString() != "")
            {
                return;
            }
            addtoplaces(((Button)sender).Name);
            if (xturn)
            {
                ((Button)sender).Content += "x";
            }
            else
            {
                ((Button)sender).Content = "o";
            }
            checkwin(xturn);
            xturn = !xturn;
        }
        private void checkwin(bool whoturn)
        {
            string winner = "";
            if (whoturn)
            {
                winner = "x";
            }
            else
            {
                winner = "o";
            }
            string inside = "";
            if (whoturn)
            {
                foreach(int i in xplaces)
                {
                    inside += i;
                }
                if (inside.Contains("3"))
                {
                    MessageBox.Show(winner + " wins");
                    this.Close();
                }
                if ((a2.Content).ToString() == "x")
                {
                    if((c1.Content).ToString() == "x" && (b3.Content).ToString() == "x")
                    {
                        MessageBox.Show(winner + " wins");
                        this.Close();
                    }
                    if ((c3.Content).ToString() == "x" && (b1.Content).ToString() == "x")
                    {
                        MessageBox.Show(winner + " wins");
                        this.Close();
                    }
                }
            }
            else
            {
                foreach (int i in oplaces)
                {
                    inside += i;
                }
                if (inside.Contains("3"))
                {
                    MessageBox.Show(winner + " wins");
                    this.Close();
                }
                if ((a2.Content).ToString() == "o")
                {
                    if ((c1.Content).ToString() == "o" && (b3.Content).ToString() == "o")
                    {
                        MessageBox.Show(winner + " wins");
                        this.Close();
                    }
                    if ((c3.Content).ToString() == "o" && (b1.Content).ToString() == "o")
                    {
                        MessageBox.Show(winner + " wins");
                        this.Close();
                    }
                }
            }
        }
        private void addtoplaces(string name)
        {
            if (xturn)
            {
                switch (name[0])
                {
                    case 'a':
                        xplaces[3] += 1;
                        break;
                    case 'b':
                        xplaces[4] += 1;
                        break;
                    case 'c':
                        xplaces[5] += 1;
                        break;
                }
                switch (name[1])
                {
                    case '1':
                        xplaces[0] += 1;
                        break;
                    case '2':
                        xplaces[1] += 1;
                        break;
                    case '3':
                        xplaces[2] += 1;
                        break;
                }
            }
            else
            {
                switch (name[0])
                {
                    case 'a':
                        oplaces[3] += 1;
                        break;
                    case 'b':
                        oplaces[4] += 1;
                        break;
                    case 'c':
                        oplaces[5] += 1;
                        break;
                }
                switch (name[1])
                {
                    case '1':
                        oplaces[0] += 1;
                        break;
                    case '2':
                        oplaces[1] += 1;
                        break;
                    case '3':
                        oplaces[2] += 1;
                        break;
                }
            }
        }
        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }
    }
}
