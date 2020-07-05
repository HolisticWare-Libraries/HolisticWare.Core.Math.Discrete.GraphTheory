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
            nodes = new HashSet<Node>();
            edges = new HashSet<Edge>();
        }

        HashSet<Node> nodes;

        public HashSet<Node> Nodes
        {
            get
            {
                return nodes;
            }
        }

        HashSet<Edge> edges;

        public HashSet<Edge> Edges
        {
            get
            {
                return edges;
            }
        }

        public void Add(Node n)
        {
            nodes.Add(n);

            return;
        }

        public void Remove(Node n)
        {
            nodes.Remove(n);
            edges.RemoveWhere
                    (
                        (Edge e) =>
                        {
                            return (e.Tuple.first == n || e.Tuple.second == n);
                        }
                    );
            return;
        }

        public void Add(Edge e)
        {
            edges.Add(e);

            return;
        }

        public void Remove(Edge e)
        {
            edges.Remove(e);

            return;

        }


        public override string ToString()
        {
            return base.ToString();
        }
    }
}
