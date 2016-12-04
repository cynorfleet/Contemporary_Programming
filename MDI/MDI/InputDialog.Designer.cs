namespace MDI
{
    partial class InputDialog
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
            this.BoxItemDetails = new System.Windows.Forms.GroupBox();
            this.labelID = new System.Windows.Forms.Label();
            this.labelItemName = new System.Windows.Forms.Label();
            this.labelQtyRequired = new System.Windows.Forms.Label();
            this.labelQtyonhand = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxQtyRequired = new System.Windows.Forms.TextBox();
            this.textBoxQty = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.BoxItemDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // BoxItemDetails
            // 
            this.BoxItemDetails.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BoxItemDetails.Controls.Add(this.textBoxName);
            this.BoxItemDetails.Controls.Add(this.textBoxQty);
            this.BoxItemDetails.Controls.Add(this.textBoxQtyRequired);
            this.BoxItemDetails.Controls.Add(this.textBoxID);
            this.BoxItemDetails.Controls.Add(this.labelQtyonhand);
            this.BoxItemDetails.Controls.Add(this.labelQtyRequired);
            this.BoxItemDetails.Controls.Add(this.labelItemName);
            this.BoxItemDetails.Controls.Add(this.labelID);
            this.BoxItemDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BoxItemDetails.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxItemDetails.Location = new System.Drawing.Point(34, 12);
            this.BoxItemDetails.Name = "BoxItemDetails";
            this.BoxItemDetails.Padding = new System.Windows.Forms.Padding(5);
            this.BoxItemDetails.Size = new System.Drawing.Size(471, 162);
            this.BoxItemDetails.TabIndex = 0;
            this.BoxItemDetails.TabStop = false;
            this.BoxItemDetails.Text = "Item Details";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(40, 30);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(51, 16);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "Item ID";
            // 
            // labelItemName
            // 
            this.labelItemName.AutoSize = true;
            this.labelItemName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemName.Location = new System.Drawing.Point(40, 63);
            this.labelItemName.Name = "labelItemName";
            this.labelItemName.Size = new System.Drawing.Size(74, 16);
            this.labelItemName.TabIndex = 1;
            this.labelItemName.Text = "Item Name";
            // 
            // labelQtyRequired
            // 
            this.labelQtyRequired.AutoSize = true;
            this.labelQtyRequired.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQtyRequired.Location = new System.Drawing.Point(40, 94);
            this.labelQtyRequired.Name = "labelQtyRequired";
            this.labelQtyRequired.Size = new System.Drawing.Size(92, 16);
            this.labelQtyRequired.TabIndex = 2;
            this.labelQtyRequired.Text = "Qty Required";
            // 
            // labelQtyonhand
            // 
            this.labelQtyonhand.AutoSize = true;
            this.labelQtyonhand.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQtyonhand.Location = new System.Drawing.Point(40, 128);
            this.labelQtyonhand.Name = "labelQtyonhand";
            this.labelQtyonhand.Size = new System.Drawing.Size(86, 16);
            this.labelQtyonhand.TabIndex = 3;
            this.labelQtyonhand.Text = "Qty on hand";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(167, 26);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(168, 22);
            this.textBoxID.TabIndex = 4;
            // 
            // textBoxQtyRequired
            // 
            this.textBoxQtyRequired.Location = new System.Drawing.Point(167, 90);
            this.textBoxQtyRequired.Name = "textBoxQtyRequired";
            this.textBoxQtyRequired.Size = new System.Drawing.Size(100, 22);
            this.textBoxQtyRequired.TabIndex = 5;
            // 
            // textBoxQty
            // 
            this.textBoxQty.Location = new System.Drawing.Point(167, 124);
            this.textBoxQty.Name = "textBoxQty";
            this.textBoxQty.Size = new System.Drawing.Size(100, 22);
            this.textBoxQty.TabIndex = 6;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(167, 59);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(247, 22);
            this.textBoxName.TabIndex = 7;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonCancel.Location = new System.Drawing.Point(219, 180);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(99, 39);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonOK.Location = new System.Drawing.Point(349, 180);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(99, 39);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // InputDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(539, 243);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.BoxItemDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "InputDialog";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InputDialog";
            this.BoxItemDetails.ResumeLayout(false);
            this.BoxItemDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox BoxItemDetails;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxQty;
        private System.Windows.Forms.TextBox textBoxQtyRequired;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelQtyonhand;
        private System.Windows.Forms.Label labelQtyRequired;
        private System.Windows.Forms.Label labelItemName;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
    }
}