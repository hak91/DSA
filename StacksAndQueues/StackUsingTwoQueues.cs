namespace StacksAndQueues;

public class StackUsingTwoQueues<T>
{
    private Queue<T> queue1 = new();
    private Queue<T> queue2 = new();

    public void Push(T element)
    {
        queue2.Enqueue(element);
        while (queue1.Count != 0)
        {
            queue2.Enqueue(queue1.Dequeue());
        }

        Swap();
    }

    public T Pop()
    {
        if (queue1.Count == 0)
        {
            Console.WriteLine("Stack is Empty.");
        }
        return queue1.Dequeue();
    }

    public T Top()
    {
        if (queue1.Count == 0)
        {
            Console.WriteLine("Stack is Empty.");
        }
        return queue1.Peek();
    }

    public int Size()
    {
        return queue1.Count;
    }

    public bool IsEmpty()
    {
        return queue1.Count == 0;
    }

    private void Swap()
    {
        var temp = queue1;
        queue1 = queue2;
        queue2 = temp;
    }
}