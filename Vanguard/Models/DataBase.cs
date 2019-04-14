using System.Collections.Generic;

namespace Vanguard.Models
{
    public class DataBase
    {
        public string DbVersion { get; set; }
        public List<WeaponModel> WeaponsDB { get; set; }
        public List<ArmorModel> ArmorDB { get; set; }
    }
}