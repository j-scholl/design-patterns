using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class ConcreteAggregate : Aggregate
    {
        public override Iterator CreateIterator()
        {
            return new StandardIterator(this);
        }

        public Iterator CreateOtherIterator()
        {
            return new OtherIterator(this);
        }
    }
}
