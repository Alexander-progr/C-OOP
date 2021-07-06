using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using LabRab6.Models;

namespace LabRab6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IFigure> figures = new List<IFigure>();

            using (StreamReader fs = new StreamReader("input.txt"))
            {
                string[] temp = new string[2];
                while (true)
                {
                    temp = fs.ReadLine()?.Split();
                    if (temp == null) break;

                    figures.Add(
                        temp[0] switch
                        {
                            "H" => new Horse("horse", temp[1]),
                            "R" => new Rook("rook", temp[1])
                        }
                    );
                }
            }

            string pos = Console.ReadLine();
            Console.WriteLine(figures.All(f => f.CheckPos(pos)));
        }
    }
}