using CSharp_Invent_HUB.csharp_invent_hub.Backend;
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
    public partial class CategoryAdd : Form
    {
        public CategoryAdd()
        {
            InitializeComponent();

            if (Category_Table.addCategory)
            {
                add_category_btn.Text = "ADD";
                add_category_label.Text = "ADD A NEW CATEGORY";
            }
            else
            {
                string[] arr = Category_Table.categoryDetails;
                add_category_box.Text = arr[1];
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void add_category_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_category_btn_Click(object sender, EventArgs e)
        {

            if (!Category_Table.addCategory)
            {
                DbActivities db = new DbActivities();
                string query = String.Format("UPDATE category SET NAME='{0}' WHERE ID={1};",
                                            add_category_box.Text.ToString(), Category_Table.categoryDetails[0]);
                MySqlConnection conn = db.connectDB("csharp_ia");
                MySqlDataReader reader = db.queryDB(query, conn);
                MessageBox.Show("CATEGORY UPDATED!");
            }
            else
            {
                DbActivities db = new DbActivities();
                string query = String.Format("INSERT INTO category(NAME) VALUES('{0}') ;",add_category_box.Text.ToString());
                MySqlConnection conn = db.connectDB("csharp_ia");
                MySqlDataReader reader = db.queryDB(query, conn);

                if (db.getReturnCode() < 1)
                {
                    MessageBox.Show("INSERT FAILED " + db.getReturnText());
                    return;
                }

                MessageBox.Show("NEW CATEGORY CREATED SUCCESSFULLY");
            }


            Hide();

        }

        private void CategoryAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
