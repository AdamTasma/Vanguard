using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanguard.Models
{
    public class DataBase
    {
        public string DbVersion { get; set; }
        public List<WeaponModel> WeaponsDB { get; }
        public List<ArmorModel> ArmorDB { get; }
    }
}