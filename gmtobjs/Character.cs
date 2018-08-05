using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderTools {
    public class Character : INotifyPropertyChanged {

        byte my_str;
        GearCollection mo_gear;

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets or sets the strength.
        /// </summary>
        /// <value>
        /// The strength.
        /// </value>
        public byte Strength {
            get => my_str;
            set => setStrength( value );
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

        void setGear( GearCollection value ) {
            mo_gear = value;
            OnPropertyChanged( "Gear" );
        }

        void setStrength( byte value ) {
            my_str = value;
            OnPropertyChanged( "Strength" );
        }

        /// <summary>
        /// Called when the value of a property has changed.
        /// </summary>
        /// <param name="propertyName">Name of the property.</param>
        protected virtual void OnPropertyChanged( string propertyName ) => PropertyChanged?.Invoke( this, new PropertyChangedEventArgs( propertyName ) );
    }
}
