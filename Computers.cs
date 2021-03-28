using System;
using System.Collections.Generic;
using System.Text;

namespace MP_EF_Lavinia_Bleoca
{
    class Computers : Assets
    {

        /*
        public Computers()
        {
            this.ResourceType = "computerx";
        }
        */

        public Computers( string model, string brand, DateTime purchased)
        {
           // ResourceType = resourcetype;
            Model = model;
            Brand = brand;
            Purchased = purchased;
          //  this.IsDeprecated = IsDeprecated;
        }

        public int Id { get; set; }
      
        public override string ResourceType { get; set; } = "computer";  // C# 6 or higher


        public Offices Office { get; set; }



    }
}
