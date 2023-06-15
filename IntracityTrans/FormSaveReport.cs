using Microsoft.Office.Interop.Excel;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace IntracityTrans
{
    public partial class FormSaveReport : Form
    {
        public FormSaveReport()
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

        private void FormNewReport_Load(object sender, EventArgs e)
        {
            cbType.SelectedIndex = 0;
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                
                Excel.Application ExcelApp = new Excel.Application();
                Workbook ExcelWorkBook;
                Worksheet ExcelWorkSheet;
                ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
                ExcelWorkSheet = (Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
                ExcelWorkBook.Title = "Отчёт IntracityTrans";
                ExcelWorkSheet.Name = "Отчёт";
                for (int i = 1; i < FormNewReport.ReportTable.Columns.Count + 1; i++)
                {
                    ExcelWorkSheet.Cells[1, i] = FormNewReport.ReportTable.Columns[i - 1].ColumnName;
                }
                for (int i = 0; i < FormNewReport.ReportTable.Rows.Count; i++)
                {
                    for (int j = 0; j < FormNewReport.ReportTable.Columns.Count; j++)
                    {
                        ExcelWorkSheet.Cells[i + 2, j + 1] = FormNewReport.ReportTable.Rows[i][j];
                    }
                }
                ExcelWorkSheet.Columns.AutoFit();
                ExcelWorkSheet.Rows.AutoFit();
                if(cbOpen.Checked)
                {
                    ExcelApp.Visible = true;
                    Alert.Message("Файл создан!", FormAlert.enmType.Success);
                    Close();
                }
                else
                {
                    if (txtName.Text.Trim() == string.Empty) txtName.Text = "Отчёт IntracityTrans";
                    if (txtName.Text.Trim() == string.Empty)
                    {
                        ExcelWorkBook.SaveAs(txtFolder.Text + "/" + txtName.Text + cbType.SelectedItem);
                        if (cbSaveOpen.Checked)
                            ExcelApp.Visible = true;
                        else
                            ExcelWorkBook.Close();
                        Alert.Message("Файл сохранён!", FormAlert.enmType.Success);
                        Close();
                    }
                    else
                        Alert.Message("Сначала выберите папку для сохранения!", FormAlert.enmType.Error);
                }
                
                
            }
            catch (Exception er) { Alert.Error(er); }
            finally {}
        }

        private void cbOpen_CheckedChanged(object sender, EventArgs e)
        {
            lblName.Visible = !lblName.Visible;
            txtName.Visible = !txtName.Visible;
            cbType.Visible = !cbType.Visible;
            lblFolder.Visible = !lblFolder.Visible;
            txtFolder.Visible = !txtFolder.Visible;
            btnFolder.Visible = !btnFolder.Visible;
            lblSaveOpen.Visible = !lblSaveOpen.Visible;
            cbSaveOpen.Visible = !cbSaveOpen.Visible;
            if (cbOpen.Checked)
                btnSave.Text = "Открыть";
            else
                btnSave.Text = "Сохранить";
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog DirDialog = new FolderBrowserDialog();
            DirDialog.Description = "Выберите папку, в которую будет сохранён Excel файл с полученным отчётом по рейсам.";
            DirDialog.SelectedPath = @"C:\";
            if (DirDialog.ShowDialog() == DialogResult.OK)
            {
                txtFolder.Text = DirDialog.SelectedPath;
            }
        }
    }
}
