using GraphNS;
using System;

namespace Pinos4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Graph ADT Implementation ===");
            
            try
            {
                Graph graph = new Graph("graphdata.json");
                Console.WriteLine($"Loaded {graph.Nodes.Count} nodes");
                
                // Display first node's connections
                if (graph.Nodes.Count > 0)
                {
                    Console.WriteLine($"\nNode 0 connects to: " + 
                        string.Join(", ", graph.Nodes[0].AdjacentNodes
                            .Select((connected, index) => connected ? index : -1)
                            .Where(i => i != -1)));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}