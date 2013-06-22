using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toolkit {
    public partial class FrmMain : Form {
        public FrmMain() {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e) {
            notifyIcon.ShowBalloonTip(1000, "", "Toolkit started.", ToolTipIcon.Info);
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e) {
            notifyIcon.Visible = false;
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                cms.Show();
            }
        }

        private void notifyIcon_MouseMove(object sender, MouseEventArgs e) {

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
