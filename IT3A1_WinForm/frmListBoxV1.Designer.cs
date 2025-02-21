namespace IT3A1_WinForm
{
    partial class frmListBoxV1
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
            btnUpdate = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            txtStudent = new TextBox();
            label1 = new Label();
            lbStudent = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(txtStudent);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(606, 150);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "បញ្ចូល ឬកែតម្រូវព័ត៌មាននិស្សិត";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(468, 85);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 43);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "កែតម្រូវ";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(329, 85);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(133, 43);
            btnClear.TabIndex = 4;
            btnClear.Text = "លុបទាំងអស់";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(211, 85);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 43);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "លុប";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(93, 85);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 43);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "បញ្ចូល";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtStudent
            // 
            txtStudent.Location = new Point(158, 39);
            txtStudent.Name = "txtStudent";
            txtStudent.Size = new Size(422, 40);
            txtStudent.TabIndex = 1;
            txtStudent.KeyPress += txtStudent_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 42);
            label1.Name = "label1";
            label1.Size = new Size(116, 33);
            label1.TabIndex = 0;
            label1.Text = "ឈ្មោះនិស្សិត៖";
            // 
            // lbStudent
            // 
            lbStudent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbStudent.FormattingEnabled = true;
            lbStudent.ItemHeight = 33;
            lbStudent.Location = new Point(12, 168);
            lbStudent.Name = "lbStudent";
            lbStudent.SelectionMode = SelectionMode.MultiExtended;
            lbStudent.Size = new Size(606, 400);
            lbStudent.TabIndex = 1;
            lbStudent.SelectedIndexChanged += lbStudent_SelectedIndexChanged;
            // 
            // frmListBoxV1
            // 
            AutoScaleDimensions = new SizeF(10F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 576);
            Controls.Add(lbStudent);
            Controls.Add(groupBox1);
            Font = new Font("Khmer OS Siemreap", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmListBoxV1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmListBox";
            Load += frmListBox_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnUpdate;
        private Button btnClear;
        private Button btnDelete;
        private Button btnAdd;
        private TextBox txtStudent;
        private Label label1;
        private ListBox lbStudent;
    }
}