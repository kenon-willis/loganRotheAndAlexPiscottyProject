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
    public partial class Form4 : Form
    {
        
        public Form4()
        {
            InitializeComponent();
        }
        Label[,] myArray;
        bool left = false;
        bool right = false;
        bool Down = false;
        bool Up = false;
        bool lever = false;
        int r = 2;
        int c = 0;
        int r1 = 0;
        int c1 = 0;
        public void move()
        {
            if (r < 4 && Down)    //Bottom
            {
                left = false;
                right = false;
                Up = false;
                myArray[r, c].BackColor = Color.White;
                r += 1;
                myArray[r, c].BackColor = Color.Green;
                Down = false;
            }
            if (c < 9 && right)
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
        public void check(int alex, int logan)
        {
            if (r == alex && c == logan)
            {
                timer1.Stop();
                Form1.deaths++;
                label51.Text = ("Deaths: " + Form1.deaths.ToString());
                lever = false;
                myArray[2, 5].BackColor = Color.Red;
                myArray[2, 6].BackColor = Color.Red;
                myArray[2, 7].BackColor = Color.Red;
                myArray[r, c].BackColor = Color.Red;
                r = 2;
                c = 0;
                myArray[r, c].BackColor = Color.Green;
                timer1.Start();
            }
        }
        private void check2()
        {
            if (r == r1 && c == c1)
            {
                r = 2;
                c = 0;
                myArray[r, c].BackColor = Color.Green;
                Form1.level2 = true;
                Hide();
                Form5 frm5 = new Form5();
                frm5.ShowDialog();
            }
        }
        
        public void check3()
        {
            if (r==4 && c==4)
            {
                    if (lever)
                    {
                        myArray[2, 5].BackColor = Color.Red;
                        myArray[2, 6].BackColor = Color.Red;
                        myArray[2, 7].BackColor = Color.Red;
                        lever = false;
                        r = 4;
                        c = 3;
                        myArray[4, 4].BackColor = Color.Maroon;
                        myArray[r, c].BackColor = Color.Green;
                    }
                    else if (lever == false)
                    {
                        myArray[2, 5].BackColor = Color.White;
                        myArray[2, 6].BackColor = Color.White;
                        myArray[2, 7].BackColor = Color.White;
                        lever = true;
                        r = 4;
                        c = 3;
                        myArray[4, 4].BackColor = Color.Maroon;
                        myArray[r, c].BackColor = Color.Green;
                    
                }
            }
        }
        
        Random rand = new Random();
        private void Form4_Load(object sender, EventArgs e)
        {
            label51.Text = ("Deaths: " + Form1.deaths.ToString());
            int thing = rand.Next(8, 10);
            c1 += thing;
            int thing1 = rand.Next(0, 5);
            r1 += thing1;

            timer1.Start();
            myArray = new Label[,]
            {
            { label1, label2, label3, label4, label5, label6, label7, label8, label9, label10},
            { label11, label12, label13, label14, label15, label16, label17, label18, label19, label20},
            { label21, label22, label23, label24, label25, label26, label27, label28, label29, label30},
            { label31, label32, label33, label34, label35, label36, label37, label38, label39, label40},
            { label41, label42, label43, label44, label45, label46, label47, label48, label49, label50},
            };
            myArray[thing1, thing].BackColor = Color.Gold;
            while(r==3&&c==8|| r == 3&& c ==9)
            {
                myArray[thing1, thing].BackColor = Color.White;
                thing = rand.Next(8, 10);
                thing1 = rand.Next(0, 5);
                myArray[thing1, thing].BackColor = Color.Gold;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Form9.Achieve();
            if (lever == false)
            {
                check(0, 5);
                check(0, 7);
                check(1, 5);
                check(1, 6);
                check(1, 7);
                check(3, 5);
                check(3, 6);
                check(3, 7);
                check(4, 5);
                check(4, 7);
                check(2, 5);
                check(2, 6);
                check(2, 7);
                check(3, 1);
                check(3, 2);
                check(3, 3);
                check(3, 4);
                check3();
                move();

            }
            else if (lever)
            {
                check(0, 5);
                check(0, 7);
                check(1, 5);
                check(1, 6);
                check(1, 7);
                check(3, 5);
                check(3, 6);
                check(3, 7);
                check(4, 5);
                check(4, 7);
                check(3, 1);
                check(3, 2);
                check(3, 3);
                check(3, 4);
                check3();
                move();
                check2();
            }

            }

        private void Form4_KeyUp(object sender, KeyEventArgs e)
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

        private void Form4_KeyDown(object sender, KeyEventArgs e)
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            Hide();
            Form1 frm1 = new Form1();
            frm1.ShowDialog();
        }
    }
}
