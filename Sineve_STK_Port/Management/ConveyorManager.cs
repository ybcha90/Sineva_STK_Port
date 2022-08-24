using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sineva_STK_Port.Motion
{
    public class ConveyorManager
    {
        #region Singleton
        private static volatile ConveyorManager instance;
        private static object syncRoot = new object();

        public static ConveyorManager Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new ConveyorManager();
                    }
                }
                return instance;
            }
        }
        #endregion

        public void Move()
        {

        }
    }
    
}
