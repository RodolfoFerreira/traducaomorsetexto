using System;

namespace MorseToText
{
    class Program
    {
        public static void Main(string[] args)
        {
            string text = new TraducaoMorseText("EXEMPLO DE TEXTO A SER CONVERTIDO").traduzMorse();
            Console.Write(text);
            Console.ReadKey();
        }

    }
}