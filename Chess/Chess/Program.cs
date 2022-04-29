using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Program
    {
        static void Main()
        {
            string FigPos = Console.ReadLine();
            Horse horse = new Horse();
            Rook rook = new Rook();

            string text = "";

            using (StreamReader fs = new StreamReader(@"chess.txt"))
            {
                while (true)
                {
                    // Читаем строку из файла во временную переменную.
                    string temp = fs.ReadLine();

                    // Если достигнут конец файла, прерываем считывание.
                    if (temp == null) break;

                    // Пишем считанную строку в итоговую переменную.
                    text += temp+" ";
                }
            }

            List<IFigure> lst = new List<IFigure>() { };

            string[] text2 = text.Split(' ');

            for (int i = 0; i < text2.Length; i += 2)
            {
                if (text2[i] == "R")
                {
                    rook.Pos = text2[i + 1];
                    rook.Name = text2[i];

                    lst.Add(rook);
                    if (!rook.CheckPos(FigPos))
                    {
                        Console.WriteLine(false);
                        Console.ReadLine();
                        return;  
                    }
                }

                if (text2[i] == "H")
                {

                    horse.Pos = text2[i + 1];
                    horse.Name = text2[i];

                    lst.Add(horse);
                    if(horse.CheckPos(FigPos) == false)
                    {
                        Console.WriteLine(false);
                        Console.ReadLine();
                        return;
                    }
                }
            }

            Console.WriteLine(true);
            Console.ReadLine();


        }

    }
}
