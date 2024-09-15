using System.Globalization;

namespace homework_15_13._09
{
    internal class Program
    {
        class BankruptException : ApplicationException
        {
            public BankruptException() { }
            public BankruptException(string message) : base(message) { }
            public BankruptException(string message, Exception inner) : base(message, inner) { }
        }

        class Money
        {
            public int cents { get; set; }

            public Money(double money)
            {
                if (money < 0) throw new BankruptException("You are a bankrupt");
                this.cents = Convert.ToInt32(money * 100);
            }

            public override string ToString()
            {
                return (cents / 100.00).ToString("C", CultureInfo.GetCultureInfo("en-us")); 
            }

            public static Money operator + (Money a, Money b)
            {
                return new Money((a.cents + b.cents) / 100.00);
            }

            public static Money operator -(Money a, Money b)
            {
                return new Money((a.cents - b.cents) / 100.00);
            }

            public static Money operator /(Money a, int b)
            {
                if (b == 0) throw new DivideByZeroException();
                return new Money(a.cents / b / 100.00);
            }

            public static Money operator *(Money a, int b)
            {
                return new Money(a.cents * b / 100.00);
            }

            public static Money operator ++(Money money)
            {
                money.cents++;
                return money;
            }

            public static Money operator --(Money money)
            {
                money.cents--;
                if (money.cents < 0) throw new BankruptException("You are a bankrupt");
                return money;
            }

            public static bool operator ==(Money a, Money b)
            {
                return a.cents == b.cents;
            }

            public static bool operator !=(Money a, Money b)
            {
                return a.cents != b.cents;
            }

            public override bool Equals(object? obj)
            {
                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (ReferenceEquals(obj, null))
                {
                    return false;
                }

                throw new NotImplementedException();
            }

            public override int GetHashCode()
            {
                return (int)cents;
                throw new NotImplementedException();
            }
        }
        static void Main(string[] args)
        {
            Money sum1 = new(15.43);
            Money sum2 = new(12);
            Money sum3 = new(3.43);
            Console.WriteLine(sum1 == sum2);
            Console.WriteLine(sum1 - sum3 == sum2);
            Console.WriteLine(sum1 - sum2 - sum3);
            Console.WriteLine(sum2 / 3 * 10);
            try 
            { 
                Console.WriteLine(sum2 - sum1);
            }
            catch (BankruptException e) 
            { 
                Console.WriteLine(e.Message); 
            }

            try
            {
                while (true) sum2--;
            }
            catch (BankruptException e) 
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
