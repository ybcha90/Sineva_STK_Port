using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sineva_STK_Port.Define
{
    public enum PortCmd
    {
        MOVE_HOME_ZONE_REQ = 4003,
        MOVE_HOME_ZONE_RSP = 4004,
        OPERATION_STATUS_CHANGE_REQ = 4011,
        OPERATION_STATUS_CHANGE_RSP = 4012,
        OPERATION_STATUS_REQ = 4013,
        OPERATION_STATUS_RSP = 4014,
        PROCESS_STATUS_CHANGE_REQ = 4017,
        PROCESS_STATUS_CHANGE_RSP = 4018,
        UPDATE_PORT_STATUS = 4021,
        ALARM_CLEARED = 4031,
        ALARM_SET = 4033,
        CARRIER_REMOVED = 4041,
        CARRIER_WAIT_IN = 4043,
        CARRIER_WAIT_OUT_REQ = 4045,
        CARRIER_WAIT_OUT_RSP = 4046,
        ZONE_CAPACITY_CHANGE = 4047,
        CARRIER_ID_READ = 4061,
        ID_READ_ERROR = 4063,
        INITIALIZE_REQ = 4071,
        INITIALIZE_RSP = 4072,
        PORT_STATUS_REQ = 4081,
        PORT_STATUS_RSP = 4082
    }
    public enum ErrorCode : ushort
    {
        SUCESS = 0,
        ERROR_INVALID_SOURCE = 1,
        ERROR_INVALID_DESTINY = 2,
        ERROR_FAIL_TO_READ_BCR = 3,
        ERROR_MISMATCH_CARRIER_ID = 4,
    }
    public enum HandoffType : ushort
    {
        HANDOFF_TYPE_MANUAL = 0,
        HANDOFF_TYPE_AUTOMATED = 1
    }
    public enum PortState : ushort
    {
        PORT_STATE_IDLE = 0,
        PORT_STATE_ACTIVE = 1,
    }
    public enum PortType : ushort
    {
        NONE = 0,
        PORT_TYPE_LP = 1,
        PORT_TYPE_BP = 2,
        PORT_TYPE_OP = 3
    }
    public enum PortMode : ushort
    {
        NONE = 0,
        Manual = 1,
        Auto = 2
    }
    public enum ProcessStatus : ushort
    {
        NONE = 0,
        Disable = 1,
        Enable = 2
    }
    
}
