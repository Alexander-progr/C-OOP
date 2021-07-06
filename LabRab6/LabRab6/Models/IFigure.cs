namespace LabRab6.Models
{
    public interface IFigure
    {
        string Name { get; set; }
        string Pos { get; set; }
        bool CheckPos(string pos);
    }
}

