using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntracityTrans
{
    public partial class FormMenu : Form
    {
        //Constructor
        public FormMenu()
        {
            InitializeComponent();
            //Исправление мерцания
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }
        //Изменение размера формы
        private int tolerance = 15;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //Панель
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.panelContenedorPrincipal.Region = region;
            this.Invalidate();
        }
        //Цвета приложения
        protected override void OnPaint(PaintEventArgs e)
        {

            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(55, 61, 69));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }
       
        //Перетаскивание
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PanelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
        //Максимум, минимум
        int lx, ly;
        int sw, sh;
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            lx = Location.X;
            ly = Location.Y;
            sw = Size.Width;
            sh = Size.Height;
            Size = Screen.PrimaryScreen.WorkingArea.Size;
            Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnMaximize.Visible = false;
            btnNormal.Visible = true;

        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            Size = new Size(sw, sh);
            Location = new Point(lx, ly);
            btnNormal.Visible = false;
            btnMaximize.Visible = true;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
             Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите выйти?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //анимация меню
        private void btnMenu_Click(object sender, EventArgs e)
        {
            //slide
            if (panelMenu.Width == 420)
            {
                tmContraerMenu.Start();
            }
            else if (panelMenu.Width == 100)
            {
                tmExpandirMenu.Start();
            }


            //без эффекта 
            //if (panelMenu.Width == 55)
            //{
            //    panelMenu.Width = 230;
            //}
            //else

            //    panelMenu.Width = 55;

        }

        double angle = 0;
        float DEG2RAD = (float)(3.14159 / 180);
        double xSettings, ySettings, xNewConnect, yNewConnect, degInRad;

        private void tmExpandirMenu_Tick(object sender, EventArgs e)
        {
            if (panelMenu.Width >= 420)
            {
                tmExpandirMenu.Stop();
                toolTip1.SetToolTip(btnMenu, "Свернуть");
                angle = 0;
            }
            else
            {
                panelMenu.Width += 10;

                degInRad = angle * DEG2RAD;
                if (btnNewConnect.Top < btnExit.Top)
                {
                    xSettings = Math.Cos(degInRad) * 89 + btnExit.Location.X;
                    ySettings = Math.Sin(degInRad) * 89 + btnExit.Location.Y;
                    btnSettings.Left = (int)xSettings;
                    btnSettings.Top = (int)ySettings;
                    
                }

                if (btnNewConnect.Top < btnExit.Top)
                {
                    xNewConnect = Math.Cos(degInRad) * 178 + btnExit.Location.X;
                    yNewConnect = Math.Sin(degInRad) * 178 + btnExit.Location.Y;
                    btnNewConnect.Left = (int)xNewConnect;
                    btnNewConnect.Top = (int)yNewConnect;
                }
                angle += 3.2;
            } 
        }

        private void tmContraerMenu_Tick(object sender, EventArgs e)
        {
            if (panelMenu.Width <= 100)
            {
                tmContraerMenu.Stop();
                toolTip1.SetToolTip(btnMenu, "Развернуть");
            }   
            else
            {
                panelMenu.Width -= 10;

                degInRad = angle * DEG2RAD;
                if (btnNewConnect.Left > btnExit.Left)
                {
                    xSettings = Math.Cos(degInRad) * 89 + btnExit.Location.X;
                    ySettings = Math.Sin(degInRad) * 89 + btnExit.Location.Y;
                    btnSettings.Left = (int)xSettings;
                    btnSettings.Top = (int)ySettings;
                }

                if (btnNewConnect.Left > btnExit.Left)
                {
                    xNewConnect = Math.Cos(degInRad) * 178 + btnExit.Location.X;
                    yNewConnect = Math.Sin(degInRad) * 178 + btnExit.Location.Y;
                    btnNewConnect.Left = (int)xNewConnect;
                    btnNewConnect.Top = (int)yNewConnect;
                }
                angle -= 3;
            }    
                
        }

        //Внутренняя панель
        private void OpenFormInPanel(object formHijo)
        {
            if (panelContenedorForm.Controls.Count > 0)
                panelContenedorForm.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;            
            panelContenedorForm.Controls.Add(fh);
            panelContenedorForm.Tag = fh;
            fh.Show();
        }
        //Лого при старте
        private void ShowFormLogo()
        {
            OpenFormInPanel(new FormLogo());
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            ShowFormLogo();
            UserInfo();
        }
        //Лого при закрытии форм
        private void ShowFormLogoAtCloseForms(object sender, FormClosedEventArgs e)
        {
            ShowFormLogo();
        }

        //Открытие форм
        public enum TableDB
        {
            Transports,
            Drivers,
            Routes,
            Lines
        }

        public static TableDB tableDB;

        private void OpenTable (TableDB table)
        {
            tableDB = table;
            FormTable fm = new FormTable();
            fm.FormClosed += new FormClosedEventHandler(ShowFormLogoAtCloseForms);
            OpenFormInPanel(fm);
        }

        private void btnTransports_Click(object sender, EventArgs e)
        {
            OpenTable(TableDB.Transports);
        }

        private void btnDrivers_Click(object sender, EventArgs e)
        {
            OpenTable(TableDB.Drivers);
        }


        private void btnRoutes_Click(object sender, EventArgs e)
        {
            OpenTable(TableDB.Routes);
        }

        private void btnLines_Click(object sender, EventArgs e)
        {
            OpenTable(TableDB.Lines);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            FormReport fm = new FormReport();
            fm.FormClosed += new FormClosedEventHandler(ShowFormLogoAtCloseForms);
            OpenFormInPanel(fm);

        }

        private void UserInfo()
        {
            if(Properties.Settings.Default.CheckConnect)
            { 
                lblHost.Text = Properties.Settings.Default.Host;
                lblDB.Text = Properties.Settings.Default.DB;
                lblUser.Text = Properties.Settings.Default.User;
                pbProfile.Image = Properties.Resources.profile;
            }
            else
            {
                lblHost.Text = null;
                lblDB.Text = null;
                lblUser.Text = null;
                pbProfile.Image = Properties.Resources.ErrorDB;
            }
            
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            FormSettings frm = new FormSettings();
            frm.FormClosed += new FormClosedEventHandler(ShowFormLogoAtCloseForms);
            OpenFormInPanel(frm);
        }

        private void btnNewConnect_Click(object sender, EventArgs e)
        {
            bool auto = false;
            if (Properties.Settings.Default.CheckAutoConnect)
            {
                Properties.Settings.Default.CheckAutoConnect = !Properties.Settings.Default.CheckAutoConnect;
                auto = true;
            }    
            ShowFormLogo();
            FormConnect frm = new FormConnect();
            frm.ShowDialog();
            UserInfo();
            if (auto) Properties.Settings.Default.CheckAutoConnect = !Properties.Settings.Default.CheckAutoConnect;
        }



        //Дата и время
        private void tmDataTime_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dddd, ") + DateTime.Now.ToLongDateString();
            lblTime.Text = DateTime.Now.ToString("HH:mm:ssss");
        }  

    }
}
