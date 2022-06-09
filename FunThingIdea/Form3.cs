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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        Label[,] myArray;
        bool left = false;
        bool right = false;
        bool Down = false;
        bool Up = false;
        bool lever = false;
        int r = 0;
        int c = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 frm1 = new Form1();
            frm1.ShowDialog();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            myArray = new Label[,]
            {
            {label3,label4,label5, label21 },
            {label6,label7,label8, label20 },
            {label16,label15,label14, label18 },
            {label13,label12,label10, label17 },
        };
        }
        private void move()
        {
            if (r < 3 && Down)    //Bottom
            {
                myArray[r, c].BackColor = Color.White;
                r += 1;
                myArray[r, c].BackColor = Color.Green;
                Down = false;
            }
            if (c < 3 && right)
            {

                myArray[r, c].BackColor = Color.White;
                c += 1;
                myArray[r, c].BackColor = Color.Green;
                right = false;
            }
            if (r > 0 && Up)
            {

                myArray[r, c].BackColor = Color.White;
                r -= 1;
                myArray[r, c].BackColor = Color.Green;
                Up= false;
            }
            if (c > 0 && left)
            {
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
                myArray[1, 2].BackColor = Color.Red;
                lever = false;
                myArray[alex,logan].BackColor = Color.Red;
                timer1.Stop();
                r = 0;
                c = 0;
                myArray[r, c].BackColor = Color.Green;
                timer1.Start();
            }
        }
        public void check3()
        {
            if (r == 3 && c == 1)
            {
                if (lever)
                {
                    myArray[1, 2].BackColor = Color.Red;
                    lever = false;
                    r = 2;
                    c = 1;
                    myArray[3, 1].BackColor = Color.Maroon;
                    myArray[r, c].BackColor = Color.Green;
                }
                else if (lever == false)
                {
                    myArray[1, 2].BackColor = Color.White;
                    lever = true;
                    r = 2;
                    c = 1;
                    myArray[3, 1].BackColor = Color.Maroon;
                    myArray[r, c].BackColor = Color.Green;

                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            move();
            check3();
            check(3, 0);
            check(0, 2);
            if(lever==false)
            check(1, 2);
            check(2, 2);
            check(3, 2);
            if(r==3 && c==3)
            {
                lever = false;

                r = 0;
                c = 0;
                myArray[r, c].BackColor = Color.Green;
                myArray[3, 3].BackColor = Color.Gold;
                myArray[1, 2].BackColor = Color.Red;
            }
        }

        private void button2_KeyDown(object sender, KeyEventArgs e)
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

        private void button2_KeyUp(object sender, KeyEventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
             
        }

        private void button3_Click(object sender, EventArgs e)
        {
            r= 0;
            c = 0;
        }
    }
}
