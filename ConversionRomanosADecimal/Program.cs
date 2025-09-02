namespace ConversionRomanosADecimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("CONVERSOR DE NUMEROS ROMANOS A NUMEROS DECIMALES");
            Console.WriteLine();
            Console.Write("Ingrese un número romano: ");
            string romano = Console.ReadLine().ToUpper();

            try
            {
                int numeroDecimal = RomanoADecimal(romano);
                Console.WriteLine($"El número decimal es: {numeroDecimal}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
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

        static int RomanoADecimal(string romano)
        {
            int total = 0;
            int valorAnterior = 0;

            for (int i = romano.Length - 1; i >= 0; i--)
            {
                int valor = ValorRomano(romano[i]);

                if (valor < valorAnterior)
                {
                    total -= valor;
                } 
                else
                {
                    total += valor;
                    valorAnterior = valor;
                }
            }

            return total;
        }
    }
}
