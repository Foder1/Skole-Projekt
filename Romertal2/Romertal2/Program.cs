using System;

namespace Romertal
{               
    class /*userInput? */program
    {
        static void Main(string[] args)
        {
            TextInput input = new TextInput();
            input.Add('1');
            input.Add('a');
            input.Add('0');
            Console.WriteLine(input.GetValue());
        }
    }
}
