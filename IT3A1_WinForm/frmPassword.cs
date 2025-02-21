using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT3A1_WinForm
{
    public partial class frmPassword : Form
    {
        public frmPassword()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdatePwd_Click(object sender, EventArgs e)
        {
            string pwdHash = BCrypt.Net.BCrypt.HashPassword(txtOldPwd.Text,
                MyConfig.activeUser.Password_Salt);
            if (pwdHash != MyConfig.activeUser.Password_Hash)
            {
                MessageBox.Show("Invalid password!", "Invalid",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrEmpty(txtNewPwd.Text))
            {
                MessageBox.Show("Please enter new password!",
                    "No password", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            if (txtNewPwd.Text != txtConfirmPwd.Text)
            {
                MessageBox.Show("Password mismatch!",
                    "Mismatch", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            string newPwdSalt = BCrypt.Net.BCrypt.GenerateSalt();
            string newPwdHash = BCrypt.Net.BCrypt.HashPassword(txtNewPwd.Text,
                newPwdSalt);
            MyConfig.activeUser.Password_Salt = newPwdSalt;
            MyConfig.activeUser.Password_Hash = newPwdHash;
            if (MyConfig.activeUser.UpdatePwd())
            {
                MessageBox.Show("Password has been updated!",
                    "Password Changed", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Fail updating password!",
                    "Failed", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void frmPassword_Load(object sender, EventArgs e)
        {

        }
    }
}
