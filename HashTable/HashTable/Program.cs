using System;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            HashMap<int, string> objHash = new HashTable.HashMap<int, string>(4);
            objHash.Add(0, "hi");
            objHash.Add(1, "how");
            objHash.Add(2, "are");
            objHash.Add(3, "you");
            
            string varGetValue = objHash.getValue(3);
            Console.WriteLine(" Value of an incex is =" + varGetValue);
        }
    }
}
