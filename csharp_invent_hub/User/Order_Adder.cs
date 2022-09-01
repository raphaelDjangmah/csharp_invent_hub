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

namespace CSharp_Invent_HUB.csharp_invent_hub.User
{
    public partial class Order_Adder : Form
    {
        public Order_Adder()
        {
            InitializeComponent();

            //load all the categories and products
            DbActivities db = new DbActivities();
            string query = String.Format("SELECT * FROM products;");
            MySqlConnection conn = db.connectDB("csharp_ia");
            MySqlDataReader reader = db.queryDB(query, conn);
            int lines = 1;

            string data = "";
            string prodData = "";

            while (reader.Read())
            {
                data = (string)reader["CATEGORY"];
                update_order_category.Items.Add(data);

                prodData = (string)reader["NAME"];
                update_order_product.Items.Add(prodData);
                lines++;
            }

            db.closeConnection();

            if (AddOrders.addOrder)
            {
                update_order_label.Text = "ADD";
                update_order_btn.Text = "ADD A NEW ORDER";

                update_order_category.Text = data;
                update_order_product.Text = prodData;

            }
            else
            {
                string[] arr = AddOrders.orderDetails;
                update_order_category.Text = arr[2];
                update_order_category.Enabled = false;

                update_order_product.Text = arr[1];
                update_order_product.Enabled = false;

                update_od_quantity.Text = arr[3];

            }
        }

        private void update_order_btn_Click(object sender, EventArgs e)
        {

            double price = 0;
            int qty = 0;
            double amount = 0;
            string quantity = "";
            string date;
            DbActivities dbp = new DbActivities();

            try
            {
                //getting of price of the selected product and update the date added
                string queryp = String.Format("SELECT * FROM products WHERE NAME='{0}' AND CATEGORY='{1}';", update_order_product.Text,update_order_category.Text);
                MySqlConnection conn = dbp.connectDB("csharp_ia");
                MySqlDataReader reader = dbp.queryDB(queryp, conn);
                int lines = 1;

                while (reader.Read())
                {
                    price = Double.Parse(reader["PRICE"].ToString());

                    lines++;
                }


                quantity = update_od_quantity.Text.ToString();

                amount = price * (Int32.Parse(quantity));
                DateTime time = DateTime.UtcNow.Date;
                date = time + "";
                dbp.closeConnection();
            }
            catch (Exception ex){ MessageBox.Show("CHECK PRODUCT AND CATEGORY MATCH"); return; }

            if (!AddOrders.addOrder)
            {
                DbActivities db = new DbActivities();

                string query = String.Format("UPDATE orders SET CATEGORY='{0}',PRODUCT='{1}',QTY={2},PRICE={3},AMOUNT={4},DATECREATED='{5}' WHERE ID={6};",
                                           update_order_category.Text.ToString(), update_order_product.Text.ToString(),
                                           update_od_quantity.Text.ToString(),price,amount,date,
                                           AddOrders.orderDetails[0]);

                MySqlConnection connection = db.connectDB("csharp_ia");
                MySqlDataReader readers = db.queryDB(query, connection);

                MessageBox.Show(db.getReturnText()+"ab");
            }
            else
            {
                
                DbActivities db = new DbActivities();
                string query = String.Format("INSERT INTO orders(CATEGORY,PRODUCT,QTY,PRICE,AMOUNT,DATECREATED) VALUES('{0}','{1}',{2},{3},{4},'{5}');", 
                                update_order_category.Text.ToString(), update_order_product.Text.ToString(),
                                update_od_quantity.Text.ToString(), price,amount,date);
                MySqlConnection conns = db.connectDB("csharp_ia");
                MySqlDataReader readers = db.queryDB(query, conns);


                if (db.getReturnCode() < 1)
                {
                    MessageBox.Show("INSERT FAILED " + db.getReturnText());
                    return;
                }

                MessageBox.Show("NEW ORDER CREATED SUCCESSFULLY");
            }


            Hide();
        }

        private void Order_Adder_Load(object sender, EventArgs e)
        {

        }
    }
}



