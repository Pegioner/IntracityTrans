using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IntracityTrans
{
    public partial class FormEditDrivers : Form
    {
        public FormEditDrivers()
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

        private void FormEditDrivers_Load(object sender, EventArgs e)
        {
            dateD_DOB.Value = DateTime.Now;
            dateD_DOS.Value = DateTime.Now;

            switch (FormTable.editDB)
            {
                case FormTable.EditDB.Add:
                    lblID.Visible = false;
                    cbID.Visible = false;
                    Text = "Добавление водителя";
                    lblTitle.Text = "Добавление водителя";
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
                        string qa = "INSERT INTO Drivers (D_FullName, D_DOB, D_DOS, D_Salary) VALUES ( '" + txtD_FullName.Text + "', '" + dateD_DOB.Value.Date.ToString() + "', '" + dateD_DOS.Value.Date.ToString() + "', " + txtD_Salary.Text + " )";
                        SqlCommand commanda = new SqlCommand(qa, con);
                        commanda.ExecuteNonQuery();
                        Alert.AddSuccess();
                        break;
                    case FormTable.EditDB.Correct:
                        string ID = cbID.Text;
                        string qc = "UPDATE Drivers SET D_FullName= '" + txtD_FullName.Text + "', D_DOB= '" + dateD_DOB.Value.Date.ToString() + "', D_DOS= '" + dateD_DOS.Value.Date.ToString() + "', D_Salary= " + txtD_Salary.Text + "WHERE ID_Driver= " + ID;
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
            txtD_FullName.Text = FormTable.Table.Rows[cbID.SelectedIndex][1].ToString();
            dateD_DOB.Value = Convert.ToDateTime(FormTable.Table.Rows[cbID.SelectedIndex][2].ToString());
            dateD_DOS.Value = Convert.ToDateTime(FormTable.Table.Rows[cbID.SelectedIndex][3].ToString());
            txtD_Salary.Text = FormTable.Table.Rows[cbID.SelectedIndex][4].ToString();
        }
    }
}
