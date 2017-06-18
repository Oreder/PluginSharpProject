using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PPOGroupTree.Plugins
{
    class LocalEventHandler
    {
        private WorkingPlugin PWork = null;
        private PluginInfor PInfor;
        private TreeView Tree;

        public LocalEventHandler(IPlugin plugin, TreeView tree)
        {
            this.PWork = plugin.Run;
            this.PInfor = plugin.PluginInfo;
            this.Tree = tree;
        }

        //public LocalEventHandler(ISettingPlugin plugin)
        //{
        //    this.PWork = plugin.Run;
        //    this.PInfor = plugin.PluginInfo;
        //    this.Tree = plugin.Tree;
        //}

        public EventHandler GetHandler { get { return EventHandlerMethod; } }

        private void EventHandlerMethod(object sender, EventArgs e)
        {
            try
            {
                PLUGIN_CONTENT_TYPE TagType = (PLUGIN_CONTENT_TYPE)((ToolStripMenuItem)sender).Tag;

                GroupStructure gs = GroupStructure.Instance;
                object _instance;

                switch (TagType)
                {
                    case PLUGIN_CONTENT_TYPE.Root:
                        _instance = this.PWork.Invoke(gs);
                        break;
                    
                    case PLUGIN_CONTENT_TYPE.Group:
                        _instance = this.PWork.Invoke(gs[this.Tree.SelectedNode.Text]);
                        break;
                    
                    case PLUGIN_CONTENT_TYPE.Student:
                        _instance = this.PWork.Invoke(gs[this.Tree.SelectedNode.Parent.Text][this.Tree.SelectedNode.Index]);
                        break;
                    
                    default:
                        throw new Exception("Unknown Plugin Instance");
                }

                switch (this.PInfor.Type)
                {
                    case PLUGIN_TYPEOUT.Message:
                        MessageBox.Show(_instance.ToString(), this.PInfor.Text);
                        break;
                    case PLUGIN_TYPEOUT.File:
                        string fileName = this.PInfor.Name + "_" + DateTime.Now.Hour.ToString() + "-" +
                                                                   DateTime.Now.Minute.ToString() + "-" +
                                                                   DateTime.Now.Second.ToString() + ".txt";

                        var sw = new StreamWriter(fileName);
                        sw.Write(_instance.ToString());
                        sw.Close();

                        MessageBox.Show("Written into file '" + fileName + ".txt'", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error on working plugin: " + ex.Message, this.PInfor.Text);
            }
        }
    }
}
