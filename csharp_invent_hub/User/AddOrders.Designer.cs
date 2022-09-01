namespace CSharp_Invent_HUB.csharp_invent_hub.User
{
    partial class AddOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrders));
            this.add_orders_table = new System.Windows.Forms.DataGridView();
            this.Category_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add_product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_delete_but = new System.Windows.Forms.DataGridViewImageColumn();
            this.Customer_update_but = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.order_add = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.add_orders_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_add)).BeginInit();
            this.SuspendLayout();
            // 
            // add_orders_table
            // 
            this.add_orders_table.AllowUserToAddRows = false;
            this.add_orders_table.AllowUserToDeleteRows = false;
            this.add_orders_table.AllowUserToOrderColumns = true;
            this.add_orders_table.BackgroundColor = System.Drawing.Color.White;
            this.add_orders_table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.add_orders_table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.add_orders_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.add_orders_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Category_num,
            this.Category_id,
            this.Category_name,
            this.add_product,
            this.QTY,
            this.Column1,
            this.Column3,
            this.Column2,
            this.Customer_delete_but,
            this.Customer_update_but});
            this.add_orders_table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add_orders_table.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.add_orders_table.Location = new System.Drawing.Point(0, 0);
            this.add_orders_table.MultiSelect = false;
            this.add_orders_table.Name = "add_orders_table";
            this.add_orders_table.ReadOnly = true;
            this.add_orders_table.RowHeadersVisible = false;
            this.add_orders_table.RowHeadersWidth = 62;
            this.add_orders_table.RowTemplate.Height = 33;
            this.add_orders_table.ShowCellErrors = false;
            this.add_orders_table.ShowCellToolTips = false;
            this.add_orders_table.Size = new System.Drawing.Size(1091, 615);
            this.add_orders_table.TabIndex = 7;
            this.add_orders_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.add_orders_table_CellContentClick);
            // 
            // Category_num
            // 
            this.Category_num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Category_num.HeaderText = "NO";
            this.Category_num.MinimumWidth = 8;
            this.Category_num.Name = "Category_num";
            this.Category_num.ReadOnly = true;
            this.Category_num.Width = 75;
            // 
            // Category_id
            // 
            this.Category_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Category_id.HeaderText = "ORDER ID";
            this.Category_id.MinimumWidth = 8;
            this.Category_id.Name = "Category_id";
            this.Category_id.ReadOnly = true;
            this.Category_id.Width = 119;
            // 
            // Category_name
            // 
            this.Category_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Category_name.HeaderText = "CATEGORY NAME";
            this.Category_name.MinimumWidth = 8;
            this.Category_name.Name = "Category_name";
            this.Category_name.ReadOnly = true;
            // 
            // add_product
            // 
            this.add_product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.add_product.HeaderText = "PRODUCT";
            this.add_product.MinimumWidth = 8;
            this.add_product.Name = "add_product";
            this.add_product.ReadOnly = true;
            // 
            // QTY
            // 
            this.QTY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.QTY.HeaderText = "QTY";
            this.QTY.MinimumWidth = 8;
            this.QTY.Name = "QTY";
            this.QTY.ReadOnly = true;
            this.QTY.Width = 80;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "AMOUNT";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 124;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "NET AMOUNT";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 147;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "DATE";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 90;
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(923, 508);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // order_add
            // 
            this.order_add.BackColor = System.Drawing.Color.White;
            this.order_add.Image = ((System.Drawing.Image)(resources.GetObject("order_add.Image")));
            this.order_add.Location = new System.Drawing.Point(884, 528);
            this.order_add.Name = "order_add";
            this.order_add.Size = new System.Drawing.Size(150, 75);
            this.order_add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.order_add.TabIndex = 9;
            this.order_add.TabStop = false;
            this.order_add.Click += new System.EventHandler(this.order_add_Click);
            // 
            // AddOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 615);
            this.Controls.Add(this.order_add);
            this.Controls.Add(this.add_orders_table);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddOrders";
            this.Text = "AddOrders";
            ((System.ComponentModel.ISupportInitialize)(this.add_orders_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_add)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView add_orders_table;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox order_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn add_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewImageColumn Customer_delete_but;
        private System.Windows.Forms.DataGridViewImageColumn Customer_update_but;
    }
}