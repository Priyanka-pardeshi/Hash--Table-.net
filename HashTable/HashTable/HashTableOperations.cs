using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable
{

    internal class Node<T>
    {
        int key;
        int value;
        public Node<int> next;
        private int v;

        Node(int key, int values)
        {
            this.key = key;
            this.value = value;
            this.next = next;
        }

        public Node(int v)
        {
            this.v = v;
        }
        public void insert()
        {
            Node<int> node = new Node<int>(key);

        }
    }
    class HashTableOperations
    {
        Node<int>[] keyarray = new Node<int>[11];
        public void HashFunction()
        {
            for (int i = 0; i < 11; i++)
            {
                Node<int> node = new Node<int>(-1);
                keyarray[i] = node;
            }

        }
        public void insert(int key)
        {
            Node<int> node = new Node<int>(key);
            Node<int> temp;

            int index = key % 11;
            temp = keyarray[index];

            if (temp is null)
            {
                temp = node;
            }
            else
            {
                while (temp.next!= null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }

        }//end insert

       

    }

}
