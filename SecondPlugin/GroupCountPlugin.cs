using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
using PPOGroupTree;
using PPOGroupTree.Plugins;

namespace SecondPlugin
{
    /// <summary>
    /// Count the number of students in list
    /// </summary>
    [Export(typeof(IPlugin))]
    public class GroupCountPlugin : IPlugin
    {
        private PluginInfor _plugin;

        public PluginInfor PluginInfo
        {
            get { return _plugin; }
        }

        public object Run(object arg)
        {
            string total = "Empty Group!";
            Group group = new Group("Example");
            GroupStructure tree;

            try
            {
                // Find total student of given group
                group = (Group)arg;
                int count = group.StudentsCount;

                if (count > 0)
                    total = count.ToString();
            }
            catch (Exception)
            {
                // Find total students of all groups
                tree = GroupStructure.Instance;

                if (tree.Groups.Count > 0)
                {
                    int count = 0;

                    for (int i = 0; i < tree.Groups.Count; i++)
                        for (int j = 0; j < tree.Groups[i].StudentsCount; j++)
                            count++;

                    total = count.ToString();
                }
            }
                
            return total;
        }

        public GroupCountPlugin()
        {
            this._plugin.Name = "Show Total Students";
            this._plugin.Text = "Count the number of student";
            this._plugin.Type = PLUGIN_TYPEOUT.Message;
            this._plugin.Content = PLUGIN_CONTENT_TYPE.RootGroup;
        }
    }
}
