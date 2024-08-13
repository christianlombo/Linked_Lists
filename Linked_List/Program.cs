using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Arrays
{
    //Program class is treated as a  linkedlist node
    public class Program
    {
        public int data;
        public Program next;

        public Program(int new_data) //Constructor initialises new node with data
        { 
            data = new_data;
            next = null;
        }

        public static void printList(Program head) //function responsible for printing list
        {
            while (head != null)// loop will run till node head is empty
            {
                Console.WriteLine(" " + head.data);

                head = head.next;
            }
            Console.WriteLine();
        }

        public static void Main(string[] args) // driver function
        {
            //creating data for the list
            Program head = new Program(2);
            head.next = new Program(3);
            head.next.next = new Program(5);
            head.next.next.next = new Program(6);
            head.next.next.next.next = new Program(8);
            head.next.next.next.next.next = new Program(9);

            Console.WriteLine("Linked List: ");
            printList(head);
        }
    }
}
