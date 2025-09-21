using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Cache<Tkey,Tvalue> 
    {
        private int maxSize;
        private int size;
        private readonly Dictionary<Tkey, Tvalue> cacheMap;
        private Dictionary<int,int> cacheFreq;

        public Cache(int maxsize)
        {
            size = 0;
            this.maxSize = maxsize;
            cacheFreq = new Dictionary<int,int>();
            cacheMap = new Dictionary<Tkey,Tvalue>();
        }

        public void Add(Tkey key,Tvalue value)
        {
            int keyHashCode = key.GetHashCode();
            if (cacheFreq.ContainsKey(key.GetHashCode()) == true) return;
            if (size == maxSize)
               RemoveLRU();
            cacheMap.Add(key, value);
            cacheFreq.Add(keyHashCode, 0);
            size++;
        }
        
        public void Reomve(Tkey key)
        {
            if (cacheMap.ContainsKey(key)== false) return;
            cacheMap.Remove(key);
            cacheFreq.Remove(key.GetHashCode());
            size--;
        }

        public void DisplayAll()
        {
            foreach(var item in cacheMap)
            {
                Console.WriteLine($"key:{item.Key},  value:{item.Value}");
            }
        }
        public object Retrieve (Tkey key)// i have a question here what can return type be rather than object type?????
        {
            if(!cacheMap.ContainsKey(key)) return null;
            cacheFreq[key.GetHashCode()]++;
            return cacheMap[key];

        }
        public void RemoveLRU()
        {
            int minFreq = int.MaxValue;
            int LRUHashCode = -1;

            foreach (var element in cacheFreq)
            {
                if (element.Value <= minFreq)
                {
                    minFreq = element.Value;
                    LRUHashCode = element.Key;
                }
            }
            cacheFreq.Remove(LRUHashCode);
            foreach (var element in cacheMap)
            {
                if (element.Key.GetHashCode() == LRUHashCode)
                {
                    cacheMap.Remove(element.Key);
                    break;
                }
            }
            size--;
        }

       
    }
}