namespace ConversionRomanosADecimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        static int ValorRomano(char c)
        {
            if (c == 'I') return 1;
            if (c == 'V') return 5;
            if (c == 'X') return 10;
            if (c == 'L') return 50;
            if (c == 'C') return 100;
            if (c == 'D') return 500;
            if (c == 'M') return 1000;

            throw new ArgumentException("Carácter romano inválido");
        }
    }
}
