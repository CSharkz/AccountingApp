namespace AccountingApp
{
    partial class LoginAccountingAppForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginAccountingAppForm));
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this._txtUsername = new System.Windows.Forms.TextBox();
            this._txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnLostPass = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMainTitle
            // 
            resources.ApplyResources(this.lblMainTitle, "lblMainTitle");
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.UseWaitCursor = true;
            // 
            // lblUsername
            // 
            resources.ApplyResources(this.lblUsername, "lblUsername");
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPassword
            // 
            resources.ApplyResources(this.lblPassword, "lblPassword");
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // _txtUsername
            // 
            resources.ApplyResources(this._txtUsername, "_txtUsername");
            this._txtUsername.Name = "_txtUsername";
            // 
            // _txtPassword
            // 
            resources.ApplyResources(this._txtPassword, "_txtPassword");
            this._txtPassword.Name = "_txtPassword";
            this._txtPassword.ShortcutsEnabled = false;
            // 
            // btnLogin
            // 
            resources.ApplyResources(this.btnLogin, "btnLogin");
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.OnClickLogin);
            // 
            // btnLostPass
            // 
            resources.ApplyResources(this.btnLostPass, "btnLostPass");
            this.btnLostPass.Name = "btnLostPass";
            this.btnLostPass.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            resources.ApplyResources(this.btnRegister, "btnRegister");
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // AccountingAppForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLostPass);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this._txtPassword);
            this.Controls.Add(this._txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblMainTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AccountingAppForm";
            this.Load += new System.EventHandler(this.AccountingAppForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox _txtUsername;
        private System.Windows.Forms.TextBox _txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnLostPass;
        private System.Windows.Forms.Button btnRegister;
    }
}

