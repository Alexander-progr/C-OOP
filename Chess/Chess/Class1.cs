using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Horse : IFigure
    {        
        readonly List<Char> letters = new List<Char> {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
        readonly List<Char> numbers = new List<Char> { '1', '2', '3', '4', '5', '6', '7', '8' };
        public string Pos { get; set; }
        public string Name { get; set; }

        public bool CheckPos(string Pos1)
        {
            int x = letters.FindIndex(i => i == Pos[0]);  // буква 
            int y = numbers.FindIndex(i => i == Pos[1]); // цифра 
            if ((Math.Abs(letters.FindIndex(i => i == Pos1[0]) - x) == 2 & Math.Abs(numbers.FindIndex(i => i == Pos1[1]) - y) == 1) ||
                (Math.Abs(letters.FindIndex(i => i == Pos1[0]) - x) == 1 & Math.Abs(numbers.FindIndex(i => i == Pos1[1]) - y) == 2))
            {
                return false;
            }
            return true;
        }

    }


    public class Rook : IFigure
    {
        public string Pos { get; set; }
        public string Name { get; set; }

        public bool CheckPos(string Pos1)
        {
            char x = Pos[0];  // буква 
            char y = Pos[1]; // цифра 
            if (Pos1[0] != x & Pos1[1] != y)
            {
                return true;
            }
            else
            {
                return false; 
            };
        }

    }
}
