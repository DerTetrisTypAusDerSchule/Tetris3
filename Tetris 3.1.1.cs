using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n1 = Öffnet eine unbestimmte Anzahl an Chrome Fenster ohne zu stoppen");
            Console.WriteLine("\n2 = Öffnet eine vorher festgelegte Anzahl an Chromes");
            Console.WriteLine("\n3 = Öffnet eine vorher festgelegte Zeit lang Tabs");
            Console.WriteLine("\n4 = Öffnet eine vorher festgelegte Anzahl an Tabs");
            Console.WriteLine("\n5 = Öffnet Tabs ohne zu stoppen(crasht meistens den Browser)");
            Console.Write("\n\nWähle eine der Varianten: ");
            int num;
            try
            {
                num = Convert.ToInt32(Console.ReadLine());



                if (num != 1 && num != 2 && num != 3 && num != 4 && num != 5)
                {
                    while (num != 1 && num != 2 && num != 3 && num != 4 && num != 5)
                    {
                        Console.WriteLine("Das war eine ungültige Zahl.");
                        Console.Write("Wähle eine der oben genannten Varianten: ");
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

                else if (num == 3)
                {
                    Console.Write("Bitte gib an, wie lang sich neue Tabs öffnen sollen(in Sekunden): ");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Bist du sicher, dass du das tun möchtest ? ('y' für ja oder 'n' für nein) ");
                    string yn = Console.ReadLine();
                    if (yn == "y")
                    {
                        DateTime start = DateTime.Now;

                        while (DateTime.Now.Subtract(start).Seconds < num2)
                        {
                            System.Diagnostics.Process.Start("https://www.google.com/");
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
                else if (num == 4)
                {
                    Console.Write("Bitte gib an, wie viele tabs du öffnen möchtest: ");
                    int num2 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Bist du sicher, dass du das tun möchtest ? ('y' für ja oder 'n' für nein) ");
                    string yn = Console.ReadLine();
                    if (yn == "y")
                    {

                        for (int i = 1; i <= num2; i++)
                        {
                            System.Diagnostics.Process.Start("https://www.google.com/");
                            Console.Write("Es wurden ");
                            Console.Write(i);
                            Console.WriteLine(" Tabs geöffnet.");
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
                else if (num == 5)
                {
                    Console.Write("Bist du sicher, dass du das tun möchtest? ('y' für ja oder 'n' für nein) ");
                    string yn = Console.ReadLine();
                    if (yn == "y")
                    {
                        while (true)
                        {
                            System.Diagnostics.Process.Start("https://www.google.com/");
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
            }
            catch (FormatException)
            {
                string error = ("Programm schließt sich in kürze...");
                Console.WriteLine("Du musst eine ganze Zahl eingeben. Weder einen Buchstaben, noch eine Dezimalzahl.");
                System.Threading.Thread.Sleep(500);

                for (int o = 0; o < error.Length; o++)
                {
                    Console.Write(error[o]);
                    System.Threading.Thread.Sleep(50);
                }
                System.Threading.Thread.Sleep(500);
                Environment.Exit(-1);
            };
            Console.ReadLine();
        }
    }

}
