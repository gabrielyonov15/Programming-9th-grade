namespace ArrayAndListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведи число:");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Въведи число:");
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 1; i < arr.Length; i++)
            {
                int swapVar = arr[i];
                int index = i;
                while (index > 0 && arr[index - 1] >= swapVar)
                {
                    arr[index] = arr[index - 1];
                    index--;
                }
                arr[index] = swapVar;
            }
            Console.WriteLine(string.Join(" ", arr));
            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }
            for (int index = 0; index < list.Count; index++)
            {
                Console.WriteLine($"list[{index}] = {list[index]}");
            }
            for (int i = 0; i < n; i++)
            {
                list.Remove(int.Parse(Console.ReadLine()));
                list.Remove(1);
                Console.WriteLine(String.Join(",", list));
            }
        }
    }
}
