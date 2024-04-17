using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp7
{
    internal class Custom
    {
        internal class CustomGenericList<T>
        {
            T[] array;

            public CustomGenericList()
            {
                array = Array.Empty<T>();
            }
            public void Add(T item)
            {
                Array.Resize(ref array,array.Length + 1);
                array[array.Length-1] = item;

            }
            public bool Find(Predicate<T> match)
            {
                foreach (T item in array)
                {
                    if (item.Match == match)
                    {
                        return true;
                    }
                    continue;
                }

                return true;


            }
            public bool FindAll(Predicate<T> match)
            {
                T[] araaynew = new T[0];
                foreach (T item in array)
                {
                    if (item.Match == match)
                    {
                        Array.Resize(ref araaynew, araaynew.Length + 1);
                        araaynew[array.Length-1] = item;

                    }
                }
                return true;

            }
            public bool Remove(Predicate<T> match)
            {
                T[] arrays = new T[0];
                int index = 0;
                foreach (T item in array)
                {
                    if (item.Match != match)
                    {
                        index++;
                        arrays[index] = item;
                        
                    }

                }
                array = arrays;
                return true;
            }

            public void RemoveAll(Predicate<T> match)
            {
                T[] arrays = new T[0];
                int index = 0;
                foreach(T item in array)
                {
                    if (item.Match != match)
                    {
                        index++;
                        arrays[index] = item;
                    }
                }
            }





        }
    }

}
}
