namespace CSharp_Invent_HUB
{
    partial class Category
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Category));
            this.Users_table_list = new System.Windows.Forms.DataGridView();
            this.Category_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_delete_but = new System.Windows.Forms.DataGridViewImageColumn();
            this.Customer_update_but = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Users_table_list)).BeginInit();
            this.SuspendLayout();
            // 
            // Users_table_list
            // 
            this.Users_table_list.AllowUserToDeleteRows = false;
            this.Users_table_list.AllowUserToOrderColumns = true;
            this.Users_table_list.BackgroundColor = System.Drawing.Color.White;
            this.Users_table_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Users_table_list.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Users_table_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Users_table_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Category_name,
            this.Customer_id,
            this.Customer_name,
            this.Customer_delete_but,
            this.Customer_update_but});
            this.Users_table_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Users_table_list.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.Users_table_list.Location = new System.Drawing.Point(0, 0);
            this.Users_table_list.MultiSelect = false;
            this.Users_table_list.Name = "Users_table_list";
            this.Users_table_list.ReadOnly = true;
            this.Users_table_list.RowHeadersVisible = false;
            this.Users_table_list.RowHeadersWidth = 62;
            this.Users_table_list.RowTemplate.Height = 33;
            this.Users_table_list.ShowCellErrors = false;
            this.Users_table_list.ShowCellToolTips = false;
            this.Users_table_list.Size = new System.Drawing.Size(1059, 590);
            this.Users_table_list.TabIndex = 4;
            // 
            // Category_name
            // 
            this.Category_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Category_name.HeaderText = "NO";
            this.Category_name.MinimumWidth = 8;
            this.Category_name.Name = "Category_name";
            this.Category_name.ReadOnly = true;
            this.Category_name.Width = 75;
            // 
            // Customer_id
            // 
            this.Customer_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Customer_id.HeaderText = "PRODUCT ID";
            this.Customer_id.MinimumWidth = 8;
            this.Customer_id.Name = "Customer_id";
            this.Customer_id.ReadOnly = true;
            this.Customer_id.Width = 151;
            // 
            // Customer_name
            // 
            this.Customer_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Customer_name.HeaderText = "CATEGORY NAME";
            this.Customer_name.MinimumWidth = 8;
            this.Customer_name.Name = "Customer_name";
            this.Customer_name.ReadOnly = true;
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
            // login_inventory1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1059, 590);
            this.Controls.Add(this.Users_table_list);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login_inventory1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Users_table_list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Users_table_list;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_name;
        private System.Windows.Forms.DataGridViewImageColumn Customer_delete_but;
        private System.Windows.Forms.DataGridViewImageColumn Customer_update_but;
    }
}
