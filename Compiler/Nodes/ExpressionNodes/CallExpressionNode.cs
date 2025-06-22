using Compiler.Tokenization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compiler.Nodes.ExpressionNodes
{
  public class CallExpressionNode : IExpressionNode
    {
       public IdentifierNode Identifier { get; }

       public IParameterNode Parameter { get; }

        public SimpleTypeDeclarationNode Type { get; set; }

        public Position Position { get { return Identifier.Position; } }

        public CallExpressionNode(IdentifierNode identifier, IParameterNode parameter)
        {
            Identifier = identifier;
            Parameter = parameter;
            
        }
    }
}
