using System;
using System.Collections.Generic;
using System.Text;

namespace MP_EF_Lavinia_Bleoca
{
    class Offices
    {
        public string ResourceType { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Currency { get; set; }
        public List<Computers> Computers { get; set; }
        public List<CellPhones> CellPhones { get; set; }

        public List<OtherAssets> OtherAssets { get; set; }
        public List<DiverseAssets> DiverseAssets { get; internal set; }
    }
}
