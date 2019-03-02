using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanguard.Models
{
    class WeaponModel
    {
        string Name { get; set; }
        int TargetNumberMelee { get; set; }
        int TargetNumberShort { get; set; }
        int TargetNumberMedium { get; set; }
        int TargetNumberLong { get; set; }
        string WeaponTrait { get; set; }
        string Description { get; set; }
    }
}
