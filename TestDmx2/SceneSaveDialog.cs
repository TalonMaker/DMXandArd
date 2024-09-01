using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TestDmx2
{
    public partial class SceneSaveDialog : Form
    {
        public string SceneNameReturn { get; set; }

        public SceneSaveDialog()
        {
            InitializeComponent();
            SceneNameReturn = "";
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            //Add null check On TextBox
            this.DialogResult = DialogResult.OK;
            //this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SceneName_TextChanged(object sender, EventArgs e)
        {
            SceneNameReturn = ((System.Windows.Forms.TextBox)sender).Text;
            if(SceneNameReturn.CompareTo("")!=0)
            {
                buttonSave.Enabled = true;
            }
            else
            {
                buttonSave.Enabled = false;
            }
        }
    }
}
