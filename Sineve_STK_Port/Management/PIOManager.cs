using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sineva_STK_Port.Motion
{
    public class PIOManager
    {
        #region Singleton
        private static volatile PIOManager instance;
        private static object syncRoot = new object();

        public static PIOManager Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new PIOManager();
                    }
                }
                return instance;
            }
        }
        #endregion
    }
}
