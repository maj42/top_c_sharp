using System.Runtime.CompilerServices;

namespace homework_12_06._09
{
    public interface IPart
    {
        internal decimal Completeness {  get; set; }
        internal decimal Difficulty { get; init; }

        internal string ToString();
    }

    public interface IWorker
    {
        internal int Productivity { get; init; }
    }

    public interface IIndexer
    {
        IPart this[int index] { get; set; }
    }
}
