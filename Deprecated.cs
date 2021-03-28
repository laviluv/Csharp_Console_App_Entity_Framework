using System;
using System.Collections.Generic;
using System.Text;

namespace MP_EF_Lavinia_Bleoca
{
    class Deprecated
    {

       // public  bool IsDeprecated { get; private set; }
        public bool CheckDeprecated(DateTime purchaseTime)
        {
            DateTime CurrentTime = DateTime.Now;
            TimeSpan timeSpan = CurrentTime - purchaseTime;

            if (timeSpan.TotalDays > 1004)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
