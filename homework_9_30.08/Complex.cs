using System;

namespace homework_9_30._08
{
    internal class Complex
    {
        public double real { get; set; }
        public double imaginary { get; set; }

        public Complex() {
            real = 0;
            imaginary = 0;
        }

        public Complex(double real, double imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        public static Complex operator -(Complex a, Complex b)
        {
            return new Complex(a.real - b.real, a.imaginary - b.imaginary);
        }

        public static Complex operator -(Complex a, double b)
        {
            return new Complex(a.real - b, a.imaginary);
        }

        public static Complex operator *(Complex a, Complex b)
        {
            return new Complex(a.real * b.real - a.imaginary * b.imaginary, a.imaginary * b.real + a.real * b.imaginary);
        }

        public static Complex operator *(double a, Complex b)
        {
            return new Complex(a * b.real, a * b.imaginary);
        }

        public static Complex operator *(Complex a, double b)
        {
            return b * a;
        }

        public static Complex operator /(Complex a, Complex b)
        {
            return new Complex((a.real * b.real + a.imaginary * b.imaginary) / (b.real * b.real + b.imaginary * b.imaginary),
                                (a.imaginary * b.real - a.real * b.imaginary) / (b.real * b.real + b.imaginary * b.imaginary));
        }

        public override string ToString()
        {
            return $"{real} + {imaginary}i";
        }
    }
}
