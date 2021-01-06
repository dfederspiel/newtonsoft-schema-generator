using MyProjectWithModels;
using Newtonsoft.Json.Schema.Generation;
using System;


/// <summary>
/// Using Json Schema Generator, we can quickly convert .Net classes to JSON Schema Definitions for use in validation.
/// </summary>
namespace MyNewConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello JSchemaGenerator!");

            var generater = new JSchemaGenerator();
            var schema1 = generater.Generate(typeof(MyCustomType1));
            var schema2 = generater.Generate(typeof(MyCustomType2));
            var schema3 = generater.Generate(typeof(MyCustomType3));
            var schema4 = generater.Generate(typeof(MyCustomType4));
            var schema5 = generater.Generate(typeof(MyCustomType5));
            var schema6 = generater.Generate(typeof(MyCustomType6));
            var schema7 = generater.Generate(typeof(MyCustomType7));
            var schema8 = generater.Generate(typeof(ThingOne));
            var schema9 = generater.Generate(typeof(ThingTwo));
            var schema10 = generater.Generate(typeof(ThingThree));

            Console.WriteLine(schema1);
            Console.WriteLine(schema2);
            Console.WriteLine(schema3);
            Console.WriteLine(schema4);
            Console.WriteLine(schema5);
            Console.WriteLine(schema6);
            Console.WriteLine(schema7);
            Console.WriteLine(schema8);
            Console.WriteLine(schema9);
            Console.WriteLine(schema10);

            Console.ReadKey();
        }
    }
}
