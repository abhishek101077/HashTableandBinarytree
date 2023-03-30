namespace Hashandtable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Binarysearchtree<int> binarySearch = new Binarysearchtree<int>(56);
            binarySearch.Insert(30);
            binarySearch.Insert(70);
            binarySearch.GetSize();
            binarySearch.Display();
            Console.ReadLine();
        }
    }
}