using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPOGroupTree
{
    public class Group
    {
        #region Fields

        private string iGroup;
        private int maxRate;
        private int minRate;
        private double avgRate;
        private Student header;
        private List<Student> students;

        #endregion

        #region GetSet members

        public string getIGroup { get { return iGroup; } }
        public int getMinRate { get { return minRate; } }
        public int getMaxRate { get { return maxRate; } }
        public double getAvgRate { get { return avgRate; } }
        public Student getHeader { get { return header; } }

        #endregion

        public Group(string index)
        {
            iGroup = index;
            minRate = maxRate = 0;
            avgRate = 0;
            header = null;
            students = new List<Student>();
        }

        public Group(Group g)
        {
            this.iGroup = g.getIGroup;
            this.minRate = g.getMinRate;
            this.maxRate = g.getMaxRate;
            this.avgRate = g.getAvgRate;
            this.header = g.getHeader;
            this.students = new List<Student>(g.students);
        }

        private int compare(Student S1, Student S2)
        {
            return (S1 > S2) ? 1 : -1;
        }

        private void ReloadRate()
        {
            int min, max, sumRate = 0;
            if (students.Count == 0)
                min = max = 0;
            else
                max = min = students[0].Rating;

            foreach (var std in students)
            {
                sumRate += std.Rating;
                if (min > std.Rating) 
                    min = std.Rating;
                if (max < std.Rating) 
                    max = std.Rating;
            }

            minRate = min;
            maxRate = max;
            avgRate = (double)sumRate / (students.Count);
        }

        /// <summary>
        /// Insert STUDENT into group
        /// </summary>
        /// <param name="std"></param>
        public void Insert(Student std)
        {
            students.Add(std);
            if (std.Role == "head")
                header = std;
            
            students.Sort(compare);
        }

        /// <summary>
        /// Delete STUDENT from group
        /// </summary>
        /// <param name="std"></param>
        public void Delete(Student std)
        {
            students.Remove(std);
            ReloadRate();
        }

        /// <summary>
        /// Update STUDENT of group
        /// </summary>
        /// <param name="old_std"></param>
        /// <param name="new_std"></param>
        public void Update(Student old_std, Student new_std)
        {
            int i = students.FindIndex(x => x == old_std);
            if (i >= 0)
            {
                students[i] = new_std;
                students.Sort(compare);
                ReloadRate();
                if (new_std.Role == "head")
                    header = new_std;
            }
        }

        /// <summary>
        /// Rename group
        /// </summary>
        /// <param name="index"></param>
        public void Rename(string index)
        {
            iGroup = index;
            foreach (Student std in students)
                std.GroupIndex = iGroup;
        }

        /// <summary>
        /// Compare 2 groups, using index
        /// By default, return g1 > g2
        /// </summary>
        /// <param name="g1"></param>
        /// <param name="g2"></param>
        /// <returns></returns>
        public static bool operator >(Group g1, Group g2)
        {
            if (g1 == null) return false;
            if (g2 == null) return true;

            return String.Compare(g1.getIGroup, g2.getIGroup) > 0;
        }

        public static bool operator <(Group g1, Group g2)
        {
            if (g2 == null) return false;
            if (g1 == null) return true;

            return String.Compare(g1.getIGroup, g2.getIGroup) < 0;
        }

        public List<Student> Students
        {
            get { return new List<Student>(students); }
        }

        public int StudentsCount
        {
            get { return students.Count; }
        }

        public Student this[int index] { get { return students[index]; } }
    }
}
