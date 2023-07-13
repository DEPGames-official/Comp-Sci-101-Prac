using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Doubly_Linked_List
{
    public class DLinkedList<T>
    {
        Node<T>? head = null;
        Node<T>? tail = null;

        public void AddBeginning(T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (head == null)
            {
                this.head = newNode;
                tail = newNode;
                return;
            }

            head.previous = newNode;
            newNode.next = this.head;
            this.head = newNode;



        }

        public void AddEnd(T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (head == null)
            {
                AddBeginning(data);
                return;
            }

            newNode.previous = tail;
            tail.next = newNode;

            tail = newNode;

        }

        public void DeleteFront()
        {
            head.next.previous = null;
            head = head.next;
        }

        public void DeleteBack()
        {
            tail.previous.next = null;
            tail = tail.previous;

        }
        public void PrintListForward()
        {
            Node<T>? currentPlace = head;
            while (currentPlace != null)
            {
                System.Console.WriteLine(currentPlace.data);
                currentPlace = currentPlace.next;

            }
        }

        public void PrintListBackward()
        {
            Node<T>? currentPlace = tail;
            while (currentPlace != null)
            {
                System.Console.WriteLine(currentPlace.data);
                currentPlace = currentPlace.previous;
            }
        }
    }

    class Node<T>
    {
        public Node<T>? next;
        public Node<T>? previous;
        public T data;
        public Node(T data)
        {
            this.data = data;
            this.next = null;
            this.previous = null;
        }
    }
}