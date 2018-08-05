using System.ComponentModel;

namespace PathfinderTools {

    /// <summary>
    /// Defines the properties and events that all gera items must implement
    /// </summary>
    public interface IGear : INotifyPropertyChanged {

        /// <summary>
        /// Gets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        string Title {
            get;
        }

        /// <summary>
        /// Gets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        string Description {
            get;
        }

        /// <summary>
        /// Gets the cost.
        /// </summary>
        /// <value>
        /// The cost.
        /// </value>
        float Cost {
            get;
        }

        /// <summary>
        /// Gets the bulk.
        /// </summary>
        /// <value>
        /// The bulk.
        /// </value>
        string Bulk {
            get;
        }

        /// <summary>
        /// Gets the hands.
        /// </summary>
        /// <value>
        /// The hands.
        /// </value>
        string Hands {
            get;
        }

        /// <summary>
        /// Gets the group.
        /// </summary>
        /// <value>
        /// The group.
        /// </value>
        string Group {
            get;
        }
    }
}
