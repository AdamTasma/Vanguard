using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanguard.Models
{
    class CardModel
    {
        CreatureRankEnum CreatureRank { get; set; }
        CreatureFightingEnum CreatureFightingType { get; set; }
        int MeleeStat { get; set; }
        int RangedStat { get; set; }
        int Aptitude { get; set; }
        WeaponModel Weapon1 { get; set; }
        WeaponModel Weapon2 { get; set; }
        int Armor { get; set; }
        CreatureTrait Trait1 { get; set; }
        CreatureTrait Trait2 { get; set; }
        CreatureTrait Trait3 { get; set; }
        int PlotArmor { get; set; }
        int CardCost { get; set; }
    }
}
