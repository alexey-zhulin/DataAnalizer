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
using DataEngine;

namespace ApplicationGUI
{
    public partial class MainForm : Form
    {
        DBHandler dbHandler;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.WindowState = Settings.Default.MainWindowState;
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.Location = Settings.Default.MainWindowLocation;
                this.Size = Settings.Default.MainWindowSize;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.MainWindowState = this.WindowState;
            if (this.WindowState != FormWindowState.Maximized)
            {
                Settings.Default.MainWindowLocation = this.Location;
                Settings.Default.MainWindowSize = this.Size;
            }
            Settings.Default.Save();
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog(this);
            if (loginForm.DialogResult == DialogResult.OK)
            {
                if (dbHandler != null)
                {
                    dbHandler.CloseConnection();
                }
                StatusLabel.Text = "Connecting...";
                Application.DoEvents();
                Cursor.Current = Cursors.WaitCursor;
                dbHandler = new DBHandler { ServerName = loginForm.ServerName, Database = loginForm.DataBase, UserName = loginForm.User, Pwd = loginForm.Password, DomainAuth = loginForm.DomainAuth };
                bool connResult = dbHandler.Connect();
                Cursor.Current = Cursors.Default;
                StatusLabel.Text = "";
                if (!connResult)
                {
                    MessageBox.Show(dbHandler.connectException.Message, "Ошибка подключения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Settings.Default.Server = loginForm.ServerName;
                    Settings.Default.DataBase = loginForm.DataBase;
                    Settings.Default.User = loginForm.User;
                    Settings.Default.DomainAuth = loginForm.DomainAuth;
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
