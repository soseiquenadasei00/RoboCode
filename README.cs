using System;

namespace Robocode
{
    class Program
    {
        static void Main()
        {
            int part;
            Console.WriteLine("Bem vindo AI4G!!!");
            Console.WriteLine("Irá participar do ROBOCODE???Se sim digite 1 se não digite 0");

            part = int.Parse(Console.ReadLine());

            if (part==1)
                {
                Console.WriteLine("OHHH NICEE SO LET´S GO TO THE RULES");
                Console.WriteLine("An arena of AI controlled tank bots");
                Console.WriteLine("Wins the last standing bot");
                Console.WriteLine("Bots programmed in Java or C#");
                Console.WriteLine("Teams of one to two programmers");
                Console.WriteLine("Teams must be registered in the AI4G School");
                Console.WriteLine(" Tournament will be by single elimination playoffs, best of three battles");
                Console.WriteLine("Teams can be declassified if they use external code"); }

            if (part==0)
            {
                Console.WriteLine("Aserio?? Não faças isso, será um evento incrível, pensa mais um bocadinho...");
            }
            
        }
    }
}
