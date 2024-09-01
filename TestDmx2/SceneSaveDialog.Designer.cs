namespace TestDmx2
{
    public partial class SceneSaveDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonSave = new System.Windows.Forms.Button();
            buttonCancel = new System.Windows.Forms.Button();
            SceneName = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.Enabled = false;
            buttonSave.Location = new System.Drawing.Point(76, 80);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new System.Drawing.Size(75, 23);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new System.Drawing.Point(225, 80);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new System.Drawing.Size(75, 23);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // SceneName
            // 
            SceneName.Location = new System.Drawing.Point(35, 37);
            SceneName.Name = "SceneName";
            SceneName.PlaceholderText = "Please Enter Scene Name";
            SceneName.Size = new System.Drawing.Size(340, 23);
            SceneName.TabIndex = 2;
            SceneName.TextChanged += SceneName_TextChanged;
            // 
            // SceneSaveDialog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(412, 125);
            Controls.Add(SceneName);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SceneSaveDialog";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "SceneSaveDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox SceneName;
    }
}