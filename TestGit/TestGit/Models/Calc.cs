
namespace TestGit.Models
{
    public class Calc
    {
        //эти поля нужно подкинуть в базу данных
        public double First;
        public double Second;
        public double Result;

        public double Sum(double a, double b)
        {
            First = a;
            Second = b;
            Result = a + b;
            return Result;
        }
        public double Sub(double a, double b)
        {
            First = a;
            Second = b;
            Result = a - b;
            return Result;
        }
        public double Mult(double a, double b)
        {
            First = a;
            Second = b;
            Result = a * b;
            return Result;
        }
        public double Div(double a, double b)
        {
            First = a;
            Second = b;
            Result = a / b;
            return Result;
        }
    }
}