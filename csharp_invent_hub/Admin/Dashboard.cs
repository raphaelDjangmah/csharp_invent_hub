using CSharp_Invent_HUB.csharp_invent_hub.Admin;
using CSharp_Invent_HUB.csharp_invent_hub.User;
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
    public partial class Dashboard : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private string update = "";
        private string timeUpdate = "";
        public static bool itemSearch = false;
        public static string searchQuery = "";
        public Dashboard()
        {
            InitializeComponent();
            AdminName.Text = (Login_Form.username).ToString().ToUpper();

        }
        public void loadform(Object form)
        {
            if (this.HomePanel.Controls.Count > 0)
                this.HomePanel.Controls.RemoveAt(0);

            Form details = (Form)form;
            details.TopLevel = false;

            //set the updates
            DateTime thisDay = DateTime.Today;
            setTimeUpdate("Time : "+thisDay.ToString());
            setUpdates("Last Update : "+details.Name.ToString());

            details.Dock = DockStyle.Fill;
            this.HomePanel.Controls.Add(details);
            this.HomePanel.Tag = details;
            details.Show();

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


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login_Form signup = new Login_Form();
            signup.Show();
            Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserBox_Click(object sender, EventArgs e)
        {
            loadform(new Users_Table());
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            loadform(new Product_Table());
        }

        private void CategoryBox_Click(object sender, EventArgs e)
        {
            loadform(new Category_Table());
        }

        private void CustomerBox_Click(object sender, EventArgs e)
        {
            loadform(new Customer());
        }

        private void OrderBox_Click(object sender, EventArgs e)
        {
            loadform(new AddOrders());
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {
            
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            label2.Text=getUpdate();
        }

        public string getUpdate()
        {
            return update;
        }
        public void setUpdates(string update)
        {
            this.update = update;
            label2.Text = getUpdate();
            label3.Text = getTimeUpdate();
        }

        public string getTimeUpdate()
        {
            return timeUpdate;
        }
        public void setTimeUpdate(string timeUpdate)
        {
            this.timeUpdate= timeUpdate;
            label2.Text = getUpdate();
            label3.Text = getTimeUpdate();
        }

        private void user_search_TextChanged(object sender, EventArgs e)
        {
            itemSearch = true;
            searchQuery = user_search.Text.ToString();

            loadform(new Users_Table());
        }
    }
}
