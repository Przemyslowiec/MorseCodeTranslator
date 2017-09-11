using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCodeGenerator
{
    class morse_code_translator
    {
        private Dictionary<string,string> morse_code;
        private string translated_text;

      public  morse_code_translator()
        {
            morse_code = new Dictionary<string, string>();
            morse_code.Add("a",".-");
            morse_code.Add("b","-...");
            morse_code.Add("c","-.-.");
            morse_code.Add("d","-..");
            morse_code.Add("e",".");
            morse_code.Add("f","..-.");
            morse_code.Add("g","__.");
            morse_code.Add("h","....");
            morse_code.Add("i", "..");
            morse_code.Add("j",".___");
            morse_code.Add("k", "-.-");
            morse_code.Add("l",".-..");
            morse_code.Add("m", "__");
            morse_code.Add("n","-.");
            morse_code.Add("o","---");
            morse_code.Add("p",".--.");
            morse_code.Add("q","--.-");
            morse_code.Add("r",".-.");
            morse_code.Add("s","...");
            morse_code.Add("t","-");
            morse_code.Add("u","..-");
            morse_code.Add("v","...-");
            morse_code.Add("w",".--");
            morse_code.Add("x","-..-");
            morse_code.Add("y","-.--");
            morse_code.Add("z","--..");
            morse_code.Add("ą",".-.-");
            morse_code.Add("ć","-.-..");
            morse_code.Add("ę","..-..");
            morse_code.Add("ch","----");
            morse_code.Add("ł",".-..-");
            morse_code.Add("ń","--.--");
            morse_code.Add("ó","---.");
            morse_code.Add("ś","...-...");
            morse_code.Add("ż","--..-.");
            morse_code.Add("ź","--..-");
            morse_code.Add("1",".----");
            morse_code.Add("2","..---");
            morse_code.Add("3","...--");
            morse_code.Add("4","....-");
            morse_code.Add("5",".....");
            morse_code.Add("6","-....");
            morse_code.Add("7","--...");
            morse_code.Add("8","---..");
            morse_code.Add("9","----.");
            morse_code.Add("0","-----");
            morse_code.Add(".",".-.-.-");
            morse_code.Add(",","--..--");
            morse_code.Add("'",".----.");
            morse_code.Add("\"",".-..-.");
            morse_code.Add("-", "..--.-");
            morse_code.Add(":","---...");
            morse_code.Add(";","-.-.-.");
            morse_code.Add("?", "..--..");
            morse_code.Add("!", "-.-.--");
            morse_code.Add("+", ".-.-.");
            morse_code.Add("/", "-..-.");
            morse_code.Add("(", "-.--.");
            morse_code.Add(")", "-.--.-");
            morse_code.Add("=", "-...-");
            morse_code.Add("@", ".--.-.");
        }

        public StringBuilder translate(string input)
        {
            StringBuilder to_return = new StringBuilder();
            input = input.ToLower();
            for(int i=0; i<input.Length; i++)
            {
                if(morse_code.ContainsKey(input[i].ToString())==true)
                {
                    to_return.Append(morse_code[input[i].ToString()]);
                }
                else
                {
                    to_return.Append(input[i]);
                }
            }

            translated_text = to_return.ToString(); 
            return to_return;
        }
    }
}
