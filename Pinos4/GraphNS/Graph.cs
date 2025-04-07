/********************************************************************
*** NAME : Graph.cs ***
*** CLASS : CSc 346 ***
*** ASSIGNMENT : 4 ***
*** DUE DATE : 04-02-25 ***
*** INSTRUCTOR : GAMRADT ***
*********************************************************************
*** DESCRIPTION : Graph class to implement basic graph functionality
***               including DFS and BFS using adjacency lists.
********************************************************************/

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace GraphNS
{
    public class Graph
    {
        private int numVertices;
        private Dictionary<int, List<int>> adjacencyList;

        /********************************************************************
        *** CONSTRUCTOR Graph ***
        *********************************************************************
        *** DESCRIPTION : Loads graph data from a JSON file and builds the graph.
        *** INPUT ARGS : filename - JSON file path
        *** OUTPUT ARGS : none
        *** IN/OUT ARGS : none
        ********************************************************************/
        public Graph(string filename)
        {
            adjacencyList = new Dictionary<int, List<int>>();
            LoadFromJson(filename);
        }

        /********************************************************************
        *** METHOD LoadFromJson ***
        *********************************************************************
        *** DESCRIPTION : Reads and parses a JSON file to build adjacency list.
        *** INPUT ARGS : filename - JSON file path
        *** OUTPUT ARGS : none
        *** IN/OUT ARGS : none
        *** RETURN : void
        ********************************************************************/
        private void LoadFromJson(string filename)
        {
            string jsonString = File.ReadAllText(filename);
            var data = JsonSerializer.Deserialize<Dictionary<string, List<int>>>(jsonString);
            
            if (data != null)
            {
                foreach (var kvp in data)
                {
                    int vertex = int.Parse(kvp.Key);
                    adjacencyList[vertex] = kvp.Value;
                }
                numVertices = adjacencyList.Count;
            }
            else
            {
                throw new Exception("Failed to parse graph data.");
            }
        }

        /********************************************************************
        *** METHOD DepthFirstSearch ***
        *********************************************************************
        *** DESCRIPTION : Performs DFS from the given start node.
        *** INPUT ARGS : startVertex - vertex to start DFS
        *** OUTPUT ARGS : none
        *** RETURN : void
        ********************************************************************/
        public void DepthFirstSearch(int startVertex)
        {
            bool[] visited = new bool[numVertices];
            DFSUtil(startVertex, visited);
            Console.WriteLine();
        }

        private void DFSUtil(int vertex, bool[] visited)
        {
            visited[vertex] = true;
            Console.Write(vertex + " ");

            foreach (var neighbor in adjacencyList[vertex])
            {
                if (!visited[neighbor])
                    DFSUtil(neighbor, visited);
            }
        }

        /********************************************************************
        *** METHOD BreadthFirstSearch ***
        *********************************************************************
        *** DESCRIPTION : Performs BFS from the given start node.
        *** INPUT ARGS : startVertex - vertex to start BFS
        *** OUTPUT ARGS : none
        *** RETURN : void
        ********************************************************************/
        public void BreadthFirstSearch(int startVertex)
        {
            bool[] visited = new bool[numVertices];
            Queue<int> queue = new Queue<int>();

            visited[startVertex] = true;
            queue.Enqueue(startVertex);

            while (queue.Count > 0)
            {
                int vertex = queue.Dequeue();
                Console.Write(vertex + " ");

                foreach (var neighbor in adjacencyList[vertex])
                {
                    if (!visited[neighbor])
                    {
                        visited[neighbor] = true;
                        queue.Enqueue(neighbor);
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
