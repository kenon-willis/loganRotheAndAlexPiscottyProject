using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunThingIdea
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        Label[,] myArray;
        bool left = false;
        bool right = false;
        bool Down = false;
        bool Up = false;
        bool lever = false;
        int r = 3;
        int c = 7;
        Random rand = new Random();
        private void Form7_Load(object sender, EventArgs e)
        {
            label117.Text = ("Deaths: " + Form1.deaths.ToString());
            timer1.Start();
            myArray = new Label[,]
            {
            { label1, label2, label3, label4, label5, label6, label7, label8, label9, label10, label59, label60, label69, label70, label79, label80},
            { label11, label12, label13, label14, label15, label16, label17, label18, label19, label20, label57,label58, label67, label68, label77, label78},
            { label21, label22, label23, label24, label25, label26, label27, label28, label29, label30, label55, label56, label65, label66, label75, label76},
            { label31, label32, label33, label34, label35, label36, label37, label38, label39, label40, label51, label52, label61, label62, label71, label72},
            { label41, label42, label43, label44, label45, label46, label47, label48, label49, label50, label53,label54, label63, label64, label73, label74},
            { label93, label94, label95, label96, label97, label98, label99, label100, label101, label102, label89, label90, label85, label86, label81,label82},
            { label103, label104, label105, label106, label107, label108, label109, label110, label111, label112, label91, label92, label87, label88, label83, label84}
            };
        }
        public void move()
        {
            if (r < 6 && Down)    //Bottom
            {
                left = false;
                right = false;
                Up = false;
                myArray[r, c].BackColor = Color.White;
                r += 1;
                myArray[r, c].BackColor = Color.Green;
                Down = false;
            }
            if (c < 15 && right)
            {
                left = false;
                Down = false;
                Up = false;
                myArray[r, c].BackColor = Color.White;
                c += 1;
                myArray[r, c].BackColor = Color.Green;
                right = false;
            }
            if (r > 0 && Up)
            {
                left = false;
                right = false;
                Down = false;
                myArray[r, c].BackColor = Color.White;
                r -= 1;
                myArray[r, c].BackColor = Color.Green;
                Up = false;
            }
            if (c > 0 && left)
            {
                right = false;
                Down = false;
                Up = false;
                myArray[r, c].BackColor = Color.White;
                c -= 1;
                myArray[r, c].BackColor = Color.Green;
                left = false;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Form9.Achieve();
            check3(6, 2,6, 1, 6, 2);
            move();
            check(0, 0);
            check(0, 1);
            check(0, 2);
            check(0, 3);
            check(0, 4);
            check(0, 5);
            check(0, 6);
            check(0, 7);
            check(0, 8);
            check(0, 9);
            check(0, 10);
            check(0, 11);
            check(0, 12);
            check(0, 13);
            check(0, 14);
            check(0, 15);
            check(1, 0);
            check(1, 10);
            check(2, 0);
            check(2, 2);
            check(2, 6);
            check(2, 7);
            check(2, 8);
            check(2, 10);
            check(2, 12);
            check(2, 13);
            check(2, 14);
            check(3, 0);
            check(3, 2);
            check(3, 6);
            check(3, 8);
            check(3, 10);
            check(3, 12);
            check(4, 0);
            check(4, 2);
            check(4, 6);
            check(4, 10);
            check(4, 12);
            check(4, 14);
            check(4, 15);
            check(5, 0);
            check(5, 2);
            check(5, 6);
            check(5, 7);
            check(5, 8);
            check(5, 9);
            check(5, 10);
            check(5, 12);
            if (lever == false)
            {
            check(5, 13);//lever
            check(5, 14);//lever
            check(5, 15);//lever
            }
            check(6, 0);
            check(6, 3);
            check(6, 12);
            check(6, 13);
            check(6, 14);
            check2();
        }

        private void Form7_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
                Up = false;
            if (e.KeyCode == Keys.A)
                left = false;
            if (e.KeyCode == Keys.S)
                Down = false;
            if (e.KeyCode == Keys.D)
                right = false;
        }

        private void Form7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
                Up = true;
            if (e.KeyCode == Keys.A)
                left = true;
            if (e.KeyCode == Keys.S)
                Down = true;
            if (e.KeyCode == Keys.D)
                right = true;
        }
        public void check(int alex, int logan)
        {
            if (r == alex && c == logan)
            {
                timer2.Stop();
                lever = false;
                myArray[5, 13].BackColor = Color.Red;
                myArray[5, 14].BackColor = Color.Red;
                myArray[5, 15].BackColor = Color.Red;
                timer1.Stop();
                Form1.deaths++;
                label117.Text = ("Deaths: " + Form1.deaths.ToString());
                myArray[r, c].BackColor = Color.Red;
                r = 3;
                c = 7;
                myArray[r, c].BackColor = Color.Green;
                timer1.Start();
            }
        }
        private void check2()
        {
            if (r == 6 && c == 15)
            {
                r = 3;
                c = 7;
                myArray[r, c].BackColor = Color.Green;
                Form1.level4 = true;
                Hide();
                Form6 frm6 = new Form6();
                frm6.ShowDialog();
            }
        }
        public void check3(int num, int num1, int loc, int loc1, int lev, int lev1)
        {
            if (r == num && c == num1)
            {
                timer2.Start();
                myArray[5, 13].BackColor = Color.White;
                myArray[5, 14].BackColor = Color.White;
                myArray[5, 15].BackColor = Color.White;
                lever = true;
                r = loc;
                c = loc1;
                myArray[lev, lev1].BackColor = Color.Maroon;
                myArray[r, c].BackColor = Color.Green;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 frm1 = new Form1();
            frm1.ShowDialog();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lever = false;
            myArray[5, 13].BackColor = Color.Red;
            myArray[5, 14].BackColor = Color.Red;
            myArray[5, 15].BackColor = Color.Red;
        }
    }
}
