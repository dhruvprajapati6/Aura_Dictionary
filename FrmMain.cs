using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aura_dectionary
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void serchWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v frm = new v();
            frm.Show();
        }

        private void addWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddWord frm = new FrmAddWord();
            frm.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Are you sure you want to logout?",
            "Logout",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question
             );

            if (result == DialogResult.Yes)
            {
                UserSession.Clear();

                this.Hide();

                CCCC login = new CCCC();
                login.Show();
            }
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProfile profile = new FrmProfile();
            profile.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void deleteWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDeleteWord frm = new FrmDeleteWord();
            //frm. = this;
            //frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void aditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditWord frm = new FrmEditWord();
            frm.Show();
        }
    }
}
