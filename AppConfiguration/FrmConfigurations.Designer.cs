
namespace AppConfiguration
{
    partial class FrmConfigurations
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
            this.GpConfigs = new System.Windows.Forms.GroupBox();
            this.LblDevice = new System.Windows.Forms.Label();
            this.TxtDevice = new System.Windows.Forms.TextBox();
            this.LblSystem = new System.Windows.Forms.Label();
            this.TxtSystem = new System.Windows.Forms.TextBox();
            this.LblVersion = new System.Windows.Forms.Label();
            this.TxtVersion = new System.Windows.Forms.TextBox();
            this.LblTheme = new System.Windows.Forms.Label();
            this.CbTheme = new System.Windows.Forms.ComboBox();
            this.GpPreferences = new System.Windows.Forms.GroupBox();
            this.TxtPathDownloads = new System.Windows.Forms.TextBox();
            this.LblDownloads = new System.Windows.Forms.Label();
            this.BtnSelectPathDownloads = new System.Windows.Forms.Button();
            this.CkRememberPassword = new System.Windows.Forms.CheckBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.GpConfigs.SuspendLayout();
            this.GpPreferences.SuspendLayout();
            this.SuspendLayout();
            // 
            // GpConfigs
            // 
            this.GpConfigs.Controls.Add(this.CbTheme);
            this.GpConfigs.Controls.Add(this.LblTheme);
            this.GpConfigs.Controls.Add(this.TxtVersion);
            this.GpConfigs.Controls.Add(this.LblVersion);
            this.GpConfigs.Controls.Add(this.TxtSystem);
            this.GpConfigs.Controls.Add(this.LblSystem);
            this.GpConfigs.Controls.Add(this.TxtDevice);
            this.GpConfigs.Controls.Add(this.LblDevice);
            this.GpConfigs.Location = new System.Drawing.Point(12, 12);
            this.GpConfigs.Name = "GpConfigs";
            this.GpConfigs.Size = new System.Drawing.Size(309, 148);
            this.GpConfigs.TabIndex = 0;
            this.GpConfigs.TabStop = false;
            this.GpConfigs.Text = "Configs";
            // 
            // LblDevice
            // 
            this.LblDevice.AutoSize = true;
            this.LblDevice.Location = new System.Drawing.Point(8, 30);
            this.LblDevice.Name = "LblDevice";
            this.LblDevice.Size = new System.Drawing.Size(41, 13);
            this.LblDevice.TabIndex = 0;
            this.LblDevice.Text = "Device";
            // 
            // TxtDevice
            // 
            this.TxtDevice.Location = new System.Drawing.Point(55, 27);
            this.TxtDevice.Name = "TxtDevice";
            this.TxtDevice.Size = new System.Drawing.Size(248, 20);
            this.TxtDevice.TabIndex = 1;
            // 
            // LblSystem
            // 
            this.LblSystem.AutoSize = true;
            this.LblSystem.Location = new System.Drawing.Point(8, 56);
            this.LblSystem.Name = "LblSystem";
            this.LblSystem.Size = new System.Drawing.Size(41, 13);
            this.LblSystem.TabIndex = 0;
            this.LblSystem.Text = "System";
            // 
            // TxtSystem
            // 
            this.TxtSystem.Location = new System.Drawing.Point(55, 53);
            this.TxtSystem.Name = "TxtSystem";
            this.TxtSystem.Size = new System.Drawing.Size(248, 20);
            this.TxtSystem.TabIndex = 1;
            // 
            // LblVersion
            // 
            this.LblVersion.AutoSize = true;
            this.LblVersion.Location = new System.Drawing.Point(8, 82);
            this.LblVersion.Name = "LblVersion";
            this.LblVersion.Size = new System.Drawing.Size(42, 13);
            this.LblVersion.TabIndex = 0;
            this.LblVersion.Text = "Version";
            // 
            // TxtVersion
            // 
            this.TxtVersion.Location = new System.Drawing.Point(55, 79);
            this.TxtVersion.Name = "TxtVersion";
            this.TxtVersion.Size = new System.Drawing.Size(248, 20);
            this.TxtVersion.TabIndex = 1;
            // 
            // LblTheme
            // 
            this.LblTheme.AutoSize = true;
            this.LblTheme.Location = new System.Drawing.Point(8, 108);
            this.LblTheme.Name = "LblTheme";
            this.LblTheme.Size = new System.Drawing.Size(40, 13);
            this.LblTheme.TabIndex = 0;
            this.LblTheme.Text = "Theme";
            // 
            // CbTheme
            // 
            this.CbTheme.DisplayMember = "label";
            this.CbTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbTheme.FormattingEnabled = true;
            this.CbTheme.Location = new System.Drawing.Point(55, 105);
            this.CbTheme.Name = "CbTheme";
            this.CbTheme.Size = new System.Drawing.Size(248, 21);
            this.CbTheme.TabIndex = 1;
            this.CbTheme.ValueMember = "value";
            // 
            // GpPreferences
            // 
            this.GpPreferences.Controls.Add(this.CkRememberPassword);
            this.GpPreferences.Controls.Add(this.BtnSelectPathDownloads);
            this.GpPreferences.Controls.Add(this.TxtPathDownloads);
            this.GpPreferences.Controls.Add(this.LblDownloads);
            this.GpPreferences.Location = new System.Drawing.Point(12, 166);
            this.GpPreferences.Name = "GpPreferences";
            this.GpPreferences.Size = new System.Drawing.Size(309, 100);
            this.GpPreferences.TabIndex = 2;
            this.GpPreferences.TabStop = false;
            this.GpPreferences.Text = "Preferences";
            // 
            // TxtPathDownloads
            // 
            this.TxtPathDownloads.Location = new System.Drawing.Point(11, 46);
            this.TxtPathDownloads.Name = "TxtPathDownloads";
            this.TxtPathDownloads.ReadOnly = true;
            this.TxtPathDownloads.Size = new System.Drawing.Size(253, 20);
            this.TxtPathDownloads.TabIndex = 1;
            // 
            // LblDownloads
            // 
            this.LblDownloads.AutoSize = true;
            this.LblDownloads.Location = new System.Drawing.Point(8, 30);
            this.LblDownloads.Name = "LblDownloads";
            this.LblDownloads.Size = new System.Drawing.Size(60, 13);
            this.LblDownloads.TabIndex = 0;
            this.LblDownloads.Text = "Downloads";
            // 
            // BtnSelectPathDownloads
            // 
            this.BtnSelectPathDownloads.Location = new System.Drawing.Point(270, 46);
            this.BtnSelectPathDownloads.Name = "BtnSelectPathDownloads";
            this.BtnSelectPathDownloads.Size = new System.Drawing.Size(33, 20);
            this.BtnSelectPathDownloads.TabIndex = 2;
            this.BtnSelectPathDownloads.Text = "...";
            this.BtnSelectPathDownloads.UseVisualStyleBackColor = true;
            this.BtnSelectPathDownloads.Click += new System.EventHandler(this.BtnSelectPathDownloads_Click);
            // 
            // CkRememberPassword
            // 
            this.CkRememberPassword.AutoSize = true;
            this.CkRememberPassword.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CkRememberPassword.Location = new System.Drawing.Point(11, 77);
            this.CkRememberPassword.Name = "CkRememberPassword";
            this.CkRememberPassword.Size = new System.Drawing.Size(126, 17);
            this.CkRememberPassword.TabIndex = 3;
            this.CkRememberPassword.Text = "Remember Password";
            this.CkRememberPassword.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(165, 272);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 3;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(246, 272);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 3;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // FrmConfigurations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 304);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.GpPreferences);
            this.Controls.Add(this.GpConfigs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmConfigurations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurations";
            this.Load += new System.EventHandler(this.FrmConfigurations_Load);
            this.GpConfigs.ResumeLayout(false);
            this.GpConfigs.PerformLayout();
            this.GpPreferences.ResumeLayout(false);
            this.GpPreferences.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GpConfigs;
        private System.Windows.Forms.ComboBox CbTheme;
        private System.Windows.Forms.Label LblTheme;
        private System.Windows.Forms.TextBox TxtVersion;
        private System.Windows.Forms.Label LblVersion;
        private System.Windows.Forms.TextBox TxtSystem;
        private System.Windows.Forms.Label LblSystem;
        private System.Windows.Forms.TextBox TxtDevice;
        private System.Windows.Forms.Label LblDevice;
        private System.Windows.Forms.GroupBox GpPreferences;
        private System.Windows.Forms.CheckBox CkRememberPassword;
        private System.Windows.Forms.Button BtnSelectPathDownloads;
        private System.Windows.Forms.TextBox TxtPathDownloads;
        private System.Windows.Forms.Label LblDownloads;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
    }
}