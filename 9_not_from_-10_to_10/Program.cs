namespace _9_not_from__10_to_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вводится число. Вывести «Да», если оно попадает в диапазон [-10,10], и «Нет» в противном случае.");
            Console.WriteLine("Введите число\n");

            int dig1 = Convert.ToInt32(Console.ReadLine());

            if (dig1 <= -10 || dig1 >= 10) Console.WriteLine("\nДа");
            else Console.WriteLine("\nНет");

            Console.WriteLine("\nPress any key to quit");
            Console.ReadKey();
        }
    }
}