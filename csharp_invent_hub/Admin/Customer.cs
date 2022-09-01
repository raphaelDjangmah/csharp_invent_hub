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

namespace CSharp_Invent_HUB
{
    public partial class Customer : Form
    {
        public static string[] customerDetails = new string[3];
        public static bool addCustomer = true; //true for adding a user... false for updating
        public Customer()
        {
            InitializeComponent();

            Customers_table_list.EnableHeadersVisualStyles = false;
            Customers_table_list.ColumnHeadersHeight = 60;
            Customers_table_list.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            Customers_table_list.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


            DbActivities db = new DbActivities();
            string query = String.Format("SELECT * FROM customer");
            MySqlConnection conn = db.connectDB("csharp_ia");
            MySqlDataReader reader = db.queryDB(query, conn);
            int lines = 1;

            while (reader.Read())
            {
                string[] array = new string[4];

                array[0] = lines + "";
                array[1] = reader["ID"].ToString();
                array[2] = (string)reader["NAME"];
                array[3] = reader["PHONE"].ToString();


                Customers_table_list.Rows.Add(array);
                lines++;
            }

            db.closeConnection();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = e.ColumnIndex;
            int rowIndex = e.RowIndex;


            //if pressed either close remove or update
            if (columnIndex == 4 || columnIndex == 5)
            {

                DataGridViewRow row = Customers_table_list.Rows[rowIndex];
                customerDetails[0] = row.Cells[1].Value.ToString();
                customerDetails[1] = row.Cells[2].Value.ToString();
                customerDetails[2] = row.Cells[3].Value.ToString();

                //if we are updating
                if (columnIndex == 4)
                {
                    addCustomer = false;
                    //navigate to user update and fill the table
                    Customers_Add update = new Customers_Add();
                    update.Show();
                }
                else
                {
                    //if we are deleting from db
                    DbActivities db = new DbActivities();
                    string query = String.Format("DELETE FROM customer WHERE ID={0};", Int32.Parse(customerDetails[0]));
                    MySqlConnection conn = db.connectDB("csharp_ia");
                    MySqlDataReader reader = db.queryDB(query, conn);
                    MessageBox.Show("CUSTOMER DELETED SUCCESSFULLY");
                }
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            addCustomer = true;
            //navigate to user update and fill the table
            Customers_Add update = new Customers_Add();
            update.Show();
        }
    }
}

