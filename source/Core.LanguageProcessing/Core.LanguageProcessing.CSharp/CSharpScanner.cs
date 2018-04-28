using System;
using System.Collections.Generic;
using System.IO;

using Core.LanguageProcessing.Analysis.Lexical;

namespace Core.LanguageProcessing.CSharp
{
	public partial class CSharpScanner : LexicalAnalyzerScanner
	{
		public CSharpScanner()
		{
			this.LexicalStructure = new Core.LanguageProcessing.CSharp.LexicalStructure () 
			{
			};

			return;
		}
	}
}

