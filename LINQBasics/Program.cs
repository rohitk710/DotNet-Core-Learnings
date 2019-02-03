using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQBasics
{
	class Program
	{
		static void Main(string[] args)
		{
			// 1. LINQ Query Syntax

			Console.Out.WriteLine("LINQ Query Syntax");

			IList<string> stringList = new List<string>() {
			"C# Tutorials",
			"VB.NET Tutorials",
			"Learn C++",
			"MVC Tutorials" ,
			"Java"
			};

			// LINQ Query Syntax
			// From rangeVariableName in IEnumerableCollection
			// LINQ query syntax always ends with a Select or Group clause
			var result = from s in stringList
						 where s.Contains("Tutorials")
						 select s;
			foreach(string a in result)
			{
				Console.Out.WriteLine(a);
			}
			
			Console.ReadKey();

			// 2. LINQ Method Syntax
			Console.Out.WriteLine("LINQ Method Syntax");

			// Method syntax comprises of extension methods and Lambda expression. The extension method Where() is defined in the Enumerable class.
			// You can also use a Delegate instead of a Lambda expression.
			result = stringList.Where(s => s.Contains("Tutorials"));
			foreach (string a in result)
			{
				Console.Out.WriteLine(a);
			}
			Console.ReadKey();


			// Delegate in itself is a good topic to cover. We have different type of delegates like Func<>, Action<> delegates etc.
			// See the filtering operator Where below to see how a Func delegate works.
			

			// 3. Filtering Operators - Where
			Console.Out.WriteLine("Filtering Operators - Where");
			//The Where extension method has following two overloads. Both overload methods accepts a Func delegate type parameter.
			// This filters the collection based on a predicate function.

			Func<string, bool> mydel = s => s.Contains("Java");
			result = from s in stringList
					 where mydel(s)
					 select s;
			foreach (string a in result)
			{
				Console.Out.WriteLine(a);
			}
			Console.ReadKey();

			//There is another filter operator OfType which filters from collection based on a given type.

			// 4. Sorting Operators: OrderBy

		}
	}
}
