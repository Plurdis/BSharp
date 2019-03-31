using BSharp.Common;
using BSharp.Components;
using BSharp.Extensions;
using System;

namespace BSharp.Test
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public void Test()
        {
            var classBlock = new ClassBlock()
            {
                Name = "TestClass"
            };

            var method1 = new MethodBlock();
            method1.Name = "LoopName";
            method1.Parameters = new FieldBlock[]
            {
                new FieldBlock("name", typeof(string).ToDynamic())
            };

            IfBlock if1 = new IfBlock();
            ElseBlock else1 = new ElseBlock();

            if1.Condition = new OperationBlock(
                new GetterBlock(method1.Parameters[0], new PropertyBlock("Length", null)),
                OperationType.Equal,
                new ValueBlock(3));

            if1.Add(new ReturnBlock(method1.Parameters[0]));

            else1.Add(new ReturnBlock(new ValueBlock("!")));

            method1.Add(if1);
            method1.Add(else1);

            classBlock.AddMethod(method1);
        }
    }


    public class TestClass
    {
        public string LoopName(string name)
        {
            if (name.Length == 3)
            {
                return name;
            }
            else
            {
                return "!";
            }
        }
    }
}
