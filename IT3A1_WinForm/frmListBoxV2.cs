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
    public partial class frmListBoxV2 : Form
    {
        public frmListBoxV2()
        {
            InitializeComponent();
        }
        private void Add()
        {
            if (string.IsNullOrEmpty(txtStudent.Text))
            {
                MessageBox.Show("Please enter student's name!",
                    "No data", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            lbStudent.Items.Add(txtStudent.Text);
            txtStudent.Clear();
            txtStudent.Focus();
            if (lbStudent.Items.Count > 0)
            {
                btnClear.Enabled = true;
            }
            else
            {
                btnClear.Enabled = false;
            }

        }
        private void Delete()
        {
            //Check if lbStudent selected
            if (lbStudent.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select student's name to " +
                    "delete!", "No item selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            //Confirm user before deleting
            DialogResult confirm = MessageBox.Show("Are you sure " +
                "you want to delete selected item?",
                "Confirm", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            //Delete
            if (confirm == DialogResult.Yes)
            {
                //lbStudent.Items.Remove(lbStudent.SelectedItem);
                //lbStudent.Items.Remove(lbStudent.SelectedItems[0]);
                //lbStudent.Items.RemoveAt(lbStudent.SelectedIndex);
                //lbStudent.Items.RemoveAt(lbStudent.SelectedIndices[0]);

                while (lbStudent.SelectedItems.Count != 0)
                {
                    lbStudent.Items.RemoveAt(lbStudent.SelectedIndex);
                }

                //for(int i = lbStudent.SelectedItems.Count -1; i >= 0; i--)
                //{
                //    lbStudent.Items.RemoveAt(lbStudent.SelectedIndices[i]);
                //}
            }
        }

        private void UpdateData()
        {
            if (string.IsNullOrEmpty(txtStudent.Text))
            {
                MessageBox.Show("Please enter student's name!",
                    "No data", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            lbStudent.Items[lbStudent.SelectedIndex] = txtStudent.Text;
            LeaveUpdateMode();
        }
        private void frmListBox_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnClear.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (UpdateMode)
            {
                UpdateData();
            }
            else
            {
                Add();
            }

        }

        private void txtStudent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (UpdateMode)
                {
                    UpdateData();
                }
                else
                {
                    Add();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (UpdateMode)
            {
                LeaveUpdateMode();
            }
            else
            {
                Delete();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Confirm user before clearing
            DialogResult confirm = MessageBox.Show("Are you sure " +
                "you want to clear data?",
                "Confirm", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            //Clear
            if (confirm == DialogResult.Yes)
            {
                lbStudent.Items.Clear();
                btnClear.Enabled = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lbStudent.SelectedIndex != -1)
            {
                txtStudent.Text = lbStudent.Items[lbStudent.SelectedIndex].ToString();
                EnterUpdateMode();
            }
        }

        bool UpdateMode = false;
        private void EnterUpdateMode()
        {
            UpdateMode = true;
            btnAdd.Text = "រក្សារទុក";
            btnDelete.Text = "បោះបង់";
            btnClear.Enabled = false;
            btnUpdate.Enabled = false;
            lbStudent.Enabled = false;
        }
        private void LeaveUpdateMode()
        {
            UpdateMode = false;
            btnAdd.Text = "បញ្ចូល";
            btnDelete.Text = "លុប";
            btnClear.Enabled = true;
            btnUpdate.Enabled = true;
            lbStudent.Enabled = true;
            txtStudent.Clear();
        }

        private void lbStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbStudent.SelectedIndex != -1)
            {
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
            }
            else
            {
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
            }
            if(lbStudent.Items.Count > 0)
            {
                btnClear.Enabled = true;
            }
            else
            {
                btnClear.Enabled = false;
            }
        }
    }
}
