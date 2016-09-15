namespace Project3_working
{
    partial class Binary_Converter_form
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
            this.convert_button = new System.Windows.Forms.Button();
            this.result_description_label = new System.Windows.Forms.Label();
            this.Input_label = new System.Windows.Forms.Label();
            this.user_input = new System.Windows.Forms.TextBox();
            this.result_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // convert_button
            // 
            this.convert_button.Enabled = false;
            this.convert_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convert_button.Location = new System.Drawing.Point(88, 102);
            this.convert_button.Margin = new System.Windows.Forms.Padding(1);
            this.convert_button.Name = "convert_button";
            this.convert_button.Size = new System.Drawing.Size(126, 60);
            this.convert_button.TabIndex = 8;
            this.convert_button.Text = "convert";
            this.convert_button.UseVisualStyleBackColor = true;
            this.convert_button.Click += new System.EventHandler(this.convert_button_Click);
            // 
            // result_description_label
            // 
            this.result_description_label.AutoSize = true;
            this.result_description_label.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_description_label.ForeColor = System.Drawing.Color.Maroon;
            this.result_description_label.Location = new System.Drawing.Point(21, 215);
            this.result_description_label.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.result_description_label.Name = "result_description_label";
            this.result_description_label.Size = new System.Drawing.Size(160, 18);
            this.result_description_label.TabIndex = 7;
            this.result_description_label.Text = "The decimal equivalent is";
            this.result_description_label.Visible = false;
            // 
            // Input_label
            // 
            this.Input_label.AutoSize = true;
            this.Input_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_label.Location = new System.Drawing.Point(20, 29);
            this.Input_label.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Input_label.Name = "Input_label";
            this.Input_label.Size = new System.Drawing.Size(205, 24);
            this.Input_label.TabIndex = 6;
            this.Input_label.Text = "Enter binary value here";
            // 
            // user_input
            // 
            this.user_input.Location = new System.Drawing.Point(227, 34);
            this.user_input.Margin = new System.Windows.Forms.Padding(1);
            this.user_input.Name = "user_input";
            this.user_input.Size = new System.Drawing.Size(80, 20);
            this.user_input.TabIndex = 5;
            this.user_input.TextChanged += new System.EventHandler(this.GUI_description_Enable);
            // 
            // result_label
            // 
            this.result_label.AutoSize = true;
            this.result_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_label.ForeColor = System.Drawing.Color.Maroon;
            this.result_label.Location = new System.Drawing.Point(183, 211);
            this.result_label.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.result_label.Name = "result_label";
            this.result_label.Size = new System.Drawing.Size(0, 22);
            this.result_label.TabIndex = 9;
            // 
            // Binary_Converter_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(327, 263);
            this.Controls.Add(this.result_label);
            this.Controls.Add(this.convert_button);
            this.Controls.Add(this.result_description_label);
            this.Controls.Add(this.Input_label);
            this.Controls.Add(this.user_input);
            this.Name = "Binary_Converter_form";
            this.Text = "Binary Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button convert_button;
        private System.Windows.Forms.Label result_description_label;
        private System.Windows.Forms.Label Input_label;
        private System.Windows.Forms.TextBox user_input;
        private System.Windows.Forms.Label result_label;
    }
}

