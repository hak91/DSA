namespace StacksAndQueues
{
    public class QueueUsingArray
    {
        private readonly int[] elements = new int[5];
        private int front = 0;
        private int afterRear = 0;
        private int numberOfElements = 0;

        public void Push(int element)
        {
            if (numberOfElements >= elements.Length)
            {
                Console.WriteLine("Queue is full.");
                return;
            }
            elements[afterRear % 5] = element;
            afterRear++;
            numberOfElements++;
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is Empty.");
            }
            numberOfElements--;
            return elements[front++];
        }

        public int Top()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is Empty.");
                return -1;
            }

            return elements[front % 5];
        }

        public bool IsEmpty()
        {
            return numberOfElements == 0;
        }

        public int Size()
        {
            return afterRear - front;
        }
    }
}