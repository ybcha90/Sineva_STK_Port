using Sineva_STK_Port.Management;
using System.Data;
using Sineva_STK_Port.Define;
using System.Xml.Serialization;
using Microsoft.VisualBasic.Logging;
using System.Drawing;

namespace Sineva_STK_Port
{
    public partial class FormMain_7Inch : Form
    {
        public FormMain_7Inch()
        {
            InitializeComponent();
        }

        private void FormMain_7Inchi_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ActiveControl = button2;
            this.RefreshFormMain();
            GetPortInfo();            
        }

        public void RefreshFormMain()
        {
            string language = CDisplayManager.m_strLanguage;
            string privilege = CDisplayManager.m_strUserGroup;
            CDisplayManager.Instance.RefreshVerifyPrivilege(this.Controls, privilege);
            if (privilege != SytemUserGroup.Operator.ToString())
            {
                CDisplayManager.Instance.SetCtlText(Btn_LogIn, "Log Out");
            }
            else
            {
                CDisplayManager.Instance.SetCtlText(Btn_LogIn, "Log In");
            }

        }

        private void GetPortInfo()
        {
            DataTable Portinfo = DBManager.Instance.GetPortInfo();
            Btn_PortID.Text = "PortID：" + Portinfo.Rows[0][0].ToString();
        }
        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            if (CDisplayManager.m_strUserGroup == SytemUserGroup.Operator.ToString())
            {
                formLogin.refreshPrivilege += new FormLogin.UserLoginEventHandler(this.RefreshFormMain);
                formLogin.ShowDialog();
            }
            else
            {
                DB_MESSAGE_DEFINE msgDefine = CDisplayManager.Instance.GetMessageDefine("1006");
                if (CDisplayManager.Instance.Show(msgDefine) == DialogResult.OK)
                {
                    CDisplayManager.m_strUserGroup = SytemUserGroup.Operator.ToString();
                    RefreshFormMain();
                }
            }
        }

        //================================================Paint Function
        #region
        //private void FormMain_Paint(object sender, PaintEventArgs e)
        //{
        //    Rectangle tang = this.ClientRectangle;					//获取窗口矩形 为了下面得到窗口的宽高
        //    Graphics g3 = e.Graphics;
        //    Color c3 = Color.FromArgb(46, 204, 113);
        //    Pen p3 = new Pen(c3);
        //    g3.DrawLine(p3, 0, 0, 0, tang.Height - 1);				//在（0，0）和（tang.Width - 1, 0）这两点间画一条直线
        //    g3.DrawLine(p3, 0, tang.Height - 1, tang.Width - 1, tang.Height - 1);	//注意必须减1 不然显示不出来  因为 如果假设窗口的高度是3像素 我们知道（0，0）位置代表 窗口最左上角的像素点  那么最左下角的像素点应该是（0，2） 而不是（0，3） 因为0，1，2 已经三个像素点了
        //    g3.DrawLine(p3, tang.Width - 1, tang.Height - 1, tang.Width - 1, 0);
        //    g3.DrawLine(p3, tang.Width - 1, 0, 0, 0);
        //}
        protected void Panel_Paint(object sender, PaintEventArgs e)
        {
            Rectangle borderRectangle = ((System.Windows.Forms.Control)sender).ClientRectangle;
            ControlPaint.DrawBorder(e.Graphics, borderRectangle,
                                  Color.Black, 2, ButtonBorderStyle.Solid,
                                  Color.Black, 2, ButtonBorderStyle.Solid,
                                  Color.Black, 2, ButtonBorderStyle.Solid,
                                  Color.Black, 2, ButtonBorderStyle.Solid);
        }
        protected void Button_Paint(object sender, PaintEventArgs e)
        {
            ((System.Windows.Forms.Control)sender).BackColor = System.Drawing.Color.LightSkyBlue;
            ((System.Windows.Forms.Control)sender).ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            Rectangle borderRectangle = ((System.Windows.Forms.Control)sender).ClientRectangle;
            ControlPaint.DrawBorder(e.Graphics, borderRectangle,
                                  //System.Drawing.SystemColors.ControlText, 5, ButtonBorderStyle.Outset,
                                  Color.WhiteSmoke, 8, ButtonBorderStyle.Dashed,
                                  Color.Gray, 8, ButtonBorderStyle.Dotted,
                                  //System.Drawing.SystemColors.ControlText, 5, ButtonBorderStyle.Outset,
                                  Color.WhiteSmoke, 8, ButtonBorderStyle.Dashed,
                                  Color.Gray, 8, ButtonBorderStyle.Dotted);
        }
        protected void InfoButton_Paint(object sender, PaintEventArgs e)
        {
            ((System.Windows.Forms.Control)sender).BackColor = System.Drawing.SystemColors.HighlightText;
            Rectangle borderRectangle = ((System.Windows.Forms.Control)sender).ClientRectangle;
            ControlPaint.DrawBorder(e.Graphics, borderRectangle,
                                  Color.DarkGray, 6, ButtonBorderStyle.Dashed,
                                  Color.WhiteSmoke, 6, ButtonBorderStyle.Dashed,
                                  Color.DarkGray, 6, ButtonBorderStyle.Dashed,
                                  Color.WhiteSmoke, 6, ButtonBorderStyle.Dashed);
        }
        #endregion

        private void Btn_ControlStatus_Click(object sender, EventArgs e)
        {
            FormCurrentAlarm formAlarm=new FormCurrentAlarm();
            formAlarm.ShowDialog();
        }
    }
}