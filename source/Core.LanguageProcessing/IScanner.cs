using System;
using System.Collections.Generic;
using System.IO;

namespace Core.LanguageProcessing
{
	public interface IScanner 
	{
		IEnumerable<Token> Scan(TextReader reader);
	}
}

