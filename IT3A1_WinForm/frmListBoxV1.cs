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
    public partial class frmListBoxV1 : Form
    {
        public frmListBoxV1()
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
        }
        private void frmListBox_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void txtStudent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Add();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
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
            }
        }

        private void lbStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtStudent.Clear();
            if (lbStudent.SelectedIndex != -1)
            {
                txtStudent.Text = lbStudent.Items[lbStudent.SelectedIndex].ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateData();
        }
    }
}
