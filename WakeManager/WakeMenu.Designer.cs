namespace WakeManager
{
    partial class WakeMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WakeMenu));
            this.listDevices = new System.Windows.Forms.ListBox();
            this.buttonDisable = new System.Windows.Forms.Button();
            this.buttonSelectAll = new System.Windows.Forms.Button();
            this.lblDeviceTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listDevices
            // 
            this.listDevices.FormattingEnabled = true;
            this.listDevices.Location = new System.Drawing.Point(12, 25);
            this.listDevices.Name = "listDevices";
            this.listDevices.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listDevices.Size = new System.Drawing.Size(423, 238);
            this.listDevices.TabIndex = 0;
            // 
            // buttonDisable
            // 
            this.buttonDisable.Location = new System.Drawing.Point(335, 271);
            this.buttonDisable.Name = "buttonDisable";
            this.buttonDisable.Size = new System.Drawing.Size(100, 23);
            this.buttonDisable.TabIndex = 1;
            this.buttonDisable.Text = "Disable Selected";
            this.buttonDisable.UseVisualStyleBackColor = true;
            this.buttonDisable.Click += new System.EventHandler(this.buttonDisable_Click);
            // 
            // buttonSelectAll
            // 
            this.buttonSelectAll.Location = new System.Drawing.Point(254, 271);
            this.buttonSelectAll.Name = "buttonSelectAll";
            this.buttonSelectAll.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectAll.TabIndex = 2;
            this.buttonSelectAll.Text = "Select All";
            this.buttonSelectAll.UseVisualStyleBackColor = true;
            this.buttonSelectAll.Click += new System.EventHandler(this.buttonSelectAll_Click);
            // 
            // lblDeviceTitle
            // 
            this.lblDeviceTitle.AutoSize = true;
            this.lblDeviceTitle.Location = new System.Drawing.Point(12, 9);
            this.lblDeviceTitle.Name = "lblDeviceTitle";
            this.lblDeviceTitle.Size = new System.Drawing.Size(201, 13);
            this.lblDeviceTitle.TabIndex = 3;
            this.lblDeviceTitle.Text = "Devices enabled to wake your computer:";
            // 
            // WakeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 300);
            this.Controls.Add(this.lblDeviceTitle);
            this.Controls.Add(this.buttonSelectAll);
            this.Controls.Add(this.buttonDisable);
            this.Controls.Add(this.listDevices);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WakeMenu";
            this.Text = "Wake Manager";
            this.Load += new System.EventHandler(this.WakeMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listDevices;
        private System.Windows.Forms.Button buttonDisable;
        private System.Windows.Forms.Button buttonSelectAll;
        private System.Windows.Forms.Label lblDeviceTitle;
    }
}

