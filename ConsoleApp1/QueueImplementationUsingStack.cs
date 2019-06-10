using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSamples
{
    public class QueueImplementationUsingStack
    {
        Stack<int> s1 = new Stack<int>();

        public void Enqueue(int element)
        {
            s1.Push(element);
        }

        public int Dequeue()
        {
            Stack<int> s2 = new Stack<int>();
            while(s1.Count>1)
            {
                var temp = s1.Pop();
                s2.Push(temp);
            }
            int x = s1.Pop();
            while(s2.Count>0)
            {
                int y = s2.Pop();
                s1.Push(y);
            }
            return x;
        }
        public void Enqueue1(int element)
        {
            Stack<int> s2 = new Stack<int>();
            while(s1.Count>0)
            {
                s2.Push(s1.Pop());
            }
            s2.Push(element);
            while (s2.Count>0)
            {
                s1.Push(s2.Pop());
            }

        }
        public int Dequeue1()
        {
           return  s1.Pop();
            
        }
    }
}
