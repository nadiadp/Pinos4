/********************************************************************
*** NAME : Nadia Pinos ***
*** CLASS : CSc 346 ***
*** ASSIGNMENT : 4 ***
*** DUE DATE : 04-02-25 ***
*** INSTRUCTOR : GAMRADT ***
*********************************************************************
*** DESCRIPTION : This file implements the Graph class which represents ***
*** a graph data structure with nodes and their adjacency relationships. ***
*** It includes functionality to read graph data from JSON files, ***
*** manage node visitation, and find adjacent nodes. ***
********************************************************************/

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace GraphNS
{
    public class Graph : IProcessData
    {
        private List<Node> _nodes;

        /********************************************************************
        *** METHOD Graph (Constructor) ***
        *********************************************************************
        *** DESCRIPTION : Initializes a new instance of the Graph class and ***
        *** loads graph data from the specified file path. ***
        *** INPUT ARGS : filePath ***
        *** OUTPUT ARGS : none ***
        *** IN/OUT ARGS : none ***
        *** RETURN : none ***
        ********************************************************************/
        public Graph(string filePath)
        {
            ReadData(filePath);
        }

        /********************************************************************
        *** METHOD _ResetVisitedSet ***
        *********************************************************************
        *** DESCRIPTION : Resets the WasVisited flag for all nodes in the graph. ***
        *** INPUT ARGS : none ***
        *** OUTPUT ARGS : none ***
        *** IN/OUT ARGS : none ***
        *** RETURN : void ***
        ********************************************************************/
        private void _ResetVisitedSet()
        {
            foreach (var node in _nodes)
            {
                node.WasVisited = false;
            }
        }

        /********************************************************************
        *** METHOD _FindAdjacentUnvisitedNode ***
        *********************************************************************
        *** DESCRIPTION : Finds and returns the first adjacent unvisited node ***
        *** to the specified node. Returns null if none found. ***
        *** INPUT ARGS : node ***
        *** OUTPUT ARGS : none ***
        *** IN/OUT ARGS : none ***
        *** RETURN : Node? ***
        ********************************************************************/
        private Node? _FindAdjacentUnvisitedNode(Node node)
        {
            for (int i = 0; i < node.AdjacentNodes.Count; i++)
            {
                if (node.AdjacentNodes[i] && !_nodes[i].WasVisited)
                {
                    return _nodes[i];
                }
            }
            return null;
        }

        /********************************************************************
        *** METHOD _ViewNode ***
        *********************************************************************
        *** DESCRIPTION : Displays information about a node including its ID ***
        *** and visited status. ***
        *** INPUT ARGS : node ***
        *** OUTPUT ARGS : none ***
        *** IN/OUT ARGS : none ***
        *** RETURN : void ***
        ********************************************************************/
        private void _ViewNode(Node node)
        {
            Console.Write(node.Id);
            if (node.WasVisited)
            {
                Console.Write(" (visited)");
            }
            Console.WriteLine();
        }

        /********************************************************************
        *** METHOD ReadData ***
        *********************************************************************
        *** DESCRIPTION : Implements IProcessData interface method to read ***
        *** graph data from a JSON file and deserialize it into Node objects. ***
        *** INPUT ARGS : path ***
        *** OUTPUT ARGS : none ***
        *** IN/OUT ARGS : none ***
        *** RETURN : void ***
        ********************************************************************/
        public void ReadData(string path)
        {
            try
            {
                string jsonString = File.ReadAllText(path);
                _nodes = JsonSerializer.Deserialize<List<Node>>(jsonString) ?? new List<Node>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file: {ex.Message}");
                _nodes = new List<Node>();
            }
        }
    }
}