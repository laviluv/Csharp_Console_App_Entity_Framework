using System;
using System.Collections.Generic;
using System.Text;

namespace MP_EF_Lavinia_Bleoca
{
    class CellPhones : Assets
    {
        public CellPhones(string model, string brand, DateTime purchased)
        {
            Model = model;
            Brand = brand;
            Purchased = purchased;

        }

        //  public override string ResourceType => "cellphones";

        public int Id { get; set; }
        public override string ResourceType => "cellphones";

        public Offices Office { get; set; }




    }
}
