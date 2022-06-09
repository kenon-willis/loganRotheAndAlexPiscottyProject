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
    public partial class Form1 : Form
    {
        public static int deaths = 0;
        public static bool level1 = false;
        public static bool level2 = false;
        public static bool level3 = false;
        public static bool level4 = false;
        public static bool level5 = false;
        public static bool level6 = false;
        public static bool level7 = false;
        public static bool level8 = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*if (level1 == false)
             button2.Visible = false;
             if (level2 == false)
                 button4.Visible = false;
             if (level3 == false)
                 button5.Visible = false;
            if (level4 == false)
                button6.Visible = false;
            if (level5 == false)
                button7.Visible = false;
            if (level6 == false)
                button9.Visible = false;
            if(level7==false)
                button10.Visible = false;
           */

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Form3 frm3 = new Form3();
            frm3.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form4 frm4 = new Form4();
            frm4.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            Form5 frm5 = new Form5();
            frm5.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            Form7 frm7 = new Form7();
            frm7.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
            Form6 frm6 = new Form6();
            frm6.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Hide();
            Form8 frm8 = new Form8();
            frm8.ShowDialog();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Hide();
            Form9 frm9 = new Form9();
            frm9.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Hide();
            Form10 frm10 = new Form10();
            frm10.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Hide();
            Form11 frm11 = new Form11();
            frm11.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
         deaths = 0;
         level1 = false;
         level2 = false;
         level3 = false;
         level4 = false;
         level5 = false;
         level6 = false;
         level7 = false;
         level8 = false;
         Form9. nah1 = false;
         Form9. nah2 = false;
         Form9. nah3 = false;
         Form9. nah4 = false;
         Form9. nah5 = false;
         Form9. nah6 = false;
         Form9. nah7 = false;
         Form9. nah8 = false;
         Form9. nah9 = false;
         Form9.nah10 = false;
         Form9.nah11 = false;
        }
    }
}
