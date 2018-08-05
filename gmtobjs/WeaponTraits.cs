using PathfinderTools.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderTools {

    /// <summary>
    /// Supplies the available weapon traits
    /// </summary>
    [Flags]
    public enum WeaponTraits {
        [EnumLocal( "WT001", "Agile" )]
        Agile = 0x01,

        [EnumLocal( "WT002", "Attached" )]
        Attached = 0x02,

        [EnumLocal( "WT003", "Backstabber" )]
        Backstabber = 0x04,

        [EnumLocal( "WT004", "Backswing" )]
        Backswing = 0x08,

        [EnumLocal( "WT005", "Charge" )]
        Charge = 0x10,

        [EnumLocal( "WT006", "Deadly" )]
        Deadly = 0x20,

        [EnumLocal( "WT007", "Disarm" )]
        Disarm = 0x40,

        [EnumLocal( "WT008", "Dwarf" )]
        Dwarf = 0x80,

        [EnumLocal( "WT009", "Elf" )]
        Elf = 0x100,

        [EnumLocal( "WT010", "Fatal" )]
        Fatal = 0x200,

        [EnumLocal( "WT011", "Finesse" )]
        Finesse = 0x400,

        [EnumLocal( "WT012", "Forceful" )]
        Forceful = 0x800,

        [EnumLocal( "WT013", "Free-Hand" )]
        FreeHand = 0x1000,

        [EnumLocal( "WT014", "Gnome" )]
        Gnome = 0x2000,

        [EnumLocal( "WT015", "Goblin" )]
        Goblin = 0x4000,

        [EnumLocal( "WT016", "Halfling" )]
        Halfling = 0x8000,

        [EnumLocal( "WT017", "Monk" )]
        Monk = 0x10000,

        [EnumLocal( "WT018", "Nonlethal" )]
        Nonlethal = 0x20000,

        [EnumLocal( "WT019", "Orc" )]
        Orc = 0x40000,

        [EnumLocal( "WT020", "Parry" )]
        Parry = 0x80000,

        [EnumLocal( "WT021", "Propulsive" )]
        Propulsive = 0x100000,

        [EnumLocal( "WT022", "Reach" )]
        Reach = 0x200000,

        [EnumLocal( "WT023", "Shove" )]
        Shove = 0x400000,

        [EnumLocal( "WT024", "Sweep" )]
        Sweep = 0x800000,

        [EnumLocal( "WT025", "Thrown" )]
        Thrown = 0x1000000,

        [EnumLocal( "WT026", "Trip" )]
        Trip = 0x2000000,

        [EnumLocal( "WT027", "Twin" )]
        Twin = 0x4000000,

        [EnumLocal( "WT028", "Two-Handed" )]
        TwoHanded = 0x8000000,

        [EnumLocal( "WT029", "Unarmed" )]
        Unarmed = 0x10000000,

        [EnumLocal( "WT030", "Versatile" )]
        Versatile = 0x20000000,

        [EnumLocal( "WT031", "Volley" )]
        Volley = 0x40000000
    }
}