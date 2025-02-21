namespace IT3A1_WinForm
{
    partial class frmPassword
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
            btnCancel = new Button();
            btnUpdatePwd = new Button();
            txtConfirmPwd = new TextBox();
            label3 = new Label();
            txtNewPwd = new TextBox();
            label2 = new Label();
            txtOldPwd = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(339, 159);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(124, 42);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "បោះបង់";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdatePwd
            // 
            btnUpdatePwd.Location = new Point(186, 159);
            btnUpdatePwd.Name = "btnUpdatePwd";
            btnUpdatePwd.Size = new Size(147, 42);
            btnUpdatePwd.TabIndex = 10;
            btnUpdatePwd.Text = "ប្ដូរពាក្យសម្ងាត់";
            btnUpdatePwd.UseVisualStyleBackColor = true;
            btnUpdatePwd.Click += btnUpdatePwd_Click;
            // 
            // txtConfirmPwd
            // 
            txtConfirmPwd.Location = new Point(186, 104);
            txtConfirmPwd.Name = "txtConfirmPwd";
            txtConfirmPwd.Size = new Size(291, 40);
            txtConfirmPwd.TabIndex = 8;
            txtConfirmPwd.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 107);
            label3.Name = "label3";
            label3.Size = new Size(169, 33);
            label3.TabIndex = 12;
            label3.Text = "បញ្ជាក់ពាក្យសម្ងាត់ថ្មី៖";
            // 
            // txtNewPwd
            // 
            txtNewPwd.Location = new Point(186, 58);
            txtNewPwd.Name = "txtNewPwd";
            txtNewPwd.Size = new Size(291, 40);
            txtNewPwd.TabIndex = 7;
            txtNewPwd.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 61);
            label2.Name = "label2";
            label2.Size = new Size(121, 33);
            label2.TabIndex = 9;
            label2.Text = "ពាក្យសម្ងាត់ថ្មី៖";
            // 
            // txtOldPwd
            // 
            txtOldPwd.Location = new Point(186, 12);
            txtOldPwd.Name = "txtOldPwd";
            txtOldPwd.Size = new Size(291, 40);
            txtOldPwd.TabIndex = 5;
            txtOldPwd.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 15);
            label1.Name = "label1";
            label1.Size = new Size(145, 33);
            label1.TabIndex = 6;
            label1.Text = "ពាក្យសម្ងាត់ចាស់៖";
            // 
            // frmPassword
            // 
            AutoScaleDimensions = new SizeF(10F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 219);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdatePwd);
            Controls.Add(txtConfirmPwd);
            Controls.Add(label3);
            Controls.Add(txtNewPwd);
            Controls.Add(label2);
            Controls.Add(txtOldPwd);
            Controls.Add(label1);
            Font = new Font("Khmer OS Siemreap", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update Password";
            Load += frmPassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnUpdatePwd;
        private TextBox txtConfirmPwd;
        private Label label3;
        private TextBox txtNewPwd;
        private Label label2;
        private TextBox txtOldPwd;
        private Label label1;
    }
}