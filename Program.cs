using System;

namespace Fatorial
{
    class Fatorial
    {
        //variaveis
        public long num, fatorial;
        //construtor
        public Fatorial (long numEntrada)
        {
            num = numEntrada;
            fatorial = 1;
        }
        //metodo
        public double Calcular()
        {
            while (num > 1)
            {
                fatorial = fatorial * num;
                num = num - 1;
            }
            return fatorial;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // obtenção dos dados e construção do objecto
            Console.Write("Numero: ");
            Fatorial fatorial = new Fatorial(long.Parse(Console.ReadLine()));
            //apresentação do resultado
            Console.WriteLine("Fatorial: " + fatorial.Calcular());
            Console.ReadLine();
        }
    }
}
