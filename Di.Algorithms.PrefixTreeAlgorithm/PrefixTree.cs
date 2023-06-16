namespace Di.Algorithms.PrefixTreeAlgorithm;

public class PrefixTree
{
    private Node _root = new();

    public PrefixTree Add(string key)
    {
        AddNode(key, _root);
        return this;
    }

    public PrefixTree Remove(string key)
    {
        RemoveNode(key, _root);
        return this;
    }
    
    public bool Contains(string key)
    {
        return ContainsNode(key, _root);
    }
    
    
    private void AddNode(string key, Node node)
    {
        if (key.Length == 0)
        {
            node.IsWord = true;
            return;
        }

        if (node.TryFind(key[0], out var curSubNode))
        {
            AddNode(key.Remove(0, 1), curSubNode);
        }
        else
        {
            var subNode = new Node(key[0]);
            node.SubNodes.Add(key[0], subNode);
            AddNode(key.Remove(0, 1), subNode);
        }
    }

    private bool RemoveNode(string key, Node node)
    {
        if (key.Length == 0)  
        {
            node.IsWord = false;
            
            if(node.SubNodes.Count == 0)
                return true;
            return false;
        }
        
        if (node.TryFind(key[0], out var curSubNode))
        {
            if (RemoveNode(key.Remove(0, 1), curSubNode) && curSubNode.SubNodes.Count == 0 && !curSubNode.IsWord)
            {
                node.SubNodes.Remove(key[0]);
                return true;
            }
        }

        return false;
    }
    
    private bool ContainsNode(string key, Node node)
    {
        if (key.Length == 0)
            return node.IsWord;
        
        if (node.TryFind(key[0], out var curSubNode))
        {
            return ContainsNode(key.Remove(0, 1), curSubNode);
        }

        return false;
    }
}