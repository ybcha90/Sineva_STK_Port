using System;
using System.Collections.Generic;
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


    }
}
