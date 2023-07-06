using System.Threading.Channels;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Di.Algorithms.HeapAlgorithm;
using Di.Algorithms.PrefixTreeAlgorithm;


Heap<int> heap = new();
while (true)
{
    var blocks = Console.ReadLine().Split(' ');
    switch (blocks[0].ToLower().Trim())
    {
        case "push":
            int value = int.Parse(blocks[1]);
            heap.Push(value, value);
            break;
        case "pop":
            heap.Pop();
            break;
        case "front":
            if(heap.Front(out var val))
                Console.WriteLine("Front vlaue is: " + val);
            else
                Console.WriteLine("Cant get front value.");
            break;
    }
}


return;
BenchmarkRunner.Run<PrefixTreeBenchmarker>();

[IterationCount(8)]
[WarmupCount(1)]
[EvaluateOverhead(false)]
public class PrefixTreeBenchmarker
{
    private List<string> _words;
    
    private PrefixTree _trie;

    private int f1 = 0, f2 = 0, f3 = 0;
    
    public PrefixTreeBenchmarker()
    {
        _trie = new();
        _words = new(new string[]
        {
            "asd", "ewttqwe", "asolka", "abcdefgh", "abc", "abcde", "abcdreg",
            "gena", "genadiy", "gerald", "gswoloch", "gsonix", "gronx", "gsorix"
        });
    }

    [Benchmark()]
    public void F1()
    {
        _trie.Add(_words[f1]);
        f1++;
        f1 %= _words.Count;
    }
    [Benchmark()]
    public void F2()
    {
        _trie.Remove(_words[f2]);
        f2++;
        f2 %= _words.Count;
    }
    [Benchmark()]
    public void F3()
    {
        _trie.Contains(_words[f3]);
        f2++;
        f2 %= _words.Count;
    }
}

