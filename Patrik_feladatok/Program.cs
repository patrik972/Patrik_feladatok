using System.ComponentModel.Design;

namespace Patrik_feladatok
{
    internal class Program
    {
        static Random r = new Random();

        static int[] tomb = new int[5];
        static void F05()
        {
            Console.WriteLine("Kérem adjon meg 5 számot amit beletehetek a tömbbe");
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (var item in tomb)
            {
                Console.Write(item + " ");
            }
            ;
        }
        static void F14()
        {
            Console.WriteLine("Kérek egy egész számot");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] tombocske = new int[n];
            Console.WriteLine("Milyen intervallumból töltsük fel a tömböt?(Az első szám -a- legyen kisebb mint a -b-!)");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int kisebb = Math.Min(a, b);
            int nagyobb = Math.Max(a, b);
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = r.Next(a, b);
            }
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write($"{i + 1}. {tomb[i]}\n");
            }
            string m;
            do
            {
                Console.WriteLine("Hogyan kívánja fojtatni a programot?(ha -a- betut nyom növeli a tomben levő számokat ha -b- csökkent ha -c- szoroz ha -k- kilép)");
                m = Convert.ToString(Console.ReadLine());
                switch (m)
                {
                    case "a":
                        Novelni();
                        break; 
                    case "b":
                        Csokkenteni();
                        break;
                    case "c":
                        Szorozni();
                        break;
                }
            } while (m != "k");

        }
        static void Novelni()
        {
            Console.Write("Mennyivel növeljem: ");
            int mennyivel = Convert.ToInt32(Console.ReadLine()); //100
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] += mennyivel;
            }
        }
        static void Csokkenteni()
        {
            Console.Write("Mennyivel csökkentsem: ");
            int mennyivel = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] -= mennyivel;
            }
        }
        static void Szorozni()
        {
            Console.Write("Mennyivel szorozzam: ");
            int mennyivel = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] *= mennyivel;
            }
        }
        static void Main(string[] args)
        {
            //F05();
            F14();
        }
    }
}
