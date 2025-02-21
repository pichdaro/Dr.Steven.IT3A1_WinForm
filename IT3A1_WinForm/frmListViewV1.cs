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
    public partial class frmListViewV1 : Form
    {
        bool UpdateMode;
        public frmListViewV1()
        {
            InitializeComponent();
        }

        private void InitControls()
        {
            rbMale.Checked = true;
            rbPhnomPenh.Checked = true;
            cboShift.Items.Clear();
            cboShift.Items.Add("ព្រឹក");
            cboShift.Items.Add("ថ្ងៃ");
            cboShift.Items.Add("ល្ងាច");
            cboShift.SelectedIndex = 0;
            cboShift.DropDownStyle = ComboBoxStyle.DropDownList;

            lvStudent.Columns.Clear();
            lvStudent.Columns.Add("អត្តលេខ", 100);
            lvStudent.Columns.Add("ឈ្មោះ", 250);
            lvStudent.Columns.Add("ភេទ", 100);
            lvStudent.Columns.Add("វេនសិក្សា", 150);
            lvStudent.Columns.Add("ទីកន្លែងកំណើត", 100);
            lvStudent.View = View.Details;
            lvStudent.FullRowSelect = true;
            lvStudent.MultiSelect = true;
        }

        private void ResetInput()
        {
            txtID.Clear();
            txtStudent.Clear();
            cboShift.SelectedIndex = 0;
            rbMale.Checked = true;
            rbPhnomPenh.Checked = true;
            lvStudent.SelectedItems.Clear();
            txtID.Focus();
        }

        private void AddData()
        {
            //Check if txtID and txtStudent is null
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Please enter student's ID!",
                    "No data", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(txtStudent.Text))
            {
                MessageBox.Show("Please enter student's name!",
                    "No data", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            //Creating array to store student info
            string[] stuInfo = new string[5];
            stuInfo[0] = txtID.Text;
            stuInfo[1] = txtStudent.Text;
            if (rbMale.Checked)
                stuInfo[2] = rbMale.Text;
            else
                stuInfo[2] = rbFemale.Text;
            stuInfo[3] = cboShift.SelectedItem.ToString();
            if (rbPhnomPenh.Checked)
                stuInfo[4] = rbPhnomPenh.Text;
            else
                stuInfo[4] = rbProvince.Text;

            //Creating ListViewItem from array
            ListViewItem stuItem = new ListViewItem(stuInfo);

            //Adding stuItem to ListView
            lvStudent.Items.Add(stuItem);

            //Reset input controls
            ResetInput();
        }

        private void DeleteData()
        {
            //Check if lbStudent selected
            if (lvStudent.SelectedItems.Count == 0)
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
                while (lvStudent.SelectedItems.Count != 0)
                {
                    lvStudent.Items.RemoveAt(lvStudent.SelectedIndices[0]);
                }
            }
        }

        private void UpdateData()
        {
            //Check if txtID and txtStudent is null
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Please enter student's ID!",
                    "No data", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(txtStudent.Text))
            {
                MessageBox.Show("Please enter student's name!",
                    "No data", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            //Creating array to store student info
            string[] stuInfo = new string[5];
            stuInfo[0] = txtID.Text;
            stuInfo[1] = txtStudent.Text;
            if (rbMale.Checked)
                stuInfo[2] = rbMale.Text;
            else
                stuInfo[2] = rbFemale.Text;
            stuInfo[3] = cboShift.SelectedItem.ToString();
            if (rbPhnomPenh.Checked)
                stuInfo[4] = rbPhnomPenh.Text;
            else
                stuInfo[4] = rbProvince.Text;

            //Creating ListViewItem from array
            ListViewItem stuItem = new ListViewItem(stuInfo);

            //update stuItem to selected ListViewItem
            lvStudent.Items[lvStudent.SelectedIndices[0]] = stuItem;

            //Reset input controls
            ResetInput();
            ExitUpdateMode();
        }

        private void ClearData()
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
                lvStudent.Items.Clear();
            }
        }

        private void EnterUpdateMode()
        {
            UpdateMode = true;
            btnClear.Enabled = false;
            btnUpdate.Enabled = false;
            lvStudent.Enabled = false;
            btnAdd.Text = "រក្សាទុក";
            btnDelete.Text = "បោះបង់";
        }
        private void ExitUpdateMode()
        {
            UpdateMode = false;
            btnClear.Enabled = true;
            btnUpdate.Enabled = true;
            lvStudent.Enabled = true;
            btnAdd.Text = "បញ្ចូល";
            btnDelete.Text = "លុប";
        }

        private void frmListView_Load(object sender, EventArgs e)
        {
            InitControls();
            UpdateMode = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (UpdateMode)
                UpdateData();
            else
                AddData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (UpdateMode)
            {
                ExitUpdateMode();
                ResetInput();
            }
            else
            {
                DeleteData();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lvStudent.SelectedItems.Count > 0)
            {
                ListViewItem editItm = lvStudent.SelectedItems[0];
                txtID.Text = editItm.SubItems[0].Text;
                txtStudent.Text = editItm.SubItems[1].Text;
                if (editItm.SubItems[2].ToString() == rbMale.Text)
                    rbMale.Checked = true;
                else
                    rbFemale.Checked = true;
                cboShift.SelectedItem = editItm.SubItems[3].Text;
                if (editItm.SubItems[4].Text == rbPhnomPenh.Text)
                    rbPhnomPenh.Checked = true;
                else
                    rbProvince.Checked = true;
                EnterUpdateMode();
            }
        }
    }
}
