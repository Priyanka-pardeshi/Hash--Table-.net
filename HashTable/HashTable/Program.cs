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

            HashMap<int, string> strObjectHash = new HashMap<int, string>(6);
            strObjectHash.Add(0, "To");
            strObjectHash.Add(1, "be");
            strObjectHash.Add(2, "or");
            strObjectHash.Add(3, "not");
            strObjectHash.Add(4, "To");
            strObjectHash.Add(5, "be");
            string findValue = strObjectHash.getValue(4);
            Console.WriteLine("value of an key is :"+findValue);

        }
    }
}
