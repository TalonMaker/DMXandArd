using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TestDmx2.Models
{
    class DMXFixtures
    {
        public DMXFixtures() {
            DMXfixtureList = new List<DMXfixture>();
            //32 fixtures
            for (int i = 0; i < 32; i++) { 
            DMXfixtureList.Add(new DMXfixture());
            }

        }
        public DMXFixtures ShallowCopy()
        {
            return (DMXFixtures)this.MemberwiseClone();
        }
        public List<DMXfixture> DMXfixtureList {  get; set; }
        public DMXFixtures DeepCopy()
        {
            DMXFixtures other = (DMXFixtures)this.MemberwiseClone();
            other.DMXfixtureList = other.DMXfixtureList.GetRange(0, other.DMXfixtureList.Count);
            return other;
        }
    }
    class DMXfixture
    {
        public DMXfixture() {
            Channels = new List<int>();
            //Channels each fixture
            for (int i = 0; i < 16; i++)
            {
                Channels.Add(0);
            }
            fixture_enabled = false;
            isIndividual = false;
        }
        public DMXfixture ShallowCopy()
        {
            return (DMXfixture)this.MemberwiseClone();
        }
        public List<int> Channels { get; set; }
        public Boolean fixture_enabled { get; set; }
        public Boolean isIndividual { get; set; }
    }
    
    class ArdDataList
    {
        public ArdDataList()
        {
            PortNumber = "";
            IO = "";
            Triggered = "";
        }
        public string PortNumber { get; set; }
        public string IO { get; set; }
        public string Triggered { get; set; }
    }
    class MusicDataList
    {
        public MusicDataList()
        {
            Name = "";
            Owner = "";
            Title = "";
            Rating = "";
            Path = "";
        }
        public string Name { get; set; }
        public string Owner { get; set; }
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Path {  get; set; }
    }
    class DMXARDproject
    {
        public DMXARDproject()
        {
            Scenes = new Dictionary<string, DMXFixtures>();
            Scenes.Add("(AutoSaveScene)", new DMXFixtures());
            ArdDevicePort = "";
            DmxDevicePort = "";
            MusicData = new DataTable();
            MusicData.TableName = "MusicConfig";
            MusicData.Columns.Add(new DataColumn("Name"));
            MusicData.Columns.Add(new DataColumn("Owner"));
            MusicData.Columns.Add(new DataColumn("Title"));
            MusicData.Columns.Add(new DataColumn("Rating"));
            MusicData.Columns.Add(new DataColumn("Path"));
            ArdData = new DataTable();
            ArdData.TableName = "Config";
            ArdData.Columns.Add(new DataColumn("PortNumber"));
            ArdData.Columns.Add(new DataColumn("IO"));
            ArdData.Columns.Add(new DataColumn("Triggered"));
        }
        public DMXARDproject ShallowCopy()
        {
            return (DMXARDproject)this.MemberwiseClone();
        }
        public void setArdTable(DataTable table)
        {
            listArd = new List<ArdDataList>();
            foreach (DataRow row in table.Rows)
            {
                listArd.Add( new ArdDataList()
                {
                    PortNumber=row[0].ToString(),
                    IO=row[1].ToString(),
                    Triggered=row[2].ToString(),
                });
            }
            ArdData = table;
        }
        public void setMusicTable(DataTable table)
        {
            listMusic = new List<MusicDataList>();
            foreach (DataRow row in table.Rows)
            {
                listMusic.Add(new MusicDataList()
                {
                    Name = row[0].ToString(),
                    Owner = row[1].ToString(),
                    Title = row[2].ToString(),
                    Rating = row[3].ToString(),
                    Path = row[4].ToString(),
                });
            }
            MusicData = table;
        }
        public DataTable getMusicData()
        {
            return MusicData;
        }
        public DataTable getArdData()
        {
            return ArdData;
        }
        public void refreshMusicTableData()
        {
            MusicData=new DataTable();
            MusicData.TableName = "MusicConfig";
            MusicData.Columns.Add(new DataColumn("Name"));
            MusicData.Columns.Add(new DataColumn("Owner"));
            MusicData.Columns.Add(new DataColumn("Title"));
            MusicData.Columns.Add(new DataColumn("Rating"));
            MusicData.Columns.Add(new DataColumn("Path"));
            foreach(MusicDataList items in  listMusic)
            {
                DataRow newRow= MusicData.NewRow();
                newRow[0] = items.Name;
                newRow[1] = items.Owner;
                newRow[2] = items.Title;
                newRow[3] = items.Rating;
                newRow[4] = items.Path;
                MusicData.Rows.Add(newRow);
                MusicData.AcceptChanges();
            }

        }
        public void refreshArdTableData()
        { 
            ArdData=new DataTable();
            ArdData.TableName = "Config";
            ArdData.Columns.Add(new DataColumn("PortNumber"));
            ArdData.Columns.Add(new DataColumn("IO"));
            ArdData.Columns.Add(new DataColumn("Triggered"));
            foreach (ArdDataList items in listArd)
            {
                DataRow newRow=ArdData.NewRow();
                newRow[0]=items.PortNumber;
                newRow[1] = items.IO;
                newRow[2] = items.Triggered;
                ArdData.Rows.Add(newRow);
                ArdData.AcceptChanges();
            }
        }
        public Dictionary<String, DMXFixtures> Scenes { get; set; }
        public string ArdDevicePort { get; set; }
        public string DmxDevicePort { get; set; }
        public string ArdConfigPins { get; set; }
        private DataTable MusicData { get; set; }
        private DataTable ArdData { get; set; }
        public List<ArdDataList> listArd { get; set; }
        public List<MusicDataList> listMusic { get;  set; }
        
    }
}
