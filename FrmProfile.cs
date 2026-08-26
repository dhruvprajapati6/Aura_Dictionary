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
    public partial class FrmProfile : Form
    {
        public FrmProfile()
        {
            InitializeComponent();
            lblname.Text = "Name: " + UserSession.Name;
            lblemail.Text = "Email: " + UserSession.Email;
            lblusername.Text = "Username: " + UserSession.Username;
        }

        private void FrmProfile_Load(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
