namespace Di.Algorithms.PrefixTreeAlgorithm;

public class PrefixTree<T>
{
    private Node<T> _root;

    public void Add(string key, T data)
    {
        
    }

    private void AddNode(string key, T data, Node<T> node)
    {
        node.IsWord = node.SubNodes.Count == 0;
        
        if (key.Length == 0)
            return;
        
        if (node.TryFind(key[0], out var curSubNode))
        {
            AddNode(key.Remove(0), data, curSubNode);
        }
        else
        {
            var subNode = new Node<T>(key[0], data);
            node.SubNodes.Add(key[0], subNode);
            AddNode(key.Remove(0), data, subNode);
        }
    }
}