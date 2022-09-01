using CSharp_Invent_HUB.csharp_invent_hub.Backend;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace CSharp_Invent_HUB.csharp_invent_hub.Admin
{
    public partial class User_Add : Form
    {
        public User_Add()
        {
            InitializeComponent();


            if (Users_Table.addUser)
            {
                updateButton.Text = "ADD";
                add_update_user.Text = "ADD A NEW USER";
            }
            else
            {
                string[] arr = Users_Table.userDetails;
                update_firstname.Text = arr[1];
                update_othernames.Text = arr[2];
                update_password.Text = "";
                update_email.Text = arr[4];
                update_phone.Text = arr[5];
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Users_Table.addUser)
            {
                DbActivities db = new DbActivities();
                string query = String.Format("UPDATE account_details SET FIRSTNAME='{0}',OTHERNAMES='{1}',EMAIL='{2}',PHONE={3} WHERE ID={4};",
                                            update_firstname.Text.ToString(), update_othernames.Text.ToString(), update_email.Text.ToString(), update_phone.Text, Users_Table.userDetails[0]);
                MySqlConnection conn = db.connectDB("csharp_ia");
                MySqlDataReader reader = db.queryDB(query, conn);
                MessageBox.Show("USER UPDATED!");
            }
            else
            {
                DbActivities db = new DbActivities();
                string query = String.Format("INSERT INTO ACCOUNT_DETAILS(FIRSTNAME,OTHERNAMES,PASSWORD,EMAIL,PHONE,TYPE) VALUES('{0}','{1}','{2}','{3}',{4},{5}) ;", 
                    update_firstname.Text, update_othernames.Text, PwdHashing.hash(update_password.Text),
                    update_email.Text, Int32.Parse(update_phone.Text), 0);
                MySqlConnection conn = db.connectDB("csharp_ia");
                MySqlDataReader reader = db.queryDB(query, conn);

                if (db.getReturnCode() < 1)
                {
                    MessageBox.Show("INSERT FAILED " + db.getReturnText());
                    return;
                }

                MessageBox.Show("USER CREATED SUCCESSFULLY");
            }
            

            Hide();
        }

        private void updatePhone_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
