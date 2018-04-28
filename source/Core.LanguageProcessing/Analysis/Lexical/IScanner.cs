using System;
using System.Collections.Generic;

using System.IO;

namespace Core.LanguageProcessing.Analysis.Lexical
{
	public interface IScanner 
	{
		IEnumerable<Lexeme> Scan(TextReader reader);
	}
}

