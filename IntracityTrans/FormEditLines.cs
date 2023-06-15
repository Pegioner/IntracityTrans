using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IntracityTrans
{
    public partial class FormEditLines : Form
    {
        public FormEditLines()
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

        private void FormEditLines_Load(object sender, EventArgs e)
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

                string q3 = "Select ID_Trans, T_Name FROM Transports WHERE ID_Type= " + cbT_Type.SelectedValue;
                DataTable TTable = new DataTable();
                SqlCommand command3 = new SqlCommand(q3, con);
                SqlDataAdapter TAdapter = new SqlDataAdapter(command3);
                TAdapter.Fill(TTable);
                cbT_Name.DataSource = TTable;
                cbT_Name.DisplayMember = TTable.Columns[1].ToString();
                cbT_Name.ValueMember = TTable.Columns[0].ToString();

                string q4 = "Select ID_Driver, D_FullName FROM Drivers";
                DataTable DTable = new DataTable();
                SqlCommand command4 = new SqlCommand(q4, con);
                SqlDataAdapter DAdapter = new SqlDataAdapter(command4);
                DAdapter.Fill(DTable);
                cbD_FullName.DataSource = DTable;
                cbD_FullName.DisplayMember = DTable.Columns[1].ToString();
                cbD_FullName.ValueMember = DTable.Columns[0].ToString();

                string q5 = "Select ID_Route, R_FirstLast FROM Routes";
                DataTable RTable = new DataTable();
                SqlCommand command5 = new SqlCommand(q5, con);
                SqlDataAdapter RAdapter = new SqlDataAdapter(command5);
                RAdapter.Fill(RTable);
                cbR_FirstLast.DataSource = RTable;
                cbR_FirstLast.DisplayMember = RTable.Columns[1].ToString();
                cbR_FirstLast.ValueMember = RTable.Columns[0].ToString();
            }
            catch (Exception er) { Alert.Error(er); }
            finally { if (con.State == ConnectionState.Open) con.Close(); }

            dateL_Date.Value = DateTime.Now;

            switch (FormTable.editDB)
            {
                case FormTable.EditDB.Add:
                    lblID.Visible = false;
                    cbID.Visible = false;
                    Text = "Добавление рейса";
                    lblTitle.Text = "Добавление рейса";
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

        private void cbT_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cbT_Name.Text = "";
                if (int.TryParse(cbT_Type.SelectedValue.ToString(), out int id))
                {
                    string q3 = "Select ID_Trans, T_Name FROM Transports WHERE ID_Type= " + cbT_Type.SelectedValue;
                    DataTable TTable = new DataTable();
                    SqlCommand command3 = new SqlCommand(q3, con);
                    SqlDataAdapter TAdapter = new SqlDataAdapter(command3);
                    TAdapter.Fill(TTable);
                    cbT_Name.DataSource = TTable;
                    cbT_Name.DisplayMember = TTable.Columns[1].ToString();
                    cbT_Name.ValueMember = TTable.Columns[0].ToString();
                }
            }
            catch (Exception er) { Alert.Error(er); }
            finally { if (con.State == ConnectionState.Open) con.Close(); }
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
                        string qa = "INSERT INTO Lines (ID_Trans, ID_Driver, ID_Route, L_Date, L_Rounds, L_Count) VALUES ( " + cbT_Name.SelectedValue + ", " + cbD_FullName.SelectedValue + ", " + cbR_FirstLast.SelectedValue + ", '" + dateL_Date.Value.Date.ToString() + "', " + txtL_Rounds.Text + ", " + txtL_Count.Text + " )";
                        SqlCommand commanda = new SqlCommand(qa, con);
                        commanda.ExecuteNonQuery();
                        Alert.AddSuccess();
                        break;
                    case FormTable.EditDB.Correct:
                        string ID = cbID.Text;
                        string qc = "UPDATE Lines SET ID_Trans= " + cbT_Name.SelectedValue + ", ID_Driver= " + cbD_FullName.SelectedValue + ", ID_Route= " + cbR_FirstLast.SelectedValue + ", L_Date= '" + dateL_Date.Value.Date.ToString() + "', L_Rounds= " + txtL_Rounds.Text + ", L_Count= " + txtL_Count.Text + "WHERE ID_Line= " + ID;
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
            cbT_Type.Text = FormTable.Table.Rows[cbID.SelectedIndex][1].ToString();
            cbT_Name.Text = FormTable.Table.Rows[cbID.SelectedIndex][2].ToString();
            cbD_FullName.Text = FormTable.Table.Rows[cbID.SelectedIndex][3].ToString();
            cbR_FirstLast.Text = FormTable.Table.Rows[cbID.SelectedIndex][4].ToString();
            dateL_Date.Value = Convert.ToDateTime(FormTable.Table.Rows[cbID.SelectedIndex][6].ToString());
            txtL_Rounds.Text = FormTable.Table.Rows[cbID.SelectedIndex][7].ToString();
            txtL_Count.Text = FormTable.Table.Rows[cbID.SelectedIndex][8].ToString();
        }
    }
}
