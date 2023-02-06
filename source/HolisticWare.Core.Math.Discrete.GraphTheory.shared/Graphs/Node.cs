using System;

namespace Core.Math.Discrete.GraphTheory.Graphs
{
    public partial class
                                        Node<NodeType>
                                        :
                                        NodeBase
    {
        /// <summary>
        /// Constructor (default)
        /// </summary>
        public
                                        Node
                                            (
                                            )
        {
            return;
        }

        public
            NodeType
                                        Weight
        {
            get;
            set;
        }

    }
}
