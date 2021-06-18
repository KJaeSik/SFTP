namespace SFTP
{
    partial class main
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.m_IPaddr_tbx = new System.Windows.Forms.TextBox();
            this.m_Portaddr_tbx = new System.Windows.Forms.TextBox();
            this.m_UserID_tbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.m_UserPW_tbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.m_Connect_btn = new System.Windows.Forms.Button();
            this.m_ConnectiomMSG_tbx = new System.Windows.Forms.TextBox();
            this.m_SelectedFilePath_tbx = new System.Windows.Forms.TextBox();
            this.m_FileSelect_btn = new System.Windows.Forms.Button();
            this.m_listview = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.m_FileNMChange_tbx = new System.Windows.Forms.TextBox();
            this.FileListMenu_Contextstrips = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_sendFile_btn = new System.Windows.Forms.Button();
            this.changeNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_UploadData_pgb = new System.Windows.Forms.ProgressBar();
            this.FileListMenu_Contextstrips.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Address :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port :";
            // 
            // m_IPaddr_tbx
            // 
            this.m_IPaddr_tbx.Location = new System.Drawing.Point(13, 29);
            this.m_IPaddr_tbx.Name = "m_IPaddr_tbx";
            this.m_IPaddr_tbx.Size = new System.Drawing.Size(221, 21);
            this.m_IPaddr_tbx.TabIndex = 2;
            // 
            // m_Portaddr_tbx
            // 
            this.m_Portaddr_tbx.Location = new System.Drawing.Point(256, 29);
            this.m_Portaddr_tbx.Name = "m_Portaddr_tbx";
            this.m_Portaddr_tbx.Size = new System.Drawing.Size(150, 21);
            this.m_Portaddr_tbx.TabIndex = 3;
            // 
            // m_UserID_tbx
            // 
            this.m_UserID_tbx.Location = new System.Drawing.Point(13, 72);
            this.m_UserID_tbx.Name = "m_UserID_tbx";
            this.m_UserID_tbx.Size = new System.Drawing.Size(140, 21);
            this.m_UserID_tbx.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "User ID :";
            // 
            // m_UserPW_tbx
            // 
            this.m_UserPW_tbx.Location = new System.Drawing.Point(158, 72);
            this.m_UserPW_tbx.Name = "m_UserPW_tbx";
            this.m_UserPW_tbx.Size = new System.Drawing.Size(140, 21);
            this.m_UserPW_tbx.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "User PW :";
            // 
            // m_Connect_btn
            // 
            this.m_Connect_btn.Location = new System.Drawing.Point(304, 72);
            this.m_Connect_btn.Name = "m_Connect_btn";
            this.m_Connect_btn.Size = new System.Drawing.Size(104, 23);
            this.m_Connect_btn.TabIndex = 8;
            this.m_Connect_btn.Text = "Connect Check";
            this.m_Connect_btn.UseVisualStyleBackColor = true;            
            // 
            // m_ConnectiomMSG_tbx
            // 
            this.m_ConnectiomMSG_tbx.Location = new System.Drawing.Point(13, 99);
            this.m_ConnectiomMSG_tbx.Name = "m_ConnectiomMSG_tbx";
            this.m_ConnectiomMSG_tbx.ReadOnly = true;
            this.m_ConnectiomMSG_tbx.Size = new System.Drawing.Size(393, 21);
            this.m_ConnectiomMSG_tbx.TabIndex = 9;
            // 
            // m_SelectedFilePath_tbx
            // 
            this.m_SelectedFilePath_tbx.Location = new System.Drawing.Point(13, 146);
            this.m_SelectedFilePath_tbx.Name = "m_SelectedFilePath_tbx";
            this.m_SelectedFilePath_tbx.ReadOnly = true;
            this.m_SelectedFilePath_tbx.Size = new System.Drawing.Size(395, 21);
            this.m_SelectedFilePath_tbx.TabIndex = 10;
            // 
            // m_FileSelect_btn
            // 
            this.m_FileSelect_btn.Location = new System.Drawing.Point(291, 173);
            this.m_FileSelect_btn.Name = "m_FileSelect_btn";
            this.m_FileSelect_btn.Size = new System.Drawing.Size(115, 23);
            this.m_FileSelect_btn.TabIndex = 11;
            this.m_FileSelect_btn.Text = "File Selecet";
            this.m_FileSelect_btn.UseVisualStyleBackColor = true;            
            // 
            // m_listview
            // 
            this.m_listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.m_listview.ContextMenuStrip = this.FileListMenu_Contextstrips;
            this.m_listview.GridLines = true;
            this.m_listview.HideSelection = false;
            this.m_listview.Location = new System.Drawing.Point(15, 238);
            this.m_listview.MultiSelect = false;
            this.m_listview.Name = "m_listview";
            this.m_listview.Size = new System.Drawing.Size(393, 278);
            this.m_listview.TabIndex = 12;
            this.m_listview.UseCompatibleStateImageBehavior = false;
            this.m_listview.View = System.Windows.Forms.View.Details;            
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Path";
            this.columnHeader1.Width = 388;
            // 
            // m_FileNMChange_tbx
            // 
            this.m_FileNMChange_tbx.Location = new System.Drawing.Point(44, 507);
            this.m_FileNMChange_tbx.Name = "m_FileNMChange_tbx";
            this.m_FileNMChange_tbx.Size = new System.Drawing.Size(100, 21);
            this.m_FileNMChange_tbx.TabIndex = 13;
            this.m_FileNMChange_tbx.Visible = false;            
            // 
            // FileListMenu_Contextstrips
            // 
            this.FileListMenu_Contextstrips.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createFolderToolStripMenuItem,
            this.deleteFolderToolStripMenuItem,
            this.changeNameToolStripMenuItem,
            this.downloadToolStripMenuItem});
            this.FileListMenu_Contextstrips.Name = "FileListMenu_Contextstrips";
            this.FileListMenu_Contextstrips.Size = new System.Drawing.Size(152, 92);            
            // 
            // createFolderToolStripMenuItem
            // 
            this.createFolderToolStripMenuItem.Name = "createFolderToolStripMenuItem";
            this.createFolderToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.createFolderToolStripMenuItem.Text = "Create Folder";            
            // 
            // deleteFolderToolStripMenuItem
            // 
            this.deleteFolderToolStripMenuItem.Name = "deleteFolderToolStripMenuItem";
            this.deleteFolderToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.deleteFolderToolStripMenuItem.Text = "Delete Folder";            
            // 
            // m_sendFile_btn
            // 
            this.m_sendFile_btn.Location = new System.Drawing.Point(291, 209);
            this.m_sendFile_btn.Name = "m_sendFile_btn";
            this.m_sendFile_btn.Size = new System.Drawing.Size(115, 23);
            this.m_sendFile_btn.TabIndex = 15;
            this.m_sendFile_btn.Text = "Upload";
            this.m_sendFile_btn.UseVisualStyleBackColor = true;            
            // 
            // changeNameToolStripMenuItem
            // 
            this.changeNameToolStripMenuItem.Name = "changeNameToolStripMenuItem";
            this.changeNameToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.changeNameToolStripMenuItem.Text = "Change Name";            
            // 
            // downloadToolStripMenuItem
            // 
            this.downloadToolStripMenuItem.Name = "downloadToolStripMenuItem";
            this.downloadToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.downloadToolStripMenuItem.Text = "Download";            
            // 
            // m_UploadData_pgb
            // 
            this.m_UploadData_pgb.ForeColor = System.Drawing.Color.DarkViolet;
            this.m_UploadData_pgb.Location = new System.Drawing.Point(15, 209);
            this.m_UploadData_pgb.Name = "m_UploadData_pgb";
            this.m_UploadData_pgb.Size = new System.Drawing.Size(270, 23);
            this.m_UploadData_pgb.TabIndex = 16;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 528);
            this.Controls.Add(this.m_UploadData_pgb);
            this.Controls.Add(this.m_sendFile_btn);
            this.Controls.Add(this.m_FileNMChange_tbx);
            this.Controls.Add(this.m_listview);
            this.Controls.Add(this.m_FileSelect_btn);
            this.Controls.Add(this.m_SelectedFilePath_tbx);
            this.Controls.Add(this.m_ConnectiomMSG_tbx);
            this.Controls.Add(this.m_Connect_btn);
            this.Controls.Add(this.m_UserPW_tbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.m_UserID_tbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.m_Portaddr_tbx);
            this.Controls.Add(this.m_IPaddr_tbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Form1";
            this.FileListMenu_Contextstrips.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
		
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox m_IPaddr_tbx;
        private System.Windows.Forms.TextBox m_Portaddr_tbx;
        private System.Windows.Forms.TextBox m_UserID_tbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox m_UserPW_tbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button m_Connect_btn;
        private System.Windows.Forms.TextBox m_ConnectiomMSG_tbx;
        private System.Windows.Forms.TextBox m_SelectedFilePath_tbx;
        private System.Windows.Forms.Button m_FileSelect_btn;
        private System.Windows.Forms.ListView m_listview;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TextBox m_FileNMChange_tbx;
        private System.Windows.Forms.ContextMenuStrip FileListMenu_Contextstrips;
        private System.Windows.Forms.ToolStripMenuItem createFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteFolderToolStripMenuItem;
        private System.Windows.Forms.Button m_sendFile_btn;
        private System.Windows.Forms.ToolStripMenuItem changeNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadToolStripMenuItem;
        private System.Windows.Forms.ProgressBar m_UploadData_pgb;
    }
}

