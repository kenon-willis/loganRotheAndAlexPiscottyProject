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
    public partial class Form9 : Form
    {
        public Form9()
        {

            
            InitializeComponent();
        }
        public static bool nah1 = false;
        public static bool nah2 = false;
        public static bool nah3 = false;
        public static bool nah4 = false;
        public static bool nah5 = false;
        public static bool nah6 = false;
        public static bool nah7 = false;
        public static bool nah8 = false;
        public static bool nah9 = false;
        public static bool nah10 = false;
        public static bool nah11 = false;
        System.Media.SoundPlayer player = new System.Media.SoundPlayer(FunThingIdea.Properties.Resources.ytmp3free_cc_rick_astley_never_gonna_give_you_up_official_music_video_youtubemp3free_org);




        public static void Achieve()
        {
            


            if (nah1 == false)
            {
                if (Form1.deaths==15)
                {
                    
                    nah1 = true;
                    MessageBox.Show("Wow you really suck at this; Achievement unlocked");

                }
            }
            if (nah2 == false)
            {
                if (Form1.deaths == 30)
                {
                    nah2 = true;
                    MessageBox.Show("Are You Even Trying; Achievement unlocked");

                }
            }
            if (nah3 == false)
            {
                if (Form1.deaths == 50)
                {
                    nah3 = true;
                    MessageBox.Show("You Disappointment; Achievement unlocked");

                }
            }
            if (nah4 == false)
            {
                if (Form1.level2)
                {
                    nah4 = true;
                    MessageBox.Show("A Good Start; Achievement unlocked!");

                }
            }
            if (nah5 == false)
            {
                if (Form1.level3)
                {
                    nah5 = true;
                    MessageBox.Show("Master of Deception; Achievement unlocked!");

                }
            }
            if (nah6 == false)
            {
                if (Form1.level4)
                {
                    nah6 = true;
                    MessageBox.Show("Speedster; Achievement unlocked!");

                }
            }
            if (nah7 == false)
            {
                if (Form1.level5)
                {
                    nah7 = true;
                    MessageBox.Show("Perserverance; Achievement unlocked!");

                }
            }
            if (nah8 == false)
            {
                if (Form1.level6)
                {
                    nah8 = true;
                    MessageBox.Show("Portal Master; Achievement unlocked!");

                }
            }
            if (nah9 == false)
            {
                if (Form1.level7)
                {
                    nah9 = true;
                    MessageBox.Show("Slow and Steady; Achievement unlocked!");

                }
            }
            if (nah11 == false)
            {
                if (Form1.level1 && Form1.level2 && Form1.level3 && Form1.level4 && Form1.level5 && Form1.level6 && Form1.level7 && Form1.level8)
                {
                    nah11 = true;
                    MessageBox.Show("Full Completionist; Achievement unlocked!");

                }
            }
            if (nah10 == false)
            {
                if (Form1.level8)
                {
                    nah10 = true;
                    MessageBox.Show("I was Born in the Dark; Achievement unlocked!");

                }
            }
            


        }
        private void button1_Click(object sender, EventArgs e)
        {
            player.Stop();
            Hide();
            Form1 frm1 = new Form1();
            frm1.ShowDialog();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            if (Form1.deaths>14)
            {
                
                pictureBox1.Image = Properties.Resources.Check;

            }
            if (Form1.deaths > 29)
            {
                pictureBox3.Image = Properties.Resources.Check;
            }
            if (Form1.deaths > 49)
            {
                pictureBox2.Image = Properties.Resources.Check;
            }
            if(Form1.level2)
            {
                pictureBox4.Image = Properties.Resources.Check;
            }
            if (Form1.level3)
            {
                pictureBox5.Image = Properties.Resources.Check;
            }
            if (Form1.level4)
            {
                pictureBox6.Image = Properties.Resources.Check;
            }
            if (Form1.level5)
            {
                pictureBox7.Image = Properties.Resources.Check;
            }
            if (Form1.level6)
            {
                pictureBox8.Image = Properties.Resources.Check;
            }
            if (Form1.level7)
            {
                pictureBox9.Image = Properties.Resources.Check;
            }
            if (Form1.level8)
            {
                pictureBox10.Image = Properties.Resources.Check;
            }
            if (Form1.level1 && Form1.level2 && Form1.level3 && Form1.level4 && Form1.level5 && Form1.level6 && Form1.level7 && Form1.level8)
            {
                pictureBox11.Image = Properties.Resources.Check;
                player.PlayLooping();
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }
    }
    }

