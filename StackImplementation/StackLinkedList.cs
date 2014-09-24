using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImplementation
{
    /// <summary>
    /// This is a stack implemtation using linked list
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class StackLinkedList<T>
    {
        //the head variable is used to detemine the head of a linke list
        public StackLinkedListNode<T> head = null;

        /// <summary>
        /// Push method is used to push data into the stack
        /// </summary>
        /// <param name="item">Item that will be added to the stack</param>
        public void Push(T item)
        {
            //The newNode variable will be used to create a new node that will be added to the stack
            StackLinkedListNode<T> newNode = new StackLinkedListNode<T>();
            newNode.data = item;
            newNode.next = head;
            //the new node will be as new head
            head = newNode;
        }

        /// <summary>
        /// Pop method is used to get and remove the last item added to the stack
        /// </summary>
        /// <returns>The last added element</returns>
        public T Pop()
        {
            //the if statment is true when the list is empty
            if (head == null)
            {
                throw new InvalidOperationException("Pop not possible when the list is empty.");
            }
            //this variable will be used to save the head
            StackLinkedListNode<T> myNode = head;
            //the head is changed to the second node
            head = head.next;
            //this will return the data of the head node
            return myNode.data;
        }

        /// <summary>
        /// Peek method return the data of the last added element without removing from the stack
        /// </summary>
        /// <returns>The last added element</returns>
        public T Peek()
        {
            //the if statment is true when the list is empty
            if (head == null)
            {
                //throws an invalid operation exception when the list is empty
                throw new InvalidOperationException("Peek not possible when the list is empty.");                
            }
            return head.data;
        }
    }

    /// <summary>
    /// StackLinkedListNode is used with the StackLinkedList to create nodes
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class StackLinkedListNode<T>
    {
        public T data;
        public StackLinkedListNode<T> next;
    }
}
