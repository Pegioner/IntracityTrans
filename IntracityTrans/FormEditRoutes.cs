using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IntracityTrans
{
    public partial class FormEditRoutes : Form
    {
        public FormEditRoutes()
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

        private void FormEditRoutes_Load(object sender, EventArgs e)
        {
            switch (FormTable.editDB)
            {
                case FormTable.EditDB.Add:
                    lblID.Visible = false;
                    cbID.Visible = false;
                    Text = "Добавление маршрута";
                    lblTitle.Text = "Добавление маршрута";
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
                        string qa = "INSERT INTO Routes (R_FirstLast, R_Count, R_Time, R_Price) VALUES ( '" + txtR_Start.Text + " - " + txtR_End.Text + "', " + txtR_Count.Text + ", " + txtR_Time.Text + ", " + txtR_Price.Text + " )";
                        SqlCommand commanda = new SqlCommand(qa, con);
                        commanda.ExecuteNonQuery();
                        Alert.AddSuccess();
                        break;
                    case FormTable.EditDB.Correct:
                        string ID = cbID.Text;
                        string qc = "UPDATE Routes SET R_FirstLast= '" + txtR_Start.Text + " - " + txtR_End.Text + "', R_Count= " + txtR_Count.Text + ", R_Time= " + txtR_Time.Text + ", R_Price= " + txtR_Price.Text + "WHERE ID_Route= " + ID;
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
            txtR_Start.Text = FormTable.Table.Rows[cbID.SelectedIndex][1].ToString().Split(new string[] { " - " }, StringSplitOptions.RemoveEmptyEntries)[0];
            txtR_End.Text = FormTable.Table.Rows[cbID.SelectedIndex][1].ToString().Split(new string[] { " - " }, StringSplitOptions.RemoveEmptyEntries)[1];
            txtR_Count.Text = FormTable.Table.Rows[cbID.SelectedIndex][2].ToString();
            txtR_Time.Text = FormTable.Table.Rows[cbID.SelectedIndex][3].ToString();
            txtR_Price.Text = FormTable.Table.Rows[cbID.SelectedIndex][4].ToString();
        }


    }
}
