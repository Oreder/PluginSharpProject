using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPOGroupTree
{
    interface IReader
    {
        List<Group> Read(string fileName);
    }

    interface IWriter
    {
        void Save(string fileName, List<Group> grp);
    }
}
