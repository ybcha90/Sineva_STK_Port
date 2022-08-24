using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sineva_STK_Port.Management
{
    public class SCSEventManager
    {
        #region Singleton
        private static volatile SCSEventManager instance;
        private static object syncRoot = new object();

        public static SCSEventManager Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new SCSEventManager();
                    }
                }
                return instance;
            }
        }
        #endregion
    }
}
