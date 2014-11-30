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
    public partial class MainForm : Form
    {
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
    }
}
