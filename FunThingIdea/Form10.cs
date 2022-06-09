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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        Label[,] myArray;
        bool left = false;
        bool right = false;
        bool Down = false;
        bool Up = false;
        bool flash1 = false;
        bool flash2 = false;
        bool flash3 = false;
        bool flash4 = false;
        bool flash5 = false;
        bool flash6 = false;
        bool flash7 = false;
        bool flash8 = false;
        bool flash9 = false;
        bool flash10 = false;
        bool flash11= false;
        bool flash12 = false;
        bool falsh = false;
        bool falsh1 = false;
        int th = -1;
        int th1 = 2;
        int a = -1;
        int b = 12;
        int r = 1;
        int c = 0;
        private void Form10_Load(object sender, EventArgs e)
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
        public void check(int alex, int logan)
        {
            if (r == alex && c == logan)
            {
                a = -1;
                flash1 = false;
                flash2 = false;
                flash3 = false;
                flash4 = false;
                flash5 = false;
                flash6 = false;
                flash7 = false;
                flash8 = false;
                flash9 = false;
                flash10 = false;
                flash11 = false;
                flash12 = false;
                falsh = false;
                falsh1 = false;
                myArray[4, 13].BackColor = Color.Red;
                myArray[4, 9].BackColor = Color.Red;
                myArray[4, 5].BackColor = Color.Red;
                myArray[6, 2].BackColor = Color.Red;
                myArray[6, 6].BackColor = Color.Red;
                myArray[6, 10].BackColor = Color.Red;
                myArray[4, 11].BackColor = Color.Red;
                myArray[4, 7].BackColor = Color.Red;
                myArray[4, 3].BackColor = Color.Red;
                myArray[6, 4].BackColor = Color.Red;
                myArray[6, 8].BackColor = Color.Red;
                myArray[6, 12].BackColor = Color.Red;
                timer3.Stop();
                timer2.Stop();
                timer1.Stop();
                Form1.deaths++;
                label117.Text = ("Deaths: " + Form1.deaths.ToString());
                myArray[r, c].BackColor = Color.Red;
                r = 1;
                c = 0;
                myArray[r, c].BackColor = Color.Green;
                timer1.Start();
                timer2.Start();
            }
        }
        public void check3(int num, int num1, int loc, int loc1, int lev, int lev1)
        {
            if (r == num && c == num1)
            {
                timer3.Start();
                r = loc;
                c = loc1;
                myArray[lev, lev1].BackColor = Color.Maroon;
                myArray[r, c].BackColor = Color.Green;

            }
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
        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 frm1 = new Form1();
            frm1.ShowDialog();
        }

        private void Form10_KeyDown(object sender, KeyEventArgs e)
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

        private void Form10_KeyUp(object sender, KeyEventArgs e)
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
        private void check2()
        {
            if (r == 6 && c == 15)
            {
                r = 1;
                c = 0;
                myArray[r, c].BackColor = Color.Green;
                Form1.level7 = true;
                Hide();
               Form11 frm11 = new Form11();
               frm11.ShowDialog();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Form9.Achieve();
            check(0,0);
            check(0,1);
            check(0,2);
            check(0,3);
            check(0,4);
            check(0,5);
            check(0,6);
            check(0,7);
            check(0,8);
            check(0,9);
            check(0,10);
            check(0,11);
            check(0,12);
            check(0,13);
            check(0,14);
            check(0,15);
            check(2, 0);
            check(2, 1);
            check(2, 2);
            check(2,3 );
            check(2,4 );
            check(2, 5);
            check(2, 6);
            check(2, 7);
            check(2, 8);
            check(2, 9);
            check(2, 10);
            check(2, 11);
            check(2, 12);
            check(2, 13);
            check(2, 15);
            check(3, 0);
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
            check(3, 15);
            check(4, 15);
            check(5, 0);
            check(5, 2);
            check(5, 3);
            check(5, 4);
            check(5, 5);
            check(5, 6);
            check(5, 7);
            check(5, 8);
            check(5, 9);
            check(5, 10);
            check(5,11 );
            check(5, 12);
            check(5, 13);
            check(5, 14);
            check(5, 15);
            check(6, 0);

            check2();
            myArray[r, c].BackColor = Color.Green;
            move();
            if(flash1==false)
            {
                check(1, 2);
                myArray[1, 2].BackColor = Color.Red;
            }
            if (flash2 == false)
            {
                check(1, 3);
                myArray[1, 3].BackColor = Color.Red;
            }
            if (flash3 == false)
            {
                check(1, 4);
                myArray[1, 4].BackColor = Color.Red;
            }
            if (flash4 == false)
            {
                check(1, 5);
                myArray[1, 5].BackColor = Color.Red;

            }
            if (flash5 == false)
            {
                check(1, 6);
                myArray[1, 6].BackColor = Color.Red;
            }
            if (flash6== false)
            {
                check(1, 7);
                myArray[1, 7].BackColor = Color.Red;
            }
            if (flash7 == false)
            {
                check(1, 8);
                myArray[1, 8].BackColor = Color.Red;
            }
            if (flash8 == false)
            {
                check(1, 9);
                myArray[1, 9].BackColor = Color.Red;
            }
            if (flash9 == false)
            {
                check(1, 10);
                myArray[1, 10].BackColor = Color.Red;
            }
            if (flash10 == false)
            {
                check(1, 11);
                myArray[1, 11].BackColor = Color.Red;
            }
            if (flash11 == false)
            {
                check(1, 12);
                myArray[1, 12].BackColor = Color.Red;
            }
            if (flash12 == false)
            {
                check(1, 13);
                myArray[1, 13].BackColor = Color.Red;
            }
            check3(1, 15, 1, 14, 1, 15);
            if (falsh == false)
            {
                check(4, 13);
                check(4, 9);
                check(4, 5);
                check(6, 2);
                check(6, 6);
                check(6, 10);
            }
            if (falsh1 == false)
            {
                check(4, 11);
                check(4, 7);
                check(4, 3);
                check(6, 4);
                check(6, 8);
                check(6, 12);
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            a++;
            int result = a % b;
            if(result==0)
            {
                myArray[1, 2].BackColor = Color.White;
                myArray[1, 3].BackColor = Color.White;
                flash1 = true;
                flash2 = true;
                flash3 = false;
                flash4 = false;
                flash5 = false;
                flash6 = false;
                flash7 = false;
                flash8 = false;
                flash9 = false;
                flash10 = false;
                flash11 = false;
                flash12 = false;
            }
            else if (result == 1)
            {
                myArray[1, 3].BackColor = Color.White;
                myArray[1, 4].BackColor = Color.White;
                flash1 =false ;
                flash2 = true;
                flash3 = true;
                flash4 = false;
                flash5 = false;
                flash6 = false;
                flash7 = false;
                flash8 = false;
                flash9 = false;
                flash10 = false;
                flash11 = false;
                flash12 = false;
            }
            else if (result == 2)
            {
                myArray[1, 4].BackColor = Color.White;
                myArray[1, 5].BackColor = Color.White;
                flash1 = false;
                flash2 = false;
                flash3 = true;
                flash4 = true;
                flash5 = false;
                flash6 = false;
                flash7 = false;
                flash8 = false;
                flash9 = false;
                flash10 = false;
                flash11 = false;
                flash12 = false;
            }
            else if (result == 3)
            {
                myArray[1, 5].BackColor = Color.White;
                myArray[1, 6].BackColor = Color.White;
                flash1 = false;
                flash2 = false;
                flash3 = false;
                flash4 = true;
                flash5 = true;
                flash6 = false;
                flash7 = false;
                flash8 = false;
                flash9 = false;
                flash10 = false;
                flash11 = false;
                flash12 = false;
            }
            else if (result == 4)
            {
                myArray[1, 6].BackColor = Color.White;
                myArray[1, 7].BackColor = Color.White;
                flash1 = false;
                flash2 = false;
                flash3 = false;
                flash4 = false; 
                flash5 = true;
                flash6 = true;
                flash7 = false;
                flash8 = false;
                flash9 = false;
                flash10 = false;
                flash11 = false;
                flash12 = false;
            }
            else if (result == 5)
            {
                myArray[1, 8].BackColor = Color.White;
                myArray[1, 7].BackColor = Color.White;
                flash1 = false;
                flash2 = false;
                flash3 = false;
                flash4 = false;
                flash5 = false;
                flash6 = true;
                flash7 = true;
                flash8 = false;
                flash9 = false;
                flash10 = false;
                flash11 = false;
                flash12 = false;
            }
            else if (result == 6)
            {
                myArray[1, 8].BackColor = Color.White;
                myArray[1, 9].BackColor = Color.White;
                flash1 = false;
                flash2 = false;
                flash3 = false;
                flash4 = false;
                flash5 = false;
                flash6 = false;
                flash7 = true;
                flash8 = true;
                flash9 = false;
                flash10 = false;
                flash11 = false;
                flash12 = false;
            }
            else if (result == 7)
            {
                myArray[1, 9].BackColor = Color.White;
                myArray[1, 10].BackColor = Color.White;
                flash1 = false;
                flash2 = false;
                flash3 = false;
                flash4 = false;
                flash5 = false;
                flash6 = false;
                flash7 = false;
                flash8 = true;
                flash9 = true;
                flash10 = false;
                flash11 = false;
                flash12 = false;
            }
            else if (result == 8)

            {
                myArray[1, 10].BackColor = Color.White;
                myArray[1, 11].BackColor = Color.White;
                flash1 = false;
                flash2 = false;
                flash3 = false;
                flash4 = false;
                flash5 = false;
                flash6 = false;
                flash7 = false;
                flash8 = false;
                flash9 = true;
                flash10 = true;
                flash11 = false;
                flash12 = false;
            }
            else if (result == 9)
            {
                myArray[1, 11].BackColor = Color.White;
                myArray[1, 12].BackColor = Color.White;
                flash1 = false;
                flash2 = false;
                flash3 = false;
                flash4 = false;
                flash5 = false;
                flash6 = false;
                flash7 = false;
                flash8 = false;
                flash9 = false;
                flash10 = true;
                flash11 = true;
                flash12 = false;
            }
            else if (result == 10)
            {
                myArray[1, 12].BackColor = Color.White;
                myArray[1, 13].BackColor = Color.White;
                flash1 = false;
                flash2 = false;
                flash3 = false;
                flash4 = false;
                flash5 = false;
                flash6 = false;
                flash7 = false;
                flash8 = false;
                flash9 = false;
                flash10 = false;
                flash11 = true;
                flash12 = true;
            }
            else if (result == 11)
            {
                myArray[1, 13].BackColor = Color.White;
                flash1 = false;
                flash2 = false;
                flash3 = false;
                flash4 = false;
                flash5 = false;
                flash6 = false;
                flash7 = false;
                flash8 = false;
                flash9 = false;
                flash10 = false;
                flash11 = false;
                flash12 = true;
            }

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            th++;
            int result1 = th % th1;
            if (result1 == 0)
            {
                falsh = false;
                myArray[4, 13].BackColor = Color.Red;
                myArray[4, 9].BackColor = Color.Red;
                myArray[4, 5].BackColor = Color.Red;
                myArray[6, 2].BackColor = Color.Red;
                myArray[6, 6].BackColor = Color.Red;
                myArray[6, 10].BackColor = Color.Red;
                falsh1 = true;
                myArray[4, 11].BackColor = Color.White;
                myArray[4, 7].BackColor = Color.White;
                myArray[4, 3].BackColor = Color.White;
                myArray[6, 4].BackColor = Color.White;
                myArray[6, 8].BackColor = Color.White;
                myArray[6, 12].BackColor = Color.White;
            }
            else if (result1==1)
            {
                falsh = true;
                falsh1 = false;
                myArray[4, 11].BackColor = Color.Red;
                myArray[4, 7].BackColor = Color.Red;
                myArray[4, 3].BackColor = Color.Red;
                myArray[6, 4].BackColor = Color.Red;
                myArray[6, 8].BackColor = Color.Red;
                myArray[6, 12].BackColor = Color.Red;
                myArray[4, 13].BackColor = Color.White;
                myArray[4, 9].BackColor = Color.White;
                myArray[4, 5].BackColor = Color.White;
                myArray[6, 2].BackColor = Color.White;
                myArray[6, 6].BackColor = Color.White;
                myArray[6, 10].BackColor = Color.White;
            }
            
        }

    }
}
