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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnOpenConfigs_Click(object sender, EventArgs e)
        {
            using (var frmConfigs = new FrmConfigurations())
            {
                frmConfigs.ShowDialog();
            }
        }
    }
}
