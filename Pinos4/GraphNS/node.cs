/********************************************************************
*** NAME : Node.cs ***
*** CLASS : CSc 346 ***
*** ASSIGNMENT : 4 ***
*** DUE DATE : 04-02-25 ***
*** INSTRUCTOR : GAMRADT ***
*********************************************************************
*** DESCRIPTION : This file implements the Node class which represents ***
*** a single node in a graph, containing its ID, visitation status, and ***
*** adjacency list. ***
********************************************************************/

namespace GraphNS
{
    public class Node
    {
        /********************************************************************
        *** PROPERTY Id ***
        *********************************************************************
        *** DESCRIPTION : Gets or sets the unique identifier for the node. ***
        ********************************************************************/
        public int Id { get; set; }

        /********************************************************************
        *** PROPERTY WasVisited ***
        *********************************************************************
        *** DESCRIPTION : Gets or sets whether the node has been visited ***
        *** during graph traversal. ***
        ********************************************************************/
        public bool WasVisited { get; set; }

        /********************************************************************
        *** PROPERTY AdjacentNodes ***
        *********************************************************************
        *** DESCRIPTION : Gets or sets the list of adjacent nodes represented ***
        *** as boolean values indicating connectivity. ***
        ********************************************************************/
        public List<bool> AdjacentNodes { get; set; } = new List<bool>();

        /********************************************************************
        *** METHOD Node (Constructor) ***
        *********************************************************************
        *** DESCRIPTION : Initializes a new instance of the Node class with ***
        *** the specified ID and default values. ***
        *** INPUT ARGS : id ***
        *** OUTPUT ARGS : none ***
        *** IN/OUT ARGS : none ***
        *** RETURN : none ***
        ********************************************************************/
        public Node(int id)
        {
            Id = id;
            WasVisited = false;
        }
    }
}