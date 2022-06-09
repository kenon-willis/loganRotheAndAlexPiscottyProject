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
    public partial class Form6 : Form
    {
        public Form6()
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
        Random rand = new Random();
        bool flash = false;
        bool lever = false;
        bool flash1 = false;
        bool flash2 = false;
        bool flash3 = false;
        bool flash4 = false;
        bool flash5 = false;
        bool flash6 = false;
        
        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 frm1 = new Form1();
            frm1.ShowDialog();
        }

        private void Form6_Load(object sender, EventArgs e)
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
            myArray[6, 15].BackColor = Color.Gold;
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
            check(0,2);
            check(0,4);
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
            check(1,2);
            check(1,1);
            if (flash == false)
            {
                myArray[1, 4].BackColor = Color.Red;
                myArray[1, 6].BackColor = Color.Red;
                myArray[1, 8].BackColor = Color.Red;
                myArray[1, 10].BackColor = Color.Red;
                myArray[1, 12].BackColor = Color.Red;
                check(1, 4);//flash
                check(1, 6);//flash
                check(1, 8);//flash
                check(1, 10);//flash
                check(1, 12);//flash
            }
            check(2, 1);
            check(2, 2);
            check(2, 4);
            check(2, 5);
            check(2, 6);
            check(2, 7);
            check(2, 8);
            check(2, 9);
            check(2, 10);
            check(2, 11);
            check(2, 12);
            check(2, 13);
            check(2, 14);
            check(2, 15);
            check(3, 2);
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
            check(4, 0);
            if (flash1 == false)
            {
                check(4, 4);//flash
                myArray[4, 4].BackColor = Color.Red;
            }
            if (flash2 == false)
            {
                check(4, 6);//flash
                myArray[4, 6].BackColor = Color.Red;
            }
            if (flash3 == false)
            {
                check(4, 8);//flash
                myArray[4, 8].BackColor = Color.Red;
            }
            if (flash4 == false)
            {
                check(4, 10);//flash
                myArray[4, 10].BackColor = Color.Red;
            }
            if (flash5 == false)
            {
                check(4, 12);//flash
                myArray[4, 12].BackColor = Color.Red;
            }
            if (flash6 == false)
            {
                check(4, 14);//flash
                myArray[4, 14].BackColor = Color.Red;
            }
            check(5, 0);
            if (lever == false)
            {
                myArray[5, 1].BackColor = Color.Red;
                check(5, 1);//door
            }
            check(5, 2);
            check(5, 3);
            check(5, 4);
            check(5, 5);
            check(5, 6);
            check(5, 7);
            check(5, 8);
            check(5, 9);
            check(5, 10);
            check(5, 11);
            check(5, 12);
            check(5, 13);
            check(5, 14);
            if (lever == false)
            {
                label113.Visible = true;
                myArray[5, 15].BackColor = Color.Red;
                check(5, 15);//dor
            }
            check(6, 0);
            check(6, 2);
            check(6, 3);
            check(6, 4);
            check(6, 5);
            check(6, 6);
            check(6, 7);
            check(6, 8);
            check(6, 9);
            check(6, 10);
            check(6, 11);
            check(6, 12);
            check(6, 13);
            check(6, 14);
            checkflash(timer2, 0, 3, 1, 3, 0, 3);
            checkflash2(timer3, timer4, timer5, timer6, timer7, timer8, 1, 15, 1, 14, 1, 15);
            check3(3, 15, 5, 1, 4, 15, 3, 15);
            if(lever)
                label113.Visible = false;
            check3(6, 1, 5, 15, 5, 1, 6, 1);
            check2();

        }

        private void Form6_KeyUp(object sender, KeyEventArgs e)
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

        private void Form6_KeyDown(object sender, KeyEventArgs e)
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
                flash = false;
                flash1 = false;
                flash2 = false;
                flash3 = false;
                flash4 = false;
                flash5 = false;
                flash6 = false;
                timer3.Stop();
                timer4.Stop();
                timer5.Stop();
                timer6.Stop();
                timer7.Stop();
                timer8.Stop();
                lever = false;
                myArray[5, 15].BackColor = Color.Red;


                timer1.Stop();
                
                Form1.deaths++;
                label117.Text = ("Deaths: " + Form1.deaths.ToString());
                myArray[r, c].BackColor = Color.Red;
                label113.Visible = true;
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
                Form1.level5 = true;
                Hide();
                Form8 frm8 = new Form8();
                frm8.ShowDialog();
            }
        }
        public void checkflash(Timer time, int num, int num1, int loc, int loc1, int lev, int lev1)
        {
            if (r == num && c == num1)
            {
                    time.Start();
                    r = loc;
                    c = loc1;
                    myArray[lev, lev1].BackColor = Color.Maroon;
                    myArray[r, c].BackColor = Color.Green;
            }
        }
        public void checkflash2(Timer time, Timer time1, Timer time2, Timer time3, Timer time5, Timer time6,  int num, int num1, int loc, int loc1, int lev, int lev1)
        {
            if (r == num && c == num1)
            {
                time.Start();
                time1.Start();
                time2.Start();
                time3.Start();
                time5.Start();
                time6.Start();
                r = loc;
                c = loc1;
                myArray[lev, lev1].BackColor = Color.Maroon;
                myArray[r, c].BackColor = Color.Green;
            }
        }


        public void check3(int num, int num1, int one, int two, int loc, int loc1, int lev, int lev1)
        {
            if (r == num && c == num1)
            {
                    myArray[one, two].BackColor = Color.White;
                    lever = true;
                    r = loc;
                    c = loc1;
                    myArray[lev, lev1].BackColor = Color.Maroon;
                    myArray[r, c].BackColor = Color.Green;
                    
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (flash)
            {
                myArray[1, 4].BackColor = Color.Red;
                myArray[1, 6].BackColor = Color.Red;
                myArray[1, 8].BackColor = Color.Red;
                myArray[1, 10].BackColor = Color.Red;
                myArray[1, 12].BackColor = Color.Red;
                flash = false;
            }
            else if (flash == false)
            {
                myArray[1, 4].BackColor = Color.White;
                myArray[1, 6].BackColor = Color.White;
                myArray[1, 8].BackColor = Color.White;
                myArray[1, 10].BackColor = Color.White;
                myArray[1, 12].BackColor = Color.White;
                flash = true;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (flash1)
            {
                flash1 = false;
                myArray[4, 4].BackColor = Color.Red;
            }
            else if (flash1 == false)
            {
                flash1 = true;
                myArray[4, 4].BackColor = Color.White;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (flash2)
            {
                flash2 = false;
                myArray[4, 6].BackColor = Color.Red;
            }
            else if (flash2 == false)
            {
                flash2 = true;
                myArray[4, 6].BackColor = Color.White;
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (flash3)
            {
                flash3 = false;
                myArray[4, 8].BackColor = Color.Red;
            }
            else if (flash3 == false)
            {
                flash3 = true;
                myArray[4, 8].BackColor = Color.White;
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            if (flash4)
            {
                flash4 = false;
                myArray[4, 10].BackColor = Color.Red;
            }
            else if (flash4 == false)
            {
                flash4 = true;
                myArray[4, 10].BackColor = Color.White;
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            if (flash5)
            {
                flash5 = false;
                myArray[4, 12].BackColor = Color.Red;
            }
            else if (flash5 == false)
            {
                flash5 = true;
                myArray[4, 12].BackColor = Color.White;
            }
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            if (flash6)
            {
                flash6 = false;
                myArray[4, 14].BackColor = Color.Red;
            }
            else if (flash6 == false)
            {
                flash6 = true;
                myArray[4, 14].BackColor = Color.White;
            }
        }
    }
    
}
