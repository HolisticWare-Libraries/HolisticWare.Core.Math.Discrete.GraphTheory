using System;
using System.Collections.Generic;

namespace Core.Math.Discrete.GraphTheory.Graphs
{
    /// <summary>
    /// Graph (undirected)
    /// is mathematical structure used to model pairwise relations between objects.
    /// Consists of
    ///     Nodes (Vertices, Points) and
    ///     Edges (Arcs, Links, or Lines)
    /// </summary>
    public partial class Graph
    {
        public Graph()
        {
        }

        public IEnumerable<Node> Nodes
        {
            get;
            set;
        }

        public IEnumerable<Edge> Edges
        {
            get;
            set;
        }

        //public override string ToString()
        //{
        //    return base.ToString();
        //}
    }
}
