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
            objHash.Add(4, "are");
            string varGetValue = objHash.getValue(3);
            Console.WriteLine(" Value of an index is =" + varGetValue);
            Console.WriteLine("Count an occuranc:"+objHash.occurance("are"));


            string goodThought = "To be or not to be";
            string[] separator = goodThought.Split(" ");
            HashMap<int, string> objHashh = new HashMap<int, string>(separator.Length);
            int key = 0;
            foreach (string word in separator)
            {
                objHashh.Add(key, word);
                key++;
            }
            string findVal = objHashh.getValue(3);
            Console.WriteLine(" Value of an incex is =" + findVal);

            string Message = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberatetly into paranoid avoiddable situations";
            string[] separatorStr = Message.Split(" ");
            HashMap<int, string> objHashTable = new HashMap<int, string>(separatorStr.Length);
            int keyStr = 0;
            foreach (string word in separatorStr)
            {
                objHashTable.Add(keyStr, word);
                key++;
            }
            
            Console.WriteLine(" removed an index =");
            objHashTable.RemoveValue("paranoid");
        }
    }
}
