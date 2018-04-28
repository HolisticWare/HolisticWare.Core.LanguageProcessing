using System;
using System.IO;
using System.Collections.Generic;
using System.Reactive;
using System.Reactive.Linq;

using NUnit.Framework;

using Core.LanguageProcessing.Analysis.Lexical;

using Consume.Core.LanguageProcessing;

namespace UnitTests.Core.LanguageProcessing
{
	[TestFixture ()]
	public class TestBinnaryScanner
	{
		string testcase = @"0 1 00 11";
		
		[Test ()]
		public void Test01 ()
		{
			TextReader tr = new StringReader (testcase);

			BinnaryScanner scanner = new BinnaryScanner ();
			scanner.LexicalStructure = new LexicalStructure () 
			{
				WhiteSpace = new string[]{},
				PunctuatorsDelimiters = new string[]{}
			};
			IEnumerable<Lexeme> tokens_enumerable = scanner.Scan (tr);
			IObservable<Lexeme> tokens = tokens_enumerable.ToObservable();

			tokens.Subscribe
			(
				token =>
				{
					Console.WriteLine("token = " + token.Value);
				},
				exception => 
				{
					Console.WriteLine("excpetion = " + exception.Message);

				},
				() =>
				{
					Console.WriteLine("Parsing Complete " );
				}
			);
				
			List<Lexeme> list = new List<Lexeme> (tokens_enumerable);

			return;
		}
	}
}

