using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IntracityTrans
{
    public partial class FormNewReport : Form
    {
        public FormNewReport()
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
        public static DataTable ReportTable = new DataTable();
        SqlDataAdapter Adapter;

        private void FormNewReport_Load(object sender, EventArgs e)
        {
            cbType.SelectedIndex = 0;
            dateT_Date.Value = DateTime.Now;
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (cbType.SelectedIndex)
                {
                    case 0:
                        lblS_Type.Visible = false;
                        cbS_Type.Visible = false;
                        break;
                    case 1:
                        lblS_Type.Text = "ФИО:";
                        lblS_Type.Visible = true;
                        string qd = "Select ID_Driver, D_FullName FROM Drivers";
                        DataTable DTable = new DataTable();
                        SqlCommand commandd = new SqlCommand(qd, con);
                        SqlDataAdapter DAdapter = new SqlDataAdapter(commandd);
                        DAdapter.Fill(DTable);
                        cbS_Type.DataSource = DTable;
                        cbS_Type.DisplayMember = DTable.Columns[1].ToString();
                        cbS_Type.ValueMember = DTable.Columns[0].ToString();
                        cbS_Type.Visible = true;
                        break;
                    case 2:
                        lblS_Type.Text = "Нач.-Кон.:";
                        lblS_Type.Visible = true;
                        string qr = "Select ID_Route, R_FirstLast FROM Routes";
                        DataTable RTable = new DataTable();
                        SqlCommand commandr = new SqlCommand(qr, con);
                        SqlDataAdapter RAdapter = new SqlDataAdapter(commandr);
                        RAdapter.Fill(RTable);
                        cbS_Type.DataSource = RTable;
                        cbS_Type.DisplayMember = RTable.Columns[1].ToString();
                        cbS_Type.ValueMember = RTable.Columns[0].ToString();
                        cbS_Type.Visible = true;
                        break;
                }
            }
            catch (Exception er) { Alert.Error(er); }
            finally { if (con.State == ConnectionState.Open) con.Close(); }
        }
        
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                ReportTable.Clear();
                ReportTable.Columns.Clear();
                //FormReport.dgvReport.Columns.Clear();
                con.Open();
                string req;
                switch (cbType.SelectedIndex)
                {
                    case 0:
                        req = "SELECT Lines.ID_Line, TransportType.TT_Name, Transports.T_Name, Drivers.D_FullName, Routes.R_FirstLast, Routes.R_Price, Lines.L_Date, Lines.L_Rounds, Lines.L_Count, (Routes.R_Price * Lines.L_Count) AS L_Total FROM Lines INNER JOIN Transports ON Transports.ID_Trans=Lines.ID_Trans INNER JOIN Drivers ON Drivers.ID_Driver=Lines.ID_Driver INNER JOIN Routes ON Routes.ID_Route=Lines.ID_Route INNER JOIN TransportType ON TransportType.ID_Type=Transports.ID_Type WHERE Lines.L_Date BETWEEN '" + dateF_Date.Value.Date.ToString() + "' AND '" + dateT_Date.Value.Date.ToString() + "' AND (Routes.R_Price * Lines.L_Count)> " + txtTotal.Text;
                        SqlCommand command0 = new SqlCommand(req, con);
                        Adapter = new SqlDataAdapter(command0);
                        Adapter.Fill(ReportTable);
                        ReportTable.Columns["ID_Line"].ColumnName = "ID";
                        ReportTable.Columns["TT_Name"].ColumnName = "Тип транспорта";
                        ReportTable.Columns["T_Name"].ColumnName = "Название транспорта";
                        ReportTable.Columns["D_FullName"].ColumnName = "ФИО водителя";
                        ReportTable.Columns["R_FirstLast"].ColumnName = "Начальная и конечная остановки маршрута";
                        ReportTable.Columns["R_Price"].ColumnName = "Цена проезда по\nмаршруту (руб.)";
                        ReportTable.Columns["L_Date"].ColumnName = "Дата рейса";
                        ReportTable.Columns["L_Rounds"].ColumnName = "Количество проездов\nпо маршруту";
                        ReportTable.Columns["L_Count"].ColumnName = "Количество пассажиров";
                        ReportTable.Columns["L_Total"].ColumnName = "Заработано (руб.)";
                        break;
                    case 1:
                        req = "SELECT Lines.ID_Line, TransportType.TT_Name, Transports.T_Name, Drivers.D_FullName, Routes.R_FirstLast, Routes.R_Price, Lines.L_Date, Lines.L_Rounds, Lines.L_Count, (Routes.R_Price * Lines.L_Count) AS L_Total FROM Lines INNER JOIN Transports ON Transports.ID_Trans=Lines.ID_Trans INNER JOIN Drivers ON Drivers.ID_Driver=Lines.ID_Driver INNER JOIN Routes ON Routes.ID_Route=Lines.ID_Route INNER JOIN TransportType ON TransportType.ID_Type=Transports.ID_Type WHERE Lines.L_Date BETWEEN '" + dateF_Date.Value.Date.ToString() + "' AND '" + dateT_Date.Value.Date.ToString() + "' AND (Routes.R_Price * Lines.L_Count)> " + txtTotal.Text + " AND Drivers.ID_Driver= " + cbS_Type.SelectedValue;
                        SqlCommand command1 = new SqlCommand(req, con);
                        Adapter = new SqlDataAdapter(command1);
                        Adapter.Fill(ReportTable);
                        ReportTable.Columns["ID_Line"].ColumnName = "ID";
                        ReportTable.Columns["TT_Name"].ColumnName = "Тип транспорта";
                        ReportTable.Columns["T_Name"].ColumnName = "Название транспорта";
                        ReportTable.Columns["D_FullName"].ColumnName = "ФИО водителя";
                        ReportTable.Columns["R_FirstLast"].ColumnName = "Начальная и конечная остановки маршрута";
                        ReportTable.Columns["R_Price"].ColumnName = "Цена проезда по\nмаршруту (руб.)";
                        ReportTable.Columns["L_Date"].ColumnName = "Дата рейса";
                        ReportTable.Columns["L_Rounds"].ColumnName = "Количество проездов\nпо маршруту";
                        ReportTable.Columns["L_Count"].ColumnName = "Количество пассажиров";
                        ReportTable.Columns["L_Total"].ColumnName = "Заработано (руб.)";
                        break;
                    case 2:
                        req = "SELECT Lines.ID_Line, TransportType.TT_Name, Transports.T_Name, Drivers.D_FullName, Routes.R_FirstLast, Routes.R_Price, Lines.L_Date, Lines.L_Rounds, Lines.L_Count, (Routes.R_Price * Lines.L_Count) AS L_Total FROM Lines INNER JOIN Transports ON Transports.ID_Trans=Lines.ID_Trans INNER JOIN Drivers ON Drivers.ID_Driver=Lines.ID_Driver INNER JOIN Routes ON Routes.ID_Route=Lines.ID_Route INNER JOIN TransportType ON TransportType.ID_Type=Transports.ID_Type WHERE Lines.L_Date BETWEEN '" + dateF_Date.Value.Date.ToString() + "' AND '" + dateT_Date.Value.Date.ToString() + "' AND (Routes.R_Price * Lines.L_Count)> " + txtTotal.Text + " AND Routes.ID_Route= " + cbS_Type.SelectedValue;
                        SqlCommand command2 = new SqlCommand(req, con);
                        Adapter = new SqlDataAdapter(command2);
                        Adapter.Fill(ReportTable);
                        ReportTable.Columns["ID_Line"].ColumnName = "ID";
                        ReportTable.Columns["TT_Name"].ColumnName = "Тип транспорта";
                        ReportTable.Columns["T_Name"].ColumnName = "Название транспорта";
                        ReportTable.Columns["D_FullName"].ColumnName = "ФИО водителя";
                        ReportTable.Columns["R_FirstLast"].ColumnName = "Начальная и конечная остановки маршрута";
                        ReportTable.Columns["R_Price"].ColumnName = "Цена проезда по маршруту (руб.)";
                        ReportTable.Columns["L_Date"].ColumnName = "Дата рейса";
                        ReportTable.Columns["L_Rounds"].ColumnName = "Количество проездов по маршруту";
                        ReportTable.Columns["L_Count"].ColumnName = "Количество пассажиров";
                        ReportTable.Columns["L_Total"].ColumnName = "Заработано (руб.)";
                        break;
                }
                if (cbID.Checked == false) ReportTable.Columns.RemoveAt(0);
                Close();
                Alert.Message("Отчёт создан!", FormAlert.enmType.Success);
            }
            catch (Exception er) { Alert.Error(er); }
            finally { if (con.State == ConnectionState.Open) con.Close(); }
        }

        private void cbDate_CheckedChanged(object sender, EventArgs e)
        {
            lblFrom.Visible = !lblFrom.Visible;
            lblTo.Visible = !lblTo.Visible;
            dateF_Date.Visible = !dateF_Date.Visible;
            dateT_Date.Visible = !dateT_Date.Visible;
        }

        private void cbTotal_CheckedChanged(object sender, EventArgs e)
        {
            txtTotal.Visible = !txtTotal.Visible;
            lblCur.Visible = !lblCur.Visible;
            if (txtTotal.Visible == false) txtTotal.Text = "0";
        }
    }
}
