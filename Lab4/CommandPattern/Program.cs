using System;
using System.Numerics;

// Complete the sample task based on:
// https://pierresimondelaplace.gitlab.io/wsb-zaawansowane-techniki-obiektowe/WSB_ZaawansowaneTechnikiObiektowe.pdf

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var character = new Character();
            MoveCommand up = new MoveCommand(character, new Vector3(0f, 1f, 0f));
            //...

            character.Move(up);
            Console.WriteLine(character.ToString());

            //...

            Console.ReadLine();
        }
    }
}
