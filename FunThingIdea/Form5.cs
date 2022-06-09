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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        Label[,] myArray;
        bool left = false;
        bool right = false;
        bool Down = false;
        bool Up = false;
        bool lever1 = false;
        bool lever2 = false;
        bool lever3 = false;
        int r = 0;
        int c = 0;
        int r1 = 0;
        int c1 = 0; 
        Random rand = new Random();
        private void Form5_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 frm1 = new Form1();
            frm1.ShowDialog();
        }
        private void check4(int lel, int lel2, Label label, int lell, int lell2)
        {
            if (r==lel && c==lel2)
                label.Visible = false;
            else if (r==lell && c==lell2)
                label.Visible = true;
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
        public void check(int alex, int logan)
        {
            if (r == alex && c == logan)
            {
                lever1 = false;
                lever2 = false;
                lever3 = false;
                label113.Visible = true;
                label115.Visible = true;
                label116.Visible = true;
                myArray[3, 0].BackColor = Color.Red;
                myArray[5, 8].BackColor = Color.Red;
                myArray[6, 12].BackColor = Color.Red;
                myArray[6, 13].BackColor = Color.Red;
                myArray[6, 14].BackColor = Color.Red;

                timer1.Stop();
                Form1.deaths++;
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
                Form1.level3 = true;
                Hide();
                Form7 frm7 = new Form7();
                frm7.ShowDialog();
            }
        }
        public void check3(int num, int num1, ref bool lever,  int one, int two, int three, int four, int loc, int loc1, int lev, int lev1)
        {
            if (r == num && c == num1)
            {
                if (lever)
                {
                    myArray[one, two].BackColor = Color.Red;
                    myArray[three, four].BackColor = Color.Red;
                    lever = false;
                    r = loc;
                    c = loc1;
                    myArray[lev, lev1].BackColor = Color.Maroon;
                    myArray[r, c].BackColor = Color.Green;
                }
                else if (lever == false)
                {
                    myArray[one, two].BackColor = Color.White;
                    myArray[three, four].BackColor = Color.White;
                    lever = true;
                    r = loc;
                    c = loc1;
                    myArray[lev, lev1].BackColor = Color.Maroon;
                    myArray[r, c].BackColor = Color.Green;

                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Form9.Achieve();
            check4(2, 3, label113, 2,2);
            check4(4, 7, label115, 5, 7);
            check4(4, 9, label116, 5, 9);
            check3(0, 15, ref lever1, 3, 0, 6, 12, 1, 15, 0, 15);
            check3(3, 4, ref lever2, 5, 8, 6, 13, 3, 5, 3, 4);
            check3(3, 15, ref lever3, 6, 14, 6, 14, 3, 14, 3, 15);
            check(0,1);
            check(0,6);
            check(0, 10);
            check(0, 14);
            check(1, 2);
            check(1, 4);
            check(1, 8);
            check(1, 12);
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
            if (lever1 == false)
            {
                check(3, 0); //lever box
                check(6, 12);//lever box
            }
            if (lever2 == false)
            {
                check(5, 8); //lever box
                check(6, 13);//lever box
            }
            if (lever3 == false)
            {
                check(6, 14);//lever boxdddd
            }
            check(3, 1);
            check(3, 2);
            check(3, 3);
            check(3, 8);
            check(4, 1);
            check(4, 2);
            check(4, 4);
            check(4, 5);
            check(4, 6);
            check(4, 8);
            check(4, 10);
            check(4, 11);
            check(4, 12);
            check(4, 13);
            check(4, 14);
            check(4, 15);
            check(5, 1);
            check(5, 6);
            check(5, 12);
            check(5, 13);
            check(5, 14);
            check(5, 15);
            check(6, 3);
            check(6, 8);
            check(6, 9);
            move();
            check2();
            
        }

        private void Form5_KeyUp(object sender, KeyEventArgs e)
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

        private void Form5_KeyDown(object sender, KeyEventArgs e)
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

        private void label116_Click(object sender, EventArgs e)
        {

        }

        private void label115_Click(object sender, EventArgs e)
        {

        }

        private void label113_Click(object sender, EventArgs e)
        {

        }

        private void label81_Click(object sender, EventArgs e)
        {

        }

        private void label82_Click(object sender, EventArgs e)
        {

        }

        private void label83_Click(object sender, EventArgs e)
        {

        }

        private void label84_Click(object sender, EventArgs e)
        {

        }

        private void label85_Click(object sender, EventArgs e)
        {

        }

        private void label86_Click(object sender, EventArgs e)
        {

        }

        private void label87_Click(object sender, EventArgs e)
        {

        }

        private void label88_Click(object sender, EventArgs e)
        {

        }

        private void label89_Click(object sender, EventArgs e)
        {

        }

        private void label90_Click(object sender, EventArgs e)
        {

        }

        private void label91_Click(object sender, EventArgs e)
        {

        }

        private void label92_Click(object sender, EventArgs e)
        {

        }

        private void label93_Click(object sender, EventArgs e)
        {

        }

        private void label94_Click(object sender, EventArgs e)
        {

        }

        private void label95_Click(object sender, EventArgs e)
        {

        }

        private void label96_Click(object sender, EventArgs e)
        {

        }

        private void label97_Click(object sender, EventArgs e)
        {

        }

        private void label98_Click(object sender, EventArgs e)
        {

        }

        private void label99_Click(object sender, EventArgs e)
        {

        }

        private void label100_Click(object sender, EventArgs e)
        {

        }

        private void label101_Click(object sender, EventArgs e)
        {

        }

        private void label102_Click(object sender, EventArgs e)
        {

        }

        private void label103_Click(object sender, EventArgs e)
        {

        }

        private void label104_Click(object sender, EventArgs e)
        {

        }

        private void label105_Click(object sender, EventArgs e)
        {

        }

        private void label106_Click(object sender, EventArgs e)
        {

        }

        private void label107_Click(object sender, EventArgs e)
        {

        }

        private void label108_Click(object sender, EventArgs e)
        {

        }

        private void label109_Click(object sender, EventArgs e)
        {

        }

        private void label110_Click(object sender, EventArgs e)
        {

        }

        private void label111_Click(object sender, EventArgs e)
        {

        }

        private void label112_Click(object sender, EventArgs e)
        {

        }

        private void label71_Click(object sender, EventArgs e)
        {

        }

        private void label72_Click(object sender, EventArgs e)
        {

        }

        private void label73_Click(object sender, EventArgs e)
        {

        }

        private void label74_Click(object sender, EventArgs e)
        {

        }

        private void label75_Click(object sender, EventArgs e)
        {

        }

        private void label76_Click(object sender, EventArgs e)
        {

        }

        private void label77_Click(object sender, EventArgs e)
        {

        }

        private void label78_Click(object sender, EventArgs e)
        {

        }

        private void label79_Click(object sender, EventArgs e)
        {

        }

        private void label80_Click(object sender, EventArgs e)
        {

        }

        private void label61_Click(object sender, EventArgs e)
        {

        }

        private void label62_Click(object sender, EventArgs e)
        {

        }

        private void label63_Click(object sender, EventArgs e)
        {

        }

        private void label64_Click(object sender, EventArgs e)
        {

        }

        private void label65_Click(object sender, EventArgs e)
        {

        }

        private void label66_Click(object sender, EventArgs e)
        {

        }

        private void label67_Click(object sender, EventArgs e)
        {

        }

        private void label68_Click(object sender, EventArgs e)
        {

        }

        private void label69_Click(object sender, EventArgs e)
        {

        }

        private void label70_Click(object sender, EventArgs e)
        {

        }

        private void label51_Click(object sender, EventArgs e)
        {

        }

        private void label52_Click(object sender, EventArgs e)
        {

        }

        private void label53_Click(object sender, EventArgs e)
        {

        }

        private void label54_Click(object sender, EventArgs e)
        {

        }

        private void label55_Click(object sender, EventArgs e)
        {

        }

        private void label56_Click(object sender, EventArgs e)
        {

        }

        private void label57_Click(object sender, EventArgs e)
        {

        }

        private void label58_Click(object sender, EventArgs e)
        {

        }

        private void label59_Click(object sender, EventArgs e)
        {

        }

        private void label60_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void label44_Click(object sender, EventArgs e)
        {

        }

        private void label45_Click(object sender, EventArgs e)
        {

        }

        private void label46_Click(object sender, EventArgs e)
        {

        }

        private void label47_Click(object sender, EventArgs e)
        {

        }

        private void label48_Click(object sender, EventArgs e)
        {

        }

        private void label49_Click(object sender, EventArgs e)
        {

        }

        private void label50_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
