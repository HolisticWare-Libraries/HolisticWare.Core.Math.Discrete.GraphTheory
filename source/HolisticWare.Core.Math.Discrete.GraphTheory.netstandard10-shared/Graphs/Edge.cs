namespace Core.Math.Discrete.GraphTheory.Graphs
{
    /// <summary>
    /// Edge, Arc
    /// </summary>
    /// <see cref="https://en.wikipedia.org/wiki/Graph_theory"/>
    public partial class Edge : GraphElement
    {
        public Edge(Node begin, Node end)
        {
        }

        public override string ToString()
        {
            string s = "Edge";

            s = s + System.Environment.NewLine + $"  Label = {this.Label}";

            return s;
        }
    }
}
