namespace LabRab6.Models
{
    public class Rook : IFigure
    {
        public Rook(string name, string pos)
        {
            Name = name;
            Pos = pos;
        }
        public string Name { get; set; }
        public string Pos { get; set; }
        public bool CheckPos(string pos) => !(
            pos[0] == Pos[0] ||
            pos[1] == Pos[1] ||
            pos == Pos
        );
    }
}
