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
    public partial class Category_Table : Form
    {
        public static string[] categoryDetails = new string[2];
        public static bool addCategory = true; //true for adding a user... false for updating
        public Category_Table()
        {
            InitializeComponent();

            Category_table_list.EnableHeadersVisualStyles = false;
            Category_table_list.ColumnHeadersHeight = 60;
            Category_table_list.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            Category_table_list.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            DbActivities db = new DbActivities();
            string query = String.Format("SELECT * FROM category");
            MySqlConnection conn = db.connectDB("csharp_ia");
            MySqlDataReader reader = db.queryDB(query, conn);
            int lines = 1;

            while (reader.Read())
            {
                string[] array = new string[3];

                array[0] = lines + "";
                array[1] = reader["ID"].ToString();
                array[2] = (string)reader["NAME"];


                Category_table_list.Rows.Add(array);
                lines++;
            }

            db.closeConnection();
        }

        private void Category_Table_Load(object sender, EventArgs e)
        {

        }

        private void Category_table_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int columnIndex = e.ColumnIndex;
            int rowIndex = e.RowIndex;

            //if pressed either close remove or update
            if (columnIndex == 3 || columnIndex == 4)
            {

                DataGridViewRow row = Category_table_list.Rows[rowIndex];
                categoryDetails[0] = row.Cells[1].Value.ToString();
                categoryDetails[1] = row.Cells[2].Value.ToString();

                //if we are updating
                if (columnIndex == 3)
                {
                    addCategory = false;
                    //navigate to user update and fill the table
                    CategoryAdd update = new CategoryAdd();
                    update.Show();
                }
                else
                {
                    //if we are deleting from db
                    DbActivities db = new DbActivities();
                    string query = String.Format("DELETE FROM category WHERE ID={0};", Int32.Parse(categoryDetails[0]));
                    MySqlConnection conn = db.connectDB("csharp_ia");
                    MySqlDataReader reader = db.queryDB(query, conn);
                    MessageBox.Show("CATEGORY DELETED SUCCESSFULLY");
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            addCategory = true;
            //navigate to user update and fill the table
            CategoryAdd update = new CategoryAdd();
            update.Show();
        }
    }
}
