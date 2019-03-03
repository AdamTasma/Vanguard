using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanguard.Models
{
    public class CreatureTrait
    {
        public CreatureTraitCategoryEnum Category { get; set; }
        public int Cost { get; set; }
        public string Description { get; set; }
    }
}
