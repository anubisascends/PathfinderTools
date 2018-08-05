using System.Collections.Generic;
using System.IO;

namespace PathfinderTools.Globalization {

    /// <summary>
    /// Provides easy localization for the Pathfinder tools app
    /// </summary>
    public static class Localization {
        static readonly string ms_folderpath = ".\\Languages";
        static readonly string ms_defaultvalue = "<String Not Found>";

        /// <summary>
        /// Tries to get the string with the given key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        /// <param name="culture">The culture.</param>
        /// <returns>True if the string was found, otherwise, false</returns>
        public static bool TryGetString( string key, out string value, string culture = "en-US" ) {
            value = ms_defaultvalue;
            string [ ] ls_lines = getLines( culture );

            foreach ( string ls_line in ls_lines ) {
                if ( ls_line.StartsWith(key)) {
                    value = ls_line.Replace( key, "" ).Remove( 0, 1 );
                    break;
                }
            }

            return !value.Equals( ms_defaultvalue );
        }

        /// <summary>
        /// Tries to the get all of the groups with the given prefix.
        /// </summary>
        /// <param name="prefix">The prefix.</param>
        /// <param name="values">The values.</param>
        /// <param name="culture">The culture.</param>
        /// <returns>True if any groups were found, otherwise false</returns>
        public static bool TryGetGroups( string prefix, out string [ ] values, string culture = "en-US" ) {
            values = new string [ 0 ];
            string [ ] ls_lines = getLines( culture );
            List<string> ls_ret = new List<string>( );

            foreach ( string ls_line in ls_lines ) {
                if ( ls_line.StartsWith( prefix ) ) {
                    ls_ret.Add( ls_line.Substring( 6, ls_line.Length - 6 ) );
                }
            }

            values = ls_ret.ToArray( );
            return ls_ret.Count > 0;
        }

        static string [ ] getLines( string culture = "en-US" ) {
            string ls_filePath = ms_folderpath + "\\" + culture + ".lng";
            string [ ] ls_lines = File.ReadAllLines( ls_filePath );
            string [ ] ls_ret = new string [ ls_lines.Length - 3 ];

            for ( int i = 3; i < ls_lines.Length; i++ ) {
                ls_ret [ i - 3 ] = ls_lines [ 3 ];
            }

            return ls_ret;
        }
    }
}
