using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppConfiguration
{
    public partial class FrmConfigurations : Form
    {
        private Configuration Configuration { get; set; }

        public FrmConfigurations()
        {
            InitializeComponent();
        }

        private void FrmConfigurations_Load(object sender, EventArgs e)
        {
            LoadThemes();
            LoadConfigs();
        }

        public void LoadThemes()
        {
            CbTheme.DataSource = new object[]
            {
                new {label = "Theme 1", value = 0},
                new {label = "Theme 2", value = 1},
                new {label = "Theme 3", value = 2},
            }.ToList();
        }

        public void LoadConfigs()
        {
            Configuration = ConfigService.Load();

            TxtDevice.Text = this.Configuration.Device;
            TxtSystem.Text = this.Configuration.System;
            TxtVersion.Text = this.Configuration.Version;
            CbTheme.SelectedIndex = this.Configuration.Theme;
            TxtPathDownloads.Text = this.Configuration.PathDownloads;
            CkRememberPassword.Checked = this.Configuration.RememberPassword;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            this.Configuration.Device = TxtDevice.Text;
            this.Configuration.System = TxtSystem.Text;
            this.Configuration.Version = TxtVersion.Text;
            this.Configuration.Theme = (int)CbTheme.SelectedValue;
            this.Configuration.PathDownloads = TxtPathDownloads.Text;
            this.Configuration.RememberPassword = CkRememberPassword.Checked;

            ConfigService.Save(this.Configuration);
            MessageBox.Show("Configurations Salved!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void BtnSelectPathDownloads_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                dialog.ShowDialog();
                TxtPathDownloads.Text = string.IsNullOrEmpty(dialog.SelectedPath)
                    ? Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) : dialog.SelectedPath;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
