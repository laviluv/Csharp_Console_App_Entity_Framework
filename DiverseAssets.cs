using System;
using System.Collections.Generic;
using System.Text;

namespace MP_EF_Lavinia_Bleoca
{
    class DiverseAssets : Assets
    {

        public DiverseAssets(string resourceType, string model, string brand, DateTime purchased)
        {
            ResourceType = resourceType;
            Model = model;
            Brand = brand;
            Purchased = purchased;
        }
        public int Id { get; set; }
        public override string ResourceType { get => base.ResourceType; set => base.ResourceType = value; }

        public Offices Office { get; set; }


    }
}
