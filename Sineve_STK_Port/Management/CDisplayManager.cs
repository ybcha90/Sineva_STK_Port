using Sineva_STK_Port.Define;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sineva_STK_Port.Management
{
    public class CDisplayManager
    {
        #region Singleton
        private static volatile CDisplayManager instance;
        private static object syncRoot = new object();

        public static CDisplayManager Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new CDisplayManager();
                    }
                }
                return instance;
            }
        }
        #endregion

        public string strUserGroup = SytemUserGroup.Operator.ToString();
        public string strLanguage = SystemLanguage.ENG.ToString();
        DataTable msgDefineTable = DBManager.Instance.GetMessageDefine();

        public void RefreshVerifyPrivilege(Control.ControlCollection parentControl, string strPrivilege)
        {
            List<string> listBtnName = new List<string>();
            listBtnName = DBManager.Instance.GetBtnNameByGroupId(strPrivilege);

            foreach (Control control in parentControl)
            {
                if (control is Button)
                {
                    if (listBtnName.Exists(t => t == control.Name))
                    {
                        control.Enabled = true;
                    }
                    else
                    {
                        control.Enabled = false;
                    }
                }
            }
        }

        public DB_MESSAGE_DEFINE GetMessageDefine(string msgID)
        {
            
            DB_MESSAGE_DEFINE msg = new DB_MESSAGE_DEFINE();
            try
            {
                foreach (DataRow row in msgDefineTable.Select(string.Format("ID = '{0}'", msgID)))
                {
                    msg = DB_MESSAGE_DEFINE.Create_DB_MESSAGE_DEFINE(row);
                    if (strLanguage == SystemLanguage.ENG.ToString())
                    {
                        msg.TEXT = msg.EngName;
                    }
                    else if (strLanguage == SystemLanguage.CHN.ToString())
                    {
                        msg.TEXT = msg.ChnName;
                    }
                    break;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print(ex.Message);
                return null;
            }

            return msg;
        }

        public DialogResult Show(DB_MESSAGE_DEFINE msgDefine)
        {
            string msg = string.Empty;
            string title = string.Empty;
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Warning;

            try
            {
                if (msgDefine != null)
                {
                    msg = msgDefine.TEXT;
                    title = msgDefine.Title;
                    buttons = GetButtonsType(msgDefine.Button);
                    icon = GetIconType(msgDefine.Icon);
                }
                else
                {
                    msg = "Not Defined!";
                }

                return Show(msg, title, buttons, icon);
            }
            catch
            {
                return Show("Exception Create, Please define log", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static public MessageBoxButtons GetButtonsType(string buttons)
        {
            MessageBoxButtons buttonsType = MessageBoxButtons.OK;
            switch (buttons.ToUpper())
            {
                case "YESNO":
                    buttonsType = MessageBoxButtons.YesNo;
                    break;
                case "OK":
                    buttonsType = MessageBoxButtons.OK;
                    break;
                case "OKCANCEL":
                    buttonsType = MessageBoxButtons.OKCancel;
                    break;
                case "ABORTRETRYIGNORE":
                    buttonsType = MessageBoxButtons.AbortRetryIgnore;
                    break;
                case "YESNOCANCEL":
                    buttonsType = MessageBoxButtons.YesNoCancel;
                    break;
                case "RETRYCANCEL":
                    buttonsType = MessageBoxButtons.YesNoCancel;
                    break;
                default:
                    break;
            }
            return buttonsType;
        }

        static public MessageBoxIcon GetIconType(string icon)
        {
            MessageBoxIcon iconType = MessageBoxIcon.None;
            switch (icon)
            {
                case "None":
                    iconType = MessageBoxIcon.None;
                    break;
                case "Error":
                    iconType = MessageBoxIcon.Error;
                    break;
                case "Hand":
                    iconType = MessageBoxIcon.Hand;
                    break;
                case "Stop":
                    iconType = MessageBoxIcon.Stop;
                    break;
                case "Question":
                    iconType = MessageBoxIcon.Question;
                    break;
                case "Exclamation":
                    iconType = MessageBoxIcon.Exclamation;
                    break;
                case "Warning":
                    iconType = MessageBoxIcon.Warning;
                    break;
                case "Information":
                    iconType = MessageBoxIcon.Information;
                    break;
                case "Asterisk":
                    iconType = MessageBoxIcon.Asterisk;
                    break;
                default:
                    break;
            }
            return iconType;
        }

        static public DialogResult Show(string message, string title, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            Form topmostForm = new Form();
            
            topmostForm.Size = new System.Drawing.Size(1, 1);
            topmostForm.StartPosition = FormStartPosition.Manual;
            System.Drawing.Rectangle rect = SystemInformation.VirtualScreen;
            topmostForm.Location = new System.Drawing.Point(rect.Bottom + 10, rect.Right + 10);
            topmostForm.Show();

            topmostForm.Focus();
            topmostForm.BringToFront();
            topmostForm.TopMost = true;

            DialogResult result = MessageBox.Show(topmostForm, message, title, buttons, icon);


            topmostForm.Dispose(); 
            return result;
        }
    }
}
