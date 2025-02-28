namespace _6_even_or_not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вводится число. Вывести «Да», если оно четное, и «Нет» в противном случае.");
            Console.WriteLine("Введите число\n");
            // дабл или инт? по условию число, скорее всего инт
            int dig1 = Convert.ToInt32(Console.ReadLine());

            if (dig1 % 2 == 0) Console.WriteLine("\nДа");
            else Console.WriteLine("\nНет");

            Console.WriteLine("\nPress any key to quit");
            Console.ReadKey();
        }
    }
}