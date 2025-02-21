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
    public partial class frmMDI : Form
    {
        public frmMDI()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("App Version: 1.0\n" +
                "Developer: NoBody@All\n" +
                "Company: NA");
        }

        private void frmMainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain mainForm = new frmMain();
            mainForm.MdiParent = this;
            mainForm.Show();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void frmMDI_Load(object sender, EventArgs e)
        {
            tsStatus.Text = MyConfig.activeUser.Username;
            if (MyConfig.activeUser.Role != UserRoles.SuperAdmin)
            {
                userManagerToolStripMenuItem.Enabled = false;
            }
        }

        private void frmListBoxStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListBoxV1 lbStu = new frmListBoxV1();
            lbStu.MdiParent = this;
            lbStu.Show();
        }

        private void frmListBoxStudentV2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListBoxV2 lbStu = new frmListBoxV2();
            lbStu.MdiParent = this;
            lbStu.Show();
        }

        private void frmListViewStiudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListViewV1 lvStu = new frmListViewV1();
            lvStu.MdiParent = this;
            lvStu.Show();
        }

        private void frmLitstViewStudentDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListViewV2 lvStu = new frmListViewV2();
            lvStu.MdiParent = this;
            lvStu.Show();
        }

        private void userManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MyConfig.activeUser.Role == UserRoles.SuperAdmin)
            {
                frmUser usr = new frmUser();
                usr.MdiParent = this;
                usr.WindowState = FormWindowState.Maximized;
                usr.Show();
            }
            else
            {
                MessageBox.Show("Your don't permissio to access " +
                    "this area!", "Access Denied",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPassword pwd = new frmPassword();
            pwd.ShowDialog();
        }

        private void updateAvataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAvata avata = new frmAvata();
            avata.ShowDialog();
        }
    }
}
