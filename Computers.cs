using System;
using System.Collections.Generic;
using System.Text;

namespace MP_EF_Lavinia_Bleoca
{
    class Computers : Assets
    {
        public Computers(string model, string brand, DateTime purchased)
        {
            //ResourceType = "computers";
            Model = model;
            Brand = brand;
            Purchased = purchased;
        }

        public int Id { get; set; }
        public override string ResourceType => "computers";

        public Offices Office { get; set; }



    }
}
