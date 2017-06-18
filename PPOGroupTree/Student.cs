using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPOGroupTree
{
    public class Student
    {
        #region Fields

        private string surname;
        private string name;
        private string middlename;
        private string iGroup;
        private string role;
        private string avarta;
        private int rating;

        #endregion

        public Student(string Surname, string Name, string MidName, string groupIndex, string Role, int Rating, string Ava = "")
        {
            surname = Surname;
            name = Name;
            middlename = MidName;
            iGroup = groupIndex;
            role = Role;
            rating = Rating;
            avarta = Ava;
        }

        #region Get-set properties

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string MiddleName
        {
            get { return middlename; }
            set { middlename = value; }
        }

        public string GroupIndex
        {
            get { return iGroup; }
            set { iGroup = value; }
        }

        public string Role
        {
            get { return role; }
            set { role = value; }
        }

        public int Rating
        {
            get { return rating; }
            set { rating = value; }
        }

        public string Avarta
        {
            get { return avarta; }
            set { avarta = value; }
        }

        #endregion

        /// <summary>
        /// Compare 2 students by full name (surname, name, midname)
        /// By default meaning return (S1 > S2)
        /// </summary>
        /// <param name="S1"></param>
        /// <param name="S2"></param>
        /// <returns></returns>
        public static bool operator >(Student S1, Student S2)
        {
            if (S1 == null) return false;
            if (S2 == null) return true;
            int iSurN = String.Compare(S1.Surname, S2.Surname),
                iName = String.Compare(S1.Name, S2.Name),
                iMidN = String.Compare(S1.MiddleName, S2.MiddleName);

            if (iSurN < 0)
                return false;
            else if (iSurN > 0)
                return true;
            else
            {
                // when the same Surname, check next
                if (iName < 0)
                    return false;
                else if (iName > 0)
                    return true;
                else
                {
                    // compare MidName finally
                    if (iMidN <= 0)
                        return false;
                    return true;
                }
            }
        }

        public static bool operator <(Student S1, Student S2)
        {
            if (S2 == null) return false;
            if (S1 == null) return true;
            int iSurN = String.Compare(S1.Surname, S2.Surname),
                iName = String.Compare(S1.Name, S2.Name),
                iMidN = String.Compare(S1.MiddleName, S2.MiddleName);

            if (iSurN > 0)
                return false;
            else if (iSurN < 0)
                return true;
            else
            {
                // when the same Surname, check next
                if (iName > 0)
                    return false;
                else if (iName < 0)
                    return true;
                else
                {
                    // compare MidName finally
                    if (iMidN >= 0)
                        return false;
                    return true;
                }
            }
        }
    }
}
