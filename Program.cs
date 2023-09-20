namespace Problema02_sem05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static double CalcularPotencia(double baseNum, int exponente)
            {
                if (exponente == 0)
                    return 1;
                double resultado = 1;
                for (int i = 1; i <= Math.Abs(exponente); i++)
                {
                    resultado *= baseNum;
                }
                if (exponente < 0)
                {
                    resultado = 1 / resultado;
                }
                return resultado;
            }
            static void Main()
            {
                Console.Write("Ingrese la base: ");
                double baseNum = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ingrese el exponente: ");
                int exponente = Convert.ToInt32(Console.ReadLine());
                double resultado = CalcularPotencia(baseNum, exponente);
                Console.WriteLine($"Resultado: {resultado}");
            }
        }
        
        }
    }
