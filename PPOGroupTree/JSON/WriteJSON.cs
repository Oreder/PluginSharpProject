using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPOGroupTree.JSON
{
    class WriteJSON : IWriter
    {
        public void Save(string fileName, List<Group> grp)
        {
            if (File.Exists(fileName))
                throw new Exception("File does not exist!");
            try
            {
                StreamWriter writer = new StreamWriter(fileName);
                writer.Write("[\r\n ");
                for (int i = 0; i < grp.Count; i++)
                {
                    for (int j = 0; j < grp[i].StudentsCount; j++)
                    {
                        writer.Write("{\r\n   ");
                        writer.Write("\"Surname\": \"{0}\",\r\n   ", NormalizeString(grp[i][j].Surname));
                        writer.Write("\"Name\": \"{0}\",\r\n   ", NormalizeString(grp[i][j].Name));
                        writer.Write("\"SecondName\": \"{0}\",\r\n   ", NormalizeString(grp[i][j].MiddleName));
                        writer.Write("\"Rating\": \"{0}\",\r\n   ", grp[i][j].Rating);
                        writer.Write("\"Group\": \"{0}\",\r\n   ", NormalizeString(grp[i][j].GroupIndex));
                        writer.Write("\"Role\": \"{0}\"\r\n ", NormalizeString(grp[i][j].Role));
                        if (i == grp.Count - 1 && j == grp[i].StudentsCount - 1)
                            writer.Write("}\r\n");
                        else
                            writer.Write("},\r\n ");
                    }
                }

                writer.Write("]");
                writer.Close();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Error on writing: " + e.Message);
            }
        }

        private string NormalizeString(string source)
        {
            List<char> l_source = new List<char>(source);
            int index = l_source.FindIndex(x => x == '{' || x == '}' || x == '[' || x == ']' || x == ',');
            while (index >= 0)
            {
                l_source.RemoveAt(index);
                index = l_source.FindIndex(x => x == '{' || x == '}' || x == '[' || x == ']' || x == ',');
            }
            return new string(l_source.ToArray());
        }
    }
}
