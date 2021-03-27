using System;
using System.Collections.Generic;
using System.Text;

namespace MP_EF_Lavinia_Bleoca
{
    class Computers : Assets
    {
        public Computers( string model, string brand, DateTime purchased)
        {
           // ResourceType = resourcetype;
            Model = model;
            Brand = brand;
            Purchased = purchased;
        }

        public int Id { get; set; }
        public override string ResourceType { set => this.ResourceType = "computers"; }

        public Offices Office { get; set; }



    }
}
