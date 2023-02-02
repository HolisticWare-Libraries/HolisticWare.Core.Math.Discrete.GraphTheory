using System;
using System.Collections.Generic;

namespace Core.Math.Discrete.GraphTheory.Networks
{
    public partial class Graph<NodeType, EdgeType>
    {
        public Graph()
        {
        }

        public IEnumerable<NodeType> Nodes
        {
            get;
            set;
        }

        public IEnumerable<EdgeType> Edges
        {
            get;
            set;
        }

    }
}
