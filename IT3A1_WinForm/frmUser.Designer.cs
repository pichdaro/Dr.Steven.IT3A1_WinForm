namespace IT3A1_WinForm
{
    partial class frmUser
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
            lvUser = new ListView();
            txtConfirmPwd = new TextBox();
            label5 = new Label();
            btnEdit = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            cboRole = new ComboBox();
            txtEmail = new TextBox();
            txtPwd = new TextBox();
            txtUsername = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            groupBox1 = new GroupBox();
            btnClear = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // lvUser
            // 
            lvUser.Dock = DockStyle.Fill;
            lvUser.Location = new Point(3, 3);
            lvUser.Name = "lvUser";
            lvUser.Size = new Size(826, 277);
            lvUser.TabIndex = 0;
            lvUser.UseCompatibleStateImageBehavior = false;
            // 
            // txtConfirmPwd
            // 
            txtConfirmPwd.Location = new Point(201, 137);
            txtConfirmPwd.Name = "txtConfirmPwd";
            txtConfirmPwd.Size = new Size(259, 40);
            txtConfirmPwd.TabIndex = 2;
            txtConfirmPwd.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 137);
            label5.Name = "label5";
            label5.Size = new Size(157, 33);
            label5.TabIndex = 9;
            label5.Text = "បញ្ជាក់ពាក្យសម្ងាត់៖";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(605, 183);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(88, 48);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "កែតម្រូវ";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(319, 183);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 48);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "លុប";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(201, 183);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 48);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "បញ្ចូល";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // cboRole
            // 
            cboRole.FormattingEnabled = true;
            cboRole.Location = new Point(555, 90);
            cboRole.Name = "cboRole";
            cboRole.Size = new Size(259, 41);
            cboRole.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(555, 45);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(259, 40);
            txtEmail.TabIndex = 3;
            // 
            // txtPwd
            // 
            txtPwd.Location = new Point(201, 91);
            txtPwd.Name = "txtPwd";
            txtPwd.Size = new Size(259, 40);
            txtPwd.TabIndex = 1;
            txtPwd.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(201, 45);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(259, 40);
            txtUsername.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(476, 90);
            label4.Name = "label4";
            label4.Size = new Size(67, 33);
            label4.TabIndex = 3;
            label4.Text = "តួនាទី៖";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(476, 48);
            label3.Name = "label3";
            label3.Size = new Size(73, 33);
            label3.TabIndex = 2;
            label3.Text = "អ៊ីម៉ែល៖";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 90);
            label2.Name = "label2";
            label2.Size = new Size(109, 33);
            label2.TabIndex = 1;
            label2.Text = "ពាក្យសម្ងាត់៖";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 48);
            label1.Name = "label1";
            label1.Size = new Size(158, 33);
            label1.TabIndex = 0;
            label1.Text = "ឈ្មោះអ្នកប្រើប្រាស់៖";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tabControl1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 251);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(846, 368);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "បញ្ជីឈ្មោះអ្នកប្រើប្រាស់";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtConfirmPwd);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnEdit);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(cboRole);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtPwd);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(846, 251);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "គ្រប់គ្រងអ្នកប្រើប្រាស់";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(437, 183);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(162, 48);
            btnClear.TabIndex = 7;
            btnClear.Text = "ផ្អាកការប្រើប្រាស់";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(3, 36);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(840, 329);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lvUser);
            tabPage1.Location = new Point(4, 42);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(832, 283);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "កំពុងដំណើរការ";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 42);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(832, 283);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "ផ្អាកប្រើប្រាស់";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 42);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(832, 283);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "បានលុបចេញ";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // frmUser
            // 
            AutoScaleDimensions = new SizeF(10F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 619);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Khmer OS Siemreap", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmUser";
            Text = "User Manager";
            Load += frmUser_Load;
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView lvUser;
        private TextBox txtConfirmPwd;
        private Label label5;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnAdd;
        private ComboBox cboRole;
        private TextBox txtEmail;
        private TextBox txtPwd;
        private TextBox txtUsername;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Button btnClear;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
    }
}