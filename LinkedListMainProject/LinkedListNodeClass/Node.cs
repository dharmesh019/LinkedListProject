using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListMainProject.LinkedListNodeClass
{
   public class Node
    {
        public object data;
        public Node next;
       
    }

    public class LinkedList
    {
        Node head;
        Node current;
        public int Counter;

        public LinkedList()
        {
            head = new Node();
            current = head;
        }

        public void AddObjectAtEnd(object data)
        {
            Node ObjNode = new Node();
            ObjNode.data = data;
            current.next = ObjNode;
            current = ObjNode;
            Counter++;
        }
        public string DisplayAddedLinkedListItems()
        {
            StringBuilder str = new StringBuilder();
            //Traverse from head 
            str.Append("Head ->");
            Node curr = head;
            while (curr.next != null)
            {
                curr = curr.next;
               str.Append(curr.data);
               str.Append("->");
            }
            str.Append("End");
            return str.ToString();
        }


        public Node GetNthElementFromEnd(int n)
        {
            Node NodeToReturn = null;
            current = head; // current node initalized with head which is having data NULL
            Node temp = current; // another node to be initalized at head 
            int newCounter = 1;
            while (current != null) // loop for all added linked list points here 
            {
                current = current.next;
               
                if (newCounter > n) // if counter greater than passed n number which is nth element from the end of linked list
                {
                    newCounter = 1; // Reset the newcounter to 1 here to start again calculating until counter reaches the nth number passed
                    NodeToReturn = temp; // first time it will be temp node initalized outside the while loop  //other times it will be previously set values
                    temp = current; // here it changes to point to current node which will be in multiple of nth linkedlist items
                }
                else
                newCounter++;
            }
            if (NodeToReturn == null)
                return NodeToReturn;

            //if newCounter after reaching to end of the linked list is greater than 1 it means it has that many numbers of linked list items need to tranverse to reach to final nth element from the end of linked list
            int cnt = 1;
            while (cnt <= newCounter)
            {
                NodeToReturn = NodeToReturn.next;
                cnt++;
            }
            return NodeToReturn;
        }
    }


}
