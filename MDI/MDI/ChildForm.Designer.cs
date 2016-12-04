namespace MDI
{
    partial class ChildForm
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
            this.labelDetails = new System.Windows.Forms.Label();
            this.ListItem = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QuantityRequired = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // labelDetails
            // 
            this.labelDetails.AutoSize = true;
            this.labelDetails.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetails.Location = new System.Drawing.Point(36, 18);
            this.labelDetails.Name = "labelDetails";
            this.labelDetails.Size = new System.Drawing.Size(266, 23);
            this.labelDetails.TabIndex = 0;
            this.labelDetails.Text = "***SUPPLY ITEM DETAILS***";
            // 
            // ListItem
            // 
            this.ListItem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.ProductName,
            this.QuantityRequired,
            this.Quantity});
            this.ListItem.FullRowSelect = true;
            this.ListItem.GridLines = true;
            this.ListItem.Location = new System.Drawing.Point(40, 143);
            this.ListItem.Name = "ListItem";
            this.ListItem.Size = new System.Drawing.Size(447, 318);
            this.ListItem.TabIndex = 1;
            this.ListItem.UseCompatibleStateImageBehavior = false;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 50;
            // 
            // ProductName
            // 
            this.ProductName.Text = "Name";
            this.ProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProductName.Width = 100;
            // 
            // QuantityRequired
            // 
            this.QuantityRequired.Text = "Quantity Required";
            this.QuantityRequired.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.QuantityRequired.Width = 100;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantity";
            this.Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Quantity.Width = 100;
            // 
            // ChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(551, 503);
            this.Controls.Add(this.ListItem);
            this.Controls.Add(this.labelDetails);
            this.Name = "ChildForm";
            this.Text = "ChildForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChildForm_FormClosing);
            this.Load += new System.EventHandler(this.ChildForm_Load);
            this.Enter += new System.EventHandler(this.ChildForm_Enter);
            this.Leave += new System.EventHandler(this.ChildForm_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDetails;
        public System.Windows.Forms.ColumnHeader ID;
        public System.Windows.Forms.ColumnHeader ProductName;
        public System.Windows.Forms.ColumnHeader QuantityRequired;
        public System.Windows.Forms.ColumnHeader Quantity;
        public System.Windows.Forms.ListView ListItem;
    }
}