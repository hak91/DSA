namespace Graphs;
internal class BreadthFirstSearch
{
    public class Program
    {
        // Do not edit the class below except
        // for the BreadthFirstSearch method.
        // Feel free to add new properties
        // and methods to the class.
        public class Node
        {
            public string name;
            public List<Node> children = new List<Node>();
            public Node(string name)
            {
                this.name = name;
            }

            public List<string> BreadthFirstSearch(List<string> array)
            {
                var queue = new Queue<Node>();
                queue.Enqueue(this);
                while (queue.Count > 0)
                {
                    var node = queue.Dequeue();
                    array.Add(node.name);
                    this.children.ForEach(queue.Enqueue);
                }
                return array;
            }

            public Node AddChild(string name)
            {
                Node child = new Node(name);
                children.Add(child);
                return this;
            }
        }
    }

}
