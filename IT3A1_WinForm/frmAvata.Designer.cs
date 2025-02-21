namespace IT3A1_WinForm
{
    partial class frmAvata
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
            pictureBox1 = new PictureBox();
            btnBrowse = new Button();
            btnSave = new Button();
            openFileDialog1 = new OpenFileDialog();
            btnRemove = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(305, 290);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(332, 11);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(150, 43);
            btnBrowse.TabIndex = 1;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(332, 60);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 43);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(332, 109);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(150, 43);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "Remove Avata";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // frmAvata
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 329);
            Controls.Add(btnRemove);
            Controls.Add(btnSave);
            Controls.Add(btnBrowse);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmAvata";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update Avata";
            Load += frmAvata_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnBrowse;
        private Button btnSave;
        private OpenFileDialog openFileDialog1;
        private Button btnRemove;
    }
}