using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMXandArd.Models
{
    class SHOWconfig
    {
        public string project_file {  get; set; }

    }
    public class showEvents
    {
        public showEvents()
        {
            startTriggers = new List<showTriggers>();
            endTriggers = new List<showTriggers>();
            scenes = new List<showScenes>();
            sounds =new List<showSounds>();
            listModules = new List<modulesDef>();
            listModules.Add(new modulesDef { name = "Start Triggers", tag = "startTriggers" });
            listModules.Add(new modulesDef { name = "End Triggers", tag = "endTriggers" });
            listModules.Add(new modulesDef { name = "Sounds", tag = "sounds" });
            listModules.Add(new modulesDef { name = "Scenes", tag = "scenes" });
            listModules.Add(new modulesDef { name = "Next Scene", tag = "nextScene" });
        }
        public int ID { get; set; }
        public string name { get; set; }
        public List<showTriggers> startTriggers { get; set; }
        public List<showTriggers> endTriggers { get; set; }
        public List<showSounds> sounds { get; set; }
        public List<showScenes> scenes { get; set; }
        public showScenes nextScene { get; set; }
        public TreeNode treeNodeEvents { get; set; }
        public List<modulesDef> listModules {  get; set; }
        public TreeNode createTreeNew(string Name)
        {
            treeNodeEvents=new TreeNode();
            treeNodeEvents.Text=Name;
            name = Name;
            foreach (modulesDef module in listModules)
            {
                TreeNode childNodeBase = new TreeNode();
                childNodeBase.Text=module.name;
                childNodeBase.Tag = module.tag;
                treeNodeEvents.Nodes.Add(childNodeBase);
            }
            return treeNodeEvents;
        }
    }
    public class modulesDef
    {
        public modulesDef() { }
        public string name { get; set; }
        public string tag { get; set; }
    }
    public class showTriggers
    {
        public showTriggers() {
            showInterupt = new List<string>();
        }
        public string name { get; set; }
        public string type { get; set; }
        public string value { get; set; }
        public List<string> showInterupt { get; set; }
    }
    public class showSounds
    {
        public showSounds() { }
        public string Title { get; set; }
        public string FilePath {  get; set; }
        public double soundStart { get; set; }
        public double soundEnd { get; set; }
    }
    public class showScenes
    {
        public showScenes() { }
        public string Title { get; set; }
        public int runTimeMs { get; set; }
    }

}
