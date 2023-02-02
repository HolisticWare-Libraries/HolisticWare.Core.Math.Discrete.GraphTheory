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
        }

        public
            NodeType
                                        Weight
        {
            get;
            set;
        }

        public
            (
                Node<NodeType> first,
                Node<NodeType> second
            )
                                        Tuple
        {
            get;
            set;
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
