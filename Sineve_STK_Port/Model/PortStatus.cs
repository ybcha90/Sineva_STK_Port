using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Sineva_STK_Port.Define;

namespace Sineva_STK_Port.Model
{
    public class PortStatus
    {
        #region Singleton
        private static volatile PortStatus instance;
        private static object syncRoot = new object();

        public static PortStatus Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new PortStatus();
                    }
                }
                return instance;
            }
        }
        #endregion

        public string CarrierID { get; set; } = string.Empty;
        public PortType PortType { get; set; }
        public int PortID { get; set; }
	    public int ZoneCapacity { get; set; }
	    public HandoffType HandoffType { get; set; }
	    public PortState PrevCarrierState { get; set; }
	    public PortState CurrentCarrierState { get; set; }
	    public bool IsEnabled { get; set; }

        public bool ReportPortStatusData()
        {
            bool _isSend = false;
            string _sendPacketData = string.Empty;

            _sendPacketData = $"{CarrierID}{PortType}{PortID}{ZoneCapacity}{HandoffType}{PrevCarrierState}{CurrentCarrierState}{IsEnabled}";
            
            return _isSend;
        }
    }
}
