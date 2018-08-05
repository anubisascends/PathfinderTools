using System;

namespace PathfinderTools.Globalization {

    /// <summary>
    /// Provides a way to add a localizable string to an enum field
    /// </summary>
    /// <seealso cref="System.Attribute" />
    public class EnumLocalAttribute : Attribute {
        string ms_default, ms_key;

        /// <summary>
        /// Initializes a new instance of the <see cref="EnumLocalAttribute"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        public EnumLocalAttribute( string key, string defaultValue ) {
            ms_default = defaultValue;
            ms_key = key;
        }

        /// <summary>
        /// Gets the key.
        /// </summary>
        /// <value>
        /// The key.
        /// </value>
        public string Key => ms_key;

        /// <summary>
        /// Gets the default.
        /// </summary>
        /// <value>
        /// The default.
        /// </value>
        public string Default => ms_default;
    }
}
