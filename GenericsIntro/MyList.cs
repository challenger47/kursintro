using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;  //bunu yazıp alta ctor yaz ve tab la
        public MyList()
        {   
            items = new T[0];    
        }

        public void Add(T item)
        {

            //Dizinin eleman sayısı 0 old.için burda 1 artırıyoruz
            T[] tempArray = items; // önceki değerler kaybolmasın diye gecici adrese taşıdık temp ile
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];

            }
            items[items.Length - 1] = item;


        }
            
    }
}
