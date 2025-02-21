using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT3A1_WinForm
{
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            User.FetchData(lvUser);
            cboRole.Items.Add("SysAdmin");
            cboRole.Items.Add("Admin");
            cboRole.Items.Add("User");
            cboRole.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Please enter username!",
                    "No username", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrEmpty(txtPwd.Text))
            {
                MessageBox.Show("Please enter password!",
                    "No password", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            if (txtPwd.Text != txtConfirmPwd.Text)
            {
                MessageBox.Show("Password mismatch!",
                    "Mismatch", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            if (!MyConfig.IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Invalid email address!",
                    "Invalid", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            if (!User.Add(txtUsername.Text, txtPwd.Text, txtEmail.Text,
                cboRole.SelectedIndex))
            {
                MessageBox.Show("Unable to add user!",
                    "Failed", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            ClearForm();
            User.FetchData(lvUser);
        }
        private void ClearForm()
        {
            txtUsername.Text = string.Empty;
            txtPwd.Text = string.Empty;
            txtConfirmPwd.Text = string.Empty;
            txtEmail.Text = string.Empty;
            cboRole.SelectedIndex = 0;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
