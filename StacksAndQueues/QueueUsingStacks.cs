

namespace StacksAndQueues
{
    public class QueueUsingStacks<T>
    {
        private Stack<T> stack1 = new();
        private Stack<T> stack2 = new();

        public void Push(T element)
        {
            MoveStack1ToStack2();
            stack2.Push(element);
            MoveStack2ToStack1();
        }

        public T Pop()
        {
            return stack1.Pop();
        }

        public T Top()
        {
            return stack1.Peek();
        }

        public bool IsEmpty()
        {
            return stack1.Count == 0;
        }

        public int Size()
        {
            return stack1.Count;
        }

        private void MoveStack2ToStack1()
        {
            while (stack2.Count > 0)
            {
                var value = stack2.Pop();
                stack1.Push(value);
            }
        }

        private void MoveStack1ToStack2()
        {
            while (stack1.Count > 0)
            {
                var value = stack1.Pop();
                stack2.Push(value);
            }
        }
    }
}
