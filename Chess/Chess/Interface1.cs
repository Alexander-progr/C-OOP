using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public interface IFigure
    {
        string Name { get; set; }
        string Pos { get; set; }
        bool CheckPos(string Pos);
    }
}
