namespace IT3A1_WinForm
{
    partial class frmListViewV1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            panel2 = new Panel();
            rbPhnomPenh = new RadioButton();
            rbProvince = new RadioButton();
            panel1 = new Panel();
            rbMale = new RadioButton();
            rbFemale = new RadioButton();
            label5 = new Label();
            cboShift = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            txtID = new TextBox();
            label2 = new Label();
            btnUpdate = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            txtStudent = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            lvStudent = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cboShift);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(txtStudent);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(725, 347);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "បញ្ចូល ឬកែតម្រូវព័ត៌មាននិស្សិត";
            // 
            // panel2
            // 
            panel2.Controls.Add(rbPhnomPenh);
            panel2.Controls.Add(rbProvince);
            panel2.Location = new Point(183, 227);
            panel2.Name = "panel2";
            panel2.Size = new Size(230, 43);
            panel2.TabIndex = 4;
            // 
            // rbPhnomPenh
            // 
            rbPhnomPenh.AutoSize = true;
            rbPhnomPenh.Location = new Point(3, 3);
            rbPhnomPenh.Name = "rbPhnomPenh";
            rbPhnomPenh.Size = new Size(88, 37);
            rbPhnomPenh.TabIndex = 0;
            rbPhnomPenh.TabStop = true;
            rbPhnomPenh.Text = "ភ្នំពេញ";
            rbPhnomPenh.UseVisualStyleBackColor = true;
            // 
            // rbProvince
            // 
            rbProvince.AutoSize = true;
            rbProvince.Location = new Point(97, 3);
            rbProvince.Name = "rbProvince";
            rbProvince.Size = new Size(70, 37);
            rbProvince.TabIndex = 1;
            rbProvince.TabStop = true;
            rbProvince.Text = "ខេត្ត";
            rbProvince.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(rbMale);
            panel1.Controls.Add(rbFemale);
            panel1.Location = new Point(183, 131);
            panel1.Name = "panel1";
            panel1.Size = new Size(205, 46);
            panel1.TabIndex = 2;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(6, 3);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(76, 37);
            rbMale.TabIndex = 0;
            rbMale.TabStop = true;
            rbMale.Text = "ប្រុស";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(88, 3);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(64, 37);
            rbFemale.TabIndex = 1;
            rbFemale.TabStop = true;
            rbFemale.Text = "ស្រី";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 232);
            label5.Name = "label5";
            label5.Size = new Size(133, 33);
            label5.TabIndex = 13;
            label5.Text = "ទីកន្លែងកំណើត៖";
            // 
            // cboShift
            // 
            cboShift.FormattingEnabled = true;
            cboShift.Location = new Point(183, 180);
            cboShift.Name = "cboShift";
            cboShift.Size = new Size(182, 41);
            cboShift.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 188);
            label4.Name = "label4";
            label4.Size = new Size(90, 33);
            label4.TabIndex = 11;
            label4.Text = "វេនសិក្សា៖";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 136);
            label3.Name = "label3";
            label3.Size = new Size(55, 33);
            label3.TabIndex = 10;
            label3.Text = "ភេទ៖";
            // 
            // txtID
            // 
            txtID.Location = new Point(183, 39);
            txtID.Name = "txtID";
            txtID.Size = new Size(422, 40);
            txtID.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 42);
            label2.Name = "label2";
            label2.Size = new Size(85, 33);
            label2.TabIndex = 6;
            label2.Text = "អត្តលេខ៖";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(558, 285);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 43);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "កែតម្រូវ";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(419, 285);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(133, 43);
            btnClear.TabIndex = 7;
            btnClear.Text = "លុបទាំងអស់";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(301, 285);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 43);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "លុប";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(183, 285);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 43);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "បញ្ចូល";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtStudent
            // 
            txtStudent.Location = new Point(183, 85);
            txtStudent.Name = "txtStudent";
            txtStudent.Size = new Size(422, 40);
            txtStudent.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 88);
            label1.Name = "label1";
            label1.Size = new Size(116, 33);
            label1.TabIndex = 0;
            label1.Text = "ឈ្មោះនិស្សិត៖";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lvStudent);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 347);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(725, 279);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "បញ្ជីឈ្មោះនិស្សិត";
            // 
            // lvStudent
            // 
            lvStudent.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lvStudent.Dock = DockStyle.Fill;
            lvStudent.Location = new Point(3, 36);
            lvStudent.Name = "lvStudent";
            lvStudent.Size = new Size(719, 240);
            lvStudent.TabIndex = 0;
            lvStudent.UseCompatibleStateImageBehavior = false;
            lvStudent.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "អត្តលេខ";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Width = 200;
            // 
            // frmListView
            // 
            AutoScaleDimensions = new SizeF(10F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 626);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Khmer OS Siemreap", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmListView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Information";
            Load += frmListView_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtID;
        private Label label2;
        private Button btnUpdate;
        private Button btnClear;
        private Button btnDelete;
        private Button btnAdd;
        private TextBox txtStudent;
        private Label label1;
        private RadioButton rbProvince;
        private RadioButton rbPhnomPenh;
        private Label label5;
        private ComboBox cboShift;
        private Label label4;
        private Label label3;
        private RadioButton rbFemale;
        private RadioButton rbMale;
        private Panel panel1;
        private Panel panel2;
        private GroupBox groupBox2;
        private ListView lvStudent;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}