using System;

namespace Core.Math.Discrete.GraphTheory.Graphs
{
    /// <summary>
    /// Edge, Arc
    /// </summary>
    /// <see cref="https://en.wikipedia.org/wiki/Graph_theory"/>
    public partial class
                                        Edge<EdgeType, NodeType>
                                            :
                                        EdgeBase
    {
        public
                                        Edge
                                            (
                                                Node<NodeType> begin,
                                                Node<NodeType> end
                                            )
        {
            this.Nodes = (First: begin, Second: end);

            return;
        }

        public
            NodeType
                                        Weight
        {
            get;
            set;
        }

        private
            (
                Node<NodeType> First,
                Node<NodeType> Second
            )
                                        nodes;

        public
            (
                Node<NodeType> First,
                Node<NodeType> Second
            )
                                        Nodes
        {
            get
            {
                return this.nodes;
            }

            set
            {
                this.nodes = value;
            }
        }

        public override
            string
                                        ToString
                                            (
                                            )
        {
            string s = "Edge";

            s = s + System.Environment.NewLine + $"  Label = {this.Label}";

            return s;
        }
    }
}
