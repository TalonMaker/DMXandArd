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
            listModules.Add(new modulesDef { name = "Next Event", tag = "nextEvent" });
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
        public void addEventToTreeNode(string nodeID, string value)
        {
            //int indexNode = treeNodeEvents.Nodes[name].Nodes.IndexOfKey(nodeID);
            //if(indexNode >= 0)
            //{
                TreeNode tempNode= new TreeNode();
                tempNode.Tag = value;
                tempNode.Text = value;
                tempNode.Name=value;
            TreeNode test = treeNodeEvents;
                //Console.WriteLine(treeNodeEvents, tempNode);
                treeNodeEvents.Nodes[nodeID].Nodes.Add(tempNode);
            //}
        }
        public void removeEventToTreeNode(string nodeID, string value)
        {
            int indexNode = treeNodeEvents.Nodes.IndexOfKey(nodeID);
            if (indexNode >= 0)
            {
                TreeNode tempNode = new TreeNode();
                tempNode.Tag = value;
                tempNode.Text = value;
                tempNode.Name=value;
                treeNodeEvents.Nodes[indexNode].Nodes.Remove(tempNode);
            }
        }
        public TreeNode createTreeNew(string Name)
        {
            treeNodeEvents=new TreeNode();
            treeNodeEvents.Text=Name;
            treeNodeEvents.Name=Name;
            name = Name;
            foreach (modulesDef module in listModules)
            {
                TreeNode childNodeBase = new TreeNode();
                childNodeBase.Text=module.name;
                childNodeBase.Tag = module.tag;
                childNodeBase.Name=module.name;
               
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
