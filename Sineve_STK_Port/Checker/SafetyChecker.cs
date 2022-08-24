using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sineva_STK_Port.Checker
{
    public class SafetyChecker
    {
        public void CheckStart()
        {
            Task.Run(() => Run());
        }

        private void Run()
        {
            try
            {
                while (true)
                {

                    Thread.Sleep(1);
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
