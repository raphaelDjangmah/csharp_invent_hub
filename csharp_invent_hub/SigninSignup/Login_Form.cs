using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;
using Application = System.Windows.Forms.Application;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Security.Cryptography;
using Org.BouncyCastle.Crypto.Generators;
using CSharp_Invent_HUB.csharp_invent_hub.Backend;

namespace CSharp_Invent_HUB
{
    public partial class Login_Form : Form
    {
        private static readonly HttpClient client = new HttpClient();
        public static string username = "";

        public Login_Form()
        {
            InitializeComponent();

            password_invisible.Image = Properties.Resources.eye;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            //making sure there exists details of login user
            string phoneOrEmail = login_phone.Text.ToString();
            string password = login_password.Text.ToString();

            //check for null variables
            if(phoneOrEmail.Length<=0 || password.Length<=0)
            {
                MessageBox.Show("Email/Phone Or Password Field Cannot be NULL");
                return;
            }

            //connect to database with the details given
            DbActivities db = new DbActivities();
            string query = String.Format("SELECT * FROM account_details WHERE email='{0}' OR phone='{1}';", phoneOrEmail,phoneOrEmail);
            MySqlConnection conn = db.connectDB("csharp_ia");
            MySqlDataReader reader = db.queryDB(query,conn);

            int lines = 0;
            string pwd="";
            int type = 1;

            while (reader.Read()) { lines++; pwd = (string)reader["PASSWORD"]; type = Int32.Parse((string)reader["TYPE"].ToString()); username = (string)reader["FIRSTNAME"]; }

            //check if the user exists
            if (lines == 0)
            {
                MessageBox.Show("Email Of Phone Does Not Exists");
                return;
            }
            else
            {
                //check for password
                if (!PwdHashing.verifyHash(password, pwd))
                {
                    MessageBox.Show("Incorrect Password! Try again");
                    return;
                }


                //login verified... go to admin page or user page depending on the type
                if (type == 0)
                {
                    User_Dashbord dashboard = new User_Dashbord();
                    dashboard.Show();
                    Hide();
                }
                else
                {
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    Hide();
                }

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup_Form signup = new Signup_Form();
            signup.Show();
            Hide();
        }

        private void login_password_TextChanged(object sender, EventArgs e)
        {
            
        }

        bool visible = false;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (visible)
            {
                password_invisible.Image = Properties.Resources.hidden;
                visible = false;
                login_password.UseSystemPasswordChar = true;
            }
            else
            {
                password_invisible.Image = Properties.Resources.eye;
                login_password.UseSystemPasswordChar = false;
                visible = true;
            }
            
        }

        private void password_visible_Click(object sender, EventArgs e)
        {

        }
    }
}

