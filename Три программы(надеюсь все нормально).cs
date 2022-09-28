using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Выберите программу, которую вы хотите запустить \r\n1. Угадай число\r\n2. Таблица умножения\r\n3. Вывод делителей числа\r\n4. Выйти из программы");
Console.WriteLine("Введите операцию: ");
int programma =Convert.ToInt32(Console.ReadLine());
while (programma != 4)
{
    if (programma == 1)
    {
        Random rand = new Random();
        int chislotwo = rand.Next(100);
        int chislo;
        int vveli;
        vveli =  Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Вы выбрали игру угадай число");
        vveli =  Convert.ToInt32(Console.ReadLine());
        do
        {
            
            chislo = Convert.ToInt32(Console.ReadLine());

            if (chislo < vveli)
            {
                Console.WriteLine("загаданное число меньше вашего");
            }
            if (chislo > vveli)
            {
                Console.WriteLine("загаданное число больше вашего");
            }
        } while (vveli == chislo);
        Console.WriteLine("Победа");
    }
    else if (programma == 2)
    {
        int maximal = 9;
        for (int i = 1; i <= maximal; i++)
        {
            Console.WriteLine();
            for (int j = 1; j <= maximal; j++)
            {
                Console.Write("{0} ", i * j);
            }
        }
        Console.ReadKey();

    }
    else if (programma == 3)
    {
        Console.WriteLine("Введите число");
        int ChisloP3 = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i * i <= ChisloP3; i++)
        {
            if (ChisloP3 % i == 0)
                Console.WriteLine(i);
        }
        Console.WriteLine(ChisloP3);
    }
    Console.WriteLine("Вы в главном меню,выберите ваше следующее действие");
    programma = Convert.ToInt32(Console.ReadLine());
}