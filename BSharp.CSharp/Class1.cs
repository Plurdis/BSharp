using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSharp.CSharp
{
    public class Class1
    {
        public void Test()
        {


            SyntaxTree tree = CSharpSyntaxTree.ParseText(@"
namespace NS1
{ 
    class Class1
    { 
        public int ID { get; set; }
        public string Name { get; set; }
        public void Run(int id) { }        
    } 
}");
        }

        public void Test2()
        {
            //var classBlock = new ClassBlock("TestClass");

            //var method1 = new MethodBlock("LoopName");
            //method1.Parameters = new FieldBlock[]
            //{
            //    new FieldBlock("name", typeof(string).ToDynamic())
            //};

            //IfBlock if1 = new IfBlock();
            //ElseBlock else1 = new ElseBlock();

            //if1.Condition = new OperationBlock(
            //    new GetterBlock(method1.Parameters[0], new PropertyBlock("Length", null)),
            //    OperationType.Equal,
            //    new ValueBlock(3));

            //if1.Add(new ReturnBlock(method1.Parameters[0]));

            //else1.Add(new ReturnBlock(new ValueBlock("!")));

            //method1.Add(if1);
            //method1.Add(else1);

            //classBlock.AddMethod(method1);
        }
    }
}
