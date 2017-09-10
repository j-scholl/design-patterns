using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public abstract class Aggregate : List<string>
    {
        public abstract Iterator CreateIterator();
    }
}
