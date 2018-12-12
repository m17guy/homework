using System;
using System.Collections.Generic;
using System.Text;

namespace mylist
{
    class mylist<t>
    {
        private t[] items;
        private int lastindex;
        public mylist() : this(5) //overloded constractors, im calling another constractor from here (this) 
        {
            
        }
        public mylist(int size)
        {
            items = new t[size];
            lastindex = 0;
        }
        public int Size
        {
            get { return this.lastindex; }
        }
        //add new item
        public void Add(t item)
        {
            items[lastindex] = item;
            if (lastindex == items.Length) increaseCapacity();
            lastindex++;
        }
        //remove item at index(place)
        public void remove(int index)
        {
            if (index >= 0 && index <= lastindex)
            {
                for (int i = index; i < lastindex; i++)
                    items[i] = items[i + 1];
                lastindex--;
            }
            else
            {
                Console.WriteLine("index out of renge");//present error to user
            }
        }
        public t Get(int index)
        {
            return items[index];
        }
        public void Set(t item, int index)
        {
            if (index < 0 || index > lastindex)
            {
                items[index] = item;
            }
            else
            {
                Console.WriteLine("error");
            }
        }
        private void increaseCapacity()
        {
            t[] copy = new t[items.Length+10];
            for(int i=0;i<items.Length;i++)
                copy[i] = items[i]; // pass value to new array

            this.items = copy; //replace old array with new one
        }

    }
}
