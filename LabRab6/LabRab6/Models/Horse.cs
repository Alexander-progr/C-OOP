using System;

namespace LabRab6.Models
{
    public class Horse : IFigure
    {
        public Horse(string name, string pos)
        {
            Name = name;
            Pos = pos;
        }
        public string Name { get; set; }
        public string Pos { get; set; }

        public bool CheckPos(string pos) => !(
            (Math.Abs(pos[0] - Pos[0]) == 1 && Math.Abs(pos[1] - Pos[1]) == 2) ||
            (Math.Abs(pos[1] - Pos[1]) == 1 && Math.Abs(pos[0] - Pos[0]) == 2) ||
            pos == Pos
        );
    }
}