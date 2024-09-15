namespace homework_14_11._09
{
    internal class Program
    {
        class Product
        {
            public decimal price { get; set; }
            public string name { get; set; }

            public Product(decimal price, string name)
            {
                this.price = price;
                this.name = name;
            }
        }

        class Student
        {
            public DateTime bdate { get; set; }
            public string name { get; set; }
        
            public Student(DateTime bdate, string name)
            {
                this.bdate = bdate;
                this.name = name;
            }
        }

        static void Main(string[] args)
        {
            //task 1
            int[] intArr = { 1, 2, 10, 12, 22, 34, 47, 55, 100 };
            var intQuery = from i in intArr
                        where (i > 10 && i < 50)
                        select i;
            Console.WriteLine("Integers more than 10 and less than 50:");
            intQuery.ToList<int>().ForEach(i => Console.Write(i + " "));
            Console.WriteLine("\n");

            //task 2
            string[] stringArr = { "Hello", "is", "this", "laundry?", "No", "this", "is", "Patrick" };
            var stringQuery = stringArr.OrderBy(i => i.Length).ThenBy(i => i.ToLower());
            Console.WriteLine("Strings sorted by length and alphabetically:");
            stringQuery.ToList<string>().ForEach(Console.WriteLine);
            Console.WriteLine("\n");

            //task 3
            Product[] products = [new Product(10.2M, "Vegetables"), new Product(15.5M, "Fruits")];
            Console.WriteLine("Product with max price:");
            Console.WriteLine(products.MaxBy(i => i.price)?.name);
            Console.WriteLine("\n");

            //task 4
            Student[] students = [new Student(new DateTime(2000, 9, 14), "Vasya"),
                                  new Student(new DateTime(2000, 9, 10), "Lena"),
                                  new Student(new DateTime(2002, 3, 30), "Kolya")];
            var studsQuery = from student in students
                             orderby student.bdate descending
                             group student by (Convert.ToInt32((DateTime.Now - student.bdate).TotalDays) / 365) into studentsGroup
                             select studentsGroup;
            foreach (IGrouping<int, Student> group in studsQuery)
            {
                Console.WriteLine($"Age: {group.Key}");
                foreach (Student student in group) 
                { 
                    Console.WriteLine("\t" + student.name);
                }
            }
        }
    }
}
