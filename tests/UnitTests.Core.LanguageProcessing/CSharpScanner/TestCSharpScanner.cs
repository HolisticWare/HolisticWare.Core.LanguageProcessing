using System;
using System.IO;
using System.Collections.Generic;
using System.Reactive;
using System.Reactive.Linq;

using NUnit.Framework;

using Core.LanguageProcessing.Analysis.Lexical;

using Consume.Core.LanguageProcessing;
using Core.LanguageProcessing.CSharp;

namespace UnitTests.Core.LanguageProcessing
{
	[TestFixture ()]
	public class TestCSharpScanner
	{
		Dictionary<string, string> testcases = new Dictionary<string, string> () 
		{ 
			{
				"Empty",
				@"
				"				
			}, 
			{
				"Comment",
				@"
					// Hello1.cs
				"				
			}, 
			{
				"Hello World 01",
				@"
					// Hello1.cs
					public class Hello1
					{
					   public static void Main()
					   {
					      System.Console.WriteLine(""Hello, World!"");
					   }
					}
				"				
			},
		};

		[Test ()]
		public void Test01 ()
		{
			foreach (KeyValuePair<string, string> kvp in testcases)
			{
				string testcase = kvp.Value;
			
				TextReader tr = new StringReader (testcase);

				CSharpScanner scanner = new CSharpScanner ();
				scanner.LexicalStructure = new global::Core.LanguageProcessing.CSharp.LexicalStructure () 
				{
					WhiteSpace = new string[]{ },
					PunctuatorsDelimiters = new string[]{ }
				};
				IEnumerable<Lexeme> tokens_enumerable = scanner.Scan (tr);
				IObservable<Lexeme> tokens = tokens_enumerable.ToObservable ();

				tokens.Subscribe
				(
					token =>
					{
						Console.WriteLine ("token = " + token.Value);
					},
					exception =>
					{
						Console.WriteLine ("excpetion = " + exception.Message);

					},
					() =>
					{
						Console.WriteLine ("Parsing Complete ");
					}
				);
					
				List<Lexeme> list = new List<Lexeme> (tokens_enumerable);
			}

			return;
		}
	}
}

