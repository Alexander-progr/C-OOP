using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Chess
    {
        public string Pos { get; set; }
        public string Name { get; set; }
        public virtual bool CheckPos(string pos)
        {
            return false;
        }
    }

    public class Horse : Chess
    {        
        public override bool CheckPos(string pos)
        {
            if (Math.Abs(pos[0] - Pos[0]) == 2 & Math.Abs(pos[1] - Pos[1]) == 1 ||
                Math.Abs(pos[0] - Pos[0]) == 1 & Math.Abs(pos[1] - Pos[1]) == 2)
            {
                return false;
            }
            return true;
        }

    }


    public class Rook : Chess
    {
        public override bool CheckPos(string pos)
        {
            if (pos[0] != Pos[0] & pos[1] != Pos[1])
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
