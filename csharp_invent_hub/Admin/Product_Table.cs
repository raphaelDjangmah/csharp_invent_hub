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
    public partial class Product_Table : Form
    {
        public static string[] productDetails = new string[6];
        public static bool addProducts = true; //true for adding a user... false for updating

        public Product_Table()
        {
            InitializeComponent();

            Product_table_list.ColumnHeadersHeight = 60;
            Product_table_list.EnableHeadersVisualStyles = false;
            Product_table_list.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGreen;
            Product_table_list.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            DbActivities db = new DbActivities();
            string query = String.Format("SELECT * FROM products");
            MySqlConnection conn = db.connectDB("csharp_ia");
            MySqlDataReader reader = db.queryDB(query, conn);
            int lines = 1;

            while (reader.Read())
            {
                string[] array = new string[7];

                array[0] = lines + "";
                array[1] = reader["ID"].ToString();
                array[2] = (string)reader["NAME"];
                array[3] = reader["QTY"].ToString();
                array[4] = reader["PRICE"].ToString();
                array[5] = reader["DESCRIPTION"].ToString();
                array[6] = reader["CATEGORY"].ToString();



                Product_table_list.Rows.Add(array);
                lines++;
            }

            db.closeConnection();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = e.ColumnIndex;
            int rowIndex = e.RowIndex;

            //if pressed either close remove or update
            if (columnIndex == 7 || columnIndex == 8)
            {

                DataGridViewRow row = Product_table_list.Rows[rowIndex];
                productDetails[0] = row.Cells[1].Value.ToString();
                productDetails[1] = row.Cells[2].Value.ToString();
                productDetails[2] = row.Cells[3].Value.ToString();
                productDetails[3] = row.Cells[4].Value.ToString();
                productDetails[4] = row.Cells[5].Value.ToString();
                productDetails[5] = row.Cells[6].Value.ToString();

                //if we are updating
                if (columnIndex == 7)
                {
                    addProducts = false;
                    //navigate to user update and fill the table
                    ProductsAdd update = new ProductsAdd();
                    update.Show();
                }
                else
                {
                    //if we are deleting from db
                    DbActivities db = new DbActivities();
                    string query = String.Format("DELETE FROM products WHERE ID={0};", Int32.Parse(productDetails[0]));
                    MySqlConnection conn = db.connectDB("csharp_ia");
                    MySqlDataReader reader = db.queryDB(query, conn);
                    MessageBox.Show("PRODUCT DELETED SUCCESSFULLY");
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            addProducts = true;
            //navigate to user update and fill the table
            ProductsAdd update = new ProductsAdd();
            update.Show();
        }
    }
}

