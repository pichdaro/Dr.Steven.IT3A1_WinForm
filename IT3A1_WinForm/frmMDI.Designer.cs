namespace IT3A1_WinForm
{
    partial class frmMDI
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            userPreferenceToolStripMenuItem = new ToolStripMenuItem();
            changePasswordToolStripMenuItem = new ToolStripMenuItem();
            changeEmailToolStripMenuItem = new ToolStripMenuItem();
            updateAvataToolStripMenuItem = new ToolStripMenuItem();
            showFormToolStripMenuItem = new ToolStripMenuItem();
            frmMainToolStripMenuItem = new ToolStripMenuItem();
            frmListBoxStudentToolStripMenuItem = new ToolStripMenuItem();
            frmListBoxStudentV2ToolStripMenuItem = new ToolStripMenuItem();
            frmListViewStiudentToolStripMenuItem = new ToolStripMenuItem();
            frmLitstViewStudentDBToolStripMenuItem = new ToolStripMenuItem();
            userManagerToolStripMenuItem = new ToolStripMenuItem();
            windowsToolStripMenuItem = new ToolStripMenuItem();
            arrageToolStripMenuItem = new ToolStripMenuItem();
            cascadeToolStripMenuItem = new ToolStripMenuItem();
            tileVerticalToolStripMenuItem = new ToolStripMenuItem();
            tileHorizontalToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            userManualToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            tsStatus = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, showFormToolStripMenuItem, windowsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1100, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(141, 34);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { userPreferenceToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(58, 29);
            editToolStripMenuItem.Text = "&Edit";
            // 
            // userPreferenceToolStripMenuItem
            // 
            userPreferenceToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { changePasswordToolStripMenuItem, changeEmailToolStripMenuItem, updateAvataToolStripMenuItem });
            userPreferenceToolStripMenuItem.Name = "userPreferenceToolStripMenuItem";
            userPreferenceToolStripMenuItem.Size = new Size(270, 34);
            userPreferenceToolStripMenuItem.Text = "User &Preference";
            // 
            // changePasswordToolStripMenuItem
            // 
            changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            changePasswordToolStripMenuItem.Size = new Size(270, 34);
            changePasswordToolStripMenuItem.Text = "Change Password";
            changePasswordToolStripMenuItem.Click += changePasswordToolStripMenuItem_Click;
            // 
            // changeEmailToolStripMenuItem
            // 
            changeEmailToolStripMenuItem.Name = "changeEmailToolStripMenuItem";
            changeEmailToolStripMenuItem.Size = new Size(270, 34);
            changeEmailToolStripMenuItem.Text = "Change Email";
            // 
            // updateAvataToolStripMenuItem
            // 
            updateAvataToolStripMenuItem.Name = "updateAvataToolStripMenuItem";
            updateAvataToolStripMenuItem.Size = new Size(270, 34);
            updateAvataToolStripMenuItem.Text = "Update Avata";
            updateAvataToolStripMenuItem.Click += updateAvataToolStripMenuItem_Click;
            // 
            // showFormToolStripMenuItem
            // 
            showFormToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { frmMainToolStripMenuItem, frmListBoxStudentToolStripMenuItem, frmListBoxStudentV2ToolStripMenuItem, frmListViewStiudentToolStripMenuItem, frmLitstViewStudentDBToolStripMenuItem, userManagerToolStripMenuItem });
            showFormToolStripMenuItem.Name = "showFormToolStripMenuItem";
            showFormToolStripMenuItem.Size = new Size(119, 29);
            showFormToolStripMenuItem.Text = "Show &Form";
            // 
            // frmMainToolStripMenuItem
            // 
            frmMainToolStripMenuItem.Name = "frmMainToolStripMenuItem";
            frmMainToolStripMenuItem.Size = new Size(329, 34);
            frmMainToolStripMenuItem.Text = "frmMain";
            frmMainToolStripMenuItem.Click += frmMainToolStripMenuItem_Click;
            // 
            // frmListBoxStudentToolStripMenuItem
            // 
            frmListBoxStudentToolStripMenuItem.Name = "frmListBoxStudentToolStripMenuItem";
            frmListBoxStudentToolStripMenuItem.Size = new Size(329, 34);
            frmListBoxStudentToolStripMenuItem.Text = "frmListBox - Student​ - V1";
            frmListBoxStudentToolStripMenuItem.Click += frmListBoxStudentToolStripMenuItem_Click;
            // 
            // frmListBoxStudentV2ToolStripMenuItem
            // 
            frmListBoxStudentV2ToolStripMenuItem.Name = "frmListBoxStudentV2ToolStripMenuItem";
            frmListBoxStudentV2ToolStripMenuItem.Size = new Size(329, 34);
            frmListBoxStudentV2ToolStripMenuItem.Text = "frmListBox - Student​ - V2";
            frmListBoxStudentV2ToolStripMenuItem.Click += frmListBoxStudentV2ToolStripMenuItem_Click;
            // 
            // frmListViewStiudentToolStripMenuItem
            // 
            frmListViewStiudentToolStripMenuItem.Name = "frmListViewStiudentToolStripMenuItem";
            frmListViewStiudentToolStripMenuItem.Size = new Size(329, 34);
            frmListViewStiudentToolStripMenuItem.Text = "frmListView - Student";
            frmListViewStiudentToolStripMenuItem.Click += frmListViewStiudentToolStripMenuItem_Click;
            // 
            // frmLitstViewStudentDBToolStripMenuItem
            // 
            frmLitstViewStudentDBToolStripMenuItem.Name = "frmLitstViewStudentDBToolStripMenuItem";
            frmLitstViewStudentDBToolStripMenuItem.Size = new Size(329, 34);
            frmLitstViewStudentDBToolStripMenuItem.Text = "frmLitstView - Student - DB";
            frmLitstViewStudentDBToolStripMenuItem.Click += frmLitstViewStudentDBToolStripMenuItem_Click;
            // 
            // userManagerToolStripMenuItem
            // 
            userManagerToolStripMenuItem.Name = "userManagerToolStripMenuItem";
            userManagerToolStripMenuItem.Size = new Size(329, 34);
            userManagerToolStripMenuItem.Text = "User Manager";
            userManagerToolStripMenuItem.Click += userManagerToolStripMenuItem_Click;
            // 
            // windowsToolStripMenuItem
            // 
            windowsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { arrageToolStripMenuItem });
            windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            windowsToolStripMenuItem.Size = new Size(102, 29);
            windowsToolStripMenuItem.Text = "&Windows";
            // 
            // arrageToolStripMenuItem
            // 
            arrageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cascadeToolStripMenuItem, tileVerticalToolStripMenuItem, tileHorizontalToolStripMenuItem });
            arrageToolStripMenuItem.Name = "arrageToolStripMenuItem";
            arrageToolStripMenuItem.Size = new Size(167, 34);
            arrageToolStripMenuItem.Text = "&Arrage";
            // 
            // cascadeToolStripMenuItem
            // 
            cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            cascadeToolStripMenuItem.Size = new Size(227, 34);
            cascadeToolStripMenuItem.Text = "&Cascade";
            cascadeToolStripMenuItem.Click += cascadeToolStripMenuItem_Click;
            // 
            // tileVerticalToolStripMenuItem
            // 
            tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            tileVerticalToolStripMenuItem.Size = new Size(227, 34);
            tileVerticalToolStripMenuItem.Text = "Tile &Vertical";
            tileVerticalToolStripMenuItem.Click += tileVerticalToolStripMenuItem_Click;
            // 
            // tileHorizontalToolStripMenuItem
            // 
            tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            tileHorizontalToolStripMenuItem.Size = new Size(227, 34);
            tileHorizontalToolStripMenuItem.Text = "Tile &Horizontal";
            tileHorizontalToolStripMenuItem.Click += tileHorizontalToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { userManualToolStripMenuItem, aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(65, 29);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // userManualToolStripMenuItem
            // 
            userManualToolStripMenuItem.Name = "userManualToolStripMenuItem";
            userManualToolStripMenuItem.Size = new Size(212, 34);
            userManualToolStripMenuItem.Text = "User &Manual";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(212, 34);
            aboutToolStripMenuItem.Text = "&About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, tsStatus });
            statusStrip1.Location = new Point(0, 529);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1100, 32);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(74, 25);
            toolStripStatusLabel1.Text = "Howdy!";
            // 
            // tsStatus
            // 
            tsStatus.Name = "tsStatus";
            tsStatus.Size = new Size(179, 25);
            tsStatus.Text = "toolStripStatusLabel2";
            // 
            // frmMDI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 561);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmMDI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Form";
            WindowState = FormWindowState.Maximized;
            Load += frmMDI_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem userPreferenceToolStripMenuItem;
        private ToolStripMenuItem showFormToolStripMenuItem;
        private ToolStripMenuItem frmMainToolStripMenuItem;
        private ToolStripMenuItem windowsToolStripMenuItem;
        private ToolStripMenuItem arrageToolStripMenuItem;
        private ToolStripMenuItem cascadeToolStripMenuItem;
        private ToolStripMenuItem tileVerticalToolStripMenuItem;
        private ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem userManualToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel tsStatus;
        private ToolStripMenuItem frmListBoxStudentToolStripMenuItem;
        private ToolStripMenuItem frmListBoxStudentV2ToolStripMenuItem;
        private ToolStripMenuItem frmListViewStiudentToolStripMenuItem;
        private ToolStripMenuItem frmLitstViewStudentDBToolStripMenuItem;
        private ToolStripMenuItem userManagerToolStripMenuItem;
        private ToolStripMenuItem changePasswordToolStripMenuItem;
        private ToolStripMenuItem changeEmailToolStripMenuItem;
        private ToolStripMenuItem updateAvataToolStripMenuItem;
    }
}