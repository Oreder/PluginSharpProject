using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
using System.Windows.Forms;
using System.Drawing;
using PPOGroupTree;
using PPOGroupTree.Plugins;

namespace ThirdPlugin
{
    /// <summary>
    /// Change color of interfaces      (NEED EDIT!)
    /// </summary>
    [Export(typeof(IPlugin))]
    public class ColorInterfacePlugin : IPlugin
    {
        private PluginInfor _plugin;
        
        public PluginInfor PluginInfo
        {
            get { return _plugin; }
        }

        public object Run(object arg)
        {
            var color = new ColorDialog();
            color.ShowDialog();
            //MainForm.ActiveForm.BackColor = color.Color;

            return "BackColor: " + color.Color.ToString();
        }

        public ColorInterfacePlugin(TreeView tree)
        {
            this._plugin.Name = "Change color";
            this._plugin.Text = "Change color of current selected items";
            this._plugin.Type = PLUGIN_TYPEOUT.Message;
            this._plugin.Content = PLUGIN_CONTENT_TYPE.RootGroupStudent;
        }
    }
}
