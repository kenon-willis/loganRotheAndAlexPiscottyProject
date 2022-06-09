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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
        Label[,] myArray;
        Label[,] myArray1;
        bool left = false;
        bool flash = false;
        bool flash1 = false;
        bool right = false;
        bool Down = false;
        bool Up = false;
        int r = 1;
        int c = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 frm1 = new Form1();
            frm1.ShowDialog();
        }

        private void Form11_Load(object sender, EventArgs e)
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
            myArray1 = new Label[,]
            {
            { label113, label114, label115, label116, label118, label119, label120, label121, label122, label123, label124, label125, label126, label127, label128, label129},
            { label145, label144, label143, label142, label141, label140, label139, label138, label137, label136, label135,label134, label133, label132, label131, label130},
            { label161, label160, label159, label158, label157, label156, label155, label154, label153, label152, label151,label150, label149, label148, label147, label146},
            { label177, label176, label175, label174, label173, label172, label171, label170, label169, label168, label167,label166, label165, label164, label163, label162},
            { label193, label192, label191, label190, label189, label188, label187, label186, label185, label184, label183,label182, label181, label180, label179, label178},
            { label209, label208, label207, label206, label205, label204, label203, label202, label201, label200, label199,label198, label197, label196, label195, label194},
            { label225, label224, label223, label222, label221, label220, label219, label218, label217, label216, label215,label214, label213, label212, label211, label210}
            };
        }
        public void view()
        {
            if(r <6)
            {
                myArray1[r+1, c].Visible = false;
            }
            if (r > 0)
            {
                myArray1[r - 1, c].Visible = false;
            }
            if (c > 0)
            {
                myArray1[r, c-1].Visible = false;
            }
            if (c < 15)
            {
                myArray1[r, c +1].Visible = false;
            }
            if(r!=0 && c!=0)
            {
                
                myArray1[r - 1, c - 1].Visible = false;
            }
            if (r != 0 && c != 15)
            {
                
                myArray1[r - 1, c + 1].Visible = false;
            }
            if (r != 6 && c != 0)
            {
                
                myArray1[r + 1, c - 1].Visible = false;
            }
            if (r != 6 && c != 15)
            {
                
                myArray1[r + 1, c + 1].Visible = false;
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
            for (int i = 0; i < 7; i++)
            {
                for (int a = 0; a < 16; a++)
                {

                    myArray1[i, a].Visible = true;
                    myArray1[r, c].Visible = false;
                }
            }
        }
        bool lever = false;
        bool lever1 = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            check2();
            Form9.Achieve();
            move();
            view();
            check(0,0);
            check(0,2);
            check(0,1);
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
            check(2, 2);
            check(2, 1);
            check(2, 3);
            check(2, 4);
            check(2, 5);
            check(2, 6);
            check(2, 7);
            check(2, 8);
            check(2, 9);
            check(2, 12);
            check(2, 11);
            check(2, 12);
            check(3, 0);
            check(3, 1);
            check(4, 0);
            check(4, 1);
            check(4, 3);
            check(4, 4);
            check(4, 5);
            check(4, 6);
            check(4, 7);
            check(4, 8);
            check(4, 9);
            check(4, 10);
            check(4, 11);
            check(4, 12);
            check(4, 13);
            check(4, 14);
            check(6, 1);
            check(6, 2);
            check(6,3 );
            check(6, 4);
            check(6, 14);
            check(6, 5);
            check(6, 7);
            check(6, 6);
            check(6, 8);
            check(6, 9);
            check(6, 10);
            check(6, 11);
            check(6,12 );
            check(2,14 );
            check(3, 14);
            check(4, 14);
            check(5, 14);
            check3(6, 13, 5, 13, ref lever, 1,14);
            check3(6, 15, 5, 15, ref lever1,5,1);
            if (lever==false)
            {
                check(1, 14);
            }
            
           
            if (lever1 == false)
            {
                check(5, 1);
            }
           
            if (flash==false)
            {
                check(3, 4);
                check(3, 8);
                check(3, 12);
                check(5, 7);
                check(5, 12);

            }
            if (flash1 == false)
            {
                check(3, 6);
                check(3, 10);
                check(4, 2);
                check(5, 4);
                check(5, 5);
                check(5, 10);
            }
            
        }
        private void check2()
        {
            if (r == 6 && c == 0)
            {
                r = 1;
                c = 0;
                myArray[r, c].BackColor = Color.Green;
                Form1.level8 = true;
                Hide();
                Form1 frm1 = new Form1();
                frm1.ShowDialog();
            }
        }
        public void check(int alex, int logan)
        {
            if (r == alex && c == logan)
            {

                flash = false;
                flash1 = false;
                myArray[3, 4].BackColor = Color.Red;
                myArray[3, 8].BackColor = Color.Red;
                myArray[3, 12].BackColor = Color.Red;
                myArray[5, 7].BackColor = Color.Red;
                myArray[5, 12].BackColor = Color.Red;
                myArray[3, 6].BackColor = Color.Red;
                myArray[3, 10].BackColor = Color.Red;
                myArray[4, 2].BackColor = Color.Red;
                myArray[5, 4].BackColor = Color.Red;
                myArray[5, 5].BackColor = Color.Red;
                myArray[5, 10].BackColor = Color.Red;
                myArray[1, 14].BackColor = Color.Red;
                myArray[5, 1].BackColor = Color.Red;
                timer1.Stop();
                Form1.deaths++;
                label117.Text = ("Deaths: " + Form1.deaths.ToString());
                myArray[r, c].BackColor = Color.Red;
                r = 1;
                c = 0;
                myArray[r, c].BackColor = Color.Green;
                timer1.Start();
            }
        }
        private void Form11_KeyDown(object sender, KeyEventArgs e)
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
        public void check3(int num, int num1, int loc, int loc1, ref bool thing, int one, int two)
        {
            if (r == num && c == num1)
            {
                myArray[one,two ].BackColor = Color.White;
                thing = true;
                r = loc;
                c = loc1;
                myArray[num, num1].BackColor = Color.Maroon;
                myArray[r, c].BackColor = Color.Green;
            }
        }
        private void Form11_KeyUp(object sender, KeyEventArgs e)
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
        int th = -1;
        int th1 = 2;
        private void timer2_Tick(object sender, EventArgs e)
        {
            th++;
            int result1 = th % th1;
            if (result1 == 0)
            {
                flash = false;
                myArray[3, 4].BackColor = Color.Red;
                myArray[3, 8].BackColor = Color.Red;
                myArray[3, 12].BackColor = Color.Red;
                myArray[5, 7].BackColor = Color.Red;
                myArray[5, 12].BackColor = Color.Red;
                flash1 = true;
                myArray[3, 6].BackColor = Color.White;
                myArray[3, 10].BackColor = Color.White;
                myArray[5, 4].BackColor = Color.White;
                myArray[4, 2].BackColor = Color.White;
                myArray[5, 5].BackColor = Color.White;
                myArray[5, 10].BackColor = Color.White;

            }
            else if (result1 == 1)
            {
                flash = true;
                flash1 = false;
               
                myArray[3, 6].BackColor = Color.Red;
                myArray[3, 10].BackColor = Color.Red;
                myArray[4, 2].BackColor = Color.Red;
                myArray[5, 4].BackColor = Color.Red;
                myArray[5, 5].BackColor = Color.Red;
                myArray[5, 10].BackColor = Color.Red;
                //
                myArray[3, 4].BackColor = Color.White;
                myArray[3, 8].BackColor = Color.White;
                myArray[3, 12].BackColor = Color.White;
                myArray[5, 7].BackColor = Color.White;
                myArray[5, 12].BackColor = Color.White;
            }
        }
    }
}
