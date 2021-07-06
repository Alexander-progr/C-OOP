using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Task_1();
            Console.ReadLine();
        }
        public static void Task_1()
        {
            string Stud = Properties.Resources.students;
            string[] linesStud = Stud.Split('\n');
            char[] seps = new char[] { ' ', '\t', '|', ';' };
            var Students = linesStud
                .Skip(1)
                .Select(line => new Student(Int32.Parse(line.Split(seps)[0]), line.Split(seps)[1], char.Parse(line.Split(seps)[2]), Int32.Parse(line.Split(seps)[3]), Int32.Parse(line.Split(seps)[4]), Int32.Parse(line.Split(seps)[5]), Int32.Parse(line.Split(seps)[6])))
                .Where(item => item.Sex == 'м')
                .OrderBy(item => item.NameStudent);
            foreach (var item in Students)
                Console.WriteLine($"{item.Sex}\t{item.NameStudent}");
        }
        public static void Task_2()
        {
            string Direct = Properties.Resources.directions;
            string Stud = Properties.Resources.students;
            string[] linesStud = Stud.Split('\n');
            string[] linesDir = Direct.Split('\n');
            char[] seps = new char[] { ' ', '\t', '|', ';' };
            var Students = linesStud
                .Skip(1)
                .Select(line => new Student(Int32.Parse(line.Split(seps)[0]), line.Split(seps)[1], char.Parse(line.Split(seps)[2]), Int32.Parse(line.Split(seps)[3]), Int32.Parse(line.Split(seps)[4]), Int32.Parse(line.Split(seps)[5]), Int32.Parse(line.Split(seps)[6])));
            var Directions = linesDir
                .Skip(1)
                .Select(line => new Direction(Int32.Parse(line.Split(seps)[0]), line.Split(seps)[1], Int32.Parse(line.Split(seps)[2]), Int32.Parse(line.Split(seps)[3])));

            var st = Students
                .Join(Directions,
                    s => s.IdDirect,
                    d => d.IdDirect,
                    (s, d) => new { SB = s.SumBall, MB = d.MinBall, NS = s.NameStudent })
                .Where(item => item.SB >= item.MB)
                .OrderByDescending(item => item.SB);
            foreach (var item in st)
                Console.WriteLine($"{item.SB}\t{item.NS}");
        }
        public static void Task_3()
        {
            string dir = Console.ReadLine();
            string Direct = Properties.Resources.directions;
            string Stud = Properties.Resources.students;
            string[] linesStud = Stud.Split('\n');
            string[] linesDir = Direct.Split('\n');
            char[] seps = new char[] { ' ', '\t', '|', ';' };
            var Students = linesStud
                .Skip(1)
                .Select(line => new Student(Int32.Parse(line.Split(seps)[0]), line.Split(seps)[1], char.Parse(line.Split(seps)[2]), Int32.Parse(line.Split(seps)[3]), Int32.Parse(line.Split(seps)[4]), Int32.Parse(line.Split(seps)[5]), Int32.Parse(line.Split(seps)[6])));
            var Directions = linesDir
                .Skip(1)
                .Select(line => new Direction(Int32.Parse(line.Split(seps)[0]), line.Split(seps)[1], Int32.Parse(line.Split(seps)[2]), Int32.Parse(line.Split(seps)[3])))
                .Where(item => item.NameDirect == dir);
            var st = Students
                .Join(Directions,
                    s => s.IdDirect,
                    d => d.IdDirect,
                    (s, d) => new { SB = s.SumBall, NS = s.NameStudent })
                .OrderByDescending(item => item.SB)
                .Take(3);
            foreach (var item in st)
                Console.WriteLine($"{item.SB}\t{item.NS}");
        }
        public static void Task_4()
        {
            string dir = Console.ReadLine();
            string Direct = Properties.Resources.directions;
            string Stud = Properties.Resources.students;
            string[] linesStud = Stud.Split('\n');
            string[] linesDir = Direct.Split('\n');
            char[] seps = new char[] { ' ', '\t', '|', ';' };
            var Students = linesStud
                .Skip(1)
                .Select(line => new Student(Int32.Parse(line.Split(seps)[0]), line.Split(seps)[1], char.Parse(line.Split(seps)[2]), Int32.Parse(line.Split(seps)[3]), Int32.Parse(line.Split(seps)[4]), Int32.Parse(line.Split(seps)[5]), Int32.Parse(line.Split(seps)[6])));
            var Directions = linesDir
                .Skip(1)
                .Select(line => new Direction(Int32.Parse(line.Split(seps)[0]), line.Split(seps)[1], Int32.Parse(line.Split(seps)[2]), Int32.Parse(line.Split(seps)[3])))
                .Where(item => item.NameDirect == dir);
            var st = Students
                .Join(Directions,
                    s => s.IdDirect,
                    d => d.IdDirect,
                    (s, d) => new { SB = s.SumBall, MB = d.MinBall, NS = s.NameStudent })
                .Where(item => item.SB >= item.MB)
                .OrderByDescending(item => item.SB)
                .ThenBy(item => item.NS);
            foreach (var item in st)
                Console.WriteLine($"{item.SB}\t{item.NS}");
        }
        public static void Task_5()
        {
            string dir = Console.ReadLine();
            string Direct = Properties.Resources.directions;
            string Stud = Properties.Resources.students;
            string[] linesStud = Stud.Split('\n');
            string[] linesDir = Direct.Split('\n');
            char[] seps = new char[] { ' ', '\t', '|', ';' };
            var Students = linesStud
                .Skip(1)
                .Select(line => new Student(Int32.Parse(line.Split(seps)[0]), line.Split(seps)[1], char.Parse(line.Split(seps)[2]), Int32.Parse(line.Split(seps)[3]), Int32.Parse(line.Split(seps)[4]), Int32.Parse(line.Split(seps)[5]), Int32.Parse(line.Split(seps)[6])));
            var Directions = linesDir
                .Skip(1)
                .Select(line => new Direction(Int32.Parse(line.Split(seps)[0]), line.Split(seps)[1], Int32.Parse(line.Split(seps)[2]), Int32.Parse(line.Split(seps)[3])))
                .Where(item => item.NameDirect == dir);
            var st = Students
                .Join(Directions,
                    s => s.IdDirect,
                    d => d.IdDirect,
                    (s, d) => new { SB = s.SumBall, NS = s.NameStudent, LIM = d.Limit })
                .OrderByDescending(item => item.SB)
                .TakeWhile((item, index) => item.LIM > index);
            foreach (var item in st)
                Console.WriteLine($"{item.SB}\t{item.NS}");
        }
        public static void Task_6()
        {
            string dir = Console.ReadLine();
            string Direct = Properties.Resources.directions;
            string Stud = Properties.Resources.students;
            string[] linesStud = Stud.Split('\n');
            string[] linesDir = Direct.Split('\n');
            char[] seps = new char[] { ' ', '\t', '|', ';' };
            var Students = linesStud
                .Skip(1)
                .Select(line => new Student(Int32.Parse(line.Split(seps)[0]), line.Split(seps)[1], char.Parse(line.Split(seps)[2]), Int32.Parse(line.Split(seps)[3]), Int32.Parse(line.Split(seps)[4]), Int32.Parse(line.Split(seps)[5]), Int32.Parse(line.Split(seps)[6])));
            var Directions = linesDir
                .Skip(1)
                .Select(line => new Direction(Int32.Parse(line.Split(seps)[0]), line.Split(seps)[1], Int32.Parse(line.Split(seps)[2]), Int32.Parse(line.Split(seps)[3])))
                .Where(item => item.NameDirect == dir);
            var st = Students
                .Join(Directions,
                    s => s.IdDirect,
                    d => d.IdDirect,
                    (s, d) => new { SB = s.SumBall, MB = d.MinBall, NS = s.NameStudent, LIM = d.Limit })
                .OrderByDescending(item => item.SB)
                .ThenBy(item => item.NS)
                .SkipWhile((item, index) => item.LIM > index)
                .Take(1);
            foreach (var item in st)
                Console.WriteLine($"{item.SB}\t{item.NS}");
        }

        public static void Task_7()
        {
            string Direct = Properties.Resources.directions;
            string Stud = Properties.Resources.students;
            string[] linesStud = Stud.Split('\n');
            string[] linesDir = Direct.Split('\n');
            char[] seps = new char[] { ' ', '\t', '|', ';' };
            var Students = linesStud
                .Skip(1)
                .Select(line => new Student(Int32.Parse(line.Split(seps)[0]), line.Split(seps)[1], char.Parse(line.Split(seps)[2]), Int32.Parse(line.Split(seps)[3]), Int32.Parse(line.Split(seps)[4]), Int32.Parse(line.Split(seps)[5]), Int32.Parse(line.Split(seps)[6])));
            var Directions = linesDir
                .Skip(1)
                .Select(line => new Direction(Int32.Parse(line.Split(seps)[0]), line.Split(seps)[1], Int32.Parse(line.Split(seps)[2]), Int32.Parse(line.Split(seps)[3])));

            var st = Directions
                .GroupJoin(Students,
                    d => d.IdDirect,
                    s => s.IdDirect,
                    (d, s) => new { ND = d.NameDirect, C = s.Select(stud => stud.IdDirect).Count() });

            foreach (var item in st)
                Console.WriteLine($"{item.ND}\t{item.C}");
        }

        public static void Task_8()
        {
            string Direct = Properties.Resources.directions;
            string Stud = Properties.Resources.students;
            string[] linesStud = Stud.Split('\n');
            string[] linesDir = Direct.Split('\n');
            char[] seps = new char[] { ' ', '\t', '|', ';' };
            var Students = linesStud
                .Skip(1)
                .Select(line => new Student(Int32.Parse(line.Split(seps)[0]), line.Split(seps)[1], char.Parse(line.Split(seps)[2]), Int32.Parse(line.Split(seps)[3]), Int32.Parse(line.Split(seps)[4]), Int32.Parse(line.Split(seps)[5]), Int32.Parse(line.Split(seps)[6])))
                .OrderByDescending(item => item.SumBall);
            var Directions = linesDir
                .Skip(1)
                .Select(line => new Direction(Int32.Parse(line.Split(seps)[0]), line.Split(seps)[1], Int32.Parse(line.Split(seps)[2]), Int32.Parse(line.Split(seps)[3])));

            var st = Directions
                .GroupJoin(Students,
                    d => d.IdDirect,
                    s => s.IdDirect,
                    (d, s) => new { ND = d.NameDirect, SB = s.Select(stud => stud.SumBall).Take(d.Limit).Sum() / d.Limit })
                .OrderByDescending(item => item.SB);

            foreach (var item in st)
                Console.WriteLine($"{item.ND}\t{item.SB}");
        }
    }
}
