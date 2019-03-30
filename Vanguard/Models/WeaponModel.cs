using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanguard.Models
{
    public class WeaponModel
    {
        public string Name { get; set; }
        public WeaponCategoryEnum Category { get; set; }
        public int WeaponPointCost { get; set; }
        public int TargetNumberMelee { get; set; }
        public int TargetNumberShort { get; set; }
        public int TargetNumberMedium { get; set; }
        public int TargetNumberLong { get; set; }
        public string Notes { get; set; }
    }
}
