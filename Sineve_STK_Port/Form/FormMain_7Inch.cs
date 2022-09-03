using Sineva_STK_Port.Management;
using System.Data;
using Sineva_STK_Port.Define;
using System.Xml.Serialization;
using Microsoft.VisualBasic.Logging;

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
            if(privilege != SytemUserGroup.Operator.ToString())
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
            Btn_PortID.Text = "PortID："+ Portinfo.Rows[0][0].ToString();
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
    }
}