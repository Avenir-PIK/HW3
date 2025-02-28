namespace _10_n_houses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Застройщик построил n домов. Вывести фразу «Мы построили n домов», обеспечив правильное согласование числа со словом «дом», например: 20 — «Мы построили 20 домов», 32 — «Мы построили 32 дома», 41 — «Мы построили 41 дом»");
            Console.WriteLine("Введите число\n");

            int dig1 = Convert.ToInt32(Console.ReadLine());

            if (dig1 <= -10 || dig1 >= 10) Console.WriteLine("\nДа");
            else Console.WriteLine("\nНет");

            Console.WriteLine("\nPress any key to quit");
            Console.ReadKey();
        }
    }
}