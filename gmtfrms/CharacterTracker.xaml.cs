using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PathfinderTools.WPF {
    /// <summary>
    /// Interaction logic for CharacterTracker.xaml
    /// </summary>
    public partial class CharacterTracker : UserControl {
        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterTracker"/> class.
        /// </summary>
        public CharacterTracker() {
            InitializeComponent( );
            m_characterList.Items.Clear( );
        }

        /// <summary>
        /// Gets or sets the characters.
        /// </summary>
        /// <value>
        /// The characters.
        /// </value>
        public ObservableCollection<Character> Characters {
            get => ( ObservableCollection<Character> )GetValue( CharactersProperty );
            set => setCharacters( value );
        }

        // Using a DependencyProperty as the backing store for Characters.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CharactersProperty =
            DependencyProperty.Register( "Characters", typeof( ObservableCollection<Character> ), typeof( CharacterTracker ), new PropertyMetadata( new ObservableCollection<Character>() ) );

        void setCharacters( ObservableCollection<Character> value ) {
            SetValue( CharactersProperty, value );
            m_characterList.ItemsSource = Characters;
        }

        void listItemRemove_Click( object sender, RoutedEventArgs e ) {
            Character lo_character = ( ( Button )sender ).Tag as Character;
            string ls_message = "Are you sure you want to remove {0}?\r\nThis cannot be undone!";
            string ls_title = "Confirm Delete";
            string ls_value = string.Empty;

            if ( Globalization.Localization.TryGetString( "DT001", out ls_value ) ) {
                ls_message = ls_value;
            }

            if ( Globalization.Localization.TryGetString( "DT002", out ls_value ) ) {
                ls_title = ls_value;
            }

            ls_message = string.Format( ls_message, lo_character.Title );

            MessageBoxResult le_result = MessageBox.Show( ls_message, ls_title, MessageBoxButton.YesNo, MessageBoxImage.Exclamation );

            if ( le_result == MessageBoxResult.Yes ) {
                Characters.Remove( lo_character );
            }

        }
    }
}
