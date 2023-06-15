namespace Di.Algorithms.PrefixTreeAlgorithm;

public class Node<T> 
{
    public char Symbol { get; set; }

    public bool IsWord { get; set; }
    
    public T Data { get; set; }

    public Dictionary<char, Node<T>> SubNodes { get; set; } = new();
    
    public Node(char symbol, T data)
    {
        Symbol = symbol;
        Data = data;
    }

    public bool TryFind(char symbol, out Node<T> node)
    {
        return SubNodes.TryGetValue(symbol, out node);
    }
}