using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris_3._3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void CmdSicher_Click(object sender, EventArgs e)
        {
            if (OptVar1.Checked)
            {
                CmdStarten.Visible = true;

                OptVar1.AutoCheck = false;
                OptVar2.AutoCheck = false;
                OptVar3.AutoCheck = false;
                OptVar4.AutoCheck = false;
                OptVar5.AutoCheck = false;
            }
            else if (OptVar2.Checked)
            {
                LblWieOft1.Visible = true;
                TxtWieOft1.Visible = true;
                CmdStarten.Visible = true;

                OptVar1.AutoCheck = false;
                OptVar2.AutoCheck = false;
                OptVar3.AutoCheck = false;
                OptVar4.AutoCheck = false;
                OptVar5.AutoCheck = false;
            }
            else if (OptVar3.Checked)
            {
                LblWieOft2.Visible = true;
                textBox1.Visible = true;
                CmdStarten.Visible = true;

                OptVar1.AutoCheck = false;
                OptVar2.AutoCheck = false;
                OptVar3.AutoCheck = false;
                OptVar4.AutoCheck = false;
                OptVar5.AutoCheck = false;
            }
            else if (OptVar4.Checked)
            {
                LblWieLange.Visible = true;
                TxtWieLang.Visible = true;
                CmdStarten.Visible = true;

                OptVar1.AutoCheck = false;
                OptVar2.AutoCheck = false;
                OptVar3.AutoCheck = false;
                OptVar4.AutoCheck = false;
                OptVar5.AutoCheck = false;
            }
            else if (OptVar4.Checked)
            {
                CmdStarten.Visible = true;

                OptVar1.AutoCheck = false;
                OptVar2.AutoCheck = false;
                OptVar3.AutoCheck = false;
                OptVar4.AutoCheck = false;
                OptVar5.AutoCheck = false;
            }

            if (OptVar1.Checked || OptVar2.Checked || OptVar3.Checked || OptVar4.Checked || OptVar5.Checked)
                CmdSicher.Visible = false;
                label1.Visible = false;
        }

        private void OptVar1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CmdStarten_Click(object sender, EventArgs e)
        {
            if (OptVar1.Checked)
            {
                while (true)
                    System.Diagnostics.Process.Start("Chrome.Exe");
            }
            else if (OptVar2.Checked)
            {
                int Amount = Convert.ToInt32(TxtWieOft1.Text);
                for (int i = 1; i <= Amount; i++)
                {
                    System.Diagnostics.Process.Start("Chrome.Exe");
                }
                System.Threading.Thread.Sleep(2000);
                Environment.Exit(-1);
            }
            else if (OptVar3.Checked)
            {
                int amount = Convert.ToInt32(textBox1.Text);
                for (int i = 1; i <= amount; i++)
                {
                    System.Diagnostics.Process.Start("https://www.google.com/");
                }
                System.Threading.Thread.Sleep(2000);
                Environment.Exit(-1);
            } else if (OptVar4.Checked)
            {
                int Amount = Convert.ToInt32(TxtWieLang.Text);

                DateTime start = DateTime.Now;

                while (DateTime.Now.Subtract(start).Seconds < Amount)
                {
                    System.Diagnostics.Process.Start("https://www.google.com/");
                }
                System.Threading.Thread.Sleep(2000);
                Environment.Exit(-1);
            } else if(OptVar5.Checked)
            {
                while(true)
                    System.Diagnostics.Process.Start("https://www.google.com/");
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
