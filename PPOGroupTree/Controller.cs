using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPOGroupTree.Command;
using System.Windows.Forms;
using PPOGroupTree.JSON;

namespace PPOGroupTree
{
    class Controller
    {
        private GroupStructure main_data_structure;
        private StackCommand cmdStack;

        public Controller()
        {
            main_data_structure = GroupStructure.Instance;
            cmdStack = new StackCommand();
        }

        public List<TreeNode> UpdateTree()
        {
            List<TreeNode> updated_nodes = new List<TreeNode>();
            for (int i = 0; i < main_data_structure.Groups.Count; i++)
            {
                List<TreeNode> next_level = new List<TreeNode>();
                for (int j = 0; j < main_data_structure[i].StudentsCount; j++)
                    next_level.Add(new TreeNode(main_data_structure[i][j].Surname + " " + 
                                                main_data_structure[i][j].Name + " " + 
                                                main_data_structure[i][j].MiddleName));
                updated_nodes.Add(new TreeNode(main_data_structure[i].getIGroup, next_level.ToArray()));
            }

            return updated_nodes;
        }

        public void InsertGroup(string name)
        {
            cmdStack.InsertGroup(new Group(name));
        }

        public void InsertStudent(Student student)
        {
            cmdStack.InsertStudent(student);
        }

        public void UpdateStudent(Student old_rec, Student new_rec)
        {
            cmdStack.UpdateStudent(old_rec, new_rec);
        }

        public void RenameGroup(string old_name, string new_name)
        {
            cmdStack.RenameGroup(old_name, new_name);
        }

        public void DeleteGroup(string name)
        {
            cmdStack.DeleteGroup(main_data_structure[name]);
        }

        public void DeleteStudent(string group_name, int student_index)
        {
            cmdStack.DeleteStudent(main_data_structure[group_name][student_index]);
        }

        public void Undo()
        {
            cmdStack.Undo();
        }

        public void Redo()
        {
            cmdStack.Redo();
        }

        public void LoadFromFile(string filename)
        {
            IReader reader = new ParseJSON();
            List<Group> list = reader.Read(filename);
            if (list != null)
                cmdStack.Load(list);
        }

        public void SaveToFile(string filename)
        {
            IWriter writer = new WriteJSON();
            writer.Save(filename, main_data_structure.Groups);
        }

        public string GetToolTipTextForStudent(string group_name, int index)
        {
            Student student = main_data_structure[group_name][index];
            return "FullName: " + student.Surname + " " + student.Name + " " + student.MiddleName + "\n" +
                   "iGroup: " + group_name + "\n" + "Rating: " + student.Rating + "\n" +
                   "Avarta: " + student.Avarta;
        }

        public string GetToolTipTextForGroup(string group_name)
        {
            Group group = main_data_structure[group_name];
            string full_name_head;
            if (group.getHeader == null)
                full_name_head = "";
            else
                full_name_head = group.getHeader.Surname + " " + group.getHeader.Name + " " + group.getHeader.MiddleName;
            return "Group: " + group_name + "\n" + "NumberOfStudents: " + group.StudentsCount + "\n" +
                   "Header: " + full_name_head + "\n" +
                   "MaxRating: " + group.getMaxRate + "\n" + "AverageRating: " + Math.Round(group.getAvgRate, 2) + "\n" +
                   "MinRating: " + group.getMinRate + "\n";
        }

        public Student GetStudent(string group_name, int index)
        {
            return main_data_structure[group_name][index];
        }
    }
}
