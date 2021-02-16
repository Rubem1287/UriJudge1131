using System;

namespace Uri1131
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, vI, vG, e, x, c;
            x = 0;
            c = 0;
            vI = 0;
            vG = 0;
            e = 0;
            while (x != 2)
            {
                c += +1;
                x = 0;
                string[] vetor = Console.ReadLine().Split(' ');
                a = int.Parse(vetor[0]);
                b = int.Parse(vetor[1]);
                Console.Write("Novo Grenal? (1-sim 2-não)");
                x = int.Parse(Console.ReadLine());

                if (a > b)
                {
                    vI += +1;
                }
                else if (b > a)
                {
                    vG += +1;
                }
                else if (a == b)
                {
                    e += 1;
                }

            }


            Console.WriteLine();
            Console.WriteLine(c+" Grenais");
            Console.WriteLine();
            Console.WriteLine("Inter : "+vI);
            Console.WriteLine();
            Console.WriteLine("Gremio : "+vG);
            Console.WriteLine();
            Console.WriteLine("Empates : "+e);

            if (vI > vG)
            {
                Console.WriteLine();
                Console.WriteLine("Inter venceu mais");
            }
            else if (vG > vI)
            {
                Console.WriteLine();
                Console.WriteLine("Gremio venceu mais");
            }
            else if (e >vI && e > vG)
            {
                Console.WriteLine();
                Console.WriteLine("Teve mais empates");
            }


        }
    }
}
