namespace _12_name_the_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // коммент для видимости в пулл реквесте
            Console.WriteLine("Дано целое число в диапазоне 100–999. Вывести строку-описание данного числа, например: 256 — «двести пятьдесят шесть», 814 — «восемьсот четырнадцать». Если пользователь введёт данные не соответствующие условию задачи - выдать сообщение об ошибке.\r\n\r\nНеобходимо решить задачи в");
            Console.WriteLine("Введите число\n");

            int dig = Convert.ToInt32(Console.ReadLine());

            if (dig < 100 || dig > 999) Console.WriteLine("\nВведено некорректное число\nВ следующий раз введите трехзначное");
            else
            {
                int dig_1 = dig / 100;
                int dig_2 = (dig / 10) % 10;
                int dig_3 = dig % 10;

                string dig_1str = "";
                string dig_2str = "";
                string dig_3str = "";
                string allgid = "";

                switch (dig_1)
                {
                    case 1: dig_1str = "Сто"; break;
                    case 2: dig_1str = "Двести"; break;
                    case 3: dig_1str = "Триста"; break;
                    case 4: dig_1str = "Четыреста"; break;
                    case 5: dig_1str = "Пятьсот"; break;
                    case 6: dig_1str = "Шестьсот"; break;
                    case 7: dig_1str = "Семьсот"; break;
                    case 8: dig_1str = "Восемьсот"; break;
                    case 9: dig_1str = "Девятьсот"; break;
                }
                switch (dig_2)
                {
                    case 1:
                        {
                            switch (dig_3)
                            {
                                case 1: dig_2str = "одинадцать"; break;
                                case 2: dig_2str = "двенадцать"; break;
                                case 3: dig_2str = "тринадцать"; break;
                                case 4: dig_2str = "четырнадцать"; break;
                                case 5: dig_2str = "пятьнадцать"; break;
                                case 6: dig_2str = "шестьнадцать"; break;
                                case 7: dig_2str = "семьнадцать"; break;
                                case 8: dig_2str = "восемьнадцать"; break;
                                case 9: dig_2str = "девятьнадцать"; break;
                                case 0: dig_2str = "десять"; break;
                            }; break;
                        }
                    case 2: dig_2str = "двадцать"; break;
                    case 3: dig_2str = "тридцать"; break;
                    case 4: dig_2str = "сорок"; break;
                    case 5: dig_2str = "пятьдесят"; break;
                    case 6: dig_2str = "шестьдесят"; break;
                    case 7: dig_2str = "семьдесят"; break;
                    case 8: dig_2str = "восемьдесят"; break;
                    case 9: dig_2str = "девяносто"; break;
                    case 0: dig_2str = ""; break;
                }
                switch (dig_3)
                {
                    case 1: dig_3str = "один"; break;
                    case 2: dig_3str = "два"; break;
                    case 3: dig_3str = "три"; break;
                    case 4: dig_3str = "четыре"; break;
                    case 5: dig_3str = "пять"; break;
                    case 6: dig_3str = "шесть"; break;
                    case 7: dig_3str = "семь"; break;
                    case 8: dig_3str = "восемь"; break;
                    case 9: dig_3str = "девять"; break;
                    case 0: dig_3str = ""; break;
                }

                // собираем в одну строку.

                if (dig_2 == 1) allgid = dig_1str + " " + dig_2str;
                else if (dig_2 == 0) allgid = dig_1str + " " + dig_3str;
                else allgid = dig_1str + " " + dig_2str + " " + dig_3str;

                Console.WriteLine("\n{0}", allgid);
                Console.ReadKey();
            }
        }
    }
}