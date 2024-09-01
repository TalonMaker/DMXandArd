using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestDmx2.Models;

namespace TestDmx2
{
    public partial class ConfirmDialog : Form
    {
        public ConfirmDialog()
        {
            InitializeComponent();
            //this one will display Error Message with ok
            this.MessageLabel.Text = "No Scene Selected";
            this.Text = "No Scene Selected";
            CancelButton.Text = "Close";
            this.Okbutton.Visible = false;
        }
        public ConfirmDialog(String Message)
        {
            InitializeComponent();
            this.MessageLabel.Text = Message;
            this.Text = Message;
            CancelButton.Text = "Close";
        }

        private void Okbutton_Click(object sender, EventArgs e)
        {
            //do something with data
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
