namespace homework_11_04._09
{
    internal class Program
    {
        static void Main(string[] args) { 
            // IComparable (by year)
            Book book1 = new Book("1984", "George Orwell", "1948");
            Book book2 = new Book("The Lord of the Rings", "J.R.R. Tolkien", "1954");
            Book book3 = new Book("Lord of the Flies", "William Golding", "1954");

            Console.WriteLine(book1.CompareTo(book2) == 0);
            Console.WriteLine(book2.CompareTo(book3) == 0);
            Console.WriteLine();

            // IComparer (by title)
            Book book4 = new Book("Paradise Lost", "J. Milton", "1667");
            Book book5 = new Book("Paradise Lost", "G. Milton", "2008");
            Console.WriteLine(book4.CompareTo(book5) == 0);
            Console.WriteLine();

            // IEnumerable
            Library lib = new Library(book1, book2, book3, book4, book5);
            lib.Sort(new Book.BookComparer());
            foreach (Book book in lib) Console.WriteLine(book);
            Console.WriteLine();

            // ICloneable
            Student std1 = new Student("Vasya", 123);
            Student std2 = (Student)std1.Clone();
            Student std3 = (Student)std1.Clone();
            
            std2.Name = "Kolya";
            std2.Id = 234;
            std3.Name = "Masha";
            std3.Id = 345;

            foreach (Student student in new Student[] { std1, std2, std3 }) Console.WriteLine(student);
        }
    }
}
