using ApplicationGUI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationGUI
{
    public partial class LoginForm : Form
    {
        public string ServerName;
        public string DataBase;
        public string User;
        public string Password;
        public bool DomainAuth;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void checkBoxDomainAuth_CheckedChanged(object sender, EventArgs e)
        {
            textBoxUser.Enabled = !checkBoxDomainAuth.Checked;
            textBoxPassword.Enabled = !checkBoxDomainAuth.Checked;
            if (checkBoxDomainAuth.Checked)
            {
                textBoxUser.Text = "";
                textBoxPassword.Text = "";
            }
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            ServerName = textBoxServer.Text;
            DataBase = textBoxBase.Text;
            User = textBoxUser.Text;
            Password = textBoxPassword.Text;
            DomainAuth = checkBoxDomainAuth.Checked;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            textBoxServer.Text = Settings.Default.Server;
            textBoxBase.Text = Settings.Default.DataBase;
            textBoxUser.Text = Settings.Default.User;
            checkBoxDomainAuth.Checked = Settings.Default.DomainAuth;
        }
    }
}
