using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Student
    {
        public int IdStudent { get; set; }
        public string NameStudent { get; set; }
        public char Sex { get; set; }
        public int BallMath { get; set; }
        public int BallLang { get; set; }
        public int BallInf { get; set; }
        public int IdDirect { get; set; }
        public int SumBall { get; set; }
        public Student(int idStudent, string nameStudent, char sex, int ballMath, int ballLang, int ballInf, int idDirect)
        {
            IdStudent = idStudent;
            NameStudent = nameStudent;
            Sex = sex;
            BallMath = ballMath;
            BallLang = ballLang;
            BallInf = ballInf;
            IdDirect = idDirect;
            SumBall = BallInf + BallLang + BallMath;
        }
    }
    class Direction
    {
        public int IdDirect { get; set; }
        public string NameDirect { get; set; }
        public int MinBall { get; set; }
        public int Limit { get; set; }
        public Direction(int idDirect, string nameDirect, int minBall, int limit)
        {
            IdDirect = idDirect;
            NameDirect = nameDirect;
            MinBall = minBall;
            Limit = limit;
        }
    }
}
