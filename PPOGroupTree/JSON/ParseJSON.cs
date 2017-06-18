using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPOGroupTree.JSON
{
    class ParseJSON : IReader
    {
        private List<string> GetReader(string fileName)
        {
            try
            {
                var reader = new StreamReader(fileName);
                string text = reader.ReadToEnd().Trim(new char[] {'\n', '\r', '\t', ' '});

                if (text[0] != '[')
                    throw new Exception("Error on beginning JSON file format!");
                if (text[text.Length - 1] != ']')
                    throw new Exception("Error on ending JSON file format!");

                text = text.Trim(new char[] {'[', ']'});

                List<string> blocks = new List<string>();
                for (int i = 0, start = -1; i < text.Length; i++)
                {
                    if (text[i] == '{')
                        start = i;
                    
                    if (text[i] == '}')
                    {
                        if (start == -1)
                            throw new Exception("Error on JSON file format!");
                        char[] block = new char[i - start + 1];
                        text.CopyTo(start, block, 0, i - start + 1);
                        blocks.Add(new string(block));
                        start = -1;
                    }
                }

                return blocks;
            }
            catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Error on reading: " + e.Message);
                return null;
            }
        }

        public List<Group> Read(string filename)
        {
            try
            {
                List<string> blocks = GetReader(filename);
                if (blocks == null)
                    throw new Exception("Error on reading file!");

                List<List<string>> processed = new List<List<string>>();
                for (int i = 0; i < blocks.Count; i++)
                {
                    List<char> blockLine = new List<char>(blocks[i].Trim(new char[] {'{', '\r', '\n', ' '}).ToCharArray());
                    
                    int index = blockLine.FindIndex(x => x == ' ' || x == '\"' || x == '\r' || x == '\n' || x == '{' || x == '}');
                    
                    while (index >= 0)
                    {
                        blockLine.RemoveAt(index);
                        index = blockLine.FindIndex(x => x == ' ' || x == '\"' || x == '\r' || x == '\n' || x == '{' || x == '}');
                    }
                    
                    string s_block = new string(blockLine.ToArray());
                    string[] arr_block = s_block.Split(new char[] {','});
                    
                    if (arr_block.Length != 6)
                        throw new Exception("Error on number of nodes!");
                    processed.Add(new List<string>(arr_block));
                }

                List<Group> result = new List<Group>();
                foreach(List<string> list_str in processed)
                {
                    int index = list_str.FindIndex(x => x.Split(new char[] { ':' })[0] == "Surname");
                    if (index < 0)
                        throw new Exception("Node \"Surname\" does not exist!");
                    string surname = list_str[index].Split(new char[] { ':' })[1];

                    index = list_str.FindIndex(x => x.Split(new char[] { ':' })[0] == "Name");
                    if (index < 0)
                        throw new Exception("Node \"Name\" does not exist!");
                    string name = list_str[index].Split(new char[] { ':' })[1];

                    index = list_str.FindIndex(x => x.Split(new char[] { ':' })[0] == "SecondName");
                    if (index < 0)
                        throw new Exception("Node \"SecondName\" does not exist!!");
                    string midname = list_str[index].Split(new char[] { ':' })[1];

                    index = list_str.FindIndex(x => x.Split(new char[] { ':' })[0] == "Group");
                    if (index < 0)
                        throw new Exception("Node \"Group\" does not exist!!");
                    string iGroup = list_str[index].Split(new char[] { ':' })[1];

                    index = list_str.FindIndex(x => x.Split(new char[] { ':' })[0] == "Role");
                    if (index < 0)
                        throw new Exception("Node \"Role\" does not exist!!");
                    string role = list_str[index].Split(new char[] { ':' })[1];

                    index = list_str.FindIndex(x => x.Split(new char[] { ':' })[0] == "Rating");
                    if (index < 0)
                        throw new Exception("Node \"Rating\" does not exist!!");
                    
                    int rating = Int32.Parse(list_str[index].Split(new char[] { ':' })[1]);
                    
                    Student student = new Student(surname, name, midname, iGroup, role, rating);
                    
                    int j = result.FindIndex(x => x.getIGroup == iGroup);
                    if (j >= 0)
                        result[j].Insert(student);
                    else
                    {
                        result.Add(new Group(student.GroupIndex));
                        j = result.FindIndex(x => x.getIGroup == student.GroupIndex);
                        result[j].Insert(student);
                    }
                }

                return result;
            }
            catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Error on reading JSON format: " + e.Message);
                return null;
            }
        }
    }
}
