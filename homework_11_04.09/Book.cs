using System.Collections;

namespace homework_11_04._09
{
    public class Book : IComparable<Book>
    {
        public required string Title { get; init; }
        public required string Author { get; init; }
        public required string Year { get; init; }

        [System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute]
        public Book (string title, string author, string year)
        {
            Title = title;
            Author = author;
            Year = year;
        }

        public int CompareTo(Book? obj)
        {
            if (obj is Book)
            {
                return Year.CompareTo(obj.Year);
            }
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"\"{Title}\" by {Author} - {Year}";
        }

        public class BookComparer : IComparer<Book>
        {
            public int Compare(Book? x, Book? y)
            {
                if (x is Book && y is Book)
                {
                    return x.Title.CompareTo(y.Title);
                }
                throw new NotImplementedException();
            }
        }
    }

}
