/********************************************************************
*** NAME : Node.cs ***
*** CLASS : CSc 346 ***
*** ASSIGNMENT : 4 ***
*** DUE DATE : 04-02-25 ***
*** INSTRUCTOR : GAMRADT ***
*********************************************************************
*** DESCRIPTION : Represents a single node in a graph with adjacency info.
********************************************************************/

namespace GraphNS
{
    public class Node
    {
        /********************************************************************
        *** PROPERTY Id ***
        *********************************************************************
        *** DESCRIPTION : Unique identifier for the node.
        ********************************************************************/
        public int Id { get; set; }

        /********************************************************************
        *** PROPERTY WasVisited ***
        *********************************************************************
        *** DESCRIPTION : Tracks if node has been visited during traversal.
        ********************************************************************/
        public bool WasVisited { get; set; }

        /********************************************************************
        *** PROPERTY AdjacentNodes ***
        *********************************************************************
        *** DESCRIPTION : List indicating connections to other nodes.
        ********************************************************************/
        public List<bool> AdjacentNodes { get; set; } = new List<bool>();

        /********************************************************************
        *** CONSTRUCTOR Node ***
        *********************************************************************
        *** DESCRIPTION : Creates a new node with specified ID.
        *** INPUT ARGS : id - Node identifier
        *** OUTPUT ARGS : none
        *** IN/OUT ARGS : none
        *** RETURN : none
        ********************************************************************/
        public Node(int id)
        {
            Id = id;
            WasVisited = false;
        }
    }
}