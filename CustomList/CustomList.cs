using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList 
{
    public class CustomList<T> : IEnumerable
    {
        //member variables
        private T[] items;
        private int count; //{ get; }
        private int capacity; //{ get; set; }
        

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
                    count--;
                    if (count == 0)
                    {
                        items = new T[capacity];
                    }
                    else
                    {
                        for (int j = i + 1; j <= count; j++)
                        {
                            //starting at j move item one spot to the left
                            //do for the full length of array that starts at j
                            //take the value at j and make it new value one space to the left (j -1)
                            items[j - 1] = items[j];
                        }
                    }
                }
            }
        }


        public override string ToString()
        {
            string finalString = "";
            for (int i = 0; i < count; i++)
            {
            //loop over the entire list
            //at each index, take item and move it to a new index...
            //every item will then be added to that same index (a running list of things in one line)
            //the new index is a list of all of the items in the list
            //return all items in list as a string

                finalString += items[i].ToString();    
            }
            return finalString;

        }

        public IEnumerator GetEnumerator()
        {
            for(int i = 0; i < items.Length; i++)
            {
                yield return items[i];
            }
        }

        public static CustomList<T> operator + (CustomList<T> list1, CustomList<T> list2)
        {
            //2 loops to add stuff from first list then second
            CustomList<T> newList = new CustomList<T>();
            for (int i = 0; i < list1.Count; i++)
            {
                //add items from list1 to new list
                newList.Add(list1[i]);
            }
            for (int i = 0; i < list2.Count; i++)
            {
                //add items from list21 to new list
                newList.Add(list2[i]);
            }
            return newList;
        }

        public static CustomList<T> operator - (CustomList<T> list1, CustomList<T> list2)
        {
            //compare items from list1 to list2
            //loop over every item
            for (int i = 0; i < list1.Count; i++)
            {
                for (int j = 0; j < list2.Count; j++)
                {
                    //if there is value in list2 that is equal to value in list1, **remove that value from list1
                    if (list1[i].Equals(list2[j]))
                    {
                        //remove the equal value from list1
                        list1.Remove(list1[i]);
                        //list1.Add(newList[i]);
                    }
                }
            }

            //return the modified list
            return list1;
        }

        public CustomList<T> Zip(CustomList<T> list2)
        {
            //create new list (which will be the 2 lists zipped together)
            CustomList<T> newList = new CustomList<T>();
            //new variable to determine longer list (countwise)
            int biggerList;
            //create statements to determine which one will be biggerList
            if(Count >= list2.Count)
            {
                biggerList = Count;
            }
            else
            {
                biggerList = list2.Count;
            }
            //loop over each [i] in list 1
            //loop over each [i] in list 2
            for(int i = 0; i < biggerList; i++)
            {
                if (i < Count)
                {
                    newList.Add(items[i]);
                }
                if (i < list2.Count)
                {
                    newList.Add(list2[i]);
                }
            }
            //add first [i] from list1 then first [i] from list 2
            //keep going until end of list
            //return the new list
            return newList;
        }


    }



        

        

}

