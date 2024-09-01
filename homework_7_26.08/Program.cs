using System;

namespace ConsoleApp8
{
    //    Разработать архитектуру классов иерархии товаров
    //при разработке системы управления потоками товаров для
    //дистрибьюторской компании.Прописать члены классов.
    //Создать диаграммы взаимоотношений классов.
    //Должны быть предусмотрены разные типы товаров,
    //в том числе:
    //• бытовая химия; + 
    //• продукты питания. +
    //Предусмотреть классы управления потоком товаров
    //(пришло, реализовано, списано, передано).

    abstract class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Product(string name, decimal price, int quantity)
        {
            Name = name; //имя
            Price = price; //цена
            Quantity = quantity; //количество
        }

        public abstract string GetProductType();

        public override string ToString()
        {
            return $"{GetProductType()}: {Name}, Цена: {Price}, Количество: {Quantity}";
        }
    }

    class HouseholdСhemicals : Product //бытовая химия
    {
        public string Compound { get; set; } //состав
        public HouseholdСhemicals(string name, decimal price, int quantity, string compound)
            : base(name, price, quantity)
        {
            Compound = compound;
        }
        public override string GetProductType()
        {
            return "Бытовая химия";
        }
        public override string ToString()
        {
            return base.ToString() + $", Состав: {Compound}";
        }

    }class ConstructionMaterials : Product
    {
        public string Type { get; set; }

        public ConstructionMaterials(string name, decimal price, int quantity, string Type)
            : base(name, price, quantity)
        {
            this.Type = Type;
        }
        public override string GetProductType()
        {
            return "Стройматериалы";
        }
        public override string ToString()
        {
            return base.ToString() + $", Тип: {Type}";
        }
    }

    class Food : Product
    {
        public DateTime ExpirationDate { get; set; } //срок годности
        public Food(string name, decimal price, int quantity, DateTime expirationDate) : base(name, price, quantity)
        {
            ExpirationDate = expirationDate;
        }

        public override string GetProductType()
        {
            return "Еда";
        }

        public override string ToString()
        {
            return base.ToString() + $"Годен до: {ExpirationDate:dd.MM.yyyy}";
        }
    }

    abstract class ProductFlow //поток товаров
    {
        public int Quantity { get; set; }
        public Product Product { get; set; }
        public DateTime Date { get; set; }

        public ProductFlow(int quantity, Product product)
        {
            Quantity = product.Quantity * quantity;
            Product = product;
            Date = DateTime.Now;
        }

        public abstract void Execute();

        public override string ToString()
        {
            return $"Товар: {Product.Name}, Количество: {Quantity}, Цена: {Product.Price}, Дата: {Date.ToShortDateString()}";
        }
    }

    class Arrival : ProductFlow
    {
        public string ToBranch { get; set; }

        public Arrival(int quantity, Product prod, string branch) : base(quantity, prod)
        {
            ToBranch = branch;
        }

        public override void Execute()
        {
            Console.WriteLine($"Прибыло: {this.ToString()}");
        }

        public override string ToString()
        {
            return $"{base.ToString()}, В отделение: {ToBranch}";
        }
    }

    class Sale : ProductFlow
    {
        public string Branch { get; set; }

        public Sale(int quantity, Product prod, string branch) : base(quantity, prod) {
            Branch = branch;    
        }

        public override void Execute()
        {
            Console.WriteLine($"Продано: {this.ToString()}");
        }

        public override string ToString()
        {
            return $"{base.ToString()}, В отделении: {Branch}";
        }
    }

    class Disposal : ProductFlow
    {
        public string Branch { get; set; }

        public Disposal(int quantity, Product prod, string branch) : base(quantity, prod) {
            Branch = branch;
        }

        public override void Execute()
        {
            Console.WriteLine($"Уничтожено: {this.ToString()}");
        }

        public override string ToString()
        {
            return $"{base.ToString()}, В отделении: {Branch}";
        }
    }

    class Transfer : ProductFlow
    {
        public string FromBranch {  get; set; } 
        public string ToBranch { get; set; }

        public Transfer(int quantity, Product prod, string FromBranch, string ToBranch) : base(quantity, prod) {
            this.FromBranch = FromBranch;
            this.ToBranch = ToBranch;
        }

        public override void Execute()
        {
            Console.WriteLine($"Перемещено: {this.ToString()}");
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Из отделения: {FromBranch}, В отделение: {ToBranch}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Product food = new Food("Сельдерей", 90, 10, new DateTime(2024, 10, 15));
            HouseholdСhemicals dosia = new HouseholdСhemicals("Дося", 100, 3, "Сода");
            ConstructionMaterials bricks = new ConstructionMaterials("Кирпич красный", 20, 500, "Кирпичи");

            ProductFlow[] actions =
            {
                new Arrival(15, food, "Магазин у Людочки"),
                new Sale(3, food, "Магазин у Людочки"),
                new Disposal(10, food, "Магазин у Людочки"),
                new Transfer(2, food, "Магазин у Людочки", "Магазин у Верочки")
            };
            foreach(ProductFlow action in actions) action.Execute();

            Console.ReadLine();
        }
    }
}
