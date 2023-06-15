using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IntracityTrans
{
    public partial class FormEditTransports : Form
    {
        public FormEditTransports()
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

        SqlConnection con = DBSqlInfo.GetDBConnection();

        private void FormEditTransports_Load(object sender, EventArgs e)
        {
            try
            {
                string q2 = "Select * FROM TransportType";
                DataTable TTTable = new DataTable();
                SqlCommand command2 = new SqlCommand(q2, con);
                SqlDataAdapter TTAdapter = new SqlDataAdapter(command2);
                TTAdapter.Fill(TTTable);
                cbT_Type.DataSource = TTTable;
                cbT_Type.DisplayMember = TTTable.Columns[1].ToString();
                cbT_Type.ValueMember = TTTable.Columns[0].ToString();
            }
            catch (Exception er) { Alert.Error(er); }
            finally { if (con.State == ConnectionState.Open) con.Close(); }

            dateT_Start.Value = DateTime.Now;

            switch (FormTable.editDB)
            {
                case FormTable.EditDB.Add:
                    lblID.Visible = false;
                    cbID.Visible = false;
                    Text = "Добавление транспорта";
                    lblTitle.Text = "Добавление транспорта";
                    btnEdit.Text = "Добавить";
                    break;
                case FormTable.EditDB.Correct:
                    cbID.DataSource = FormTable.Table;
                    cbID.DisplayMember = FormTable.Table.Columns[0].ToString();
                    cbID.ValueMember = FormTable.Table.Columns[0].ToString();
                    cbID.Text = FormTable.T_ID;
                    break;
            }
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var ft = new FormTable();
                int id = cbID.SelectedIndex;
                con.Open();
                switch (FormTable.editDB)
                {
                    case FormTable.EditDB.Add:
                        string qa = "INSERT INTO Transports (T_Name, T_VIN, ID_Type, T_Count, T_Start) VALUES ( '" + txtT_Name.Text + "', '" + txtT_VIN.Text + "', " + cbT_Type.SelectedValue + ", " + txtT_Count.Text + ", '" + dateT_Start.Value.Date.ToString() + "' )";
                        SqlCommand commanda = new SqlCommand(qa, con);
                        commanda.ExecuteNonQuery();
                        Alert.AddSuccess();
                        break;
                    case FormTable.EditDB.Correct:

                        string ID = cbID.Text;
                        string qc = "UPDATE Transports SET T_Name= '" + txtT_Name.Text + "', T_VIN= '" + txtT_VIN.Text + "', ID_Type= " + cbT_Type.SelectedValue + ", T_Count= " + txtT_Count.Text + ", T_Start= '" + dateT_Start.Value.Date.ToString() + "'WHERE ID_Trans= " + ID;
                        SqlCommand commandc = new SqlCommand(qc, con);
                        commandc.ExecuteNonQuery();
                        Alert.EditSuccess();
                        break;
                }
                ft.RefreshDB();
                cbID.SelectedIndex = id;
            }
            catch (Exception er) { Alert.Error(er); }
            finally { if (con.State == ConnectionState.Open) con.Close(); }
        }

        private void cbID_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtT_Name.Text = FormTable.Table.Rows[cbID.SelectedIndex][1].ToString();
            txtT_VIN.Text = FormTable.Table.Rows[cbID.SelectedIndex][2].ToString();
            cbT_Type.Text = FormTable.Table.Rows[cbID.SelectedIndex][3].ToString();
            txtT_Count.Text = FormTable.Table.Rows[cbID.SelectedIndex][4].ToString();
            dateT_Start.Value = Convert.ToDateTime(FormTable.Table.Rows[cbID.SelectedIndex][5].ToString());
        }
    }
}
