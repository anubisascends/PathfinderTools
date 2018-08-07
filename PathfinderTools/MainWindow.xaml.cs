using System;
using System.Collections.Generic;
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

namespace PathfinderTools {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        Campaign mo_campaign;

        public MainWindow() {
            InitializeComponent( );
            mo_campaign = new Campaign( );
            m_tracker.Characters = mo_campaign.Characters;
            mo_campaign.Characters.Add( new Character( ) );
        }

        private void AddCharacter_Click( object sender, RoutedEventArgs e ) {
            mo_campaign.Characters.Add( new Character( ) { Title = "New Character" } );
        }
    }
}
