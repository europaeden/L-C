using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compiler.Nodes.ParameterNodes
{
    public class ValueParameterNode : IParameterNode
    {
        public Position Position { get; }

        public SimpleTypeDeclarationNode TypeDeclaration { get; set; }

        public ValueParameterNode(Position position)
        {
            Position = position;
        }

       
    }
}