namespace CSharp_Invent_HUB.csharp_invent_hub.Admin
{
    partial class Category_Table
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Category_Table));
            this.Category_table_list = new System.Windows.Forms.DataGridView();
            this.Category_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_delete_but = new System.Windows.Forms.DataGridViewImageColumn();
            this.Customer_update_but = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Category_table_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Category_table_list
            // 
            this.Category_table_list.AllowUserToAddRows = false;
            this.Category_table_list.AllowUserToDeleteRows = false;
            this.Category_table_list.AllowUserToOrderColumns = true;
            this.Category_table_list.BackgroundColor = System.Drawing.Color.White;
            this.Category_table_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Category_table_list.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Category_table_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Category_table_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Category_num,
            this.Category_id,
            this.Category_name,
            this.Customer_delete_but,
            this.Customer_update_but});
            this.Category_table_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Category_table_list.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.Category_table_list.Location = new System.Drawing.Point(0, 0);
            this.Category_table_list.MultiSelect = false;
            this.Category_table_list.Name = "Category_table_list";
            this.Category_table_list.ReadOnly = true;
            this.Category_table_list.RowHeadersVisible = false;
            this.Category_table_list.RowHeadersWidth = 62;
            this.Category_table_list.RowTemplate.Height = 33;
            this.Category_table_list.ShowCellErrors = false;
            this.Category_table_list.ShowCellToolTips = false;
            this.Category_table_list.Size = new System.Drawing.Size(1073, 583);
            this.Category_table_list.TabIndex = 5;
            this.Category_table_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Category_table_list_CellContentClick);
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
            this.Category_id.HeaderText = "Category ID";
            this.Category_id.MinimumWidth = 8;
            this.Category_id.Name = "Category_id";
            this.Category_id.ReadOnly = true;
            this.Category_id.Width = 143;
            // 
            // Category_name
            // 
            this.Category_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Category_name.HeaderText = "CATEGORY NAME";
            this.Category_name.MinimumWidth = 8;
            this.Category_name.Name = "Category_name";
            this.Category_name.ReadOnly = true;
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
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Category_Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 583);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Category_table_list);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Category_Table";
            this.Text = "Category_Table";
            this.Load += new System.EventHandler(this.Category_Table_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Category_table_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Category_table_list;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category_name;
        private System.Windows.Forms.DataGridViewImageColumn Customer_delete_but;
        private System.Windows.Forms.DataGridViewImageColumn Customer_update_but;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}