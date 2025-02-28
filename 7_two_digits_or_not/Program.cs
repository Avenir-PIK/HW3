namespace _7_two_digits_or_not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вводится число. Вывести «Да», если оно двухзначное, и «Нет» в противном случае.");
            Console.WriteLine("Введите число\n");

            int dig1 = Convert.ToInt32(Console.ReadLine());

            if (dig1 / 10 >= 1 && dig1 / 10 < 10) Console.WriteLine("\nДа");
            else Console.WriteLine("\nНет");

            Console.WriteLine("\nPress any key to quit");
            Console.ReadKey();
        }
    }
}