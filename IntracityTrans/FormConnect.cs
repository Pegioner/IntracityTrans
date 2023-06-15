using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection;

namespace IntracityTrans
{
    public partial class FormConnect : Form
    {
        public FormConnect()
        {
            InitializeComponent();
            
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        

        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormConnect_Load(object sender, EventArgs e)
        {
            txtHost.Text = Properties.Settings.Default.Host;
            txtDB.Text = Properties.Settings.Default.DB;
            txtName.Text = Properties.Settings.Default.User;
            txtPass.Text = Properties.Settings.Default.Pass;
            if (Properties.Settings.Default.CheckAutoConnect) Connect();
        }

        public static new LoginResult Show()
        {
            //создадим и покажем экземпляр формы подключения
            FormConnect frm = new FormConnect();
            frm.ShowDialog();

            //сюда попадем только при закрытии формы
            LoginResult ret = frm.LogRes;

            //освободим ресурсы и вернем результат
            frm.Dispose(true);
            return ret;
        }

        public LoginResult LogRes = LoginResult.NotStarted;


        private void Connect()
        {
            Properties.Settings.Default.Host = txtHost.Text;
            Properties.Settings.Default.DB = txtDB.Text;
            Properties.Settings.Default.User = txtName.Text;
            Properties.Settings.Default.Pass = txtPass.Text;
            Properties.Settings.Default.Save();

            try
            {
                //Alert.Message("Началось подключение...", Form_Alert.enmType.Warning);
                //Properties.Settings.Default.Host = txtHost.Text;
                //Properties.Settings.Default.DB = txtDB.Text;
                //Properties.Settings.Default.User = txtName.Text;
                //Properties.Settings.Default.Pass = txtPass.Text;
                //Properties.Settings.Default.Save();
                SqlConnection con = DBSqlInfo.GetDBConnection();
                con.Open();
                LogRes = LoginResult.OK;
                Properties.Settings.Default.CheckConnect = true;
                Properties.Settings.Default.Save();
                if (con.State == ConnectionState.Open) con.Close();
                Close();
                Alert.ConSuccess();
            }
            catch (Exception er)
            {
                Alert.Error(er);
                LogRes = LoginResult.Failed;
                Properties.Settings.Default.CheckConnect = false;
                Properties.Settings.Default.Save();
            }
        }


        private void btnConnect_Click(object sender, EventArgs e)
        {
            Connect();
        }


        public enum LoginResult
        {
            OK,
            Failed,
            NotStarted
        }

        private void pbPass_Click(object sender, EventArgs e)
        {
            if(txtPass.UseSystemPasswordChar)
            {
                txtPass.UseSystemPasswordChar = false;
                pbPass.Image = Properties.Resources.PassChecked;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
                pbPass.Image = Properties.Resources.PassUnchecked;
            }
        }
    }
}
