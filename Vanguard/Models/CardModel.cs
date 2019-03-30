using System.Collections.Generic;

namespace Vanguard.Models
{
    public class CardModel
    {
        public string CreatureName { get; set; }
        public CreatureRankEnum CreatureRank { get; set; }
        public CreatureFightingEnum CreatureFightingType { get; set; }
        public int MeleeStat { get; set; }
        public int RangedStat { get; set; }
        public int Aptitude { get; set; }
        public WeaponModel Weapon1 { get; set; }
        public WeaponModel Weapon2 { get; set; }
        public int Armor { get; set; }
        public CreatureTrait Trait1 { get; set; }
        public CreatureTrait Trait2 { get; set; }
        public CreatureTrait Trait3 { get; set; }
        public Dictionary<int, int> PlotArmor { get; set; }
        public Dictionary<int, int> YellowArmor { get; set; }
        public Dictionary<int, int> RedArmor { get; set; }
        public int CardCost { get; set; }
    }
}
