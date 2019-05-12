using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("!ACHTUNG!");
            Console.WriteLine("\n!DU SOLLTEST DIE GANZE ZEIT TASK-MANAGER GEÖFFNET HABEN UND BEREIT SEIN DAS PROGRAMM ZU BEENDEN!\n");
            Console.WriteLine("\nDies ist ein Programm, welches Google Chrome extrem oft öffnen wird.");
            Console.WriteLine("\nDu kannst dich zwischen zwei variationen entscheiden. Entweder wird sich Chrome immer und immer wieder öffnen ohne zu \nstoppen(1)(dies kann eventuell den Computer zum crashen bringen), oder du gibst an, wie oft sich Chrome maximal öffnen \nsoll(2).");
            Console.Write("Wähle entweder 1 oder 2: ");
            int num;
            try
            {
                num = Convert.ToInt32(Console.ReadLine());



                if (num != 1 && num != 2)
                {
                    while (num != 1 && num != 2)
                    {
                        Console.WriteLine("Das war eine ungültige Zahl.");
                        Console.Write("Wähle entweder 1 oder 2: ");
                        num = Convert.ToInt32(Console.ReadLine());
                    }
                }
                if (num == 1)
                {
                    Console.Write("Bist du sicher, dass du das tun möchtest? ('y' für ja oder 'n' für nein) ");
                    string yn = Console.ReadLine();
                    if (yn == "y")
                    {
                        while (true)
                        {
                            System.Diagnostics.Process.Start("chrome.exe");
                        }
                    }
                    else if (yn == "n")
                    {
                        Console.Write("Programm schließt sich in kürze");
                        for (int o = 0; o <= 5; o++)
                        {
                            Console.Write(".");
                            System.Threading.Thread.Sleep(100);
                        }
                        Environment.Exit(-1);
                    }
                }
                else if (num == 2)
                {
                    Console.Write("Bitte gib an, wie oft sich Chrome öffnen soll: ");
                    int num2 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Bist du sicher, dass du das tun möchtest ? ('y' für ja oder 'n' für nein) ");
                    string yn = Console.ReadLine();
                    if (yn == "y")
                    {

                        for (int i = 1; i <= num2; i++)
                        {
                            System.Diagnostics.Process.Start("chrome.exe");                       
                            Console.Write("Chrome wurde ");
                            Console.Write(i);
                            Console.WriteLine(" mal geöffnet.");                          
                        }
                        System.Threading.Thread.Sleep(3000);
                        Environment.Exit(-1);
                    }
                    else if (yn == "n")
                    {
                        Console.Write("Programm schließt sich in kürze");
                        for (int o = 0; o <= 5; o++)
                        {
                            Console.Write(".");
                            System.Threading.Thread.Sleep(100);
                        }
                        Environment.Exit(-1);
                    }

                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Du musst eine ganze Zahl eingeben. Weder einen Buchstaben, noch eine Dezimalzahl.");
                System.Threading.Thread.Sleep(3000);
                Environment.Exit(-1);
            };
            Console.ReadLine();
        }
    }
}
