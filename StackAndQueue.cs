using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_Programs
{
    public class StackAndQueue
    {
        List<char> stack = new List<char>();
        List<char> queue = new List<char>();

        public void pushCharacter(char ch)
        {
            stack.Add(ch);
        }

        public void enqueueCharacter(char ch)
        {
            queue.Add(ch);
        }

        public char popCharacter()
        {
            char c = stack[stack.Count - 1];
            stack.RemoveAt(stack.Count - 1);
            return c;
        }

        public char dequeueCharacter()
        {
            char c = queue[0];
            queue.RemoveAt(0);
            return c;
        }
    }
}
