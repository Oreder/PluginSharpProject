using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PPOGroupTree.Command;
using PPOGroupTree.JSON;
using PPOGroupTree.Plugins;

namespace PPOGroupTree
{
    public partial class MainForm : Form
    {
        private Controller manager;

        public MainForm()
        {
            InitializeComponent();
            manager = new Controller();
            treeView1.ContextMenuStrip = rootMenu;
        }

        #region Plugin (Updated..)

        private Plugin PGI;

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.PGI = new Plugin(this.treeView1, this.rootMenu, this.groupMenu, this.studentMenu);
            var events = this.PGI.Load();

            eventList.Items.Clear();
            
            // Shutdown the painting of the ListBox as items are added.
            eventList.BeginUpdate();
            if (events.Count > 0)
            {
                eventList.Items.Add("  Loaded plugins");
                eventList.Items.Add("------------------------------");
                foreach (string name in events)
                    eventList.Items.Add(name);
            }
            else
                eventList.Items.Add("No plugin");

            // Allow the ListBox to repaint and display the new items.
            eventList.EndUpdate();
        }

        #endregion

        private void UpdateTreeView()
        {
            treeView1.Nodes.Clear();
            List<TreeNode> list_nodes = manager.UpdateTree();
            for (int i = 0; i < list_nodes.Count; i++)
                treeView1.Nodes.Add(list_nodes[i]);
            treeView1.ExpandAll();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            manager.Undo();
            UpdateTreeView();
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            manager.Redo();
            UpdateTreeView();
        }

        private void btnLoadJSON_Click(object sender, EventArgs e)
        {
            openFile.ShowDialog();
        }

        private void openFile_FileOk(object sender, CancelEventArgs e)
        {
            manager.LoadFromFile(openFile.FileName);
            UpdateTreeView();
        }

        private void btnSaveJSON_Click(object sender, EventArgs e)
        {
            saveFile.ShowDialog();
        }

        private void saveFile_FileOk(object sender, CancelEventArgs e)
        {
            manager.SaveToFile(saveFile.FileName);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            int i = e.Node.Level;
            if (i == 0)
                e.Node.ContextMenuStrip = groupMenu;
            else if (i > 0)
                e.Node.ContextMenuStrip = studentMenu;
        }

        private void addNewGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form_new_group_name = new FormNewGroupName(this);
            form_new_group_name.Show();
        }

        internal void InsertGroup(string name)
        {
            manager.InsertGroup(name);
            UpdateTreeView();
        }

        private void treeView1_NodeMouseHover(object sender, TreeNodeMouseHoverEventArgs e)
        {
            toolTip.Hide(treeView1);
            if (e.Node.Level == 0)
            {
                string text = manager.GetToolTipTextForGroup(e.Node.Text);
                toolTip.Show(text, treeView1);
            }
            else if (e.Node.Level == 1)
            {
                string text = manager.GetToolTipTextForStudent(e.Node.Parent.Text, e.Node.Index);
                toolTip.Show(text, treeView1);
            }
        }

        private void renameGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form_rename_group = new FormRenameGroup(this);
            form_rename_group.Show();
        }
        
        internal void RenameGroup(string p)
        {
            manager.RenameGroup(treeView1.SelectedNode.Text, p);
            UpdateTreeView();
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form_add_student = new FormAddStudent(this, treeView1.SelectedNode.Text);
            form_add_student.Show();
        }

        internal void InsertStudent(Student student)
        {
            manager.InsertStudent(student);
            UpdateTreeView();
        }

        private void removeGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manager.DeleteGroup(treeView1.SelectedNode.Text);
            UpdateTreeView();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form_update_student = new FormUpdateStudent(this, 
                                                            treeView1.SelectedNode.Parent.Text,
                                                            treeView1.SelectedNode.Index);
            form_update_student.Show();
        }

        internal void UpdateStudent(Student old_std, Student new_std)
        {
            manager.UpdateStudent(old_std, new_std);
            UpdateTreeView();
        }

        internal Student GetStudent(string iGroup, int treeIndex)
        {
            return manager.GetStudent(iGroup, treeIndex);
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manager.DeleteStudent(treeView1.SelectedNode.Parent.Text, treeView1.SelectedNode.Index);
            UpdateTreeView();
        }
    }
}
