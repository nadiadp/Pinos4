using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace GraphNS
{
    public class Graph : IProcessData
    {
        private List<Node> _nodes = new List<Node>();
        public List<Node> Nodes => _nodes;

        public Graph(string filePath) => ReadData(filePath);

        public void ReadData(string path)
        {
            try
            {
                string fullPath = Path.Combine("Data", path);
                string jsonString = File.ReadAllText(fullPath);
                _nodes = JsonSerializer.Deserialize<List<Node>>(jsonString) ?? new List<Node>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading graph: {ex.Message}");
            }
        }

        private void _ResetVisitedSet() => _nodes.ForEach(n => n.WasVisited = false);
        private Node? _FindAdjacentUnvisitedNode(Node node) => 
            _nodes.FirstOrDefault(n => node.AdjacentNodes[n.Id] && !n.WasVisited);
    }
}