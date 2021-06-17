using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable
{
   public class HashMap<K,V>
    {
        public readonly int size;
        public readonly LinkedList<keyValue<K, V>>[] items;
        //structure
        public struct keyValue<K, V>
        {
            public K key { get; set; }
            public V value { get; set; }
        }
        //constructor
        public HashMap(int size)
        {
            this.size = size;
            this.items = new LinkedList<keyValue<K, V>>[size];
        }

        //get linklist
        protected LinkedList<keyValue<K, V>> getLinkedList(int pos)
        {
            LinkedList<keyValue<K, V>> linklist = items[pos];
            if (linklist == null)
            {
                linklist = new LinkedList<keyValue<K, V>>();
                items[pos] = linklist;
            }
            return linklist;
        }

        public int getPositionOfArray(K key)
        {
            int position = key.GetHashCode() % size;  //get hash code
            return Math.Abs(position);
        }

        //get value
        public V getValue(K key)
        {
            int position = getPositionOfArray(key);
            LinkedList<keyValue<K, V>> linklist = getLinkedList(position);
            foreach (keyValue<K, V> item in linklist)
            {
                if (item.key.Equals(key))
                {
                    return item.value;
                }
            }
            return default;
        }

        public void Add(K key,V value)
        {
            int position = getPositionOfArray(key);
            LinkedList<keyValue<K, V>> linklist = getLinkedList(position);

            keyValue<K, V> item = new keyValue<K, V>()
            {
                key = key,
                value=value
            };
            //ready made method add last
            linklist.AddLast(item);
        }

        public void Remove(K key)
        {
            int position = getPositionOfArray(key);
            LinkedList<keyValue<K, V>> linklist = getLinkedList(position);
            bool itemFound = false;
            keyValue<K, V> found = default(keyValue<K, V>);
            foreach (keyValue<K, V> item in linklist)
            {
                itemFound = true;
                found = item;
            }
            if (itemFound)
            {
                linklist.Remove(found);
            }
        }


    }
}
