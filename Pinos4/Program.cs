/********************************************************************
*** NAME : Program.cs ***
*** CLASS : CSc 346 ***
*** ASSIGNMENT : 4 ***
*** DUE DATE : 04-02-25 ***
*** INSTRUCTOR : GAMRADT ***
*********************************************************************
*** DESCRIPTION : Main program demonstrating graph functionality.
********************************************************************/

using GraphNS;
using System;

class Program
{
    /********************************************************************
    *** METHOD Main ***
    *********************************************************************
    *** DESCRIPTION : Entry point demonstrating graph operations.
    *** INPUT ARGS : args - Command line arguments
    *** OUTPUT ARGS : none
    *** IN/OUT ARGS : none
    *** RETURN : void
    ********************************************************************/
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("=== Graph ADT Implementation ===\n");

            // Create graph and load data
            Graph graph = new Graph("Data/graphdata.json");

            // Test Depth First Search
            Console.WriteLine("Depth First Search (starting from node 0):");
            graph.DepthFirstSearch(0);

            Console.WriteLine("\n------------------------------\n");

            // Test Breadth First Search
            Console.WriteLine("Breadth First Search (starting from node 0):");
            graph.BreadthFirstSearch(0);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
