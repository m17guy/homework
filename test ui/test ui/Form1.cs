using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_ui
{
    public partial class back : Form
    {
        public back()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            attack.Visible = true;
            timer1.Enabled = true;
            lt.Enabled = false;
            ht.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int temp = rnum(false);
            while (attack.Location.X < 532)
            {
                attack.Location = new Point(attack.Location.X + 8, attack.Location.Y);
            }
            label1.Text = temp.ToString();
            attack.Visible = false;
            if (helthvillin.Value - temp < 0)
            {
                pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y + 250);
                helthvillin.Value = 0;
                timer1.Enabled = false;
            }
            else
            {
                helthvillin.Value -= temp;
                attack.Location = new Point(attack.Location.X - 374, attack.Location.Y);
                timer1.Enabled = false;
                timer3.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            attack2.Visible = true;
            timer2.Enabled = true;
            lt.Enabled = false;
            ht.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int temp = rnum(true);
            while (attack2.Location.X < 532)
            {
                attack2.Location = new Point(attack2.Location.X + 5, attack2.Location.Y);
            }
            label1.Text = temp.ToString();
            attack2.Visible = false;
            if (helthvillin.Value - temp < 0)
            {
                pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y + 250);
                helthvillin.Value = 0;
                timer2.Enabled = false;
            }
            else
            {
                helthvillin.Value -= temp;
                attack2.Location = new Point(attack2.Location.X - 374, attack2.Location.Y);
                timer2.Enabled = false;
                timer3.Enabled = true;
            }
        }
        static int rnum(bool heavy)
        {
            Random num = new Random();
            if (heavy)
            {
                return num.Next(20, 35);
            }
            return num.Next(5, 15);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Enabled = false;
            villinattack.Visible = true;
            timer4.Enabled = true;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            int temp = rnum(false);
            while (villinattack.Location.X > 102)
            {
                villinattack.Location = new Point(villinattack.Location.X - 6, villinattack.Location.Y);
            }
            label2.Text = temp.ToString();
            villinattack.Visible = false;
            helthhero.Value -= temp;
            villinattack.Location = new Point(villinattack.Location.X + 374, villinattack.Location.Y);
            timer4.Enabled = false;
            lt.Enabled = true;
            ht.Enabled = true;
        }
    }
}
