using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double Resultado, Raio, H;

            Console.Write("Digite o raio da circunferencia: ");
            Raio = Convert.ToSingle(Console.ReadLine());
            Console.Write("Digite o a altura da circunferencia: ");
            H = Convert.ToSingle(Console.ReadLine());

            Raio = Raio * Raio;
            Resultado = 3.14 * Raio * H;

            Console.Write("O Volume é de: {0}", Resultado);
            Console.ReadKey();


           






        }
    }
}
