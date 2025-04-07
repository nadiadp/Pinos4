using System.Collections.Generic;

namespace GraphNS
{
    public interface ISearchAlgorithms
    {
        Queue<Node> Queue { get; set; }
        Stack<Node> Stack { get; set; }
        void DepthFS(int start);
        void BreadthFS(int start);
    }
}