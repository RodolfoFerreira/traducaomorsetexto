using System;

namespace MorseToText
{
    class Program
    {
        public static void Main(string[] args)
        {
            string text = new TraducaoMorseText(". -..- . -- .--. .-.. --- / -.-. --- -- / .- -.-. . -. - --- ---... / .... .- / ..- -- .- / .-.. ..- .- / -... . -- / -... --- -. .. - .- / -. --- / -.-. . ..- / .- -. .- --- --..-- / -.-. --- -.-. .-").traduzMorse();
            Console.Write(text);
            Console.ReadKey();
        }

    }
}