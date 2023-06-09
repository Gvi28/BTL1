﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_V1.Resources;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project_V1
{
    public partial class adminForm : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString);
        //private String username;

        //
        private manageEmployee viewEmp = new manageEmployee();
        private editInfo editInfo = new editInfo();
        private UserCont xemSP= new UserCont();
        private XemGH xemGH= new XemGH();
        private ThanhToan thanhToan= new ThanhToan();
       
        

        //move function 
        private Point mouse;

        //get info  
        public static string ID = "";
        public static string fname = "";
        public static string pos = "";
        public static string sex = "";
        public static string phone = "";
        public static string birth = "";
        public static string town = "";
        public static string mailD = "";
        public static string username = "";
        public static string password = "";
        public static int point = 0;

        public void getInfo()
        {
            ID = loginForm.ID;
            fname = loginForm.fname;
            //Select ID 
            String sSQL = "SELECT * FROM Employee WHERE " +
                           "ID_EMPLOYEE = '" + ID + "'";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                pos = dt.Rows[0]["POSITION"].ToString();
                sex = dt.Rows[0]["GENDER"].ToString();
                phone = dt.Rows[0]["PHONE"].ToString();
                birth = dt.Rows[0]["DOB"].ToString();
                town = dt.Rows[0]["HOMETOWN"].ToString();
                mailD = dt.Rows[0]["EMAIL"].ToString();
            }
            da.Dispose();
        }

        public void getAccount()
        {
            String sSQL = "SELECT * FROM Account WHERE " +
                           "ID = '" + ID + "'";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                username = dt.Rows[0]["USERNAME"].ToString();
                password = dt.Rows[0]["PASSWORD"].ToString();
            }
            da.Dispose();
        }

        private void adminForm_Load(object sender, EventArgs e)
        {
            getInfo();
            getAccount();
            displayName.Text = string.Empty;
            displayName.Text = fname;
        }

        private void adminForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouse = e.Location;
        }

        private void adminForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.Location.X - mouse.X;
                int dy = e.Location.Y - mouse.Y;
                this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);
            }
        }

        //

        public adminForm()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buttonIncome_Click(object sender, EventArgs e)
        {

        }

        private void btnEditInfo_Click(object sender, EventArgs e)
        {

        }

        private void panelAction_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEmp_Click(object sender, EventArgs e)
        {
            viewEmp.Dock = DockStyle.Fill;
            viewEmp.Show();
            panelAction.Controls.Add(viewEmp);
            viewEmp.BringToFront();
        }

        private void btnMoney_Click(object sender, EventArgs e)
        {
            xemSP.Dock = DockStyle.Fill;
            xemSP.Show();
            panelAction.Controls.Add(xemSP);
            xemSP.BringToFront();
        }

        private void btnEditI_Click(object sender, EventArgs e)
        {
            editInfo.Dock = DockStyle.Fill;
            editInfo.Show();
            panelAction.Controls.Add(editInfo);
            editInfo.BringToFront();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm f = new loginForm();
            f.FormClosed += (sender, e) => this.Close();
            f.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            editInfo.Dock = DockStyle.Fill;
            editInfo.Show();
            panelAction.Controls.Add(editInfo);
            editInfo.BringToFront();
        }

        private void panelTask_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panelPersonal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            xemSP.Dock = DockStyle.Fill;
            xemSP.Show();
            panelAction.Controls.Add(xemSP);
            xemSP.BringToFront();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            editInfo.Dock = DockStyle.Fill;
            editInfo.Show();
            panelAction.Controls.Add(editInfo);
            editInfo.BringToFront();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            xemGH.Dock = DockStyle.Fill;
            xemGH.Show();
            panelAction.Controls.Add(xemGH);
            xemGH.BringToFront();
       
        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click_2(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void panelTask_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click_3(object sender, EventArgs e)
        {
            thanhToan.Dock = DockStyle.Fill;
            thanhToan.Show();
            panelAction.Controls.Add(thanhToan);
            thanhToan.BringToFront();
        }
    }
}
