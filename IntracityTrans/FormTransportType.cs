using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IntracityTrans
{
    public partial class FormTransportType : Form
    {
        public FormTransportType()
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

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RefreshDB()
        {
            Table.Clear();
            Adapter.Fill(Table);
            dgvTransportType.DataSource = Table.DefaultView;
            //dgvTransportType.Columns[0].Visible = false;
        }

        SqlConnection con = DBSqlInfo.GetDBConnection();
        DataTable Table = new DataTable();
        SqlDataAdapter Adapter;
        private void FormTransportType_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string q = "SELECT * FROM TransportType";
                SqlCommand command = new SqlCommand(q, con);
                Adapter = new SqlDataAdapter(command);
                Adapter.Fill(Table);
                dgvTransportType.DataSource = Table.DefaultView;
                dgvTransportType.Columns[0].HeaderCell.ToolTipText = "Уникальный идентификационный номер типа транспорта";
                dgvTransportType.Columns[1].HeaderCell.ToolTipText = "Тип транспорта";
                //dgvTransports.Columns[0].Visible = false;
            }
            catch (Exception er) { Alert.Error(er); }
            finally { if (con.State == ConnectionState.Open) con.Close(); }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddTransportType frm = new FormAddTransportType();
            frm.Closing += (senderf, ef) =>
            {
                try
                {
                    con.Open();
                    RefreshDB();
                }
                catch (Exception er) { Alert.Error(er); }
                finally { if (con.State == ConnectionState.Open) con.Close(); }
            };
            frm.ShowDialog();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvTransportType.SelectedRows.Count == 1 )
            {
                try
                {
                    con.Open();
                    string Id = dgvTransportType.CurrentRow.Cells[0].Value.ToString();
                    string q = "DELETE FROM TransportType WHERE ID_Type= " + Id;
                    SqlCommand command2 = new SqlCommand(q, con);
                    command2.ExecuteNonQuery();
                    RefreshDB();
                    Alert.DelSuccess();
                }
                catch (Exception er) { Alert.Error(er); }
                finally { if (con.State == ConnectionState.Open) con.Close(); }
            }
            else
                Alert.DelInfo();
            
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            FormUpdateTransportType frm = new FormUpdateTransportType();

            if (dgvTransportType.SelectedRows.Count == 1)
            {
                frm.txtID.Text = dgvTransportType.CurrentRow.Cells[0].Value.ToString();
                frm.txtTT_Name.Text = dgvTransportType.CurrentRow.Cells[1].Value.ToString();

                frm.Closing += (senderf, ef) =>
                {
                    try
                    {
                        con.Open();
                        RefreshDB();
                    }
                    catch (Exception er) { Alert.Error(er); }
                    finally { if (con.State == ConnectionState.Open) con.Close(); }
                };
                frm.ShowDialog();

            }
            else
                Alert.EditInfo();
        

            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                RefreshDB();
                Alert.DataRefresh();
            }
            catch (Exception er) { Alert.Error(er); }
            finally { if (con.State == ConnectionState.Open) con.Close(); }
        }
    }
}
