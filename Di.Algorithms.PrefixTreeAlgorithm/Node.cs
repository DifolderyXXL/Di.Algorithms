namespace Di.Algorithms.PrefixTreeAlgorithm;

public class Node
{
    public char Symbol { get; set; }

    public bool IsWord { get; set; }

    public Dictionary<char, Node> SubNodes { get; set; } = new();
    
    public Node(char symbol = default)
    {
        Symbol = symbol;
    }

    public bool TryFind(char symbol, out Node node)
    {
        return SubNodes.TryGetValue(symbol, out node);
    }
}