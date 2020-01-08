namespace Compiler.Nodes
{
    /// <summary>
    /// A node corresponding to no parameters
    /// </summary>
    public class EmptyParameterNode : IParameterNode
    {
        /// <summary>
        /// The position in the code where the content associated with the node begins
        /// </summary>
        public Position Position { get; }

        /// <summary>
        /// The type of the parameter
        /// </summary>
        public SimpleTypeDeclarationNode Type { get; set; }

        /// <summary>
        /// Creates a new blank parameter node
        /// </summary>
        /// <param name="position">The position in the code where the content associated with the node begins</param>
        public EmptyParameterNode( Position position)
        {
            Position = position;
        }
    }
}