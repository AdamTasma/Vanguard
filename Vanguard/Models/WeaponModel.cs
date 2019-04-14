using static Vanguard.Models.WeaponCategoryEnum;

namespace Vanguard.Models
{
    public class WeaponModel
    {
        public string Name { get; set; }
        public WeaponCategory Category { get; set; }
        public int WeaponPointCost { get; set; }
        public int TargetNumberMelee { get; set; }
        public int TargetNumberShort { get; set; }
        public int TargetNumberMedium { get; set; }
        public int TargetNumberLong { get; set; }
        public string Notes { get; set; }
    }

    public class WeaponCategoryEnum
    {
        public enum WeaponCategory
        {
            Melee = 1,
            Ranged = 2
        }
    }
}