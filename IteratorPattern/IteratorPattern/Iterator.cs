namespace IteratorPattern
{
    public abstract class Iterator
    {
        protected Aggregate aggregate;

        public abstract void First();
        public abstract void Next();
        public abstract bool IsDone();
        public abstract string CurrentItem();
    }
}