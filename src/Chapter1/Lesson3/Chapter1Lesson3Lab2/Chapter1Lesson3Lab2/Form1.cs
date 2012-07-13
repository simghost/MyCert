using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chapter1Lesson3Lab2
{
    public partial class Form1 : Form
    {
        int progress = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar.Maximum = 100;
            progressBar.Minimum = 0;
            progressBar.Value = 0;

            timer1.Tick += new EventHandler(t_Tick);
            timer1.Interval = 1000;
            timer1.Start();

        }

        public void t_Tick(object sender, EventArgs args)
        {
            progressBar.Value += 10;
            if (progressBar.Value == 100)
            {
                timer1.Stop();
                lblComplete.Visible = true;
                btnExit.Enabled = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
