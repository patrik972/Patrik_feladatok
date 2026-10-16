namespace Patrik_feladatok
{
    internal class Program
    {
        static Random r = new Random();

        static int[] tomb = new int[5];
        static void F01()
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
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = r.Next(a, b);
            }
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write($"{i + 1}.{tomb[i]}--");
            }
            ;

        }
        static void Main(string[] args)
        {
            //F01();
            F14();
        }
    }
}
