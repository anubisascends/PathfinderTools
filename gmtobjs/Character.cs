using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderTools {
    public class Character : INotifyPropertyChanged {

        byte [ ] my_abilities = new byte [ 6 ];
        GearCollection mo_gear;
        string ms_title, ms_player;
        byte my_ac, my_touch, my_cmd, my_init, my_flat;
        int mi_hp;

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public string Title {
            get => ms_title;
            set => setTitle( value );
        }

        /// <summary>
        /// Gets or sets the player.
        /// </summary>
        /// <value>
        /// The player.
        /// </value>
        public string Player {
            get => ms_player;
            set => setPlayer( value );
        }

        /// <summary>
        /// Gets or sets the armor class.
        /// </summary>
        /// <value>
        /// The armor class.
        /// </value>
        public byte ArmorClass {
            get => my_ac;
            set => setArmorClass( value );
        }

        /// <summary>
        /// Gets or sets the touch armor class.
        /// </summary>
        /// <value>
        /// The touch armor class.
        /// </value>
        public byte TouchArmorClass {
            get => my_touch;
            set => setTouchArmorClass( value );
        }

        /// <summary>
        /// Gets or sets the command.
        /// </summary>
        /// <value>
        /// The command.
        /// </value>
        public byte CMD {
            get => my_cmd;
            set => setCMD( value );
        }

        /// <summary>
        /// Gets or sets the initiative modifier.
        /// </summary>
        /// <value>
        /// The initiative modifier.
        /// </value>
        public byte InitiativeModifier {
            get => my_init;
            set => setInitiativeModifier( value );
        }

        /// <summary>
        /// Gets or sets the flat footed armor class.
        /// </summary>
        /// <value>
        /// The flat footed armor class.
        /// </value>
        public byte FlatFootedArmorClass {
            get => my_flat;
            set => setFlatFootedArmorClass( value );
        }

        /// <summary>
        /// Gets or sets the hit points.
        /// </summary>
        /// <value>
        /// The hit points.
        /// </value>
        public int HitPoints {
            get => mi_hp;
            set => setHitPoints( value );
        }

        /// <summary>
        /// Gets or sets the strength.
        /// </summary>
        /// <value>
        /// The strength.
        /// </value>
        public byte Strength {
            get => my_abilities[0];
            set => setAbility( "Strength", value );
        }

        /// <summary>
        /// Gets or sets the dexterity.
        /// </summary>
        /// <value>
        /// The dexterity.
        /// </value>
        public byte Dexterity {
            get => my_abilities [ 1 ];
            set => setAbility( "Dexterity", value );
        }

        /// <summary>
        /// Gets or sets the constitution.
        /// </summary>
        /// <value>
        /// The constitution.
        /// </value>
        public byte Constitution {
            get => my_abilities [ 2 ];
            set => setAbility( "Constitution", value );
        }

        /// <summary>
        /// Gets or sets the intelligence.
        /// </summary>
        /// <value>
        /// The intelligence.
        /// </value>
        public byte Intelligence {
            get => my_abilities [ 3 ];
            set => setAbility( "Intelligence", value );
        }

        /// <summary>
        /// Gets or sets the wisdom.
        /// </summary>
        /// <value>
        /// The wisdom.
        /// </value>
        public byte Wisdom {
            get => my_abilities [ 4 ];
            set => setAbility( "Wisdom", value );
        }

        /// <summary>
        /// Gets or sets the charisma.
        /// </summary>
        /// <value>
        /// The charisma.
        /// </value>
        public byte Charisma {
            get => my_abilities [ 5 ];
            set => setAbility( "Charisma", value );
        }

        /// <summary>
        /// Gets or sets the gear.
        /// </summary>
        /// <value>
        /// The gear.
        /// </value>
        public GearCollection Gear {
            get => mo_gear;
            set => setGear( value );
        }

        void setArmorClass( byte value ) {
            my_ac = value;
            OnPropertyChanged( "ArmorClass" );
        }

        void setTouchArmorClass( byte value ) {
            my_touch = value;
            OnPropertyChanged( "TouchArmorClass" );
        }

        void setFlatFootedArmorClass( byte value ) {
            my_flat = value;
            OnPropertyChanged( "FlatFootedArmorClass" );
        }

        void setCMD( byte value ) {
            my_cmd = value;
            OnPropertyChanged( "CMD" );
        }

        void setGear( GearCollection value ) {
            mo_gear = value;
            OnPropertyChanged( "Gear" );
        }

        void setAbility( string ability, byte value ) {
            switch ( ability ) {
                case "Dexterity":
                    my_abilities [ 1 ] = value;
                    break;
                case "Constitution":
                    my_abilities [ 2 ] = value;
                    break;
                case "Intelligence":
                    my_abilities [ 3 ] = value;
                    break;
                case "Wisdom":
                    my_abilities [ 4 ] = value;
                    break;
                case "Charisma":
                    my_abilities [ 5 ] = value;
                    break;
                default:
                    my_abilities [ 0 ] = value;
                    
                    break;
            }

            OnPropertyChanged( ability );
        }

        void setTitle( string value ) {
            ms_title = value;
            OnPropertyChanged( "Title" );
        }

        void setPlayer( string value ) {
            ms_player = value;
            OnPropertyChanged( "Player" );
        }

        void setInitiativeModifier( byte value ) {
            my_init = value;
            OnPropertyChanged( "InitiativeModifier" );
        }

        void setHitPoints( int value ) {
            mi_hp = value;
            OnPropertyChanged( "HitPoints" );
        }

        /// <summary>
        /// Called when the value of a property has changed.
        /// </summary>
        /// <param name="propertyName">Name of the property.</param>
        protected virtual void OnPropertyChanged( string propertyName ) => PropertyChanged?.Invoke( this, new PropertyChangedEventArgs( propertyName ) );
    }
}
