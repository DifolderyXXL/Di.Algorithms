namespace Di.Algorithms.HeapAlgorithm;

internal class PriorityNode<T>
{
    public T Value { get; set; }
    public int Priority { get; set; }

    public PriorityNode(T value, int priority)
    {
        Value = value;
        Priority = priority;
    }
}