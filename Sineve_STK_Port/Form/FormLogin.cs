using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sineva_STK_Port.Define;
using Sineva_STK_Port.Management;

namespace Sineva_STK_Port
{
    public partial class FormLogin : Form
    {
        public delegate void UserLoginEventHandler();
        public event UserLoginEventHandler refreshPrivilege;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(txtUserID.Text == "")
            {
                DB_MESSAGE_DEFINE msgDefine = CDisplayManager.Instance.GetMessageDefine("1001");
                CDisplayManager.Instance.Show(msgDefine);

                return;
            }
            if(txtUserPW.Text == "")
            {
                DB_MESSAGE_DEFINE msgDefine = CDisplayManager.Instance.GetMessageDefine("1002");
                CDisplayManager.Instance.Show(msgDefine);
                return;
            }
            DataTable dt = DBManager.Instance.GetUserByUserID(txtUserID.Text);
            if (dt.Rows.Count == 0)
            {
                DB_MESSAGE_DEFINE msgDefine = CDisplayManager.Instance.GetMessageDefine("1003");
                CDisplayManager.Instance.Show(msgDefine);
                return;
            }
            if (dt.Rows[0]["Password"].ToString() == txtUserPW.Text)
            {
                DB_MESSAGE_DEFINE msgDefine = CDisplayManager.Instance.GetMessageDefine("1004");
                CDisplayManager.Instance.Show(msgDefine);

                if (dt.Rows[0]["GroupID"].ToString() != null)
                {
                    CDisplayManager.Instance.strUserGroup = dt.Rows[0]["GroupID"].ToString();
                }

                CDisplayManager.Instance.strLanguage = rbtnEng.Checked ? "ENG" : "CHN";
                this.refreshPrivilege();

                this.Close();   
            }
            else
            {
                DB_MESSAGE_DEFINE msgDefine = CDisplayManager.Instance.GetMessageDefine("1005");
                CDisplayManager.Instance.Show(msgDefine); 
                return;
            }
            
        }
    }
}
