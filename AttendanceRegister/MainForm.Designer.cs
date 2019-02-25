namespace AttendanceRegister
{
    partial class AttendanceRegister
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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageParishioners = new System.Windows.Forms.TabPage();
            this.ParishionersDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPageWard = new System.Windows.Forms.TabPage();
            this.WardsDataGridView = new System.Windows.Forms.DataGridView();
            this.addParishionerButton = new System.Windows.Forms.Button();
            this.addWardButton = new System.Windows.Forms.Button();
            this.removeParishionerButton = new System.Windows.Forms.Button();
            this.removeWardButton = new System.Windows.Forms.Button();
            this.mainMenu.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageParishioners.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParishionersDataGridView)).BeginInit();
            this.tabPageWard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WardsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(982, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageParishioners);
            this.tabControlMain.Controls.Add(this.tabPageWard);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControlMain.Location = new System.Drawing.Point(0, 24);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(982, 432);
            this.tabControlMain.TabIndex = 1;
            // 
            // tabPageParishioners
            // 
            this.tabPageParishioners.Controls.Add(this.ParishionersDataGridView);
            this.tabPageParishioners.Location = new System.Drawing.Point(4, 22);
            this.tabPageParishioners.Name = "tabPageParishioners";
            this.tabPageParishioners.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageParishioners.Size = new System.Drawing.Size(974, 406);
            this.tabPageParishioners.TabIndex = 0;
            this.tabPageParishioners.Text = "Parishioners";
            this.tabPageParishioners.UseVisualStyleBackColor = true;
            // 
            // ParishionersDataGridView
            // 
            this.ParishionersDataGridView.AllowUserToAddRows = false;
            this.ParishionersDataGridView.AllowUserToOrderColumns = true;
            this.ParishionersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ParishionersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ParishionersDataGridView.Location = new System.Drawing.Point(3, 3);
            this.ParishionersDataGridView.Name = "ParishionersDataGridView";
            this.ParishionersDataGridView.ReadOnly = true;
            this.ParishionersDataGridView.Size = new System.Drawing.Size(968, 400);
            this.ParishionersDataGridView.TabIndex = 0;
            // 
            // tabPageWard
            // 
            this.tabPageWard.Controls.Add(this.WardsDataGridView);
            this.tabPageWard.Location = new System.Drawing.Point(4, 22);
            this.tabPageWard.Name = "tabPageWard";
            this.tabPageWard.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWard.Size = new System.Drawing.Size(974, 406);
            this.tabPageWard.TabIndex = 1;
            this.tabPageWard.Text = "Wards";
            this.tabPageWard.UseVisualStyleBackColor = true;
            // 
            // WardsDataGridView
            // 
            this.WardsDataGridView.AllowUserToAddRows = false;
            this.WardsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WardsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WardsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.WardsDataGridView.Name = "WardsDataGridView";
            this.WardsDataGridView.ReadOnly = true;
            this.WardsDataGridView.Size = new System.Drawing.Size(968, 400);
            this.WardsDataGridView.TabIndex = 0;
            // 
            // addParishionerButton
            // 
            this.addParishionerButton.Location = new System.Drawing.Point(12, 463);
            this.addParishionerButton.Name = "addParishionerButton";
            this.addParishionerButton.Size = new System.Drawing.Size(121, 23);
            this.addParishionerButton.TabIndex = 2;
            this.addParishionerButton.Text = "Add Parishioner";
            this.addParishionerButton.UseVisualStyleBackColor = true;
            this.addParishionerButton.Click += new System.EventHandler(this.addParishionerButton_Click);
            // 
            // addWardButton
            // 
            this.addWardButton.Location = new System.Drawing.Point(139, 463);
            this.addWardButton.Name = "addWardButton";
            this.addWardButton.Size = new System.Drawing.Size(121, 23);
            this.addWardButton.TabIndex = 3;
            this.addWardButton.Text = "Add Ward";
            this.addWardButton.UseVisualStyleBackColor = true;
            // 
            // removeParishionerButton
            // 
            this.removeParishionerButton.Location = new System.Drawing.Point(721, 463);
            this.removeParishionerButton.Name = "removeParishionerButton";
            this.removeParishionerButton.Size = new System.Drawing.Size(121, 23);
            this.removeParishionerButton.TabIndex = 4;
            this.removeParishionerButton.Text = "Remove Parishioner";
            this.removeParishionerButton.UseVisualStyleBackColor = true;
            // 
            // removeWardButton
            // 
            this.removeWardButton.Location = new System.Drawing.Point(848, 463);
            this.removeWardButton.Name = "removeWardButton";
            this.removeWardButton.Size = new System.Drawing.Size(121, 23);
            this.removeWardButton.TabIndex = 5;
            this.removeWardButton.Text = "Remove Ward";
            this.removeWardButton.UseVisualStyleBackColor = true;
            // 
            // AttendanceRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 498);
            this.Controls.Add(this.removeWardButton);
            this.Controls.Add(this.removeParishionerButton);
            this.Controls.Add(this.addWardButton);
            this.Controls.Add(this.addParishionerButton);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.mainMenu);
            this.Name = "AttendanceRegister";
            this.Text = "Attendance Register";
            this.Load += new System.EventHandler(this.AttendanceRegister_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageParishioners.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ParishionersDataGridView)).EndInit();
            this.tabPageWard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WardsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageParishioners;
        private System.Windows.Forms.TabPage tabPageWard;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button addParishionerButton;
        private System.Windows.Forms.Button addWardButton;
        private System.Windows.Forms.Button removeParishionerButton;
        private System.Windows.Forms.Button removeWardButton;
        private System.Windows.Forms.DataGridView ParishionersDataGridView;
        private System.Windows.Forms.DataGridView WardsDataGridView;
    }
}

