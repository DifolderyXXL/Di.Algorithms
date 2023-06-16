using System.Threading.Channels;
using Di.Algorithms.PrefixTreeAlgorithm;

PrefixTree trie = new();

while (true)
{
    string input = Console.ReadLine();
    var blocks = input.Split(' ', 2);

    string command = blocks[0];
    string request = blocks[1];

    switch (command)
    {
        case "a":
            trie.Add(request);
            Console.WriteLine($"Added word {request}");
            break;
        case "r":
            trie.Remove(request);
            Console.WriteLine($"Removed word {request}");
            break;
        case "f":
            Console.WriteLine($"Trie " + (trie.Contains(request)?"contains":"is not contains") + $" {request}");
            break;
    }
}

Console.WriteLine();

