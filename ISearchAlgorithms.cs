/********************************************************************
*** NAME : Nadia Pinos ***
*** CLASS : CSc 346 ***
*** ASSIGNMENT : 4 ***
*** DUE DATE : 04-02-25 ***
*** INSTRUCTOR : GAMRADT ***
*********************************************************************
*** DESCRIPTION : This file defines the ISearchAlgorithms interface which ***
*** specifies the contract for classes that implement graph search ***
*** algorithms. ***
********************************************************************/

using System.Collections.Generic;

namespace GraphNS
{
    public interface ISearchAlgorithms
    {
        /********************************************************************
        *** PROPERTY Queue ***
        *********************************************************************
        *** DESCRIPTION : Gets or sets the queue used for BFS traversal. ***
        ********************************************************************/
        Queue<Node> Queue { get; set; }

        /********************************************************************
        *** PROPERTY Stack ***
        *********************************************************************
        *** DESCRIPTION : Gets or sets the stack used for DFS traversal. ***
        ********************************************************************/
        Stack<Node> Stack { get; set; }

        /********************************************************************
        *** METHOD DepthFS ***
        *********************************************************************
        *** DESCRIPTION : Performs depth-first search starting from the ***
        *** specified node ID. ***
        *** INPUT ARGS : start ***
        *** OUTPUT ARGS : none ***
        *** IN/OUT ARGS : none ***
        *** RETURN : void ***
        ********************************************************************/
        void DepthFS(int start);

        /********************************************************************
        *** METHOD BreadthFS ***
        *********************************************************************
        *** DESCRIPTION : Performs breadth-first search starting from the ***
        *** specified node ID. ***
        *** INPUT ARGS : start ***
        *** OUTPUT ARGS : none ***
        *** IN/OUT ARGS : none ***
        *** RETURN : void ***
        ********************************************************************/
        void BreadthFS(int start);
    }
}