using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT3A1_WinForm
{
    public partial class frmListViewV2 : Form
    {
        bool UpdateMode;
        Student objStu;
        public frmListViewV2()
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
            cboShift.Items.Add("យប់");
            cboShift.SelectedIndex = 0;
            cboShift.DropDownStyle = ComboBoxStyle.DropDownList;

            lvStudent.Columns.Clear();
            lvStudent.Columns.Add("អត្តលេខ", 150);
            lvStudent.Columns.Add("ឈ្មោះ", 250);
            lvStudent.Columns.Add("ភេទ", 100);
            lvStudent.Columns.Add("វេនសិក្សា", 150);
            lvStudent.Columns.Add("ទីកន្លែងកំណើត", 200);
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

        private void FetchData()
        {
            Student.FetchDataToListView(lvStudent);
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

            //Creating student object to store student info
            Student objStu = new Student();
            objStu.SID = txtID.Text;
            objStu.Name = txtStudent.Text;
            if (rbMale.Checked)
                objStu.Gender = Sex.Male;
            else
                objStu.Gender = Sex.Female;

            objStu.StudyShift = (Shift)cboShift.SelectedIndex;
            if (rbPhnomPenh.Checked)
                objStu.PoB = Address.Phnom_Penh;
            else
                objStu.PoB = Address.Province;

            if(objStu.AddStudent())
            {
                FetchData();
                //Reset input controls
                ResetInput();
            }
            else
            {
                MessageBox.Show("Unable to add student " +
                    "information!", "Fail", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
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
                Student objStu = new Student();
                for (int i=0;i<lvStudent.SelectedItems.Count;i++)
                {
                    int SelectedIndex = lvStudent.SelectedIndices[i];
                    objStu = (Student)lvStudent.Items[SelectedIndex].Tag;
                    objStu.DeleteStudent();
                }
                FetchData();
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
            objStu.SID = txtID.Text;
            objStu.Name = txtStudent.Text;
            if (rbMale.Checked)
                objStu.Gender = Sex.Male;
            else
                objStu.Gender = Sex.Female;
            
            objStu.StudyShift = (Shift)cboShift.SelectedIndex;
            if (rbPhnomPenh.Checked)
                objStu.PoB = Address.Phnom_Penh;
            else
                objStu.PoB = Address.Province;

            if (objStu.UpdateStudent())
            {
                //Reset input controls
                ResetInput();
                FetchData();
                ExitUpdateMode();
            }
            else
            {
                MessageBox.Show("Can't update student info!",
                   "Error", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
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
                if (Student.ClearData())
                {
                    FetchData();
                }
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
            FetchData();
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
                objStu = (Student)editItm.Tag;
                txtID.Text = objStu.SID;
                txtStudent.Text = objStu.Name;
                if (objStu.Gender == Sex.Male)
                    rbMale.Checked = true;
                else
                    rbFemale.Checked = true;
                cboShift.SelectedIndex = (int)objStu.StudyShift;
                if (objStu.PoB == Address.Phnom_Penh)
                    rbPhnomPenh.Checked = true;
                else
                    rbProvince.Checked = true;

                EnterUpdateMode();
            }
        }
    }
}
