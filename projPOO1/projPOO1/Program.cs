using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projPOO1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            inverteTela();
            Soma s;
            //s = new Soma();
            s = new Soma(7,8);

            s.setN1(5);
            s.setN2(6);
            //s.calcular();
            Console.WriteLine("A soma de {0} com {1} é {2}", 
                s.getN1(), s.getN2(), s.getResultado());
        }

        static void inverteTela()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
        }
    }
}
