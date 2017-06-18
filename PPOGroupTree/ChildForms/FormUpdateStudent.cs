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
    public partial class FormUpdateStudent : Form
    {
        private MainForm mainForm;
        private Student std;

        public FormUpdateStudent(MainForm mainForm, string iGroup, int treeIndex)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this.mainForm = mainForm;

            std = mainForm.GetStudent(iGroup, treeIndex);

            edtSurN.Text = std.Surname;
            edtName.Text = std.Name;
            edtMidN.Text = std.MiddleName;

            edtRate.Text = std.Rating.ToString();
            edtAvarta.Text = std.Avarta;
            edtRole.SelectedIndex = (std.Role == "head") ? 1 : 0;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
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
                mainForm.UpdateStudent(std, new Student(edtSurN.Text, edtName.Text, edtMidN.Text,
                                                   std.GroupIndex, edtRole.SelectedText, rate, edtAvarta.Text));
                Close();
            }
            else
                MessageBox.Show("Data is given incorrectly! Try again!", "Error");
        }

        private void FormUpdateStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Enabled = true;
        }
    }
}
