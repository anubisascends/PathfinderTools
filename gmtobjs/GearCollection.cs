using PathfinderTools.Globalization;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderTools {
    public class GearCollection : ObservableCollection<IGear>, IGear {
        float mf_cost;
        string ms_title, ms_desc;

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
        }

        /// <summary>
        /// Gets the total cost.
        /// </summary>
        /// <value>
        /// The total cost.
        /// </value>
        public float TotalCost => getTotalCost( );

        /// <summary>
        /// Gets the bulk.
        /// </summary>
        /// <value>
        /// The bulk.
        /// </value>
        public string Bulk => getBulk( );

        /// <summary>
        /// Gets the hands.
        /// </summary>
        /// <value>
        /// The hands.
        /// </value>
        public string Hands => "-";

        /// <summary>
        /// Gets the group.
        /// </summary>
        /// <value>
        /// The group.
        /// </value>
        public string Group => getGroup( );

        float getTotalCost() => mf_cost + this.Sum( x => x.Cost );

        void setTitle( string value ) {
            ms_title = value;
            OnPropertyChanged( new PropertyChangedEventArgs( "Title" ) );
        }

        void setDescription( string value ) {
            ms_desc = value;
            OnPropertyChanged( new PropertyChangedEventArgs( "Description" ) );
        }

        void setCost( float value ) {
            mf_cost = value;
            OnPropertyChanged( new PropertyChangedEventArgs( "Cost" ) );
            OnPropertyChanged( new PropertyChangedEventArgs( "TotalCost" ) );
        }

        string getGroup() {
            string ls_ret = "Adventuring Gear";

            if ( Localization.TryGetString( "GG001", out string ls_value ) )
                ls_ret = ls_value;

            return ls_ret;
        }

        string getBulk() {
            float lf_bulk = 0f;

            foreach ( IGear lo_gear in this ) {
                if ( float.TryParse( lo_gear.Bulk, out float lf_result ) ) {
                    lf_bulk += lf_bulk;
                } else {
                    if ( lo_gear.Bulk.Equals( "L" ) )
                        lf_bulk += .1f;
                }
            }

            return ( int )lf_bulk + "";
        }

        protected override void InsertItem( int index, IGear item ) {
            base.InsertItem( index, item );
            item.PropertyChanged += item_PropertyChanged;
            OnPropertyChanged( new PropertyChangedEventArgs( "TotalCost" ) );
            OnPropertyChanged( new PropertyChangedEventArgs( "Bulk" ) );
        }

        protected override void RemoveItem( int index ) {
            IGear lo_item = this [ index ];
            base.RemoveItem( index );
            lo_item.PropertyChanged -= item_PropertyChanged;

            OnPropertyChanged( new PropertyChangedEventArgs( "TotalCost" ) );
            OnPropertyChanged( new PropertyChangedEventArgs( "Bulk" ) );
        }

        protected override void ClearItems() {
            foreach ( IGear lo_item in this ) {
                lo_item.PropertyChanged -= item_PropertyChanged;
            }

            base.ClearItems( );

            OnPropertyChanged( new PropertyChangedEventArgs( "Bulk" ) );
            OnPropertyChanged( new PropertyChangedEventArgs( "TotalCost" ) );
        }

        protected override void SetItem( int index, IGear item ) {
            base.SetItem( index, item );

            OnPropertyChanged( new PropertyChangedEventArgs( "Bulk" ) );
            OnPropertyChanged( new PropertyChangedEventArgs( "TotalCost" ) );
        }

        void item_PropertyChanged( object sender, PropertyChangedEventArgs e ) {
            if ( e.PropertyName == "Cost" )
                OnPropertyChanged( new PropertyChangedEventArgs( "TotalCost" ) );
            else if ( e.PropertyName == "Bulk" )
                OnPropertyChanged( new PropertyChangedEventArgs( "Bulk" ) );
        }
    }
}
