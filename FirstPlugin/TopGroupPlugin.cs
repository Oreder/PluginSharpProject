using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
using PPOGroupTree;
using PPOGroupTree.Plugins;

namespace FirstPlugin
{
    /// <summary>
    /// Find student with the best rating in group
    /// </summary>
    [Export(typeof(IPlugin))]
    public class TopGroupPlugin : IPlugin
    {
        private PluginInfor _plugin;

        public PluginInfor PluginInfo
        {
            get { return _plugin; }
        }

        public object Run(object arg)
        {
            string bestRating;
            Group group = new Group("Example");
            GroupStructure tree;

            //try
            //{
            //    // Find bestRating of given group
            //    group = (Group)arg;
            //    if (group.StudentsCount <= 0)
            //        bestRating = "Empty Group!";
            //    else
            //    {
            //        Student leader = group.Students[0];
            //        foreach (var std in group.Students)
            //        {
            //            if (std.Rating > leader.Rating)
            //                leader = std;
            //        }

            //        bestRating = "Full Name: " + leader.Surname + " " + leader.Name + " " + leader.MiddleName + "\n" +
            //                     "Position : " + leader.Role + "\n" +
            //                     "Rating   : " +leader.Rating + "\n";
            //    }

            //    return bestRating;
            //}
            //catch (Exception)
            //{
                // Find bestRating among all of groups
                tree = GroupStructure.Instance;

                if (tree.Groups.Count <= 0)
                    bestRating = "Empty Group!";
                else
                {
                    List<Student> std = tree.Groups[0].Students;
                    for (int i = 1; i < tree.Groups.Count; i++)
                        std.AddRange(tree.Groups[i].Students);

                    Student leader = std[0];
                    foreach (var student in std)
                    {
                        if (student.Rating > leader.Rating)
                            leader = student;
                    }

                    bestRating = "Full Name: " + leader.Surname + " " + leader.Name + " " + leader.MiddleName + "\n" +
                                 "Position : " + leader.Role + "\n" +
                                 "iGroup   : " + leader.GroupIndex + "\n" +
                                 "Rating   : " + leader.Rating + "\n";
                }

                return bestRating;
            //}
        }

        public TopGroupPlugin()
        {
            this._plugin.Name = "Show Top Group";
            this._plugin.Text = "Show the best student of group";
            this._plugin.Type = PLUGIN_TYPEOUT.Message;
            this._plugin.Content = PLUGIN_CONTENT_TYPE.RootGroup;
        }
    }
}
