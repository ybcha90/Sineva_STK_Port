using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sineva_STK_Port.Communication
{
    public class CarrierBCRManager
    {
        #region Singleton
        private static volatile CarrierBCRManager instance;
        private static object syncRoot = new object();

        public static CarrierBCRManager Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new CarrierBCRManager();
                    }
                }
                return instance;
            }
        }
        #endregion

        private bool IsConnect { get; set; }
        private string CarrierID { get; set; }

        public bool ConnectCarrierReader()
        {
            bool isConnect = false;

            IsConnect = IsConnect;
            return isConnect;
        }

        public bool IsCarrierReaderConnect()
        {
            return IsConnect;
        }

        public (bool, string) ReadCarrierID()
        {
            try
            {
                string carrierID = string.Empty;
                bool isReadComplete = false;
                Task.Run(() => CarrierIDReadStart());
                return (isReadComplete, carrierID);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());   
                return (false, ex.ToString());     
            }
        }
            
        private void CarrierIDReadStart()
        {
            try
            {
                while (true)
                {

                    Thread.Sleep(10);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());   
            }
        }
    }
}
