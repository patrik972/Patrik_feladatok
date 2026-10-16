namespace Patrik_feladatok
{
    internal class Program
    {
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
        static void Main(string[] args)
        {
            F01();
        }
    }
}
