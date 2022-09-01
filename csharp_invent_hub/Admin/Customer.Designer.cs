namespace CSharp_Invent_HUB
{
    partial class Customer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            this.Customers_table_list = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_delete_but = new System.Windows.Forms.DataGridViewImageColumn();
            this.Customer_update_but = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Customers_table_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Customers_table_list
            // 
            this.Customers_table_list.AllowUserToAddRows = false;
            this.Customers_table_list.AllowUserToDeleteRows = false;
            this.Customers_table_list.AllowUserToOrderColumns = true;
            this.Customers_table_list.BackgroundColor = System.Drawing.Color.White;
            this.Customers_table_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Customers_table_list.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Customers_table_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Customers_table_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.Customer_id,
            this.Customer_name,
            this.Customer_phone,
            this.Customer_delete_but,
            this.Customer_update_but});
            this.Customers_table_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Customers_table_list.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.Customers_table_list.Location = new System.Drawing.Point(0, 0);
            this.Customers_table_list.MultiSelect = false;
            this.Customers_table_list.Name = "Customers_table_list";
            this.Customers_table_list.ReadOnly = true;
            this.Customers_table_list.RowHeadersVisible = false;
            this.Customers_table_list.RowHeadersWidth = 62;
            this.Customers_table_list.RowTemplate.Height = 33;
            this.Customers_table_list.ShowCellErrors = false;
            this.Customers_table_list.ShowCellToolTips = false;
            this.Customers_table_list.Size = new System.Drawing.Size(1073, 540);
            this.Customers_table_list.TabIndex = 0;
            this.Customers_table_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(933, 465);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Num
            // 
            this.Num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Num.HeaderText = "NO";
            this.Num.MinimumWidth = 8;
            this.Num.Name = "Num";
            this.Num.ReadOnly = true;
            this.Num.Width = 75;
            // 
            // Customer_id
            // 
            this.Customer_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Customer_id.HeaderText = "ID";
            this.Customer_id.MinimumWidth = 8;
            this.Customer_id.Name = "Customer_id";
            this.Customer_id.ReadOnly = true;
            this.Customer_id.Width = 66;
            // 
            // Customer_name
            // 
            this.Customer_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Customer_name.HeaderText = "CUSTOMER NAME";
            this.Customer_name.MinimumWidth = 8;
            this.Customer_name.Name = "Customer_name";
            this.Customer_name.ReadOnly = true;
            // 
            // Customer_phone
            // 
            this.Customer_phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Customer_phone.HeaderText = "PHONE";
            this.Customer_phone.MinimumWidth = 8;
            this.Customer_phone.Name = "Customer_phone";
            this.Customer_phone.ReadOnly = true;
            this.Customer_phone.Width = 107;
            // 
            // Customer_delete_but
            // 
            this.Customer_delete_but.HeaderText = "";
            this.Customer_delete_but.Image = ((System.Drawing.Image)(resources.GetObject("Customer_delete_but.Image")));
            this.Customer_delete_but.MinimumWidth = 8;
            this.Customer_delete_but.Name = "Customer_delete_but";
            this.Customer_delete_but.ReadOnly = true;
            this.Customer_delete_but.Width = 70;
            // 
            // Customer_update_but
            // 
            this.Customer_update_but.HeaderText = "";
            this.Customer_update_but.Image = ((System.Drawing.Image)(resources.GetObject("Customer_update_but.Image")));
            this.Customer_update_but.MinimumWidth = 8;
            this.Customer_update_but.Name = "Customer_update_but";
            this.Customer_update_but.ReadOnly = true;
            this.Customer_update_but.Width = 70;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 540);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Customers_table_list);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Customer";
            ((System.ComponentModel.ISupportInitialize)(this.Customers_table_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView Customers_table_list;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_phone;
        private System.Windows.Forms.DataGridViewImageColumn Customer_delete_but;
        private System.Windows.Forms.DataGridViewImageColumn Customer_update_but;
    }
}