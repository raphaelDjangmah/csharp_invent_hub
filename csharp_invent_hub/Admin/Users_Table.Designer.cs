namespace CSharp_Invent_HUB
{
    partial class Users_Table
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users_Table));
            this.Users_table_list = new System.Windows.Forms.DataGridView();
            this.Category_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete_but = new System.Windows.Forms.DataGridViewImageColumn();
            this.update_but = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Users_table_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Users_table_list
            // 
            this.Users_table_list.AllowUserToAddRows = false;
            this.Users_table_list.AllowUserToDeleteRows = false;
            this.Users_table_list.AllowUserToOrderColumns = true;
            this.Users_table_list.BackgroundColor = System.Drawing.Color.White;
            this.Users_table_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Users_table_list.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Users_table_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Users_table_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Category_name,
            this.User_id,
            this.user_firstname,
            this.User_lastname,
            this.User_password,
            this.user_email,
            this.User_phone,
            this.delete_but,
            this.update_but});
            this.Users_table_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Users_table_list.GridColor = System.Drawing.SystemColors.ControlLight;
            this.Users_table_list.Location = new System.Drawing.Point(0, 0);
            this.Users_table_list.MultiSelect = false;
            this.Users_table_list.Name = "Users_table_list";
            this.Users_table_list.ReadOnly = true;
            this.Users_table_list.RowHeadersVisible = false;
            this.Users_table_list.RowHeadersWidth = 62;
            this.Users_table_list.RowTemplate.Height = 33;
            this.Users_table_list.ShowCellErrors = false;
            this.Users_table_list.ShowCellToolTips = false;
            this.Users_table_list.Size = new System.Drawing.Size(1059, 540);
            this.Users_table_list.TabIndex = 3;
            this.Users_table_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Users_table_list_CellContentClick);
            // 
            // Category_name
            // 
            this.Category_name.HeaderText = "NO";
            this.Category_name.MinimumWidth = 8;
            this.Category_name.Name = "Category_name";
            this.Category_name.ReadOnly = true;
            this.Category_name.Width = 75;
            // 
            // User_id
            // 
            this.User_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.User_id.HeaderText = "USER ID";
            this.User_id.MinimumWidth = 8;
            this.User_id.Name = "User_id";
            this.User_id.ReadOnly = true;
            this.User_id.Width = 113;
            // 
            // user_firstname
            // 
            this.user_firstname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.user_firstname.HeaderText = "FIRST NAME";
            this.user_firstname.MinimumWidth = 8;
            this.user_firstname.Name = "user_firstname";
            this.user_firstname.ReadOnly = true;
            // 
            // User_lastname
            // 
            this.User_lastname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.User_lastname.HeaderText = "OTHER NAMES";
            this.User_lastname.MinimumWidth = 8;
            this.User_lastname.Name = "User_lastname";
            this.User_lastname.ReadOnly = true;
            // 
            // User_password
            // 
            this.User_password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.User_password.HeaderText = "PASSWORD";
            this.User_password.MinimumWidth = 8;
            this.User_password.Name = "User_password";
            this.User_password.ReadOnly = true;
            // 
            // user_email
            // 
            this.user_email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.user_email.HeaderText = "EMAIL";
            this.user_email.MinimumWidth = 8;
            this.user_email.Name = "user_email";
            this.user_email.ReadOnly = true;
            this.user_email.Width = 98;
            // 
            // User_phone
            // 
            this.User_phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.User_phone.HeaderText = "PHONE";
            this.User_phone.MinimumWidth = 8;
            this.User_phone.Name = "User_phone";
            this.User_phone.ReadOnly = true;
            this.User_phone.Width = 107;
            // 
            // delete_but
            // 
            this.delete_but.HeaderText = "";
            this.delete_but.Image = ((System.Drawing.Image)(resources.GetObject("delete_but.Image")));
            this.delete_but.MinimumWidth = 8;
            this.delete_but.Name = "delete_but";
            this.delete_but.ReadOnly = true;
            this.delete_but.Width = 70;
            // 
            // update_but
            // 
            this.update_but.HeaderText = "";
            this.update_but.Image = ((System.Drawing.Image)(resources.GetObject("update_but.Image")));
            this.update_but.MinimumWidth = 8;
            this.update_but.Name = "update_but";
            this.update_but.ReadOnly = true;
            this.update_but.Width = 70;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(909, 465);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Users_Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 540);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Users_table_list);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Users_Table";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Users_Table";
            ((System.ComponentModel.ISupportInitialize)(this.Users_table_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Users_table_list;
        private System.Windows.Forms.DataGridViewImageColumn Customer_delete_but;
        private System.Windows.Forms.DataGridViewImageColumn Customer_update_but;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_password;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_phone;
        private System.Windows.Forms.DataGridViewImageColumn delete_but;
        private System.Windows.Forms.DataGridViewImageColumn update_but;
    }
}