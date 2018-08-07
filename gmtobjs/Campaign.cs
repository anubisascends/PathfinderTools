using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PathfinderTools {
    public class Campaign : DependencyObject {
        /// <summary>
        /// Gets or sets the characters.
        /// </summary>
        /// <value>
        /// The characters.
        /// </value>
        public ObservableCollection<Character> Characters {
            get => ( ObservableCollection<Character> )GetValue( CharactersProperty );
            set => SetValue( CharactersProperty, value );
        }

        // Using a DependencyProperty as the backing store for Characters.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CharactersProperty =
            DependencyProperty.Register( "Characters", typeof( ObservableCollection<Character> ), typeof( Campaign ), new PropertyMetadata( new ObservableCollection<Character>() ) );
    }
}
