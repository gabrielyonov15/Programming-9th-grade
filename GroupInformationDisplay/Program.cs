using System.Text.RegularExpressions;

namespace GroupInformationDisplay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group A = new Group();
            Group B = new Group();
            A.Name = "Gabriel";
            B.Name = "Siana";
            A.Adress = "Karlovo";
            B.Adress = "Sopot";
            A.Grade = 6.00;
            B.Grade = 6.00;
            A.IntroduceYourself();
            B.IntroduceYourself();
        }
    }
}
