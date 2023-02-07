using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Math.Discrete.GraphTheory.Graphs
{
    /// <summary>
    /// Graph (undirected)
    /// is mathematical structure used to model pairwise relations between objects.
    /// Consists of
    ///     Nodes (Vertices, Points) and
    ///     Edges (Arcs, Links, Lines or Connections)
    /// </summary>
    /// <see href="https://en.wikipedia.org/wiki/Graph_theory" />
    /// <see href="https://en.wikipedia.org/wiki/Graph_(abstract_data_type)"/>
    public partial class
                                        Graph<NodeType, EdgeType>
                                        :
                                        GraphBase
    {
        public
                                        Graph
                                        (
                                        )
        {
            nodes = new HashSet<Node<NodeType>>();
            edges = new HashSet<Edge<EdgeType, NodeType>>();

            ToStringDelegate = ToString;

            return;
        }

        HashSet<Node<NodeType>> nodes;

        public HashSet<Node<NodeType>> Nodes
        {
            get
            {
                return nodes;
            }
        }

        HashSet<Edge<EdgeType, NodeType>> edges;

        public
            HashSet<Edge<EdgeType, NodeType>>
                                        Edges
        {
            get
            {
                return edges;
            }
        }

        public
            void
                                        Add
                                        (
                                            Node<NodeType> n
                                        )
        {
            if (!nodes.Contains(n))
            {
                nodes.Add(n);
            }

            return;
        }

        public
            void
                                        Add
                                        (
                                            Edge<EdgeType, NodeType> e
                                        )
        {
            if (!edges.Contains(e))
            {
                edges.Add(e);
            }

            if (!nodes.Contains(e.Nodes.First))
            {
                nodes.Add(e.Nodes.First);
            }
            if (!nodes.Contains(e.Nodes.Second))
            {
                nodes.Add(e.Nodes.Second);
            }

            return;
        }

        public
            void
                                        Remove
                                        (
                                            Node<NodeType> n
                                        )
        {
            nodes.Remove(n);
            edges.RemoveWhere
                        (
                            (Edge<EdgeType, NodeType> e) =>
                            {
                                return (e.Nodes.First == n || e.Nodes.Second == n);
                            }
                        );

            return;
        }

        public
            void
                                        Remove
                                        (
                                            Edge<EdgeType, NodeType> e
                                        )
        {
            edges.Remove(e);

            return;
        }


        public override
            string
                                        ToString
                                        (
                                        )
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());

            sb.AppendLine($"Nodes");
            sb.AppendLine($"  count = {nodes.Count}");

            foreach (Node<NodeType> n in nodes)
            {
                sb.AppendLine($"    Node");
                sb.AppendLine($"      NodeType = {typeof(NodeType)}");
                sb.AppendLine($"      Label    = {n.Label}");
            }

            sb.AppendLine("Edges");
            sb.AppendLine($"  count = {nodes.Count}");
            foreach (Edge<EdgeType, NodeType> e in edges)
            {
                sb.AppendLine($"    Node");
                sb.AppendLine($"      EdgeType = {typeof(EdgeType)}");
                sb.AppendLine($"      NodeType = {typeof(NodeType)}");
                sb.AppendLine($"      Label    = {e.Label}");
            }

            return sb.ToString();
        }

        public
            Func<string>
                                        ToStringDelegate;
    }
}
