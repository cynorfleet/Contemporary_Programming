namespace Painter
{
    partial class PainterForm
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
            this.canvas = new System.Windows.Forms.Panel();
            this.ColorBox = new System.Windows.Forms.GroupBox();
            this.Erase = new System.Windows.Forms.RadioButton();
            this.Blue = new System.Windows.Forms.RadioButton();
            this.Green = new System.Windows.Forms.RadioButton();
            this.Red = new System.Windows.Forms.RadioButton();
            this.Black = new System.Windows.Forms.RadioButton();
            this.StyleBox = new System.Windows.Forms.GroupBox();
            this.Large = new System.Windows.Forms.RadioButton();
            this.Normal = new System.Windows.Forms.RadioButton();
            this.Small = new System.Windows.Forms.RadioButton();
            this.Clear = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ColorMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.blackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eraseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.styleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.largeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.ModeBox1 = new System.Windows.Forms.GroupBox();
            this.Mode = new System.Windows.Forms.Label();
            this.ColorWheelBox = new System.Windows.Forms.Button();
            this.ColorPickerBox = new System.Windows.Forms.GroupBox();
            this.ColorBox.SuspendLayout();
            this.StyleBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.ModeBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.White;
            this.canvas.Location = new System.Drawing.Point(161, 44);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(617, 486);
            this.canvas.TabIndex = 2;
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PainterForm_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PainterForm_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PainterForm_MouseUp);
            // 
            // ColorBox
            // 
            this.ColorBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ColorBox.Controls.Add(this.Erase);
            this.ColorBox.Controls.Add(this.Blue);
            this.ColorBox.Controls.Add(this.Green);
            this.ColorBox.Controls.Add(this.Red);
            this.ColorBox.Controls.Add(this.Black);
            this.ColorBox.Location = new System.Drawing.Point(3, 81);
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.Size = new System.Drawing.Size(143, 139);
            this.ColorBox.TabIndex = 1;
            this.ColorBox.TabStop = false;
            this.ColorBox.Text = "Color";
            // 
            // Erase
            // 
            this.Erase.AutoSize = true;
            this.Erase.Location = new System.Drawing.Point(9, 112);
            this.Erase.Name = "Erase";
            this.Erase.Size = new System.Drawing.Size(52, 17);
            this.Erase.TabIndex = 3;
            this.Erase.Text = "Erase";
            this.Erase.UseVisualStyleBackColor = true;
            this.Erase.CheckedChanged += new System.EventHandler(this.Color_CheckedChanged);
            // 
            // Blue
            // 
            this.Blue.AutoSize = true;
            this.Blue.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.Blue.Location = new System.Drawing.Point(10, 89);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(46, 17);
            this.Blue.TabIndex = 3;
            this.Blue.Text = "Blue";
            this.Blue.UseVisualStyleBackColor = true;
            this.Blue.CheckedChanged += new System.EventHandler(this.Color_CheckedChanged);
            // 
            // Green
            // 
            this.Green.AutoSize = true;
            this.Green.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.Green.Location = new System.Drawing.Point(10, 66);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(54, 17);
            this.Green.TabIndex = 2;
            this.Green.Text = "Green";
            this.Green.UseVisualStyleBackColor = true;
            this.Green.CheckedChanged += new System.EventHandler(this.Color_CheckedChanged);
            // 
            // Red
            // 
            this.Red.AutoSize = true;
            this.Red.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Red.Location = new System.Drawing.Point(10, 43);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(45, 17);
            this.Red.TabIndex = 1;
            this.Red.Text = "Red";
            this.Red.UseVisualStyleBackColor = true;
            this.Red.CheckedChanged += new System.EventHandler(this.Color_CheckedChanged);
            // 
            // Black
            // 
            this.Black.AutoSize = true;
            this.Black.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Black.Location = new System.Drawing.Point(10, 20);
            this.Black.Name = "Black";
            this.Black.Size = new System.Drawing.Size(52, 17);
            this.Black.TabIndex = 0;
            this.Black.Text = "Black";
            this.Black.UseVisualStyleBackColor = true;
            this.Black.CheckedChanged += new System.EventHandler(this.Color_CheckedChanged);
            // 
            // StyleBox
            // 
            this.StyleBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.StyleBox.Controls.Add(this.Large);
            this.StyleBox.Controls.Add(this.Normal);
            this.StyleBox.Controls.Add(this.Small);
            this.StyleBox.Location = new System.Drawing.Point(3, 226);
            this.StyleBox.Name = "StyleBox";
            this.StyleBox.Size = new System.Drawing.Size(143, 102);
            this.StyleBox.TabIndex = 2;
            this.StyleBox.TabStop = false;
            this.StyleBox.Text = "Style";
            // 
            // Large
            // 
            this.Large.AutoSize = true;
            this.Large.Location = new System.Drawing.Point(10, 66);
            this.Large.Name = "Large";
            this.Large.Size = new System.Drawing.Size(52, 17);
            this.Large.TabIndex = 2;
            this.Large.TabStop = true;
            this.Large.Tag = "12";
            this.Large.Text = "Large";
            this.Large.UseVisualStyleBackColor = true;
            this.Large.CheckedChanged += new System.EventHandler(this.Size_CheckedChanged);
            // 
            // Normal
            // 
            this.Normal.AutoSize = true;
            this.Normal.Location = new System.Drawing.Point(10, 43);
            this.Normal.Name = "Normal";
            this.Normal.Size = new System.Drawing.Size(58, 17);
            this.Normal.TabIndex = 1;
            this.Normal.TabStop = true;
            this.Normal.Tag = "6";
            this.Normal.Text = "Normal";
            this.Normal.UseVisualStyleBackColor = true;
            this.Normal.CheckedChanged += new System.EventHandler(this.Size_CheckedChanged);
            // 
            // Small
            // 
            this.Small.AutoSize = true;
            this.Small.Location = new System.Drawing.Point(10, 20);
            this.Small.Name = "Small";
            this.Small.Size = new System.Drawing.Size(50, 17);
            this.Small.TabIndex = 0;
            this.Small.TabStop = true;
            this.Small.Tag = "1";
            this.Small.Text = "Small";
            this.Small.UseVisualStyleBackColor = true;
            this.Small.CheckedChanged += new System.EventHandler(this.Size_CheckedChanged);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(3, 443);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(143, 87);
            this.Clear.TabIndex = 3;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClearScreen);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ColorMenu,
            this.styleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(801, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ColorMenu
            // 
            this.ColorMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blackToolStripMenuItem,
            this.redToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.eraseToolStripMenuItem});
            this.ColorMenu.Name = "ColorMenu";
            this.ColorMenu.Size = new System.Drawing.Size(48, 20);
            this.ColorMenu.Text = "Color";
            // 
            // blackToolStripMenuItem
            // 
            this.blackToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.blackToolStripMenuItem.Name = "blackToolStripMenuItem";
            this.blackToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.blackToolStripMenuItem.Tag = "Black";
            this.blackToolStripMenuItem.Text = "Black";
            this.blackToolStripMenuItem.Click += new System.EventHandler(this.MenuColor_Clicked);
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Red;
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.redToolStripMenuItem.Tag = "Red";
            this.redToolStripMenuItem.Text = "Red";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.MenuColor_Clicked);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Green;
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.greenToolStripMenuItem.Tag = "Green";
            this.greenToolStripMenuItem.Text = "Green";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.MenuColor_Clicked);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Blue;
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.blueToolStripMenuItem.Tag = "Blue";
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.MenuColor_Clicked);
            // 
            // eraseToolStripMenuItem
            // 
            this.eraseToolStripMenuItem.Name = "eraseToolStripMenuItem";
            this.eraseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.eraseToolStripMenuItem.Tag = "Erase";
            this.eraseToolStripMenuItem.Text = "Erase";
            this.eraseToolStripMenuItem.Click += new System.EventHandler(this.MenuColor_Clicked);
            // 
            // styleToolStripMenuItem
            // 
            this.styleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smallToolStripMenuItem,
            this.normalToolStripMenuItem,
            this.largeToolStripMenuItem});
            this.styleToolStripMenuItem.Name = "styleToolStripMenuItem";
            this.styleToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.styleToolStripMenuItem.Text = "Style";
            // 
            // smallToolStripMenuItem
            // 
            this.smallToolStripMenuItem.Name = "smallToolStripMenuItem";
            this.smallToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.smallToolStripMenuItem.Tag = "1";
            this.smallToolStripMenuItem.Text = "Small";
            this.smallToolStripMenuItem.Click += new System.EventHandler(this.MenuSize_CheckedChanged);
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.normalToolStripMenuItem.Tag = "6";
            this.normalToolStripMenuItem.Text = "Normal";
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.MenuSize_CheckedChanged);
            // 
            // largeToolStripMenuItem
            // 
            this.largeToolStripMenuItem.Name = "largeToolStripMenuItem";
            this.largeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.largeToolStripMenuItem.Tag = "12";
            this.largeToolStripMenuItem.Text = "Large";
            this.largeToolStripMenuItem.Click += new System.EventHandler(this.MenuSize_CheckedChanged);
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            this.colorDialog1.FullOpen = true;
            this.colorDialog1.SolidColorOnly = true;
            // 
            // ModeBox1
            // 
            this.ModeBox1.Controls.Add(this.Mode);
            this.ModeBox1.Location = new System.Drawing.Point(3, 28);
            this.ModeBox1.Name = "ModeBox1";
            this.ModeBox1.Size = new System.Drawing.Size(143, 47);
            this.ModeBox1.TabIndex = 6;
            this.ModeBox1.TabStop = false;
            this.ModeBox1.Text = "Mode";
            // 
            // Mode
            // 
            this.Mode.AutoSize = true;
            this.Mode.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mode.ForeColor = System.Drawing.Color.Maroon;
            this.Mode.Location = new System.Drawing.Point(9, 16);
            this.Mode.Name = "Mode";
            this.Mode.Size = new System.Drawing.Size(54, 26);
            this.Mode.TabIndex = 0;
            this.Mode.Text = "Paint";
            // 
            // ColorWheelBox
            // 
            this.ColorWheelBox.Location = new System.Drawing.Point(12, 351);
            this.ColorWheelBox.Name = "ColorWheelBox";
            this.ColorWheelBox.Size = new System.Drawing.Size(120, 80);
            this.ColorWheelBox.TabIndex = 7;
            this.ColorWheelBox.UseVisualStyleBackColor = true;
            this.ColorWheelBox.Click += new System.EventHandler(this.ColorWheel_event);
            // 
            // ColorPickerBox
            // 
            this.ColorPickerBox.Location = new System.Drawing.Point(3, 337);
            this.ColorPickerBox.Name = "ColorPickerBox";
            this.ColorPickerBox.Size = new System.Drawing.Size(143, 100);
            this.ColorPickerBox.TabIndex = 8;
            this.ColorPickerBox.TabStop = false;
            this.ColorPickerBox.Text = "Color Picker";
            // 
            // PainterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(801, 541);
            this.Controls.Add(this.ColorWheelBox);
            this.Controls.Add(this.ModeBox1);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.ColorBox);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.StyleBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.ColorPickerBox);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PainterForm";
            this.Text = "Form1";
            this.ColorBox.ResumeLayout(false);
            this.ColorBox.PerformLayout();
            this.StyleBox.ResumeLayout(false);
            this.StyleBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ModeBox1.ResumeLayout(false);
            this.ModeBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.GroupBox ColorBox;
        private System.Windows.Forms.RadioButton Blue;
        private System.Windows.Forms.RadioButton Green;
        private System.Windows.Forms.RadioButton Red;
        private System.Windows.Forms.RadioButton Black;
        private System.Windows.Forms.GroupBox StyleBox;
        private System.Windows.Forms.RadioButton Large;
        private System.Windows.Forms.RadioButton Normal;
        private System.Windows.Forms.RadioButton Small;
        private System.Windows.Forms.RadioButton Erase;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ColorMenu;
        private System.Windows.Forms.ToolStripMenuItem blackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eraseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem styleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem largeToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox ModeBox1;
        private System.Windows.Forms.Label Mode;
        private System.Windows.Forms.Button ColorWheelBox;
        private System.Windows.Forms.GroupBox ColorPickerBox;
    }
}

