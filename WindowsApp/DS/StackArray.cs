using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.DS
{
    class StackArray
    {
        public int[] array;
        public int top;
        public StackArray(int size)
        {
            array = new int[size];
            top = -1;    
        }

        public void Push(int data)
        {
            if(top == array.Length - 1) {
                Console.WriteLine("Stack Overflow");
                return;
            }
            array[top] = data;
        }   

        public int Pop()
        {
            if(top <=0) {
                Console.WriteLine("Stack Underflow");
                return -1;
            }
            return array[top--];
        } 
    }
}
