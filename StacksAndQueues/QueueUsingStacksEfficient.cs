
namespace StacksAndQueues
{
    public class QueueUsingStacksEfficient<T>
    {
        private Stack<T> input = new();
        private Stack<T> output = new();

        public void Push(T item)
        {
            input.Push(item);
        }

        public T Pop()
        {
            if (output.Count > 0)
            {
                return output.Pop();
            }
            MoveInputToOutput();
            return output.Pop();
        }

        public T Top()
        {
            return output.Peek();
        }

        private void MoveInputToOutput()
        {
            while (input.Count > 0)
            {
                var value = input.Pop();
                output.Push(value);
            }
            return;
        }
    }
}
