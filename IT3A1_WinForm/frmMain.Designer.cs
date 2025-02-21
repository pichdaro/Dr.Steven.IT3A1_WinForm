namespace IT3A1_WinForm
{
    partial class frmMain
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
            dateTimePicker1 = new DateTimePicker();
            listBox1 = new ListBox();
            richTextBox1 = new RichTextBox();
            progressBar1 = new ProgressBar();
            btnClose = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(570, 83);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(126, 31);
            dateTimePicker1.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Items.AddRange(new object[] { "Nita", "Seyha", "Vicheka", "Tola" });
            listBox1.Location = new Point(299, 135);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(409, 129);
            listBox1.TabIndex = 1;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(82, 241);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(150, 144);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(107, 83);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(159, 37);
            progressBar1.TabIndex = 3;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(331, 77);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(103, 47);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.Location = new Point(299, 312);
            listView1.Name = "listView1";
            listView1.Size = new Size(409, 203);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "No";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Name";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Gender";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 566);
            Controls.Add(listView1);
            Controls.Add(btnClose);
            Controls.Add(progressBar1);
            Controls.Add(richTextBox1);
            Controls.Add(listBox1);
            Controls.Add(dateTimePicker1);
            Name = "frmMain";
            Text = "frmMain";
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private ListBox listBox1;
        private RichTextBox richTextBox1;
        private ProgressBar progressBar1;
        private Button btnClose;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}