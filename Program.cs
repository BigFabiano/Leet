using System;

namespace Leet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Beep();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("╔═════════════════════╗");
            Console.WriteLine("╠  MODINHA DE HACKER  ╣");
            Console.WriteLine("╚═════╝ ¤¤¤¤¤¤ ╚══════╝");  
            Console.ForegroundColor = ConsoleColor.Green;    
            string textoDigitado = "Hackers usavam leet antes de virar modinha";
            Console.WriteLine(textoDigitado);
            string recebetexto = textoDigitado.Replace("a","4").Replace("e","3").Replace("i","1").Replace("o","0").Replace("t","7").Replace("s","5").Replace("A","4").Replace("E","3").Replace("I","1").Replace("O","0").Replace("T","7").Replace("S","5");
            Console.WriteLine(recebetexto);
            Console.ResetColor();
        }
    }
}
