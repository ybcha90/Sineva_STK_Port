using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sineva_STK_Port.Motion
{
    public class CylinderManager
    {
        #region Singleton
        private static volatile CylinderManager instance;
        private static object syncRoot = new object();

        public static CylinderManager Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new CylinderManager();
                    }
                }
                return instance;
            }
        }
        #endregion
    }
}
