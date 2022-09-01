using CSharp_Invent_HUB.csharp_invent_hub.Backend;
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
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;

namespace CSharp_Invent_HUB
{
    public partial class Signup_Form : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private string OTP = "";
        public Signup_Form()
        {
            InitializeComponent();
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
            if (!checkInternet())
            {
                MessageBox.Show("NO INTERNET CONNECTION!");
                return;
            }

            //get values from the fields
            string inpFirstname = (firstname.Text.ToString());
            string inpOtherNames = (othernames.Text.ToString());
            string inpPwd        = (password.Text.ToString()).Trim();
            string inpConfirmPwd = (confirm_password.Text.ToString()).Trim();
            string inpEmail      = (email.Text.ToString()).Trim();
            string inpPhone      = (phone.Text.ToString()).Trim();
            string inpOTP        = (otp.Text.ToString()).Trim();
            

            //check for missing fields
            if(inpFirstname.Length<1 || inpOtherNames.Length < 1 || inpEmail.Length < 1 || inpPhone.Length < 1 || inpOTP.Length<1)
            {
                MessageBox.Show("All Fields Are Required!");
                return;
            }
            else
            {
                if (inpPwd != inpConfirmPwd)
                {
                    MessageBox.Show("Your Passwords Do Not Match");
                    return;
                }

                //check for OTP
                if (inpOTP != OTP)
                {
                    MessageBox.Show("Incorrect Verification Code! Try Again.");
                    return;
                }

                //now put the values in the database
                DbActivities db = new DbActivities();
                string query = String.Format("INSERT INTO ACCOUNT_DETAILS(FIRSTNAME,OTHERNAMES,PASSWORD,EMAIL,PHONE,TYPE) VALUES('{0}','{1}','{2}','{3}',{4},{5}) ;", inpFirstname, inpOtherNames, PwdHashing.hash(inpPwd), inpEmail, Int32.Parse(inpPhone), 1);
                MySqlConnection conn = db.connectDB("csharp_ia");
                MySqlDataReader reader = db.queryDB(query, conn);

                if (db.getReturnCode() < 1)
                {
                    MessageBox.Show("INSERT FAILED "+db.getReturnText());
                    return;
                }

                MessageBox.Show("ACCOUNT CREATED SUCCESSFULLY! PLEASE LOGIN");
                Login_Form login = new Login_Form();
                login.Show();
                Hide();

            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //SEEKING OTP.. generating 6 random numbers
            if(phone.Text.ToString().Length < 10)
            {
                MessageBox.Show("Phone Number Must be 10. Proceeding With Zero");
                return;
            }

            if (!sendOTP(phone.Text.ToString()+""))
            {
                MessageBox.Show("SMS send failed.. Check Phone Number!");
                return;
            }
            else
            {
                MessageBox.Show("Verification Code Sent To Phone");
            }

        }

        [System.Runtime.InteropServices.DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);
        public static bool checkInternet()
        {
            int desc;
            return InternetGetConnectedState(out desc, 0);
        }

        private bool sendOTP(string phoneNum)
        {

            if (!checkInternet())
            {
                return false;
            }

            Random rnd = new Random();

            for (int j = 0; j < 6; j++)
            {
                OTP+=(rnd.Next(10));//returns random integers < 10
            }

            string url = HttpUtility.UrlEncode("Your OTP is "+OTP);

            try
            {
                var request = (HttpWebRequest)WebRequest.Create("https://api.smsonlinegh.com/v4/message/sms/send?key=5faece05c73a4f3a0ec0b2c281cb38f495a8583b958856e31f0e5acc987e4538&text=" + url + "&type=0&sender=dreemFx&to="+ phoneNum);
                request.Method = "POST";
                var response = (HttpWebResponse)request.GetResponse();
                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

                return true;
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message.ToString());
            }

            return false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login_Form login = new Login_Form();
            login.Show();
            Hide();
        }

        private void confirm_password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
