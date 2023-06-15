using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IntracityTrans
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            cbID.Checked = Properties.Settings.Default.CheckID;
            cbTitle.Checked = Properties.Settings.Default.CheckTitle;
            cbConnect.Checked = Properties.Settings.Default.CheckAutoConnect;
        }


        private void cbID_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.CheckID = cbID.Checked;
            Properties.Settings.Default.Save();
        }

        private void cbTitle_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.CheckTitle = cbTitle.Checked;
            Properties.Settings.Default.Save();
        }

        private void cbConnect_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.CheckAutoConnect = cbConnect.Checked;
            Properties.Settings.Default.Save();
        }
    }
}
