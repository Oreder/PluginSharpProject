using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPOGroupTree
{
    public partial class FormNewGroupName : Form
    {
        private MainForm parent;

        public FormNewGroupName(MainForm root)
        {
            InitializeComponent();
            parent = root;
            parent.Enabled = false;
        }

        private void btnCreateGroup_Click(object sender, EventArgs e)
        {
            parent.InsertGroup(edtGroupName.Text);
            Close();
        }

        private void FormNewGroupName_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Enabled = true;
        }
    }
}
