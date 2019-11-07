using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        //member variables
        private T[] items;
        private int count; //{ get; }
        private int capacity; //{ get; set; }
        private int j;
        private int k;

        //below in constructor???
        public int Count
        {
            get
            {
                return count;
            }
        }
        public int Capacity
        {
            get
            {
                
                
                return capacity;
            }
            set
            {
                capacity = value;
            }
        }

        public T this[int index]
        {
            get { return items[index]; }
        }


        //constructor
        public CustomList()
        {
            capacity = 4;
            count = 0;
            items = new T[capacity];
        }

        //member methods
        public void Add(T item)
        {
            if (count == capacity)
            {
                capacity *= 2;
                //create new array
                T[] tempArray = new T[capacity];
                //copy values
                //for loop to copy each index over to new array, loop to length of array (count)
                for (int i = 0; i < count; i++)
                {
                    //temp array with copied indices is new array
                    tempArray[i] = items[i];
                }
                items = tempArray;
            }
            //new correct sized array;
            
            items[count] = item;
            count++;
        }

        public void Remove(T item)
        {
            //find item of equal value (T)
            //loop over all indexes to compare if = or !=
            for (int i = 0; i < count; i++)
            {
                if (items[i].Equals(item))
                {
                    //declare new index
                    //new index reference is the space + 1 of value being removed
                   
                    for (int j = i + 1; j <= count; j ++)
                    {
                        //starting at j move item one spot to the left
                        //do for the full length of array that starts at j
                        //take the value at j and make it new value one space to the left (j -1)
          
                        for (int k = j - 1; k < count; k ++)
                        {
                            
                        }
                    }
                }
            }
            count--;
        }



        

        

    }
}
