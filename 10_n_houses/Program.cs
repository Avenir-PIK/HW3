namespace _10_n_houses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // коммент для видимости в пулл реквесте
            Console.WriteLine("Застройщик построил n домов. Вывести фразу «Мы построили n домов», обеспечив правильное согласование числа со словом «дом», например: 20 — «Мы построили 20 домов», 32 — «Мы построили 32 дома», 41 — «Мы построили 41 дом»");
            Console.WriteLine("Введите число домов\n");

            int dig1 = Convert.ToInt32(Console.ReadLine());
            string domov = "дом";
            int lastdig = dig1 % 10;

            switch (lastdig)
            {
                case 0:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    domov = "домов";
                    break;
                case 2:
                case 3:
                case 4:
                    domov = "дома";
                    break;
            }

            Console.WriteLine("\nМы построили {0} " + domov, dig1);
            Console.WriteLine("\nPress any key to quit");
            Console.ReadKey();
        }
    }
}