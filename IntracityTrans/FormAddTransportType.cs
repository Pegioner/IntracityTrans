using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IntracityTrans
{
    public partial class FormAddTransportType : Form
    {
        public FormAddTransportType()
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

        private void FormAddTransport_Load(object sender, EventArgs e)
        {

        }

        SqlConnection con = DBSqlInfo.GetDBConnection();
        DataTable Table = new DataTable();
        SqlDataAdapter Adapter;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string q = "SELECT * FROM TransportType";
                SqlCommand command = new SqlCommand(q, con);
                Adapter = new SqlDataAdapter(command);
                Adapter.Fill(Table);
                string q1 = "INSERT INTO TransportType (TT_Name) VALUES ( '" + txtTT_Name.Text + "' )";
                SqlCommand command1 = new SqlCommand(q1, con);
                command1.ExecuteNonQuery();
                Alert.AddSuccess();
            }
            catch (Exception er) { Alert.Error(er); }
            finally { if (con.State == ConnectionState.Open) con.Close(); }
        }
    }
}
