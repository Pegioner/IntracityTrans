using System;
using System.Windows.Forms;

namespace IntracityTrans
{


    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void FormReport_Load(object sender, EventArgs e)
        {
            FormNewReport frm = new FormNewReport();
            frm.Closing += (senderf, ef) =>
            {
                dgvReport.DataSource = FormNewReport.ReportTable.DefaultView;
            };
            frm.ShowDialog();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (FormNewReport.ReportTable.Rows.Count != 0)
            {
                FormSaveReport frm = new FormSaveReport();
                frm.ShowDialog();
            }
            else
                Alert.Message("Отчёт ещё не создан или в нём отсутствуют данные!", FormAlert.enmType.Warning);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormNewReport frm = new FormNewReport();
            frm.Closing += (senderf, ef) =>
            {
                dgvReport.DataSource = FormNewReport.ReportTable.DefaultView;
            };
            frm.ShowDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ClsPrint Print = new ClsPrint(dgvReport, "Отчёт о рейсах");
            Print.PrintForm();
        }

        
    }
}
