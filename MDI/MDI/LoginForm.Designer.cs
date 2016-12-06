namespace MDI
{
    partial class LoginForm
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
            this.loginPasswordUser1 = new password.LoginPasswordUser();
            this.SuspendLayout();
            // 
            // loginPasswordUser1
            // 
            this.loginPasswordUser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginPasswordUser1.Location = new System.Drawing.Point(0, 0);
            this.loginPasswordUser1.Name = "loginPasswordUser1";
            this.loginPasswordUser1.Size = new System.Drawing.Size(284, 261);
            this.loginPasswordUser1.TabIndex = 0;
            this.loginPasswordUser1.Load += new System.EventHandler(this.loginPasswordUser1_Load);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.loginPasswordUser1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private password.LoginPasswordUser loginPasswordUser1;
    }
}