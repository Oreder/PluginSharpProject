using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

namespace PPOGroupTree.Plugins
{
    class SettingPlugin
    {
        [ImportMany(typeof(ISettingPlugin))]
        private ISettingPlugin[] Plugins;

        private TreeView Tree;
        private ContextMenuStrip rMenu; 
        private ContextMenuStrip gMenu;
        private ContextMenuStrip sMenu;

        public SettingPlugin(TreeView tree, ContextMenuStrip root, ContextMenuStrip group, ContextMenuStrip student)
        {
            this.Tree = tree;
            this.rMenu = root;
            this.gMenu = group;
            this.sMenu = student;

            //var catalog = new DirectoryCatalog(Environment.CurrentDirectory);
            //var container = new CompositionContainer(catalog);
            //container.ComposeParts(this);
        }

        public List<string> Load()
        {
            var result = new List<string>();
            var pe = getSettingPluginEvent;

            for (int i = 0; i < pe.Count; i++)
            {
                var rItem = new ToolStripMenuItem();
                var gItem = new ToolStripMenuItem();
                var sItem = new ToolStripMenuItem();

                rItem.Name = gItem.Name = sItem.Name = pe[i].Key.Name;
                rItem.Text = gItem.Text = sItem.Text = pe[i].Key.Name;

                rItem.Tag = PLUGIN_CONTENT_TYPE.Root;
                gItem.Tag = PLUGIN_CONTENT_TYPE.Group;
                sItem.Tag = PLUGIN_CONTENT_TYPE.Student;

                rItem.Click += pe[i].Value;
                gItem.Click += pe[i].Value;
                sItem.Click += pe[i].Value;

                switch (pe[i].Key.Content)
                {
                    case PLUGIN_CONTENT_TYPE.Root : this.rMenu.Items.Add(rItem); break;
                    case PLUGIN_CONTENT_TYPE.Group: this.gMenu.Items.Add(gItem); break;
                    case PLUGIN_CONTENT_TYPE.Student: this.sMenu.Items.Add(sItem); break;

                    case PLUGIN_CONTENT_TYPE.RootGroup: 
                        this.rMenu.Items.Add(rItem);
                        this.gMenu.Items.Add(gItem);
                        break;

                    case PLUGIN_CONTENT_TYPE.RootStudent:
                        this.rMenu.Items.Add(rItem);
                        this.sMenu.Items.Add(sItem);
                        break;

                    case PLUGIN_CONTENT_TYPE.GroupStudent:
                        this.gMenu.Items.Add(gItem);
                        this.sMenu.Items.Add(sItem);
                        break;

                    case PLUGIN_CONTENT_TYPE.RootGroupStudent:
                        this.rMenu.Items.Add(rItem);
                        this.gMenu.Items.Add(gItem);
                        this.sMenu.Items.Add(sItem);
                        break;
                }

                result.Add(pe[i].Key.Name);
            }

            return result;
        }
        
        private List<KeyValuePair<PluginInfor, EventHandler>> getSettingPluginEvent
        {
            get
            {
                //var result = new List<KeyValuePair<PluginInfor, EventHandler>>();

                //for (int i = 0; i < this.Plugins.Length; i++)
                //{
                //    var tmp = new LocalEventHandler(this.Plugins[i]);
                //    var handler = tmp.GetHandler;
                    
                //    result.Add(new KeyValuePair<PluginInfor, EventHandler>(this.Plugins[i].PluginInfo, handler));
                //}
                
                //return result;
                return null;
            }
        }
    }
}
