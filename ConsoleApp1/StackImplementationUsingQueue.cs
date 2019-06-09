using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSamples
{
    class StackImplementationUsingQueue
    {
        Queue<int> Q = new Queue<int>();
        internal void Push(int element)
        {
            Q.Enqueue(element);
        }
        internal int Pop()  
        {
            Queue<int> Q1 = new Queue<int>();
            while(Q.Count>1)  //Dequeue until last but 1 element
            {
                var temp = Q.Dequeue(); 
                Q1.Enqueue(temp);
                //Q1.Enqueue(Q.Dequeue());
            }
            var x = Q.Dequeue();//dequeue the last element
            Q = Q1;
            return x;
        }

    }
}
