using System.Collections;

namespace homework_12_06._09
{
    public class House : IEnumerable, IIndexer
    {
        public IPart[] parts;
        public bool Complete { get; set; }

        public House() 
        {
            parts = new IPart[] { new Basement(), new Walls(), new Doors(), new Window(), new Window(), new Roof() };
            Complete = false;
        }

        public IPart this[int index] 
        { 
            get => parts[index];
            set 
            {
                parts[index] = value;
            }
        }

        public IEnumerator GetEnumerator()
        {
            return parts.GetEnumerator();
        }
    }
}
