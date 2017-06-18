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
    public partial class FormRenameGroup : Form
    {
        private MainForm mainForm;

        public FormRenameGroup(MainForm mainForm)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this.mainForm = mainForm;
            mainForm.Enabled = false;
        }

        private void FormRenameGroup_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Enabled = true;
        }

        private void btnSubmitChanged_Click(object sender, EventArgs e)
        {
            mainForm.RenameGroup(edtGroupName.Text);
            Close();
        }
    }
}
