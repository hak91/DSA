namespace StacksAndQueues
{
    public class StackUsingArray
    {
        private readonly int[] elements = new int[5];
        private int topElement = -1;

        public void Push(int element)
        {
            if(topElement >= elements.Length - 1)
            {
                Console.WriteLine("Stack is full");
                return;
            }
            elements[++topElement] = element;
        }

        public int Pop()
        {
            if(this.IsEmpty())
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
            return this.elements[topElement--]; 
        }

        public int Top()
        {
            return elements[topElement];
        }

        public int Size()
        {
            return topElement + 1;
        }

        public bool IsEmpty()
        {
            return topElement == -1;
        }
    }
}
