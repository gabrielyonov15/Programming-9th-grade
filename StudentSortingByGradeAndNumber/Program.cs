namespace StudentSortingByGradeAndNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведи число:");
            int n = int.Parse(Console.ReadLine());
            int[] grade = new int[n];
            int[] number = new int[n];
            string[] name = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Кой клас си:");
                grade[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Кой номер си:");
                number[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Как се казваш:");
                name[i] = Console.ReadLine();
            }
            for (int i = 0; i < grade.Length - 1; i++)
            {
                for (int j = 0; j < grade.Length - 1; j++)
                {
                    if (grade[j] < grade[j + 1])
                    {
                        int swapVar = grade[j];
                        grade[j] = grade[j + 1];
                        grade[j + 1] = swapVar;
                    }
                }
            }
            for (int i = 0; i < grade.Length; i++)
            {
                Console.WriteLine(grade[i] + " ");
            }
            for (int i = 0; i < number.Length - 1; i++)
            {
                for (int j = 0; j < number.Length - 1 - i; j++)
                {
                    if (number[j] > number[j + 1])
                    {
                        int swapVar1 = number[j];
                        number[j] = number[j + 1];
                        number[j + 1] = swapVar1;
                    }
                }
            }
            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine(number[i] + " ");
            }
            for (int i = 0; i < number.Length - 1; i++)
            {
                for (int j = 0; j < number.Length - 1 - i; j++)
                {

                    if (number[j] > number[j + 1])
                    {
                        int swapVar1 = number[j];
                        number[j] = number[j + 1];
                        number[j + 1] = swapVar1;
                    }
                    if (number[j] == number[j + 1])
                    {
                        if (grade[j] > grade[j + 1])
                        {

                            int swapVar2 = grade[j];
                            grade[j] = grade[j + 1];
                            grade[j + 1] = swapVar2;
                        }
                    }
                }
            }
            for (int i = 0; i < grade.Length; i++)
            {
                Console.WriteLine(grade[i] + " ");
            }
        }
    }
}
