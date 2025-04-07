using GraphNS;
using System;
using System.Linq; 

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