namespace StacksAndQueues
{
    public class StackUsingSingleQueue<T>
    {
        private Queue<T> values = new();

        public void Push(T element)
        {
            values.Enqueue(element);
            for (int i = 0; i < values.Count - 1; i++)
            {
                var front = values.Dequeue();
                values.Enqueue(front);
            }
        }

        public T Pop()
        {
            return values.Dequeue();
        }


    }
}
