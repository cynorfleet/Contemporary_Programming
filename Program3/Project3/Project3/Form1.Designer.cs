namespace Project3
{
    partial class Converter
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
            this.user_input = new System.Windows.Forms.TextBox();
            this.Input_label = new System.Windows.Forms.Label();
            this.result_instruction_label = new System.Windows.Forms.Label();
            this.result_label = new System.Windows.Forms.Label();
            this.convert_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // user_input
            // 
            this.user_input.Location = new System.Drawing.Point(707, 240);
            this.user_input.Name = "user_input";
            this.user_input.Size = new System.Drawing.Size(337, 38);
            this.user_input.TabIndex = 0;
            // 
            // Input_label
            // 
            this.Input_label.AutoSize = true;
            this.Input_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_label.Location = new System.Drawing.Point(179, 225);
            this.Input_label.Name = "Input_label";
            this.Input_label.Size = new System.Drawing.Size(505, 54);
            this.Input_label.TabIndex = 1;
            this.Input_label.Text = "Enter binary value here";
            // 
            // result_instruction_label
            // 
            this.result_instruction_label.AutoSize = true;
            this.result_instruction_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_instruction_label.Location = new System.Drawing.Point(182, 365);
            this.result_instruction_label.Name = "result_instruction_label";
            this.result_instruction_label.Size = new System.Drawing.Size(402, 39);
            this.result_instruction_label.TabIndex = 2;
            this.result_instruction_label.Text = "The decimal equivalent is";
            this.result_instruction_label.Visible = false;
            // 
            // result_label
            // 
            this.result_label.AutoSize = true;
            this.result_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_label.Location = new System.Drawing.Point(698, 355);
            this.result_label.Name = "result_label";
            this.result_label.Size = new System.Drawing.Size(0, 52);
            this.result_label.TabIndex = 3;
            // 
            // convert_button
            // 
            this.convert_button.Enabled = false;
            this.convert_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convert_button.Location = new System.Drawing.Point(188, 497);
            this.convert_button.Name = "convert_button";
            this.convert_button.Size = new System.Drawing.Size(336, 144);
            this.convert_button.TabIndex = 4;
            this.convert_button.Text = "convert";
            this.convert_button.UseVisualStyleBackColor = true;
            this.convert_button.Click += new System.EventHandler(this.convert_button_Click);
            // 
            // Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1812, 1084);
            this.Controls.Add(this.convert_button);
            this.Controls.Add(this.result_label);
            this.Controls.Add(this.result_instruction_label);
            this.Controls.Add(this.Input_label);
            this.Controls.Add(this.user_input);
            this.Name = "Converter";
            this.Text = "Converter_window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox user_input;
        private System.Windows.Forms.Label Input_label;
        private System.Windows.Forms.Label result_instruction_label;
        private System.Windows.Forms.Label result_label;
        private System.Windows.Forms.Button convert_button;
    }
}

