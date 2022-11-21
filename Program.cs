namespace Lesson10OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();//
            list.Add(1);
            list.Add(2);
            list.Add(3);
            //list[0] = 4;
            list.RemoveAt(1);
            foreach (var item in list)
            {
                Console.Write(item + " ");

            }

        }
    }
}