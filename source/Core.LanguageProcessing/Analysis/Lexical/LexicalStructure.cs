using System;

namespace Core.LanguageProcessing.Analysis.Lexical
{
	public partial class LexicalStructure
	{
		public string[] WhiteSpace
		{
			get;
			set;
		}

		public string[] PunctuatorsDelimiters
		{
			get;
			set;
		}

		public bool IsDelimiter(char c)
		{
			return IsWhiteSpace (c) || IsPunctuator(c);
		}
			
		public bool IsWhiteSpace(char c)
		{
			return Char.IsWhiteSpace (c);
		}

		public bool IsPunctuator(char c)
		{
			return Char.IsWhiteSpace (c);
		}
	}
}

