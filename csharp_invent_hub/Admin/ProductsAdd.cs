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
    public partial class ProductsAdd : Form
    {
        public ProductsAdd()
        {
            InitializeComponent();

            if (Product_Table.addProducts)
            {
                update_products_btn.Text = "ADD";
                update_product_label.Text = "ADD A NEW PRODUCT";

                DbActivities db = new DbActivities();
                string query = String.Format("SELECT * FROM category;");
                MySqlConnection conn = db.connectDB("csharp_ia");
                MySqlDataReader reader = db.queryDB(query, conn);
                int lines = 1;

                string data="";

                while (reader.Read())
                {
                    data = (string)reader["NAME"];
                    update_product_combo.Items.Add(data);
                    lines++;
                }

                update_product_combo.Text = data;
                db.closeConnection();

            }
            else
            {
                string[] arr = Product_Table.productDetails;
                update_product_name.Text = arr[1];
                update_product_quantity.Text = arr[2];
                update_product_price.Text = arr[3];
                update_product_desc.Text = arr[4];
                update_product_combo.Text = arr[5];
            }
        }

        private void update_product_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void update_products_btn_Click(object sender, EventArgs e)
        {
            if (!Product_Table.addProducts)
            {
                DbActivities db = new DbActivities();
                string query = String.Format("UPDATE products SET NAME='{0}',QTY={1},PRICE={2},DESCRIPTION='{3}',CATEGORY='{4}' WHERE ID={5};",
                                           update_product_name.Text.ToString(), Int32.Parse(update_product_quantity.Text.ToString()),
                                           Double.Parse(update_product_price.Text),update_product_desc.Text.ToString(),update_product_combo.Text,
                                           Product_Table.productDetails[0]);
                MySqlConnection conn = db.connectDB("csharp_ia");
                MySqlDataReader reader = db.queryDB(query, conn);

                MessageBox.Show("PRODUCT UPDATE SUCCESSFULL");
            }
            else
            {
                DbActivities db = new DbActivities();
                string query = String.Format("INSERT INTO products(NAME,QTY,PRICE,DESCRIPTION,CATEGORY) VALUES('{0}',{1},{2},'{3}','{4}');",update_product_name.Text.ToString(), Int32.Parse(update_product_quantity.Text.ToString()),
                                             Double.Parse(update_product_price.Text), update_product_desc.Text.ToString(), update_product_combo.Text.ToString());
                MySqlConnection conn = db.connectDB("csharp_ia");
                MySqlDataReader reader = db.queryDB(query, conn);


                if (db.getReturnCode() < 1)
                {
                    MessageBox.Show("INSERT FAILED " + db.getReturnText());
                    return;
                }

                MessageBox.Show("NEW PRODUCT CREATED SUCCESSFULLY");
            }


            Hide();
        }

        private void update_product_desc_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProductsAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
