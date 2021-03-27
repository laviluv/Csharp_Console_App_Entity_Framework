using System;
using System.Collections.Generic;
using System.Text;

namespace MP_EF_Lavinia_Bleoca
{
    class Assets
    {

        public virtual string ResourceType { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public DateTime Purchased { get; set; }
        public bool IsDeprecated { get; set; }



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
