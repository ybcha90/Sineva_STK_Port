using Sineva_STK_Port.Management;
using System.Data;
using Sineva_STK_Port.Define;
using System.Xml.Serialization;

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
            string language = CDisplayManager.Instance.strLanguage;
            string privilege = CDisplayManager.Instance.strUserGroup;
            CDisplayManager.Instance.RefreshVerifyPrivilege(this.panelLeft.Controls, privilege);
            CDisplayManager.Instance.RefreshVerifyPrivilege(this.panelDown.Controls, privilege);
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
            formLogin.refreshPrivilege += new FormLogin.UserLoginEventHandler(this.RefreshFormMain);
            formLogin.ShowDialog();
        }
    }
}