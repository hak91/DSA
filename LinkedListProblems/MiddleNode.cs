public class MiddleNode
{
    public Program MyProgram => new Program();

    public class Program {
        // This is an input class. Do not edit.
        public class LinkedList {
            public int value;
            public LinkedList next;

            public LinkedList(int value) {
            this.value = value;
            this.next = null;
            }
        }

    public LinkedList MiddleNode(LinkedList linkedList) {
        // Write your code here.
        var slow = linkedList;
        var fast = linkedList;
        while(fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        return slow;
    }
    }

}