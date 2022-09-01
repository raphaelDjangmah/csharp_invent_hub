namespace CSharp_Invent_HUB.csharp_invent_hub.Admin
{
    partial class ProductsAdd
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
            this.update_products_btn = new System.Windows.Forms.Button();
            this.update_product_quantity = new System.Windows.Forms.TextBox();
            this.update_product_name = new System.Windows.Forms.TextBox();
            this.update_product_label = new System.Windows.Forms.Label();
            this.update_product_price = new System.Windows.Forms.TextBox();
            this.update_product_desc = new System.Windows.Forms.TextBox();
            this.update_product_combo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // update_products_btn
            // 
            this.update_products_btn.BackColor = System.Drawing.Color.Green;
            this.update_products_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.update_products_btn.ForeColor = System.Drawing.Color.Transparent;
            this.update_products_btn.Location = new System.Drawing.Point(152, 607);
            this.update_products_btn.Name = "update_products_btn";
            this.update_products_btn.Size = new System.Drawing.Size(184, 49);
            this.update_products_btn.TabIndex = 7;
            this.update_products_btn.Text = "UPDATE";
            this.update_products_btn.UseVisualStyleBackColor = false;
            this.update_products_btn.Click += new System.EventHandler(this.update_products_btn_Click);
            // 
            // update_product_quantity
            // 
            this.update_product_quantity.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.update_product_quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.update_product_quantity.Location = new System.Drawing.Point(85, 212);
            this.update_product_quantity.Multiline = true;
            this.update_product_quantity.Name = "update_product_quantity";
            this.update_product_quantity.PlaceholderText = "Quantity";
            this.update_product_quantity.Size = new System.Drawing.Size(365, 49);
            this.update_product_quantity.TabIndex = 6;
            // 
            // update_product_name
            // 
            this.update_product_name.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.update_product_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.update_product_name.Location = new System.Drawing.Point(85, 129);
            this.update_product_name.Multiline = true;
            this.update_product_name.Name = "update_product_name";
            this.update_product_name.PlaceholderText = "Product Name";
            this.update_product_name.Size = new System.Drawing.Size(365, 49);
            this.update_product_name.TabIndex = 5;
            // 
            // update_product_label
            // 
            this.update_product_label.AutoSize = true;
            this.update_product_label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.update_product_label.Location = new System.Drawing.Point(110, 52);
            this.update_product_label.Name = "update_product_label";
            this.update_product_label.Size = new System.Drawing.Size(283, 41);
            this.update_product_label.TabIndex = 4;
            this.update_product_label.Text = "UPDATE PRODUCT";
            // 
            // update_product_price
            // 
            this.update_product_price.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.update_product_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.update_product_price.Location = new System.Drawing.Point(85, 290);
            this.update_product_price.Multiline = true;
            this.update_product_price.Name = "update_product_price";
            this.update_product_price.PlaceholderText = "Price";
            this.update_product_price.Size = new System.Drawing.Size(365, 49);
            this.update_product_price.TabIndex = 8;
            // 
            // update_product_desc
            // 
            this.update_product_desc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.update_product_desc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.update_product_desc.Location = new System.Drawing.Point(85, 373);
            this.update_product_desc.Multiline = true;
            this.update_product_desc.Name = "update_product_desc";
            this.update_product_desc.PlaceholderText = "Description";
            this.update_product_desc.Size = new System.Drawing.Size(365, 110);
            this.update_product_desc.TabIndex = 9;
            this.update_product_desc.TextChanged += new System.EventHandler(this.update_product_desc_TextChanged);
            // 
            // update_product_combo
            // 
            this.update_product_combo.FormattingEnabled = true;
            this.update_product_combo.Location = new System.Drawing.Point(85, 518);
            this.update_product_combo.Name = "update_product_combo";
            this.update_product_combo.Size = new System.Drawing.Size(365, 33);
            this.update_product_combo.TabIndex = 10;
            this.update_product_combo.SelectedIndexChanged += new System.EventHandler(this.update_product_combo_SelectedIndexChanged);
            // 
            // ProductsAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(531, 690);
            this.Controls.Add(this.update_product_combo);
            this.Controls.Add(this.update_product_desc);
            this.Controls.Add(this.update_product_price);
            this.Controls.Add(this.update_products_btn);
            this.Controls.Add(this.update_product_quantity);
            this.Controls.Add(this.update_product_name);
            this.Controls.Add(this.update_product_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ProductsAdd";
            this.Text = "ProductsAdd";
            this.Load += new System.EventHandler(this.ProductsAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button customer_update_btn;
        private System.Windows.Forms.TextBox update_product_quantity;
        private System.Windows.Forms.TextBox update_product_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox update_product_price;
        private System.Windows.Forms.TextBox update_product_desc;
        private System.Windows.Forms.ComboBox update_product_combo;
        private System.Windows.Forms.Button update_products_btn;
        private System.Windows.Forms.Label update_product_label;
    }
}