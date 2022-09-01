using Sineva_STK_Port.Management;
using System.Data;
using Sineva_STK_Port.Define;

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
            CDisplayManager.Instance.RefreshVerifyPrivilege(this.panelLeft.Controls, SytemUserGroup.Operator.ToString());
            CDisplayManager.Instance.RefreshVerifyPrivilege(this.panelDown.Controls, SytemUserGroup.Operator.ToString());
            GetPortInfo();

        }
        private void GetPortInfo()
        {
            DataTable Portinfo = DBManager.Instance.GetPortInfo();
            Btn_PortID.Text = "PortID："+Portinfo.Rows[0][0].ToString();
        }
        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
        }
    }
}