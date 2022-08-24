using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sineva_STK_Port.Define;

namespace Sineva_STK_Port.Model
{
    public class IOStatus
    {
        #region Singleton
        private static volatile IOStatus instance;
        private static object syncRoot = new object();

        public static IOStatus Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new IOStatus();
                    }
                }
                return instance;
            }
        }
        #endregion

        private Dictionary<int, bool> DicInputData { get; set; }
        private Dictionary<int, bool> DicOutput { get; set; }           

        public Dictionary<int,bool> GetAllInputData()
        {
            lock (syncRoot)
            {
                return DicInputData;
            }
        }

        public Dictionary<int, bool> GetAllOutputData()
        {
            lock (syncRoot)
            {
                return DicOutput;
            }
        }

        public (bool,string,bool) GetInputState(Input number)
        {
            try
            {
                lock (syncRoot)
                {
                    bool state = false;
                    bool isExist = DicInputData[(int)number] ? true : false;

                    if (isExist)
                    {
                        state = DicInputData[(int)number];
                    }

                    return (isExist, String.Empty, state);
                }
            }
            catch(Exception ex)
            {
                return (false, ex.ToString(), false);
            }
        }

        public (bool, string, bool) GetOutputState(Output number)
        {
            try
            {
                lock (syncRoot)
                {
                    bool state = false;
                    bool isExist = DicOutput[(int)number] ? true : false;

                    if (isExist)
                    {
                        state = DicOutput[(int)number];
                    }

                    return (isExist, String.Empty, state);
                }

            }
            catch (Exception ex)
            {
                return (false, ex.ToString(), false);
            }
        }
    }
}
