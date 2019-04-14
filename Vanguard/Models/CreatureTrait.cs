using static Vanguard.Models.CreatureTraitCategoryEnum;

namespace Vanguard.Models
{
    public class CreatureTrait
    {
        public CreatureTraitCategory Category { get; set; }
        public int Cost { get; set; }
        public string Description { get; set; }
    }

    public class CreatureTraitCategoryEnum
    {
        public enum CreatureTraitCategory
        {
            Melee = 1,
            Ranged = 2,
            Movement = 3,
            Support = 4,
            Damage = 5,
            Magic = 6
        }
    }
}
