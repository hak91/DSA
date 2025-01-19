namespace StacksAndQueues;

public class Runner
{
    public static void RunStacksUsingArray()
    {
        var myStack = new StackUsingArray();
        myStack.Push(1);
        myStack.Push(2);
        myStack.Push(3);
        myStack.Push(4);
        myStack.Push(5);
        myStack.Push(6);
        Console.WriteLine(myStack.Pop()); // 5
        Console.WriteLine(myStack.Top()); // 4
        Console.WriteLine(myStack.Size()); // 4
        Console.WriteLine(myStack.IsEmpty()); // false
        Console.WriteLine(myStack.Pop()); // 4
        Console.WriteLine(myStack.Pop()); // 3
        Console.WriteLine(myStack.Pop()); // 2
        Console.WriteLine(myStack.Pop()); // 1
        Console.WriteLine(myStack.Pop()); // -1
    }

    public static void RunQueueUsingArray()
    {
        var myQueue = new QueueUsingArray();
        myQueue.Push(1);
        myQueue.Push(2);
        myQueue.Push(3);
        myQueue.Push(4);
        myQueue.Push(5);
        myQueue.Push(6); // error
        Console.WriteLine(myQueue.Top()); // 1
        Console.WriteLine(myQueue.Pop()); // 1
        myQueue.Push(6);
        Console.WriteLine(myQueue.Size()); // 5
    }

    public static void RunNextGreaterElement1()
    {
        var x = new NextGreaterElement1();
        var result = x.MySolution.NextGreaterElement([4, 1, 2], [1, 3, 4, 2]);
        Console.WriteLine(string.Join(", ", result));
        var result2 = x.MySolution.NextGreaterElement([2, 4], [1, 2, 3, 4]);
        Console.WriteLine(string.Join(", ", result2));
    }

    public static void RunNextGreaterElement2()
    {
        var result = NextGreaterElement2.MySolution.NextGreaterElements([1, 2, 1]);
        Console.WriteLine(string.Join(", ", result));

        var result1 = NextGreaterElement2.MySolution.NextGreaterElements([1, 2, 3, 4, 3]);
        Console.WriteLine(string.Join(", ", result1));

    }
}
