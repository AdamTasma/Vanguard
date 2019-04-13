using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanguard.Models
{
    public class ArmorModel
    {
        public ArmorDieTypeEnum ArmorDieType { get; set; }
        public int DieAmount { get; set; }
        public int PointCost { get; }
    }
}
