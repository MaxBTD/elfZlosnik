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
            foreach(string s in elementyZabStr)
                elementyZabInt.Add(int.Parse(s));
            List<int> elementySort = new List<int>(elementyZabInt);
            elementySort.Sort();
            int sprawLiczb = elementySort[0];

            while(elementyZabInt.Count > 0)
            {
                Console.WriteLine(elementySort.Count);
                for (int i = 0; i < elementyZabInt.Count - 1; i++)
                {
                    if (elementySort.Count >= 2 && elementyZabInt[i] == sprawLiczb)
                    {
                        elementySort.RemoveAt(0);
                        elementyZabInt.RemoveAt(i);
                        sprawLiczb = elementySort[0];
                    } else if(elementySort.Count < 2 && elementyZabInt[i] == sprawLiczb)
                    {
                        elementySort.RemoveAt(0);
                        elementyZabInt.RemoveAt(i);
                        sprawLiczb = elementySort[0];
                    }
                }
            }

            
        }
    }
}
