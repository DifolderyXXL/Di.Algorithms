using Di.Algorithms.Common;

namespace Di.Algorithms.HeapAlgorithm;

public class Heap<T>
{
    private List<PriorityNode<T>> _nodes = null!;

    public bool Empty => _nodes.Count <= 1;
    
    public Heap()
    {
        _nodes = new();
        _nodes.Add(null);
    }

    /// <summary>
    /// Insert value into a heap. Complexity is O(log(n)) where n the number of elements.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="priority"></param>
    public void Push(T value, int priority)
    {
        _nodes.Add(new(value, priority));
        this.PushUp(_nodes.Count-1);
    }
    /// <summary>
    /// Remove the front element of the heap. Complexity is O(log(n)) where n the number of elements.
    /// </summary>
    public void Pop()
    {
        if (_nodes.Count > 1)
        {
            _nodes.Swap(1, _nodes.Count-1);
            _nodes.RemoveAt(_nodes.Count-1);
            this.PushDown(1);
        }
    }
    /// <summary>
    /// Return true if can get front element and value variable will not be 'default'.
    /// Complexity is O(1)
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public bool Front(out T value)
    {
        value = default;
        if (_nodes.Count > 1)
        {
            value = _nodes[1].Value;
            return true;
        }

        return false;
    }

    private void PushUp(int index)
    {
        if (index == 1)
            return;

        if (_nodes[index / 2].Priority < _nodes[index].Priority)
        {
            _nodes.Swap(index, index / 2);
            PushUp(index/2);
        }
    }
    private void PushDown(int index)
    {
        if (index * 2 >= _nodes.Count)
            return;

        int nextIndex = index*2; //max node priority index
        if (_nodes.Count > index * 2 + 1 && _nodes[index * 2 + 1].Priority > _nodes[index * 2].Priority)
            nextIndex = index * 2 + 1;

        if (_nodes[nextIndex].Priority > _nodes[index].Priority)
        {
            _nodes.Swap(nextIndex, index);
            this.PushDown(nextIndex);
        }
    }
}