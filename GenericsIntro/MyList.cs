using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    internal class MyList<T>
    {
        T[] items;
        //constructor --->  T listesi newlendiği zaman constructor otomatik olarak çalışır ve dizi oluşturur.

        public MyList()
        {
            items = new T[0];      
        }

        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length+1];    //Bu şekilde yapıyı dinamikleştirerek kullanıcı tarafından ekleme yapılmasını sağlıyoruz.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }
    }
}
