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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        Label[,] myArray;
        bool left = false;
        bool right = false;
        bool Down = false;
        bool Up = false;
        int r = 0;
        int c = 0;
        int r1 = 4;
        int c1 = 15;
        bool left1 = false;
        bool flash = false;
        bool lever1 = false;
        private void Form8_Load(object sender, EventArgs e)
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
            move();
            check(r1, c1);
            check(r1 + 1, c1);
            if (lever1== false)
            check(0, 3);//lever
            check(0, 5);
            check(0, 9);
            if (flash == false)
            { 
            check(0, 7);//flash
            check(0, 11);//flash
            check(2, 5);//flash
            check(2, 9);//flash
            check(2, 13);//flash
            }
            check(0, 13);
            check(1, 0);
            check(1, 1);
            check(1, 3);
            check(1, 5);
            check(1, 7);
            check(1, 9);
            check(1, 11);
            check(1, 13);
            check(1, 15);
            check(2, 3);
            check(2, 7);
            check(2, 11);
            check(2, 15);
            check(3, 1);
            check(3, 2);
            check(3, 3);
            check(3, 4);
            check(3, 5);
            check(3, 6);
            check(3, 7);
            check(3, 8);
            check(3, 9);
            check(3, 10);
            check(3, 11);
            check(3, 12);
            check(3, 13);
            check(3, 14);
            check(3, 15);
            check(4, 3);
            check(4, 4);
            check(4, 5);
            check(5, 0);
            check(5, 1);
            check(5, 3);
            check(5, 4);
            check(5, 5);
            check(6, 3);
            check(6, 7);
            check(6, 8);
            check(6, 10);
            check(6, 11);
            check(6,13);
            check(6, 14);
            check2();
            checkflash(timer3, 6, 0, 6, 1, 6, 0);
            checktp(0, 15, 6, 5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 frm1 = new Form1();
            frm1.ShowDialog();
        }

        private void Form8_KeyUp(object sender, KeyEventArgs e)
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

        private void Form8_KeyDown(object sender, KeyEventArgs e)
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
                timer1.Stop();
                Form1.deaths++;
                timer3.Stop();
                lever1 = false;
                myArray[0, 3].BackColor = Color.Red;
                myArray[2, 5].BackColor = Color.Red;
                myArray[0, 7].BackColor = Color.Red;
                myArray[2, 9].BackColor = Color.Red;
                myArray[0, 11].BackColor = Color.Red;
                myArray[2, 13].BackColor = Color.Red;
                label117.Text = ("Deaths: " + Form1.deaths.ToString());
                myArray[r, c].BackColor = Color.Red;
                r = 0;
                c = 0;
                myArray[r, c].BackColor = Color.Green;
                timer1.Start();
            }
        }
        private void check2()
        {
            if (r == 6 && c == 15)
            {
                r = 0;
                c = 0;
                myArray[r, c].BackColor = Color.Green;
                Form1.level6 = true;
                Hide();
                Form10 frm10 = new Form10();
                frm10.ShowDialog();
            }
        }
        public void checkflash(Timer time, int num, int num1, int loc, int loc1, int lev, int lev1)
        {
            if (r == num && c == num1)
            {
                time.Start();
                lever1 = true;
                myArray[0, 3].BackColor = Color.White;
                r = loc;
                c = loc1;
                myArray[lev, lev1].BackColor = Color.Maroon;
                myArray[r, c].BackColor = Color.Green;
            }
        }
        public void checktp(int tp, int tp1, int dest, int dest1)
        {
            if (r == tp && c == tp1)
            {
                r = dest;
                c = dest1;
                myArray[r, c].BackColor = Color.Green;
                myArray[tp, tp1].BackColor = Color.Purple;
            }
        }
        private void moveWall()
        {
            if(c1!=6 && left1 == false)
            {
                myArray[r1, c1].BackColor = Color.White;
                myArray[r1+1, c1].BackColor = Color.White;
                c1 -= 1;
                myArray[r1, c1].BackColor = Color.Red;
                myArray[r1+1, c1].BackColor = Color.Red;
            }
            else
            {
                left1 = true;
            }
            if( left1 == true && c1!=15)
            {
                myArray[r1, c1].BackColor = Color.White;
                myArray[r1 + 1, c1].BackColor = Color.White;
                c1 += 1;
                myArray[r1, c1].BackColor = Color.Red;
                myArray[r1 + 1, c1].BackColor = Color.Red;
            }
            else
            {
                left1 = false;
            }

        }
        private void label47_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            moveWall();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (flash)
            {
                myArray[2, 5].BackColor = Color.Red;
                myArray[0, 7].BackColor = Color.Red;
                myArray[2, 9].BackColor = Color.Red;
                myArray[0, 11].BackColor = Color.Red;
                myArray[2, 13].BackColor = Color.Red;
                flash = false;
            }
            else if (flash == false)
            {
                myArray[2, 5].BackColor = Color.White;
                myArray[0, 7].BackColor = Color.White;
                myArray[2, 9].BackColor = Color.White;
                myArray[0, 11].BackColor = Color.White;
                myArray[2, 13].BackColor = Color.White;
                flash = true;
            }
        }
    }
}
