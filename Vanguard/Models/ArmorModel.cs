using static Vanguard.Models.ArmorDieTypeEnum;

namespace Vanguard.Models
{
    public class ArmorModel
    {
        public ArmorType ArmorDieType { get; set; }
        public int DieAmount { get; set; }
        public int PointCost { get; set; }
    }

    public class ArmorDieTypeEnum
    {
        public enum ArmorType
        {
            Plot = 1,
            Yellow = 2,
            Red = 3
        }
    }
}
