using System;
using System.Collections.Generic;
using System.Text;

namespace Compiler.Nodes.CommandNodes
{
    class ForCommandNode : ICommandNode
    {

        /// <summary>
        /// The name of the constant
        /// </summary>
        public IdentifierNode Identifier { get; }

        /// <summary>
        /// The condition expression
        /// </summary>
        public IExpressionNode Expression { get; }

        /// <summary>
        /// The second condition expression
        /// </summary>
        public IExpressionNode ExpressionTo { get; }

        /// <summary>
        /// The command inside the let block
        /// </summary>
        public ICommandNode Command { get; }

        /// <summary>
        /// The position in the code where the content associated with the node begins
        /// </summary>
        public Position Position { get; }

        public ForCommandNode(IdentifierNode identifier,
            IExpressionNode expression, IExpressionNode
            expressionTo, ICommandNode command, Position position)
        {
            Identifier = identifier;
            Expression = expression;
            ExpressionTo = expressionTo;
            Command = command;
            Position = position;
        }
    }
}
