namespace PROGRAM_5_abstract_shapes
{
    partial class Shape_Generator
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
            this.ShapeDropDown = new System.Windows.Forms.ComboBox();
            this.Inputcontainer = new System.Windows.Forms.GroupBox();
            this.Submit = new System.Windows.Forms.Button();
            this.InfoBox = new System.Windows.Forms.Label();
            this.Variable3 = new System.Windows.Forms.NumericUpDown();
            this.Variable2 = new System.Windows.Forms.NumericUpDown();
            this.Variable1 = new System.Windows.Forms.NumericUpDown();
            this.ImageContainer = new System.Windows.Forms.GroupBox();
            this.ShapeImage = new System.Windows.Forms.PictureBox();
            this.Inputcontainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Variable3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Variable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Variable1)).BeginInit();
            this.ImageContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShapeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // ShapeDropDown
            // 
            this.ShapeDropDown.DisplayMember = "Select Shape";
            this.ShapeDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShapeDropDown.FormattingEnabled = true;
            this.ShapeDropDown.Items.AddRange(new object[] {
            "Circle",
            "Sphere",
            "Cylinder",
            "Rectangle",
            "Square",
            "Cube"});
            this.ShapeDropDown.Location = new System.Drawing.Point(24, 193);
            this.ShapeDropDown.Name = "ShapeDropDown";
            this.ShapeDropDown.Size = new System.Drawing.Size(121, 21);
            this.ShapeDropDown.TabIndex = 0;
            this.ShapeDropDown.DropDownClosed += new System.EventHandler(this.ShapeDropDown_DropDownClosed);
            // 
            // Inputcontainer
            // 
            this.Inputcontainer.BackColor = System.Drawing.SystemColors.Control;
            this.Inputcontainer.Controls.Add(this.Submit);
            this.Inputcontainer.Controls.Add(this.InfoBox);
            this.Inputcontainer.Controls.Add(this.Variable3);
            this.Inputcontainer.Controls.Add(this.Variable2);
            this.Inputcontainer.Controls.Add(this.ShapeDropDown);
            this.Inputcontainer.Controls.Add(this.Variable1);
            this.Inputcontainer.Location = new System.Drawing.Point(17, 12);
            this.Inputcontainer.Name = "Inputcontainer";
            this.Inputcontainer.Size = new System.Drawing.Size(239, 224);
            this.Inputcontainer.TabIndex = 1;
            this.Inputcontainer.TabStop = false;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(151, 191);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(60, 23);
            this.Submit.TabIndex = 6;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // InfoBox
            // 
            this.InfoBox.BackColor = System.Drawing.SystemColors.Control;
            this.InfoBox.Location = new System.Drawing.Point(21, 16);
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.Size = new System.Drawing.Size(190, 110);
            this.InfoBox.TabIndex = 5;
            this.InfoBox.Text = "Chose a shape from the dropdown. This program will calculate area/volume/perimete" +
    "r/surface area. It will then generate a picture of selected shape.";
            this.InfoBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Variable3
            // 
            this.Variable3.DecimalPlaces = 3;
            this.Variable3.Enabled = false;
            this.Variable3.Location = new System.Drawing.Point(151, 142);
            this.Variable3.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.Variable3.Name = "Variable3";
            this.Variable3.Size = new System.Drawing.Size(60, 20);
            this.Variable3.TabIndex = 2;
            // 
            // Variable2
            // 
            this.Variable2.DecimalPlaces = 3;
            this.Variable2.Enabled = false;
            this.Variable2.Location = new System.Drawing.Point(87, 142);
            this.Variable2.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.Variable2.Name = "Variable2";
            this.Variable2.Size = new System.Drawing.Size(58, 20);
            this.Variable2.TabIndex = 1;
            // 
            // Variable1
            // 
            this.Variable1.DecimalPlaces = 3;
            this.Variable1.Enabled = false;
            this.Variable1.Location = new System.Drawing.Point(24, 142);
            this.Variable1.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.Variable1.Name = "Variable1";
            this.Variable1.Size = new System.Drawing.Size(60, 20);
            this.Variable1.TabIndex = 0;
            // 
            // ImageContainer
            // 
            this.ImageContainer.Controls.Add(this.ShapeImage);
            this.ImageContainer.Location = new System.Drawing.Point(17, 242);
            this.ImageContainer.Name = "ImageContainer";
            this.ImageContainer.Size = new System.Drawing.Size(239, 248);
            this.ImageContainer.TabIndex = 3;
            this.ImageContainer.TabStop = false;
            // 
            // ShapeImage
            // 
            this.ShapeImage.Location = new System.Drawing.Point(24, 29);
            this.ShapeImage.Name = "ShapeImage";
            this.ShapeImage.Size = new System.Drawing.Size(187, 190);
            this.ShapeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShapeImage.TabIndex = 0;
            this.ShapeImage.TabStop = false;
            // 
            // Shape_Generator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 499);
            this.Controls.Add(this.ImageContainer);
            this.Controls.Add(this.Inputcontainer);
            this.Name = "Shape_Generator";
            this.Text = "Shape Generator";
            this.Inputcontainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Variable3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Variable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Variable1)).EndInit();
            this.ImageContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ShapeImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ShapeDropDown;
        private System.Windows.Forms.GroupBox Inputcontainer;
        private System.Windows.Forms.NumericUpDown Variable3;
        private System.Windows.Forms.NumericUpDown Variable2;
        private System.Windows.Forms.NumericUpDown Variable1;
        private System.Windows.Forms.GroupBox ImageContainer;
        private System.Windows.Forms.PictureBox ShapeImage;
        private System.Windows.Forms.Label InfoBox;
        private System.Windows.Forms.Button Submit;
    }
}

