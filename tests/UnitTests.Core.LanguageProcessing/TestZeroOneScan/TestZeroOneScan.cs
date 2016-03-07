using System;
using System.IO;
using System.Collections.Generic;
using System.Reactive;
using System.Reactive.Linq;

using NUnit.Framework;

using Core.LanguageProcessing;

using Consume.Core.LanguageProcessing;

namespace UnitTests.Core.LanguageProcessing
{
	[TestFixture ()]
	public class TestZeroOneScan
	{
		string testcase = @"0 1 00 11";
		
		[Test ()]
		public void Test01 ()
		{
			TextReader tr = new StringReader (testcase);

			ZeroOneScan scanner = new ZeroOneScan ();
			IEnumerable<Token> tokens_enumerable = scanner.Scan (tr);

			IObservable<Token> tokens = tokens_enumerable.ToObservable();

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

			return;
		}
	}
}

