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
            this.ImageContainer = new System.Windows.Forms.GroupBox();
            this.ShapeImage = new System.Windows.Forms.PictureBox();
            this.Variable1 = new System.Windows.Forms.NumericUpDown();
            this.Variable2 = new System.Windows.Forms.NumericUpDown();
            this.Variable3 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.y1 = new System.Windows.Forms.GroupBox();
            this.x2 = new System.Windows.Forms.GroupBox();
            this.y2 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.x3 = new System.Windows.Forms.GroupBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.y3 = new System.Windows.Forms.GroupBox();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.x4 = new System.Windows.Forms.GroupBox();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.y4 = new System.Windows.Forms.GroupBox();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.radius = new System.Windows.Forms.GroupBox();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.helpbox = new System.Windows.Forms.Label();
            this.Inputcontainer.SuspendLayout();
            this.ImageContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShapeImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Variable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Variable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Variable3)).BeginInit();
            this.x2.SuspendLayout();
            this.y2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.x3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.y3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.x4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.y4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            this.radius.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
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
            this.ShapeDropDown.Location = new System.Drawing.Point(357, 141);
            this.ShapeDropDown.Name = "ShapeDropDown";
            this.ShapeDropDown.Size = new System.Drawing.Size(126, 21);
            this.ShapeDropDown.TabIndex = 0;
            this.ShapeDropDown.DropDownClosed += new System.EventHandler(this.ShapeDropDown_DropDownClosed);
            // 
            // Inputcontainer
            // 
            this.Inputcontainer.BackColor = System.Drawing.SystemColors.Control;
            this.Inputcontainer.Controls.Add(this.radius);
            this.Inputcontainer.Controls.Add(this.y4);
            this.Inputcontainer.Controls.Add(this.x4);
            this.Inputcontainer.Controls.Add(this.y3);
            this.Inputcontainer.Controls.Add(this.InfoBox);
            this.Inputcontainer.Controls.Add(this.x3);
            this.Inputcontainer.Controls.Add(this.y2);
            this.Inputcontainer.Controls.Add(this.Variable2);
            this.Inputcontainer.Controls.Add(this.Variable1);
            this.Inputcontainer.Controls.Add(this.groupBox1);
            this.Inputcontainer.Controls.Add(this.y1);
            this.Inputcontainer.Controls.Add(this.x2);
            this.Inputcontainer.Location = new System.Drawing.Point(17, 12);
            this.Inputcontainer.Name = "Inputcontainer";
            this.Inputcontainer.Size = new System.Drawing.Size(317, 475);
            this.Inputcontainer.TabIndex = 1;
            this.Inputcontainer.TabStop = false;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(357, 198);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(126, 23);
            this.Submit.TabIndex = 6;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // InfoBox
            // 
            this.InfoBox.BackColor = System.Drawing.SystemColors.Control;
            this.InfoBox.Location = new System.Drawing.Point(18, 16);
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.Size = new System.Drawing.Size(263, 110);
            this.InfoBox.TabIndex = 5;
            this.InfoBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ImageContainer
            // 
            this.ImageContainer.Controls.Add(this.ShapeImage);
            this.ImageContainer.Location = new System.Drawing.Point(335, 239);
            this.ImageContainer.Name = "ImageContainer";
            this.ImageContainer.Size = new System.Drawing.Size(317, 248);
            this.ImageContainer.TabIndex = 3;
            this.ImageContainer.TabStop = false;
            // 
            // ShapeImage
            // 
            this.ShapeImage.Location = new System.Drawing.Point(24, 29);
            this.ShapeImage.Name = "ShapeImage";
            this.ShapeImage.Size = new System.Drawing.Size(260, 190);
            this.ShapeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShapeImage.TabIndex = 0;
            this.ShapeImage.TabStop = false;
            // 
            // Variable1
            // 
            this.Variable1.DecimalPlaces = 3;
            this.Variable1.Enabled = false;
            this.Variable1.Location = new System.Drawing.Point(24, 148);
            this.Variable1.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.Variable1.Name = "Variable1";
            this.Variable1.Size = new System.Drawing.Size(60, 20);
            this.Variable1.TabIndex = 0;
            // 
            // Variable2
            // 
            this.Variable2.DecimalPlaces = 3;
            this.Variable2.Enabled = false;
            this.Variable2.Location = new System.Drawing.Point(90, 148);
            this.Variable2.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.Variable2.Name = "Variable2";
            this.Variable2.Size = new System.Drawing.Size(55, 20);
            this.Variable2.TabIndex = 1;
            // 
            // Variable3
            // 
            this.Variable3.DecimalPlaces = 3;
            this.Variable3.Enabled = false;
            this.Variable3.Location = new System.Drawing.Point(0, 19);
            this.Variable3.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.Variable3.Name = "Variable3";
            this.Variable3.Size = new System.Drawing.Size(60, 20);
            this.Variable3.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(21, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(63, 51);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "x1";
            // 
            // y1
            // 
            this.y1.Location = new System.Drawing.Point(90, 129);
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(63, 51);
            this.y1.TabIndex = 9;
            this.y1.TabStop = false;
            this.y1.Text = "y1";
            // 
            // x2
            // 
            this.x2.Controls.Add(this.Variable3);
            this.x2.Location = new System.Drawing.Point(24, 186);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(63, 51);
            this.x2.TabIndex = 10;
            this.x2.TabStop = false;
            this.x2.Text = "x2";
            // 
            // y2
            // 
            this.y2.Controls.Add(this.numericUpDown1);
            this.y2.Location = new System.Drawing.Point(93, 186);
            this.y2.Name = "y2";
            this.y2.Size = new System.Drawing.Size(63, 51);
            this.y2.TabIndex = 11;
            this.y2.TabStop = false;
            this.y2.Text = "y2";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 3;
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Location = new System.Drawing.Point(0, 19);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown1.TabIndex = 2;
            // 
            // x3
            // 
            this.x3.Controls.Add(this.numericUpDown2);
            this.x3.Location = new System.Drawing.Point(24, 256);
            this.x3.Name = "x3";
            this.x3.Size = new System.Drawing.Size(63, 51);
            this.x3.TabIndex = 12;
            this.x3.TabStop = false;
            this.x3.Text = "x3";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 3;
            this.numericUpDown2.Enabled = false;
            this.numericUpDown2.Location = new System.Drawing.Point(0, 19);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown2.TabIndex = 2;
            // 
            // y3
            // 
            this.y3.Controls.Add(this.numericUpDown3);
            this.y3.Location = new System.Drawing.Point(93, 256);
            this.y3.Name = "y3";
            this.y3.Size = new System.Drawing.Size(63, 51);
            this.y3.TabIndex = 13;
            this.y3.TabStop = false;
            this.y3.Text = "y3";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.DecimalPlaces = 3;
            this.numericUpDown3.Enabled = false;
            this.numericUpDown3.Location = new System.Drawing.Point(0, 19);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown3.TabIndex = 2;
            // 
            // x4
            // 
            this.x4.Controls.Add(this.numericUpDown4);
            this.x4.Location = new System.Drawing.Point(24, 323);
            this.x4.Name = "x4";
            this.x4.Size = new System.Drawing.Size(63, 51);
            this.x4.TabIndex = 14;
            this.x4.TabStop = false;
            this.x4.Text = "x4";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.DecimalPlaces = 3;
            this.numericUpDown4.Enabled = false;
            this.numericUpDown4.Location = new System.Drawing.Point(0, 19);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown4.TabIndex = 2;
            // 
            // y4
            // 
            this.y4.Controls.Add(this.numericUpDown5);
            this.y4.Location = new System.Drawing.Point(93, 323);
            this.y4.Name = "y4";
            this.y4.Size = new System.Drawing.Size(63, 51);
            this.y4.TabIndex = 15;
            this.y4.TabStop = false;
            this.y4.Text = "44";
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.DecimalPlaces = 3;
            this.numericUpDown5.Enabled = false;
            this.numericUpDown5.Location = new System.Drawing.Point(0, 19);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown5.TabIndex = 2;
            // 
            // radius
            // 
            this.radius.Controls.Add(this.numericUpDown6);
            this.radius.Location = new System.Drawing.Point(162, 129);
            this.radius.Name = "radius";
            this.radius.Size = new System.Drawing.Size(63, 51);
            this.radius.TabIndex = 11;
            this.radius.TabStop = false;
            this.radius.Text = "radius";
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.DecimalPlaces = 3;
            this.numericUpDown6.Enabled = false;
            this.numericUpDown6.Location = new System.Drawing.Point(0, 19);
            this.numericUpDown6.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown6.TabIndex = 2;
            // 
            // helpbox
            // 
            this.helpbox.BackColor = System.Drawing.SystemColors.Control;
            this.helpbox.Location = new System.Drawing.Point(354, 12);
            this.helpbox.Name = "helpbox";
            this.helpbox.Size = new System.Drawing.Size(263, 110);
            this.helpbox.TabIndex = 16;
            this.helpbox.Text = "Chose a shape from the dropdown. This program will calculate area/volume/perimete" +
    "r/surface area. It will then generate a picture of selected shape.";
            this.helpbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Shape_Generator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 499);
            this.Controls.Add(this.helpbox);
            this.Controls.Add(this.ImageContainer);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.Inputcontainer);
            this.Controls.Add(this.ShapeDropDown);
            this.Name = "Shape_Generator";
            this.Text = "Shape Generator";
            this.Inputcontainer.ResumeLayout(false);
            this.ImageContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ShapeImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Variable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Variable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Variable3)).EndInit();
            this.x2.ResumeLayout(false);
            this.y2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.x3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.y3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.x4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.y4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            this.radius.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ShapeDropDown;
        private System.Windows.Forms.GroupBox Inputcontainer;
        private System.Windows.Forms.GroupBox ImageContainer;
        private System.Windows.Forms.PictureBox ShapeImage;
        private System.Windows.Forms.Label InfoBox;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.GroupBox radius;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.GroupBox y4;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.GroupBox x4;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.GroupBox y3;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.GroupBox x3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.GroupBox y2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown Variable2;
        private System.Windows.Forms.NumericUpDown Variable1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox y1;
        private System.Windows.Forms.GroupBox x2;
        private System.Windows.Forms.NumericUpDown Variable3;
        private System.Windows.Forms.Label helpbox;
    }
}

