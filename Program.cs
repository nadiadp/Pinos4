/********************************************************************
*** NAME : Nadia Pinos ***
*** CLASS : CSc 346 ***
*** ASSIGNMENT : 4 ***
*** DUE DATE : 04-02-25 ***
*** INSTRUCTOR : GAMRADT ***
*********************************************************************
*** DESCRIPTION : This file contains the main entry point for the ***
*** application and demonstrates the usage of the Graph ADT. ***
********************************************************************/

using GraphNS;
using System;

class Program
{
    /********************************************************************
    *** METHOD Main ***
    *********************************************************************
    *** DESCRIPTION : The main entry point for the application. ***
    *** INPUT ARGS : args ***
    *** OUTPUT ARGS : none ***
    *** IN/OUT ARGS : none ***
    *** RETURN : void ***
    ********************************************************************/
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Graph ADT Implementation");
            
            // Example usage
            Graph graph = new Graph("graphdata.json");
            
            // Additional test code would go here
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}