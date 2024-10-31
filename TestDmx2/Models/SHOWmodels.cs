using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.WindowsAPICodePack.Shell.PropertySystem.SystemProperties.System;

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
            interuptsEvents = new List<showScenes>();
            listModules.Add(new modulesDef { name = "Start Triggers", tag = "startTriggers" });
            listModules.Add(new modulesDef { name = "End Triggers", tag = "endTriggers" });
            listModules.Add(new modulesDef { name = "Sounds", tag = "sounds" });
            listModules.Add(new modulesDef { name = "Scenes", tag = "scenes" });
            listModules.Add(new modulesDef { name = "Next Event", tag = "nextEvent" });
            listModules.Add(new modulesDef { name = "Interupts Event if running", tag = "interuptsEvent" });
            simpleNode = new Dictionary<string, Dictionary<string, List<string>>>();
        }
        public int ID { get; set; }
        public string name { get; set; }
        public List<showTriggers> startTriggers { get; set; }
        public List<showTriggers> endTriggers { get; set; }
        public List<showSounds> sounds { get; set; }
        public List<showScenes> scenes { get; set; }
        public showScenes nextEvent { get; set; }
        public List<showScenes> interuptsEvents { get; set; }
        public List<modulesDef> listModules { get; set; }
        public Dictionary<string, Dictionary<string, List<string>>> simpleNode { get; set; }
        [JsonIgnore]
        public TreeNode treeNodeEvents { get; set; }
        public void addEventToTreeNode(string nodeID, string value)
        {
            simpleNode[name][nodeID].Add(value);
            TreeNode tempNode= new TreeNode();
                tempNode.Tag = value;
                tempNode.Text = value;
                tempNode.Name=value;
                treeNodeEvents.Nodes[nodeID].Nodes.Add(tempNode);
        }
        public void setRunning(bool Running)
        {
            if (Running)
            {
                treeNodeEvents.BackColor = Color.DarkGreen;
            }
            else
            {
                treeNodeEvents.BackColor= Color.White;
            }
        }
        public void removeEventToTreeNode(string nodeID, string value)
        {
            simpleNode[nodeID].Remove(value);
            
                TreeNode tempNode = new TreeNode();
                tempNode.Tag = value;
                tempNode.Text = value;
                tempNode.Name=value;
                treeNodeEvents.Nodes[nodeID].Nodes.Remove(tempNode);
        }
        public TreeNode createTreeNew(string Name)
        {
            treeNodeEvents=new TreeNode();
            treeNodeEvents.Text=Name;
            treeNodeEvents.Name=Name;
            simpleNode.Add(Name, new Dictionary<string, List<string>>());
            name = Name;
            foreach (modulesDef module in listModules)
            {
                
                simpleNode[Name].Add(module.name,new List<string>());
                TreeNode childNodeBase = new TreeNode();
                childNodeBase.Text=module.name;
                childNodeBase.Tag = module.tag;
                childNodeBase.Name=module.name;
               
                treeNodeEvents.Nodes.Add(childNodeBase);
            }
            return treeNodeEvents;
        }
        public TreeNode createTreeNewNoDict(string Name)
        {
            treeNodeEvents = new TreeNode();
            treeNodeEvents.Text = Name;
            treeNodeEvents.Name = Name;

            name = Name;
            foreach (modulesDef module in listModules)
            {
                TreeNode childNodeBase = new TreeNode();
                childNodeBase.Text = module.name;
                childNodeBase.Tag = module.tag;
                childNodeBase.Name = module.name;
                treeNodeEvents.Nodes.Add(childNodeBase);
            }
            return treeNodeEvents;
        }
        public void rebuildTreeNodes()
        {
            foreach(KeyValuePair<string,Dictionary<string,List<string>>> treeStuff in simpleNode)
            {
                    foreach (KeyValuePair<string,List<string>> KVPchild in treeStuff.Value)
                    {
                        foreach (string Values in KVPchild.Value)
                        {
                            TreeNode tempNode = new TreeNode();
                            tempNode.Tag = Values;
                            tempNode.Text = Values;
                            tempNode.Name = Values;
                            treeNodeEvents.Nodes[KVPchild.Key].Nodes.Add(tempNode);
                        }
                    }
                }
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
