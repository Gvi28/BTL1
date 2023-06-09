﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_V1
{
    public partial class welcomeForm : Form
    {
        //move 
        private bool mouse;
        private Point lastPos; 

        public welcomeForm()
        {
            InitializeComponent();
        }

        //move function 
        private void welcomeForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouse = true;
            lastPos = e.Location;
        }

        private void welcomeForm_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouse)
            {
                this.Location = new Point((this.Location.X - lastPos.X) + e.X, (this.Location.Y - lastPos.Y) + e.Y);
                this.Update();
            }
        }

        private void welcomeForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void welcomeForm_Load(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 5;
            if(panel2.Width >= 750)
            {
                timer1.Stop();
                loginForm f = new loginForm();
                f.Show();
                this.Hide();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
