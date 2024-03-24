using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAMsnApp
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        public string UserEmail { get; set; }
        private void btnGonder_Click(object sender, EventArgs e)
        {
            rtbMesajlar.Text += UserEmail + ": " + txtMsjGonder.Text + "\r\n";
            txtMsjGonder.Text = string.Empty;
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            lblUserName.Text = UserEmail;
        }

    }
}
