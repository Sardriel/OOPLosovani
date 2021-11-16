using System;

namespace OOPLosovani
{
    class Program
    {
        static void Main(string[] args)
        {
            Losovac losovac = new Losovac();
            Console.WriteLine("Vítejte v programu losování.");
            char volba = '0';
            while (volba != '3')
            { 
                Console.WriteLine("1 - Losovat další číslo");
                Console.WriteLine("2 - Vypsat čísla");
                Console.WriteLine("3 - Konec");
                volba = Console.ReadKey().KeyChar;
                Console.WriteLine();
                switch(volba)
                {
                    case '1':
                        Console.WriteLine("Padlo číslo: {0}", losovac.Losuj());
                        break;
                    case '2':
                        Console.WriteLine("Padla čísla: {0}", losovac.Vypis());
                        break;
                    case '3':
                        Console.WriteLine("Děkuji za použití programu.");
                        break;
                    default:
                        Console.WriteLine("Neplatná volba, zadejte prosím znovu");
                        break;
                }
            }
        }
    }
}
