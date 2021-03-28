using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sql___trener
{
    class DBConnection
    {
        public static SQLEntities Entities { get; } = new SQLEntities();
    }
}
