namespace PetInformationPresenter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Sharo", 1);
            dog.firstPrintInfo();
            Dog cat = new Dog("Tom", 1);
            cat.secondPrintInfo();
        }
    }
}
