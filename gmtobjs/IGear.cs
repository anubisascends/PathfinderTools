using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderTools {
    public interface IGear {
        
        string Title {
            get;
        }

        string Description {
            get;
        }

        float Cost {
            get;
        }

        string Bulk {
            get;
        }

        string Hands {
            get;
        }
    }
}
