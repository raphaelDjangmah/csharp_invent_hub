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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CSharp_Invent_HUB
{
    public partial class Users_Table : Form
    {
        public static string[] userDetails = new string[6];
        public static bool addUser = true; //true for adding a user... false for updating
        public Users_Table()
        {
            InitializeComponent();

            Users_table_list.EnableHeadersVisualStyles = false;
            Users_table_list.ColumnHeadersHeight = 60;
            Users_table_list.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            Users_table_list.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            //we query from the user details
            DbActivities db = new DbActivities();
            string query = String.Format("SELECT * FROM account_details", 1);
            MySqlConnection conn = db.connectDB("csharp_ia");
            MySqlDataReader reader = db.queryDB(query, conn);
            int lines = 1;

            while (reader.Read())
            {
                string[] array = new string[7];
                
                    array[0] = lines+"";
                    array[1] = reader["ID"].ToString();
                    array[2] = (string)reader["FIRSTNAME"];
                    array[3] =(string)reader["OTHERNAMES"];
                    array[4] = (string)reader["PASSWORD"];
                    array[5] = reader["EMAIL"].ToString();
                    array[6] = reader["PHONE"].ToString();


                Users_table_list.Rows.Add(array);
                lines++;
            }

            db.closeConnection();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(e.ToString());
        }

        private void Users_table_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = e.ColumnIndex;
            int rowIndex    = e.RowIndex;

            //if pressed either close remove or update
            if (columnIndex == 7 || columnIndex == 8)
            {

                DataGridViewRow row = Users_table_list.Rows[rowIndex];
                userDetails[0] = row.Cells[1].Value.ToString();
                userDetails[1] = row.Cells[2].Value.ToString();
                userDetails[2] = row.Cells[3].Value.ToString();
                userDetails[3] = row.Cells[4].Value.ToString();
                userDetails[4] = row.Cells[5].Value.ToString();
                userDetails[5] = row.Cells[6].Value.ToString();


                //if we are updating
                if (columnIndex == 7)
                {
                    addUser = false;  
                    //navigate to user update and fill the table
                    User_Add update = new User_Add();
                    update.Show();
                }
                else
                {
                    //if we are deleting from db
                    DbActivities db = new DbActivities();
                    string query = String.Format("DELETE FROM account_details WHERE ID={0};", Int32.Parse(userDetails[0]));
                    MySqlConnection conn = db.connectDB("csharp_ia");
                    MySqlDataReader reader = db.queryDB(query, conn);
                    MessageBox.Show("USER DELETED SUCCESSFULLY");
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            addUser = true;
            //navigate to user update and fill the table
            User_Add update = new User_Add();
            update.Show();
        }
    }
}

