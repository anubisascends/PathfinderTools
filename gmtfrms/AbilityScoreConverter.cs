using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace PathfinderTools.WPF {
    public class AbilityScoreConverter : IValueConverter {

        public object Convert( object value, Type targetType, object parameter, CultureInfo culture ) {
            byte ly_value = ( byte )value;
            int li_ret = ( int )Math.Floor( ( double )( ly_value - 10 ) / 2 );
            return (li_ret >= 0 ? "+" : "") + li_ret;
        }

        public object ConvertBack( object value, Type targetType, object parameter, CultureInfo culture ) => throw new NotImplementedException( );
    }
}
