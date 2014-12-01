namespace ApplicationGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.checkBoxDomainAuth = new System.Windows.Forms.CheckBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxBase = new System.Windows.Forms.TextBox();
            this.textBoxServer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OKbutton = new System.Windows.Forms.Button();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBoxDomainAuth
            // 
            resources.ApplyResources(this.checkBoxDomainAuth, "checkBoxDomainAuth");
            this.checkBoxDomainAuth.Name = "checkBoxDomainAuth";
            this.checkBoxDomainAuth.UseVisualStyleBackColor = true;
            this.checkBoxDomainAuth.CheckedChanged += new System.EventHandler(this.checkBoxDomainAuth_CheckedChanged);
            // 
            // textBoxPassword
            // 
            resources.ApplyResources(this.textBoxPassword, "textBoxPassword");
            this.textBoxPassword.Name = "textBoxPassword";
            // 
            // textBoxUser
            // 
            resources.ApplyResources(this.textBoxUser, "textBoxUser");
            this.textBoxUser.Name = "textBoxUser";
            // 
            // textBoxBase
            // 
            resources.ApplyResources(this.textBoxBase, "textBoxBase");
            this.textBoxBase.Name = "textBoxBase";
            // 
            // textBoxServer
            // 
            resources.ApplyResources(this.textBoxServer, "textBoxServer");
            this.textBoxServer.Name = "textBoxServer";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // OKbutton
            // 
            this.OKbutton.DialogResult = System.Windows.Forms.DialogResult.OK;
            resources.ApplyResources(this.OKbutton, "OKbutton");
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.Cancelbutton, "Cancelbutton");
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.OKbutton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancelbutton;
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.checkBoxDomainAuth);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.textBoxBase);
            this.Controls.Add(this.textBoxServer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxDomainAuth;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxBase;
        private System.Windows.Forms.TextBox textBoxServer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.Button Cancelbutton;

    }
}