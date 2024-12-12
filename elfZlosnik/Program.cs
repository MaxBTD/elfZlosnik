namespace elfZlosnik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int.TryParse(Console.ReadLine(), out int n);

            List<string> elementyZabStr = new List<string>(Console.ReadLine().Split(' '));
            List<int> elementyZabInt = new List<int>();
            foreach (string s in elementyZabStr)
                elementyZabInt.Add(int.Parse(s));
            List<int> elementySort = new List<int>(elementyZabInt);
            elementySort.Sort();

            while (elementyZabInt.Count > 0)
            {
                for (int i = 0; i < elementyZabInt.Count; i++)
                {
                    if(elementySort.Count() > 0 && elementyZabInt[i] == elementySort[0])
                    {
                        elementyZabInt.RemoveAt(i);
                        elementySort.RemoveAt(0);
                        i = i - 1;
                    }
                }
                count++;
            }

            Console.WriteLine(count);
        }
    }
}
