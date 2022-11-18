using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string t1, t2, t3, t4, t5;
            Console.WriteLine("Digite o nome do primeiro time: ");
            t1 = Console.ReadLine();
            Console.WriteLine("Digite o nome do segundoo time: ");
            t2 = Console.ReadLine();
            Console.WriteLine("Digite o nome do terceiro time: ");
            t3 = Console.ReadLine();
            Console.WriteLine("Digite o nome do quarto time: ");
            t4 = Console.ReadLine();
            Console.WriteLine("Digite o nome do quinto time: ");
            t5 = Console.ReadLine();

            Console.WriteLine("Os times escolhidos foram: " + t1 + ", " + t2 + ", " + t3 + ", " + t4 + ", " + t5 + ".");

            Console.WriteLine("Agora digite a pontuação dos times digitados: ");

            int pt1, pt2, pt3, pt4, pt5;

            Console.WriteLine("Digite o nome do " +t1+ " ?");
                pt1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome do " + t2 + " ?");
                pt2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome do " + t3 + " ?");
                pt3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome do " + t4 + " ?");
                pt4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome do " + t5 + " ?");
                pt5 = int.Parse(Console.ReadLine());

            Console.WriteLine("A pontuação dos times são:\n "+t1+": "+pt1+". \n "+t2+": "+pt2+". \n "+t3+": "+pt3+". \n "+t4+": "+pt4+". \n "+t5+": "+pt5+". " );
            Console.ReadKey();
        }
    }
}
