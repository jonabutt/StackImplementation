using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImplementation
{
    public class StackArray<T>
    {
        public T[] myItems;
        private int currentItem = -1;

        /// <summary>
        /// This default constructor will create the array with a predefined size that is 1000
        /// </summary>
        public StackArray()
            : this(1000)
        { }

        /// <summary>
        /// This constructor is used to detemine the size of the array
        /// </summary>
        /// <param name="size">The size for the stack array</param>
        public StackArray(int size)
        {
            //this will set the array size to the specfic size
            myItems = new T[size];
        }

        /// <summary>
        /// This method will push the item into the last item of the array
        /// </summary>
        /// <param name="item">The item to be added to the stack</param>
        public void Push(T item)
        {
            //check if the array is full
            if (currentItem >= myItems.Length)
                throw new StackOverflowException();//this can be changed to double the array
            //increment the current item
            currentItem++;
            //the current item index to add the new item to the array
            myItems[currentItem] = item;
        }

        /// <summary>
        /// This method will pop the newest item in the stack array
        /// </summary>
        /// <returns>The value of item</returns>
        public T Pop()
        {
            //This if statment is true when there is one ore more items in the stack
            if (currentItem != -1)
            {
                //this variable is used with to return the value of poped element
                T popItem = myItems[currentItem];
                //the current item is decresed
                currentItem--;
                return popItem;
            }
            //this exception will thow when the stack is empty
            throw new InvalidOperationException("Cannot pop an empty stack.");
        }

        /// <summary>
        /// The peek method will return the newest item without removing it from the stack
        /// </summary>
        /// <returns>The latest item</returns>
        public T Peek()
        {
            //This if statment is true when there is one ore more items in the stack
            if (currentItem != -1)
            {
                //return the newest element in the stack
                return myItems[currentItem];
            }
            //this exception will thow when the stack is empty
            throw new InvalidOperationException("Cannot peek an empty stack.");
        }
    }
}
