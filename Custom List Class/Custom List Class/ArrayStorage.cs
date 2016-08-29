using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_List_Class
{
    class ArrayStorage <T> : IEnumerable
    {
        T[] originArray;
        string getString;
        int count;
        ArrayStorage<T> zipArray;
        public ArrayStorage()
        {
            originArray = new T[0];
        }
        public void AddItem(T newItem)
        {
            T[] longArray = new T[originArray.Length + 1];
            for (int i = 0; i < originArray.Length; i++)
            {
                longArray[i] = originArray[i];
                count++;
            }
            longArray[originArray.Length] = newItem;
            originArray = longArray;
        }
        public void RemoveItem(T item)
        {
            T[] shortArray = new T[originArray.Length - 1];
            int shortCount = 0;
            for (int i = 0; i < originArray.Length - 1; i++)
            {
                if (EqualityComparer<T>.Default.Equals(originArray[i], item))
                {
                    continue;
                }
                else {
                    shortArray[shortCount] = originArray[i];
                    shortCount++;
                }
            }
            originArray = shortArray;
        }
        public override string ToString()
        {
            for (int i = 0; i < originArray.Length; i++)
            {
                getString += originArray[i].ToString();
            }
            return getString;
        }
        public static ArrayStorage<T> operator +(ArrayStorage<T> listOne, ArrayStorage<T> listTwo)
        {
            ArrayStorage<T> combineList = new ArrayStorage<T>();
            foreach (T item in listOne)
            {
                combineList.AddItem(item);
            }
            foreach (T item in listTwo)
            {
                combineList.AddItem(item);
            }
            return combineList;
        }
        public static ArrayStorage<T> operator -(ArrayStorage<T> listOne, ArrayStorage<T> listTwo)
        {
            foreach (T item in listTwo)
            {
                listOne.RemoveItem(item);
            }
            return listOne;
        }
        public ArrayStorage<T> ZipList(ArrayStorage<T> listOne, ArrayStorage<T> listTwo)
        {
            zipArray = new ArrayStorage<T>();
            for (int i = 0; i < listOne.count; i++)
            {
                zipArray.AddItem(listOne.originArray[i]);
                zipArray.AddItem(listTwo.originArray[i]);
            }
            return zipArray;
        }
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < originArray.Length; i++)
            {
                yield return originArray[i];
            }
        }
    }
}
