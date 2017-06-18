using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPOGroupTree.Plugins
{
    public interface IPlugin
    {
        PluginInfor PluginInfo { get; }
        object Run(object arg);
    }

    public interface ISettingPlugin
    {
        TreeView Tree { get; }
        PluginInfor PluginInfo { get; }
        object Run(object arg);
    }

    public enum PLUGIN_TYPEOUT { Message, File };
    public enum PLUGIN_CONTENT_TYPE { Root, Group, Student, RootGroup, RootStudent, GroupStudent, RootGroupStudent };
    
    public delegate object WorkingPlugin(object sender);

    public struct PluginInfor
    {
        public PLUGIN_TYPEOUT Type;
        public PLUGIN_CONTENT_TYPE Content;
        public string Name;
        public string Text;
    }
}