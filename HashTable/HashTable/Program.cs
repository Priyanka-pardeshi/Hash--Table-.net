using System;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            HashTableOperations objHash = new HashTableOperations();
            objHash.HashFunction();
            objHash.insert(1);
        }
    }
}
