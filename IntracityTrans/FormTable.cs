using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IntracityTrans
{
    public partial class FormTable : Form
    {
        public FormTable()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Titles()
        {
            switch (FormMenu.tableDB)
            {
                case FormMenu.TableDB.Transports:
                    dgvTable.Columns[0].HeaderCell.ToolTipText = "ID транспорта";
                    dgvTable.Columns[1].HeaderCell.ToolTipText = "Название";
                    dgvTable.Columns[2].HeaderCell.ToolTipText = "VIN номер";
                    dgvTable.Columns[3].HeaderCell.ToolTipText = "Тип транспорта";
                    dgvTable.Columns[4].HeaderCell.ToolTipText = "Количество мест";
                    dgvTable.Columns[5].HeaderCell.ToolTipText = "Дата поступления на предприятие";
                    break;
                case FormMenu.TableDB.Drivers:
                    dgvTable.Columns[0].HeaderCell.ToolTipText = "ID водителя";
                    dgvTable.Columns[1].HeaderCell.ToolTipText = "ФИО водителя";
                    dgvTable.Columns[2].HeaderCell.ToolTipText = "Дата рождения";
                    dgvTable.Columns[3].HeaderCell.ToolTipText = "Дата начала работы";
                    dgvTable.Columns[4].HeaderCell.ToolTipText = "Оклад (руб.)";
                    break;
                case FormMenu.TableDB.Routes:
                    dgvTable.Columns[0].HeaderCell.ToolTipText = "ID маршрута";
                    dgvTable.Columns[1].HeaderCell.ToolTipText = "Начальная и конечная остановки";
                    dgvTable.Columns[2].HeaderCell.ToolTipText = "Количество остановок";
                    dgvTable.Columns[3].HeaderCell.ToolTipText = "Время проезда (мин.)";
                    dgvTable.Columns[4].HeaderCell.ToolTipText = "Цена проезда (руб.)";
                    break;
                case FormMenu.TableDB.Lines:
                    dgvTable.Columns[0].HeaderCell.ToolTipText = "ID рейса";
                    dgvTable.Columns[1].HeaderCell.ToolTipText = "Тип транспорта";
                    dgvTable.Columns[2].HeaderCell.ToolTipText = "Название транспорта";
                    dgvTable.Columns[3].HeaderCell.ToolTipText = "ФИО водителя";
                    dgvTable.Columns[4].HeaderCell.ToolTipText = "Начальная и конечная остановки";
                    dgvTable.Columns[5].HeaderCell.ToolTipText = "Цена проезда по данному маршруту (руб.)";
                    dgvTable.Columns[6].HeaderCell.ToolTipText = "Дата рейса";
                    dgvTable.Columns[7].HeaderCell.ToolTipText = "Количество проездов по маршруту за рейс";
                    dgvTable.Columns[8].HeaderCell.ToolTipText = "Количество поссажиров";
                    dgvTable.Columns[9].HeaderCell.ToolTipText = "Заработано (руб.)";
                    break;
            }

            if (Properties.Settings.Default.CheckTitle)
            {
                for (int i = 0; i < dgvTable.Columns.Count; i++)
                {
                    dgvTable.Columns[i].HeaderText = dgvTable.Columns[i].HeaderCell.ToolTipText;
                    dgvTable.Columns[i].HeaderCell.ToolTipText = Table.Columns[i].ColumnName;
                }
            }
        }

        private SqlConnection con = DBSqlInfo.GetDBConnection();
        public static DataTable Table = new DataTable();
        public static SqlDataAdapter Adapter;
        public static string q;
        private string qd;
        public static string T_ID;

        public enum EditDB
        {
            Add,
            Correct
        }

        public static EditDB editDB;


        private void OpenDB()
        {
            Table.DefaultView.Sort = default;
            Table.Clear();
            Table.Columns.Clear();
            switch (FormMenu.tableDB)
            {
                case FormMenu.TableDB.Transports:
                    lblTitle.Text = "Транспорт";
                    q = "SELECT Transports.ID_Trans, Transports.T_Name, Transports.T_VIN, TransportType.TT_Name, Transports.T_Count, Transports.T_Start FROM Transports INNER JOIN TransportType ON TransportType.ID_Type=Transports.ID_Type";
                    break;
                case FormMenu.TableDB.Drivers:
                    lblTitle.Text = "Водители";
                    q = "SELECT * FROM Drivers";
                    break;
                case FormMenu.TableDB.Routes:
                    lblTitle.Text = "Маршруты";
                    q = "SELECT * FROM Routes";
                    break;
                case FormMenu.TableDB.Lines:
                    lblTitle.Text = "Рейсы";
                    q = "SELECT Lines.ID_Line, TransportType.TT_Name, Transports.T_Name, Drivers.D_FullName, Routes.R_FirstLast, Routes.R_Price, Lines.L_Date, Lines.L_Rounds, Lines.L_Count, (Routes.R_Price * Lines.L_Count) AS L_Total FROM Lines INNER JOIN Transports ON Transports.ID_Trans=Lines.ID_Trans INNER JOIN Drivers ON Drivers.ID_Driver=Lines.ID_Driver INNER JOIN Routes ON Routes.ID_Route=Lines.ID_Route INNER JOIN TransportType ON TransportType.ID_Type=Transports.ID_Type";
                    break;
            }

            try
            {
                con.Open();
                SqlCommand command = new SqlCommand(q, con);
                Adapter = new SqlDataAdapter(command);
                Adapter.Fill(Table);
                dgvTable.DataSource = Table.DefaultView;
                Titles();
                if (Properties.Settings.Default.CheckID) dgvTable.Columns[0].Visible = false;
            }
            catch (Exception er) { Alert.Error(er); }
            finally { if (con.State == ConnectionState.Open) con.Close(); }
        }

        public void RefreshDB()
        {
            try
            {
                con.Open();
                Table.Clear();
                Adapter.Fill(Table);
                dgvTable.DataSource = Table.DefaultView;
            }
            catch (Exception er) { Alert.Error(er); }
            finally { if (con.State == ConnectionState.Open) con.Close(); }
        }


        private void AddDB()
        {
            editDB = EditDB.Add;

            switch (FormMenu.tableDB)
            {
                case FormMenu.TableDB.Transports:
                    FormEditTransports frmt = new FormEditTransports();
                    frmt.ShowDialog();
                    break;
                case FormMenu.TableDB.Drivers:
                    FormEditDrivers frmd = new FormEditDrivers();
                    frmd.ShowDialog();
                    break;
                case FormMenu.TableDB.Routes:
                    FormEditRoutes frmr = new FormEditRoutes();
                    frmr.ShowDialog();
                    break;
                case FormMenu.TableDB.Lines:
                    FormEditLines frml = new FormEditLines();
                    frml.ShowDialog();
                    break;
            }
        }

        private void CorrectDB()
        {
            editDB = EditDB.Correct;

            if (dgvTable.SelectedRows.Count == 1)
                T_ID = dgvTable.CurrentRow.Cells[0].Value.ToString();
            else
                T_ID = dgvTable.Rows[0].Cells[0].Value.ToString();

            switch (FormMenu.tableDB)
            {
                case FormMenu.TableDB.Transports:
                    FormEditTransports frmt = new FormEditTransports();
                    frmt.ShowDialog();
                    break;
                case FormMenu.TableDB.Drivers:
                    FormEditDrivers frmd = new FormEditDrivers();
                    frmd.ShowDialog();
                    break;
                case FormMenu.TableDB.Routes:
                    FormEditRoutes frmr = new FormEditRoutes();
                    frmr.ShowDialog();
                    break;
                case FormMenu.TableDB.Lines:
                    FormEditLines frml = new FormEditLines();
                    frml.ShowDialog();
                    break;
            }
        }


        private void DeleteDB()
        {
            string Id = dgvTable.CurrentRow.Cells[0].Value.ToString();

            switch (FormMenu.tableDB)
            {
                case FormMenu.TableDB.Transports:
                    qd = "DELETE FROM Transports WHERE ID_Trans= " + Id;
                    break;
                case FormMenu.TableDB.Drivers:
                    q = "DELETE FROM Drivers WHERE ID_Driver= " + Id;
                    break;
                case FormMenu.TableDB.Routes:
                    q = "DELETE FROM Drivers WHERE ID_Route= " + Id;
                    break;
                case FormMenu.TableDB.Lines:
                    q = "DELETE FROM Drivers WHERE ID_Line= " + Id;
                    break;
            }

            try
            {
                con.Open();
                SqlCommand command2 = new SqlCommand(qd, con);
                command2.ExecuteNonQuery();
                Alert.DelSuccess();
            }
            catch (Exception er) { Alert.Error(er); }
            finally { if (con.State == ConnectionState.Open) con.Close(); }
            RefreshDB();
        }


        private void FormTable_Load(object sender, EventArgs e)
        {
            if(FormMenu.tableDB == FormMenu.TableDB.Transports)
            {
                panel1.Width += 64;
                btnTransportType.Visible = true;
            }
            OpenDB();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddDB();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvTable.SelectedRows.Count < 2)
            {
                CorrectDB();
            }
            else
                Alert.EditInfo();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTable.SelectedRows.Count == 1)
            {
                DeleteDB();
            }
            else
                Alert.DelInfo();
        }
        

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            try
            {
                RefreshDB();
                Alert.DataRefresh();
            }
            catch (Exception er) { Alert.Error(er); }
        }

        private void btnTransportType_Click(object sender, EventArgs e)
        {
            FormTransportType frm = new FormTransportType();
            frm.ShowDialog();
        }

    }
}
