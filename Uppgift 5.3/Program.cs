using System;

namespace Uppgift_5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] frågor = new string[4];
            string[] svar = new string[4];
            string svaret = "";

            frågor[0] = "Vad heter Norges huvudstad?";
            frågor[1] = "Vilken är Norges tredje största stad?";
            frågor[2] = "Vad är Norges största inkomstkälla?";
            frågor[3] = "Vad heter Norges kung?";
            svar[0] = "Oslo";
            svar[1] = "Trondheim";
            svar[2] = "Olja";
            svar[3] = "Harald";

            Console.WriteLine("Välj ett tal mellan 1-4");
            int val = int.Parse(Console.ReadLine());
            int valIndex = val - 1;
            switch(valIndex)
            {
                case 0:
                    {
                        Console.WriteLine(frågor[0]);
                        svaret = Console.ReadLine();
                        if (svaret == svar[0])
                            Console.WriteLine("Du svarade rätt!!!");
                        else
                            Console.WriteLine($"Du svarade fel svaret var {svar[0]}.");
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine(frågor[1]);
                        svaret = Console.ReadLine();
                        if (svaret == svar[1])
                            Console.WriteLine("Du svarade rätt!!!");
                        else
                            Console.WriteLine($"Du svarade fel svaret var {svar[1]}.");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine(frågor[2]);
                        svaret = Console.ReadLine();
                        if (svaret == svar[2])
                            Console.WriteLine("Du svarade rätt!!!");
                        else
                            Console.WriteLine($"Du svarade fel svaret var {svar[2]}.");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine(frågor[3]);
                        svaret = Console.ReadLine();
                        if (svaret == svar[3])
                            Console.WriteLine("Du svarade rätt!!!");
                        else
                            Console.WriteLine($"Du svarade fel svaret var {svar[3]}.");
                        break;
                    }
                default:
                    Console.WriteLine("Du angav inget gilltigt alternativ.");
                    break;
            }

            Console.ReadKey();
        }
    }
}