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
                MessageBox.Show("Please enter user ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(txtUserPW.Text == "")
            {
                MessageBox.Show("Please enter password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataTable dt = DBManager.Instance.GetUserByUserID(txtUserID.Text);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("The user ID does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dt.Rows[0]["Password"].ToString() == txtUserPW.Text)
            {
                MessageBox.Show("Login successful!", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                MessageBox.Show("The password is incorrect. Please re-enter it!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }
    }
}
