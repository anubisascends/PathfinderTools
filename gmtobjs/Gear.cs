using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderTools {

    /// <summary>
    /// Provides a way to handle a simple piece of gear
    /// </summary>
    /// <seealso cref="PathfinderTools.IGear" />
    public class Gear : IGear {
        string ms_title, ms_desc, ms_hands,
            ms_bulk, ms_group;
        float mf_cost;

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
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description {
            get => ms_desc;
            set => setDescription( value );
        }

        /// <summary>
        /// Gets or sets the cost.
        /// </summary>
        /// <value>
        /// The cost.
        /// </value>
        public float Cost {
            get => mf_cost;
            set => setCost( value );
        }

        /// <summary>
        /// Gets or sets the bulk.
        /// </summary>
        /// <value>
        /// The bulk.
        /// </value>
        public string Bulk {
            get => ms_bulk;
            set => setBulk( value );
        }

        /// <summary>
        /// Gets or sets the hands.
        /// </summary>
        /// <value>
        /// The hands.
        /// </value>
        public string Hands {
            get => ms_hands;
            set => setHands( value );
        }

        /// <summary>
        /// Gets or sets the group.
        /// </summary>
        /// <value>
        /// The group.
        /// </value>
        public string Group {
            get => ms_group;
            set => setGroup( value );
        }

        void setTitle( string value ) {
            ms_title = value;
            OnPropertyChanged( "Title" );
        }

        void setDescription( string value ) {
            ms_desc = value;
            OnPropertyChanged( "Description" );
        }

        void setCost( float value ) {
            mf_cost = value;
            OnPropertyChanged( "Cost" );
        }

        void setBulk( string value ) {
            ms_bulk = value;
            OnPropertyChanged( "Bulk" );
        }

        void setHands( string value ) {
            ms_hands = value;
            OnPropertyChanged( "Hands" );
        }

        void setGroup( string value ) {
            ms_group = value;
            OnPropertyChanged( "Group" );
        }

        /// <summary>
        /// Called when the value of a property has changed.
        /// </summary>
        /// <param name="propertyName">Name of the property that has changed.</param>
        protected virtual void OnPropertyChanged( string propertyName ) => PropertyChanged?.Invoke( this, new PropertyChangedEventArgs( propertyName ) );
    }
}
