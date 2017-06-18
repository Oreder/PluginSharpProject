using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPOGroupTree
{
    public class GroupStructure
    {
        private List<Group> groups;

        public List<Group> Groups
        {
            get { return groups; }
        }

        private static readonly GroupStructure instance = new GroupStructure();

        public static GroupStructure Instance { get { return instance; } }

        #region Modification this

        public Group this[int index]
        {
            get
            {
                if (index >= 0 && index < groups.Count)
                    return groups[index];
                else
                    return null;
            }
        }

        public Group this[string index]
        {
            get
            {
                int i = groups.FindIndex(x => x.getIGroup == index);
                if (i >= 0)
                    return groups[i];
                else
                    return null;
            }
        }

        #endregion

        #region Constructors

        protected GroupStructure()
        {
            groups = new List<Group>();
        }

        public void LoadGroupStructure(List<Group> groups)
        {
            this.groups = groups;
        } 
        
        #endregion

        /// <summary>
        /// Insert new group
        /// </summary>
        /// <param name="g"></param>
        public void InsertGroup(Group g)
        {
            int i = groups.FindIndex(x => x.getIGroup == g.getIGroup);
            if (i < 0)
            {
                groups.Add(g);
                groups.Sort(gCompare);
            }
            else
                MessageBox.Show("Error on inserting group: Invalid iGroup", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Insert new student into current group
        /// </summary>
        /// <param name="std"></param>
        public void InsertStudent(Student std)
        {
            int i = groups.FindIndex(x => x.getIGroup == std.GroupIndex);
            if (i >= 0)
                groups[i].Insert(std);
            else
                MessageBox.Show("Error on inserting student: Given iGroup does not exist! Try creating group first..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Remove group
        /// </summary>
        /// <param name="g"></param>
        public void DeleteGroup(Group g)
        {
            int i = groups.FindIndex(x => x.getIGroup == g.getIGroup);
            if (i >= 0)
                groups.RemoveAt(i);
            else
                MessageBox.Show("Error on removing group: Invalid given iGroup", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Remove student from current group
        /// </summary>
        /// <param name="std"></param>
        public void DeleteStudent(Student std)
        {
            int i = groups.FindIndex(x => x.getIGroup == std.GroupIndex);
            if (i >= 0)
                groups[i].Delete(std);
            else
                MessageBox.Show("Error on removing student: Given iGroup is not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Update given student of group
        /// </summary>
        /// <param name="old_std"></param>
        /// <param name="new_std"></param>
        public void UpdateStudent(Student old_std, Student new_std)
        {
            int i = groups.FindIndex(x => x.getIGroup == old_std.GroupIndex);
            if (i >= 0)
                groups[i].Update(old_std, new_std);
            else
                MessageBox.Show("Error on updating student: Student does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Rename given group
        /// </summary>
        /// <param name="old_iGrp"></param>
        /// <param name="new_iGrp"></param>
        public void RenameGroup(string old_iGrp, string new_iGrp)
        {
            int i = groups.FindIndex(x => x.getIGroup == old_iGrp);
            if (i >= 0)
            {
                groups[i].Rename(new_iGrp);
                groups.Sort(gCompare);
            }
            else
                MessageBox.Show("Error on renaming group: Invalid given iGroup", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Remove all group
        /// </summary>
        public void ClearAll()
        {
            groups.Clear();
        }

        #region Group comparier

        private int gCompare(Group g1, Group g2)
        {
            return (g1 > g2) ? 1 : -1;
        }

        #endregion
    }
}
