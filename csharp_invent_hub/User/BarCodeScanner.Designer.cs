namespace CSharp_Invent_HUB.csharp_invent_hub.User
{
    partial class BarCodeScanner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarCodeScanner));
            this.barcode_img = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barcode_img)).BeginInit();
            this.SuspendLayout();
            // 
            // barcode_img
            // 
            this.barcode_img.Image = ((System.Drawing.Image)(resources.GetObject("barcode_img.Image")));
            this.barcode_img.Location = new System.Drawing.Point(174, 93);
            this.barcode_img.Name = "barcode_img";
            this.barcode_img.Size = new System.Drawing.Size(317, 196);
            this.barcode_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.barcode_img.TabIndex = 0;
            this.barcode_img.TabStop = false;
            this.barcode_img.Click += new System.EventHandler(this.barcode_img_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(40, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(599, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "POINT SCANNER TO READ BARCODE ON PRODUCT";
            // 
            // BarCodeScanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(696, 325);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.barcode_img);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BarCodeScanner";
            this.Text = "BarCodeScanner";
            ((System.ComponentModel.ISupportInitialize)(this.barcode_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox barcode_img;
        private System.Windows.Forms.Label label1;
    }
}