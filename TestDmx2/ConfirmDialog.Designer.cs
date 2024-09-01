namespace TestDmx2
{
    partial class ConfirmDialog
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
            Okbutton = new System.Windows.Forms.Button();
            CancelButton = new System.Windows.Forms.Button();
            MessageLabel = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // Okbutton
            // 
            Okbutton.Location = new System.Drawing.Point(134, 94);
            Okbutton.Name = "Okbutton";
            Okbutton.Size = new System.Drawing.Size(75, 23);
            Okbutton.TabIndex = 0;
            Okbutton.Text = "Ok";
            Okbutton.UseVisualStyleBackColor = true;
            Okbutton.Click += Okbutton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new System.Drawing.Point(231, 94);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new System.Drawing.Size(75, 23);
            CancelButton.TabIndex = 1;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // MessageLabel
            // 
            MessageLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            MessageLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            MessageLabel.Location = new System.Drawing.Point(12, 9);
            MessageLabel.Name = "MessageLabel";
            MessageLabel.Size = new System.Drawing.Size(456, 73);
            MessageLabel.TabIndex = 2;
            MessageLabel.Text = "Please confirm";
            MessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConfirmDialog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(480, 129);
            Controls.Add(MessageLabel);
            Controls.Add(CancelButton);
            Controls.Add(Okbutton);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ConfirmDialog";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "ConfirmDialog";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button Okbutton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label MessageLabel;
    }
}