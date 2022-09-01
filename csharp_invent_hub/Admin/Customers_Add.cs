using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Invent_HUB.csharp_invent_hub.Admin
{
    public partial class Customers_Add : Form
    {
        public Customers_Add()
        {
            InitializeComponent();

            if (Customer.addCustomer)
            {
                customer_update_btn.Text = "ADD";
                customer_label_update.Text = "ADD A NEW CUSTOMER";

            }
            else
            {
                string[] arr = Customer.customerDetails;
                update_customer_name.Text = arr[1];
                update_customer_phone.Text = arr[2];
            }
        }

        private void customer_update_btn_Click(object sender, EventArgs e)
        {

            if (!Customer.addCustomer)
            {
                DbActivities db = new DbActivities();
                string query = String.Format("UPDATE customer SET NAME='{0}',PHONE={1} WHERE ID={1};",
                                           update_customer_name.Text.ToString(),Int32.Parse(update_customer_phone.Text.ToString()), Category_Table.categoryDetails[0]);
                MySqlConnection conn = db.connectDB("csharp_ia");
                MySqlDataReader reader = db.queryDB(query, conn);
                MessageBox.Show("CATEGORY UPDATED!");
            }
            else
            {
                DbActivities db = new DbActivities();
                string query = String.Format("INSERT INTO customer(NAME,PHONE) VALUES('{0}',{1}) ;", update_customer_name.Text.ToString(), Int32.Parse(update_customer_phone.Text.ToString()));
                MySqlConnection conn = db.connectDB("csharp_ia");
                MySqlDataReader reader = db.queryDB(query, conn);

                if (db.getReturnCode() < 1)
                {
                    MessageBox.Show("INSERT FAILED " + db.getReturnText());
                    return;
                }

                MessageBox.Show("NEW CUSTOMER CREATED SUCCESSFULLY");
            }


            Hide();

        }

        private void customer_label_update_Click(object sender, EventArgs e)
        {

        }

        private void update_customer_phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void update_customer_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
