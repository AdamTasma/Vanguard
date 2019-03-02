using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanguard.Models
{
    class CreatureTrait
    {
        CreatureTraitCategoryEnum Category { get; set; }
        int Cost { get; set; }
        string Description { get; set; }
    }
}
