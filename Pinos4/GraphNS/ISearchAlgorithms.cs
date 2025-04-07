/********************************************************************
*** NAME : ISearchAlgorithms.cs ***
*** CLASS : CSc 346 ***
*** ASSIGNMENT : 4 ***
*** DUE DATE : 04-02-25 ***
*** INSTRUCTOR : GAMRADT ***
*********************************************************************
*** DESCRIPTION : Interface defining contract for graph search algorithms.
********************************************************************/

using System.Collections.Generic;

namespace GraphNS
{
    public interface ISearchAlgorithms
    {
        /********************************************************************
        *** PROPERTY Queue ***
        *********************************************************************
        *** DESCRIPTION : Queue for BFS implementation.
        ********************************************************************/
        Queue<Node> Queue { get; set; }

        /********************************************************************
        *** PROPERTY Stack ***
        *********************************************************************
        *** DESCRIPTION : Stack for DFS implementation.
        ********************************************************************/
        Stack<Node> Stack { get; set; }

        /********************************************************************
        *** METHOD DepthFirstSearch ***
        *********************************************************************
        *** DESCRIPTION : Performs Depth-First Search from starting node.
        *** INPUT ARGS : start - Starting node ID
        *** OUTPUT ARGS : none
        *** IN/OUT ARGS : none
        *** RETURN : void
        ********************************************************************/
        void DepthFirstSearch(int start);

        /********************************************************************
        *** METHOD BreadthFirstSearch ***
        *********************************************************************
        *** DESCRIPTION : Performs Breadth-First Search from starting node.
        *** INPUT ARGS : start - Starting node ID
        *** OUTPUT ARGS : none
        *** IN/OUT ARGS : none
        *** RETURN : void
        ********************************************************************/
        void BreadthFirstSearch(int start);
    }
}