using System;
using ComplexDIY = homework_9_30._08.Complex;

namespace homework_9_30._08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector vec1 = new Vector(1, 1);
            Vector vec2 = vec1 / 2;
            Vector vec3 = vec1 + vec2;
            Vector vec4 = vec3 - vec2;
            vec1++;
            vec2--;
            Console.WriteLine($"{vec1}\n{vec2}\n{vec3}\n{vec4}");

            // Мама, можно нам "Complex"?
            {
                System.Numerics.Complex z = new System.Numerics.Complex(1F, 1F);
                System.Numerics.Complex z1;
                z1 = z - (z * z * z - 1) / (3 * z * z);
                Console.WriteLine("z1 = {0}", z1);
            }

            // Нет, у нас есть "Complex" дома.
            // "Complex" дома:
            {
                ComplexDIY z = new ComplexDIY(1, 1);
                ComplexDIY z1;
                z1 = z - (z * z * z - 1) / (3 * z * z);
                Console.WriteLine("z1 = {0}", z1);
            }
        }
    }
}
