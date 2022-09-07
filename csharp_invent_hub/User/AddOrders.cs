using CSharp_Invent_HUB.csharp_invent_hub.Admin;
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
   
    public partial class AddOrders : Form
    {
        public static string[] orderDetails = new string[7];
        public static bool addOrder = true; //true for adding a user... false for updating

        public AddOrders()
        {
            InitializeComponent();
            add_orders_table.ColumnHeadersHeight = 60;
            add_orders_table.EnableHeadersVisualStyles = false;
            add_orders_table.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGreen;
            add_orders_table.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


            //populate table
            DbActivities db = new DbActivities();
            string query = String.Format("SELECT * FROM orders");

            if ((User_Dashbord.searchQuery).Length > 0)
            {
                query = "SELECT * FROM orders where PRODUCT LIKE '%" + User_Dashbord.searchQuery + "%';";
            }

            MySqlConnection conn = db.connectDB("csharp_ia");
            MySqlDataReader reader = db.queryDB(query, conn);
            int lines = 1;

            while (reader.Read())
            {
                string[] array = new string[8];

                array[0] = lines + "";
                array[1] = reader["ID"].ToString();
                array[2] = (string)reader["CATEGORY"];
                array[3] = (string)reader["PRODUCT"];
                array[4] = reader["QTY"].ToString();
                array[5] = reader["PRICE"].ToString();
                array[6] = reader["AMOUNT"].ToString();
                array[7] = reader["DATECREATED"].ToString();



                add_orders_table.Rows.Add(array);
                lines++;
            }

            db.closeConnection();
        }

        private void add_orders_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = e.ColumnIndex;
            int rowIndex = e.RowIndex;


            //if pressed either close remove or update
            if (columnIndex == 8 || columnIndex == 9)
            {

                DataGridViewRow row = add_orders_table.Rows[rowIndex];
                orderDetails[0] = row.Cells[1].Value.ToString();
                orderDetails[1] = row.Cells[2].Value.ToString();
                orderDetails[2] = row.Cells[3].Value.ToString();
                orderDetails[3] = row.Cells[4].Value.ToString();
                orderDetails[4] = row.Cells[5].Value.ToString();
                orderDetails[5] = row.Cells[6].Value.ToString();
                orderDetails[6] = row.Cells[7].Value.ToString();

                //if we are updating
                if (columnIndex == 8)
                {
                    addOrder = false;
                    //navigate to user update and fill the table
                    Order_Adder update = new Order_Adder();
                    update.Show();
                }
                else
                {
                    //if we are deleting from db
                    DbActivities db = new DbActivities();
                    string query = String.Format("DELETE FROM orders WHERE ID={0};", Int32.Parse(orderDetails[0]));
                    MySqlConnection conn = db.connectDB("csharp_ia");
                    MySqlDataReader reader = db.queryDB(query, conn);
                    MessageBox.Show("ORDER DELETE SUCCESSFULLY");
                }
            }
        }

        private void order_add_Click(object sender, EventArgs e)
        {
            addOrder = true;
            //navigate to user update and fill the table
            Order_Adder update = new Order_Adder();
            update.Show();
        }
    }
}

