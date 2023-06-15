using IntracityTrans.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace IntracityTrans
{
    public partial class FormAlert : Form
    {
        public FormAlert()
        {
            InitializeComponent();
        }

        public enum enmAction
        {
            wait,
            start,
            close
        }

        public enum enmType
        {
            Success,
            Warning,
            Error,
            Info
        }
        private enmAction action;

        private int x, y;

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch(action)
            {
                case enmAction.wait:
                    timer1.Interval = 5000;
                    action = enmAction.close;
                    break;
                case enmAction.start:
                    timer1.Interval = 1;
                    Opacity += 0.1;
                    if (x < Location.X)
                    {
                        Left--;
                    }
                    else
                    {
                        if (Opacity == 1.0)
                        {
                            action = enmAction.wait;
                        }
                    }
                    break;
                case enmAction.close:
                    timer1.Interval = 1;
                    Opacity -= 0.1;

                    Left -= 3;
                    if (Opacity == 0.0)
                    {
                        Close();
                    }
                    break;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //timer1.Interval = 1;
            //action = enmAction.close;
            Close();
        }

        private void FormAlert_MouseEnter(object sender, EventArgs e)
        {
            if (action == enmAction.start)
            {
                timer1.Stop();
            }
            
        }

        private void FormAlert_MouseLeave(object sender, EventArgs e)
        {
            action = enmAction.start;
            timer1.Interval = 1;
            timer1.Start();
        }

        private void lblMsg_TextChanged(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            float p = 12;   //начальный размер шрифта
            Font f = new Font(((Label)sender).Font.FontFamily, p, ((Label)sender).Font.Style);
            SizeF s = g.MeasureString(((Label)sender).Text, f);

            while (s.Width * s.Height >= (((Label)sender).Width)*(((Label)sender).Height))
            {
                p -= 0.1f;
                f = new Font(((Label)sender).Font.FontFamily, p, ((Label)sender).Font.Style);
                s = g.MeasureString(((Label)sender).Text, f);
            }
    ((Label)sender).Font = f;
        }


        public void showAlert(string msg, enmType type)
        {
            Opacity = 0.0;
            StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                FormAlert frm = (FormAlert)Application.OpenForms[fname];

                if (frm == null)
                {
                    Name = fname;
                    x = Screen.PrimaryScreen.WorkingArea.Width - Width + 15;
                    y = Screen.PrimaryScreen.WorkingArea.Height - Height * i - 5 * i;
                    Location = new Point(x, y);
                    break;

                }

            }
            x = Screen.PrimaryScreen.WorkingArea.Width - Width - 5;

            switch(type)
            {
                case enmType.Success:
                    pictureBox1.Image = Resources.success;
                    BackColor = Color.SeaGreen;
                    break;
                case enmType.Error:
                    pictureBox1.Image = Resources.error;
                    BackColor = Color.DarkRed;
                    break;
                case enmType.Info:
                    pictureBox1.Image = Resources.info;
                    BackColor = Color.RoyalBlue;
                    break;
                case enmType.Warning:
                    pictureBox1.Image = Resources.warning;
                    BackColor = Color.Orange;
                    break;
            }

            lblMsg.Text = msg;

            Show();
            action = enmAction.start;
            timer1.Interval = 1;
            timer1.Start();

        }
    }
}
