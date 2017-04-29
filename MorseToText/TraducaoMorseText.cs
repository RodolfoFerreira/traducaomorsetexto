using System.Collections.Generic;

namespace MorseToText
{
    class TraducaoMorseText
    {
        private static SortedList<string, string> listaCaracteres = new SortedList<string, string>();

        private string Msg { get; set; }

        public TraducaoMorseText(string msg)
        {
            Msg = msg;
            montaListaAlfabeto();
        }

        public string traduzMorse() => traduzTexto();

        private string traduzTexto()
        {
            string txtTexto = "";
            string valor = "";
            string texto = "";

            if (verificaTextoMorse())
            {
                foreach (var item in Msg)
                {
                    if (item.ToString() != " ")
                    {
                        valor += item.ToString();
                    }
                    else
                    {
                        listaCaracteres.TryGetValue(valor, out texto);
                        txtTexto += texto;
                        valor = "";
                    }
                }
            }
            else
            {
                foreach (var item in Msg)
                {
                    if (item.ToString() == "." || item.ToString() == "-" || item.ToString() == "/")
                        listaCaracteres.TryGetValue(@"\" + item.ToString(), out texto);
                    else
                        listaCaracteres.TryGetValue(item.ToString(), out texto);

                    txtTexto += texto;
                }
            }
            return txtTexto;
        }

        private bool verificaTextoMorse()
        {
            int morse = 0;

            foreach (var item in Msg)
            {
                morse = (item.ToString() != "." && item.ToString() != "-" && item.ToString() != "/" && item.ToString() != " ") ? 0 : 1;
                if (morse == 0)
                    break;
            }

            return morse == 1;
        }

        private void montaListaAlfabeto()
        {
            //-- Carrega lista com os caracteres do alfabeto como chave e o respectivo morse como valor
            listaCaracteres.Add("A", ".- ");
            listaCaracteres.Add("B", "-... ");
            listaCaracteres.Add("C", "-.-. ");
            listaCaracteres.Add("D", "-.. ");
            listaCaracteres.Add("E", ". ");
            listaCaracteres.Add("F", "..-. ");
            listaCaracteres.Add("G", "--. ");
            listaCaracteres.Add("H", ".... ");
            listaCaracteres.Add("I", ".. ");
            listaCaracteres.Add("J", ".--- ");
            listaCaracteres.Add("K", "-.- ");
            listaCaracteres.Add("L", ".-.. ");
            listaCaracteres.Add("M", "-- ");
            listaCaracteres.Add("N", "-. ");
            listaCaracteres.Add("O", "--- ");
            listaCaracteres.Add("P", ".--. ");
            listaCaracteres.Add("Q", "--.- ");
            listaCaracteres.Add("R", ".-. ");
            listaCaracteres.Add("S", "... ");
            listaCaracteres.Add("T", "- ");
            listaCaracteres.Add("U", "..- ");
            listaCaracteres.Add("V", "...- ");
            listaCaracteres.Add("W", ".-- ");
            listaCaracteres.Add("X", "-..- ");
            listaCaracteres.Add("Y", "-.-- ");
            listaCaracteres.Add("Z", "--.. ");
            listaCaracteres.Add("0", "----- ");
            listaCaracteres.Add("1", ".---- ");
            listaCaracteres.Add("2", "..--- ");
            listaCaracteres.Add("3", "...-- ");
            listaCaracteres.Add("4", "....- ");
            listaCaracteres.Add("5", "..... ");
            listaCaracteres.Add("6", "-.... ");
            listaCaracteres.Add("7", "--... ");
            listaCaracteres.Add("8", "---.. ");
            listaCaracteres.Add("9", "----. ");
            listaCaracteres.Add(@"\.", ".-.-.- ");
            listaCaracteres.Add(",", "--..-- ");
            listaCaracteres.Add(":", "---... ");
            listaCaracteres.Add("?", "..--.. ");
            listaCaracteres.Add("=", "-...- ");
            listaCaracteres.Add(@"\-", "-....- ");
            listaCaracteres.Add("(", "-.--. ");
            listaCaracteres.Add(")", "-.--.- ");
            listaCaracteres.Add("\"",".-..-. ");
            listaCaracteres.Add("\'", ".----. ");
            listaCaracteres.Add(@"\/", "-..-. ");
            listaCaracteres.Add("@", ".--.-. ");
            listaCaracteres.Add(" ", "/ ");

            //-- Carrega lista com os caracteres em morse como chave e o respectivo caractere literal como valor
            listaCaracteres.Add(".-", "A");
            listaCaracteres.Add("-...", "B");
            listaCaracteres.Add("-.-.", "C");
            listaCaracteres.Add("-..", "D");
            listaCaracteres.Add(".", "E");
            listaCaracteres.Add("..-.", "F");
            listaCaracteres.Add("--.", "G");
            listaCaracteres.Add("....", "H");
            listaCaracteres.Add("..", "I");
            listaCaracteres.Add(".---", "J");
            listaCaracteres.Add("-.-", "K");
            listaCaracteres.Add(".-..", "L");
            listaCaracteres.Add("--", "M");
            listaCaracteres.Add("-.", "N");
            listaCaracteres.Add("---", "O");
            listaCaracteres.Add(".--.", "P");
            listaCaracteres.Add("--.-", "Q");
            listaCaracteres.Add(".-.", "R");
            listaCaracteres.Add("...", "S");
            listaCaracteres.Add("-", "T");
            listaCaracteres.Add("..-", "U");
            listaCaracteres.Add("...-", "V");
            listaCaracteres.Add(".--", "W");
            listaCaracteres.Add("-..-", "X");
            listaCaracteres.Add("-.--", "Y");
            listaCaracteres.Add("--..", "Z");
            listaCaracteres.Add("-----", "0");
            listaCaracteres.Add(".----", "1");
            listaCaracteres.Add("..---", "2");
            listaCaracteres.Add("...--", "3");
            listaCaracteres.Add("....-", "4");
            listaCaracteres.Add(".....", "5");
            listaCaracteres.Add("-....", "6");
            listaCaracteres.Add("--...", "7");
            listaCaracteres.Add("---..", "8");
            listaCaracteres.Add("----.", "9");
            listaCaracteres.Add(".-.-.-", ".");
            listaCaracteres.Add("--..--", ",");
            listaCaracteres.Add("---...", ":");
            listaCaracteres.Add("..--..", "?");
            listaCaracteres.Add("-...-", "=");
            listaCaracteres.Add("-....-", "-");
            listaCaracteres.Add("-.--.", "(");
            listaCaracteres.Add("-.--.-", ")");
            listaCaracteres.Add(".-..-.", "\"");
            listaCaracteres.Add(".----.", "\'");
            listaCaracteres.Add("-..-.", "/");
            listaCaracteres.Add(".--.-.", "@");
            listaCaracteres.Add("/", " ");
        }
    }
}