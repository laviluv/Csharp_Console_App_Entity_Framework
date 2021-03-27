using System;
using System.Collections.Generic;
using System.Text;

namespace MP_EF_Lavinia_Bleoca
{
    class OtherAssets : Assets
    {
  
 
        public OtherAssets( string assetClass, string brand, DateTime purchased)
        {
         //ResourceType = typeofasset;
            Model = assetClass;
            Brand = brand;
            Purchased = purchased;
        }
    
        public int Id { get; set; }
        public override string ResourceType { get; set; }
        //public string Model { get; set; }
        public string AssetClass { get; set; }

        public Offices Office { get; set; }

    }
}
