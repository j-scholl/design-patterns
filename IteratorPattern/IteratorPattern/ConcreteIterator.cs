using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class StandardIterator : Iterator
    {
        int index;

        public StandardIterator(Aggregate agg)
        {
            aggregate = agg;
        }
        
        public override string CurrentItem()
        {
            return aggregate[index];
        }

        public override void First()
        {
            index = 0;
        }

        public override bool IsDone()
        {
            if (index >= aggregate.Count())
            {
                return true;
            }
            return false;
        }

        public override void Next()
        {
            index++;
        }
    }

    public class OtherIterator : Iterator
    {
        int index;

        public OtherIterator(Aggregate agg)
        {
            aggregate = agg;
        }

        public override string CurrentItem()
        {
            return aggregate[index];
        }

        public override void First()
        {
            index = 0;
        }

        public override bool IsDone()
        {
            if (index >= aggregate.Count())
            {
                return true;
            }
            return false;
        }

        public override void Next()
        {
            index += 3;
        }
    }

    public class SearchIterator : Iterator
    {
        int index;
        string searchText;

        public SearchIterator(Aggregate agg, string search)
        {
            aggregate = agg;
            searchText = search;
        }

        public override string CurrentItem()
        {
            return aggregate[index];
        }

        public override void First()
        {
            index = 0;
            while (index < aggregate.Count() && !aggregate[index].Contains(searchText) )
            {
                index++;
            }
        }

        public override bool IsDone()
        {
            if (index >= aggregate.Count())
            {
                return true;
            }
            return false;
        }

        public override void Next()
        {
            index++;
            while (index < aggregate.Count() && !aggregate[index].Contains(searchText))
            {
                index++;
            }
        }
    }
}
