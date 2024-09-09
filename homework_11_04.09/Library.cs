using System.Collections;

namespace homework_11_04._09
{
    internal class Library : IEnumerable
    {
        public List<Book> Books = [];

        public Library(params Book[] books) 
        {
            foreach (Book book in books) Books.Add(book);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Books.GetEnumerator();
            throw new NotImplementedException();
        }

        public void Sort(IComparer<Book>? cmp)
        {
            if (cmp != null) Books.Sort(cmp);
        }
    }
}
