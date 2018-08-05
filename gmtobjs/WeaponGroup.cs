using PathfinderTools.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderTools {

    /// <summary>
    /// Supplies the available weapon groups for a weapon
    /// </summary>
    public enum WeaponGroup {
        [EnumLocal( "WG001", "Axe" )]
        Axe = 0x01,

        [EnumLocal( "WG002", "Bow" )]
        Bow = 0x02,

        [EnumLocal( "WG003", "Brawling" )]
        Brawling = 0x04,

        [EnumLocal( "WG004", "Club" )]
        Club = 0x08,

        [EnumLocal( "WG005", "Dart" )]
        Dart = 0x10,

        [EnumLocal( "WG006", "Flail" )]
        Flail = 0x20,

        [EnumLocal( "WG007", "Hammer" )]
        Hammer = 0x40,

        [EnumLocal( "WG001", "Knife" )]
        Knife = 0x80,

        [EnumLocal( "WG001", "Pick" )]
        Pick = 0x100,

        [EnumLocal( "WG001", "Polearm" )]
        Polearm = 0x200,

        [EnumLocal( "WG001", "Shield" )]
        Shield = 0x400,

        [EnumLocal( "WG001", "Sling" )]
        Sling = 0x800,

        [EnumLocal( "WG001", "Spear" )]
        Spear = 0x1000,

        [EnumLocal( "WG001", "Sword" )]
        Sword = 0x2000
    }
}