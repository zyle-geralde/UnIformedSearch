using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AliacSearchAlgo;

namespace AISearchSample
{
    class Fringe2:Fringes
{
        Queue<Node> s;
        private HashSet<Node> visitedNodes;
        public Fringe2() 
        {
            s = new Queue<Node>();
            visitedNodes = new HashSet<Node>();
        }
        
        public void add(Node n,Node origin)
        {
            if (visitedNodes.Contains(n))
            {
                n.Origin = n.Origin;
            }
            else
            {
                n.Origin = origin;
                s.Enqueue(n);
                visitedNodes.Add(n);
            }
        }

        public Node remove()
        {
            if (s.Count != 0)
                 return s.Dequeue();
            return null;
        }
    }
}
