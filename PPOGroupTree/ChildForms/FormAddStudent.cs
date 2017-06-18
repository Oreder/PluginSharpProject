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
    public partial class FormAddStudent : Form
    {
        private MainForm mainForm;
        private string p;

        public FormAddStudent(MainForm mainForm, string p)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this.mainForm = mainForm;
            this.p = p;
            edtRole.SelectedIndex = 0;
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            try { int.Parse(edtRate.Text); }
            catch
            {
                MessageBox.Show("Support number only in rating, try again!", "Error");
            }

            int rate = int.Parse(edtRate.Text);
            bool err = (edtSurN.Text == "") || (edtName.Text == "");
            if ((rate > 0) && (!err))
            {
                mainForm.InsertStudent(new Student(edtSurN.Text, edtName.Text, edtMidN.Text,
                                                   p, edtRole.SelectedText, rate, edtAvarta.Text));
                Close();
            }
            else
                MessageBox.Show("Data is given incorrectly! Try again!", "Error");
        }

        private void FormAddStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Enabled = true;
        }
    }
}
