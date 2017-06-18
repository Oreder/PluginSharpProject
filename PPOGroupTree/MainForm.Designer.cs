namespace PPOGroupTree
{
    partial class MainForm
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnRedo = new System.Windows.Forms.Button();
            this.btnLoadJSON = new System.Windows.Forms.Button();
            this.btnSaveJSON = new System.Windows.Forms.Button();
            this.rootMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.renameGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.eventList = new System.Windows.Forms.ListBox();
            this.rootMenu.SuspendLayout();
            this.studentMenu.SuspendLayout();
            this.groupMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(10, 9);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(286, 397);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseHover += new System.Windows.Forms.TreeNodeMouseHoverEventHandler(this.treeView1_NodeMouseHover);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(319, 12);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(115, 66);
            this.btnUndo.TabIndex = 1;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnRedo
            // 
            this.btnRedo.Location = new System.Drawing.Point(319, 84);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(115, 66);
            this.btnRedo.TabIndex = 1;
            this.btnRedo.Text = "Redo";
            this.btnRedo.UseVisualStyleBackColor = true;
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
            // 
            // btnLoadJSON
            // 
            this.btnLoadJSON.Location = new System.Drawing.Point(319, 156);
            this.btnLoadJSON.Name = "btnLoadJSON";
            this.btnLoadJSON.Size = new System.Drawing.Size(115, 66);
            this.btnLoadJSON.TabIndex = 1;
            this.btnLoadJSON.Text = "Load JSON";
            this.btnLoadJSON.UseVisualStyleBackColor = true;
            this.btnLoadJSON.Click += new System.EventHandler(this.btnLoadJSON_Click);
            // 
            // btnSaveJSON
            // 
            this.btnSaveJSON.Location = new System.Drawing.Point(319, 228);
            this.btnSaveJSON.Name = "btnSaveJSON";
            this.btnSaveJSON.Size = new System.Drawing.Size(115, 66);
            this.btnSaveJSON.TabIndex = 1;
            this.btnSaveJSON.Text = "Save JSON";
            this.btnSaveJSON.UseVisualStyleBackColor = true;
            this.btnSaveJSON.Click += new System.EventHandler(this.btnSaveJSON_Click);
            // 
            // rootMenu
            // 
            this.rootMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewGroupToolStripMenuItem});
            this.rootMenu.Name = "rootMenu";
            this.rootMenu.Size = new System.Drawing.Size(157, 26);
            // 
            // addNewGroupToolStripMenuItem
            // 
            this.addNewGroupToolStripMenuItem.Name = "addNewGroupToolStripMenuItem";
            this.addNewGroupToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.addNewGroupToolStripMenuItem.Text = "Add new group";
            this.addNewGroupToolStripMenuItem.Click += new System.EventHandler(this.addNewGroupToolStripMenuItem_Click);
            // 
            // studentMenu
            // 
            this.studentMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.studentMenu.Name = "mainMenu";
            this.studentMenu.Size = new System.Drawing.Size(118, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editToolStripMenuItem.Text = "Edit...";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // groupMenu
            // 
            this.groupMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renameGroupToolStripMenuItem,
            this.addNewStudentToolStripMenuItem,
            this.removeGroupToolStripMenuItem});
            this.groupMenu.Name = "mainMenu";
            this.groupMenu.Size = new System.Drawing.Size(165, 70);
            // 
            // renameGroupToolStripMenuItem
            // 
            this.renameGroupToolStripMenuItem.Name = "renameGroupToolStripMenuItem";
            this.renameGroupToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.renameGroupToolStripMenuItem.Text = "Rename group...";
            this.renameGroupToolStripMenuItem.Click += new System.EventHandler(this.renameGroupToolStripMenuItem_Click);
            // 
            // addNewStudentToolStripMenuItem
            // 
            this.addNewStudentToolStripMenuItem.Name = "addNewStudentToolStripMenuItem";
            this.addNewStudentToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.addNewStudentToolStripMenuItem.Text = "Add new student";
            this.addNewStudentToolStripMenuItem.Click += new System.EventHandler(this.addNewStudentToolStripMenuItem_Click);
            // 
            // removeGroupToolStripMenuItem
            // 
            this.removeGroupToolStripMenuItem.Name = "removeGroupToolStripMenuItem";
            this.removeGroupToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.removeGroupToolStripMenuItem.Text = "Remove group";
            this.removeGroupToolStripMenuItem.Click += new System.EventHandler(this.removeGroupToolStripMenuItem_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFile";
            this.openFile.FileOk += new System.ComponentModel.CancelEventHandler(this.openFile_FileOk);
            // 
            // saveFile
            // 
            this.saveFile.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFile_FileOk);
            // 
            // eventList
            // 
            this.eventList.FormattingEnabled = true;
            this.eventList.Location = new System.Drawing.Point(302, 311);
            this.eventList.Name = "eventList";
            this.eventList.Size = new System.Drawing.Size(137, 95);
            this.eventList.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 416);
            this.Controls.Add(this.eventList);
            this.Controls.Add(this.btnSaveJSON);
            this.Controls.Add(this.btnLoadJSON);
            this.Controls.Add(this.btnRedo);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.treeView1);
            this.Name = "MainForm";
            this.Text = "GroupTreeView";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.rootMenu.ResumeLayout(false);
            this.studentMenu.ResumeLayout(false);
            this.groupMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnRedo;
        private System.Windows.Forms.Button btnLoadJSON;
        private System.Windows.Forms.Button btnSaveJSON;
        private System.Windows.Forms.ContextMenuStrip rootMenu;
        private System.Windows.Forms.ToolStripMenuItem addNewGroupToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip studentMenu;
        private System.Windows.Forms.ContextMenuStrip groupMenu;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem renameGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ListBox eventList;
    }
}

