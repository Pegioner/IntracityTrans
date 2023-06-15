using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IntracityTrans
{
    public partial class FormUpdateTransportType : Form
    {
        public FormUpdateTransportType()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        SqlConnection con = DBSqlInfo.GetDBConnection();

        private void FormAddTransport_Load(object sender, EventArgs e)
        {
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string ID = txtID.Text;
                string q = "UPDATE TransportType SET TT_Name= '" + txtTT_Name.Text + "'WHERE ID_Type= " + ID;
                SqlCommand command2 = new SqlCommand(q, con);
                command2.ExecuteNonQuery();
                Alert.EditSuccess();
            }
            catch (Exception er) { Alert.Error(er); }
            finally { if (con.State == ConnectionState.Open) con.Close(); }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            txtTT_Name.Text = "";
        }
    }
}
