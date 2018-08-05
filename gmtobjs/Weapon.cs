namespace PathfinderTools {

    /// <summary>
    /// Provides a way to handle a single weapon
    /// </summary>
    /// <seealso cref="PathfinderTools.Gear" />
    /// <seealso cref="PathfinderTools.IGear" />
    public class Weapon : Gear, IGear{
        string ms_damage, ms_reload, ms_range;
        WeaponTraits me_traits;
        WeaponGroup me_group;

        /// <summary>
        /// Gets or sets the range.
        /// </summary>
        /// <value>
        /// The range.
        /// </value>
        public string Range {
            get => ms_range;
            set => setRange( value );
        }

        /// <summary>
        /// Gets or sets the reload.
        /// </summary>
        /// <value>
        /// The reload.
        /// </value>
        public string Reload {
            get => ms_reload;
            set => setReload( value );
        }

        /// <summary>
        /// Gets or sets the damage.
        /// </summary>
        /// <value>
        /// The damage.
        /// </value>
        public string Damage {
            get => ms_damage;
            set => setDamage( value );
        }

        /// <summary>
        /// Gets or sets the traits.
        /// </summary>
        /// <value>
        /// The traits.
        /// </value>
        public WeaponTraits Traits {
            get => me_traits;
            set => setTraits( value );
        }

        /// <summary>
        /// Gets or sets the weapon group.
        /// </summary>
        /// <value>
        /// The weapon group.
        /// </value>
        public WeaponGroup weaponGroup {
            get => me_group;
            set => setWeaponGroup( value );
        }

        void setRange( string value ) {
            ms_range = value;
            OnPropertyChanged( "Range" );
        }

        void setReload( string value ) {
            ms_reload = value;
            OnPropertyChanged( "Reload" );
        }

        void setWeaponGroup( WeaponGroup value ) {
            me_group = value;
            OnPropertyChanged( "WeaponGroup" );
        }

        void setTraits( WeaponTraits value ) {
            me_traits = value;
            OnPropertyChanged( "Traits" );
        }

        void setDamage( string value ) {
            ms_damage = value;
            OnPropertyChanged( "Damage" );
        }
    }
}
