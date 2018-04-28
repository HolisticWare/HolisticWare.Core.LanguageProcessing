using System;

namespace Core.LanguageProcessing
{
	/// <summary>
	/// Token.
	/// </summary>
	/// <see cref="https://en.wikipedia.org/wiki/Lexical_analysis#Token"/> 
	public partial class Token<LexemeType>
	{
		public Token ()
		{
		}

		public Lexeme<LexemeType> Lexeme
		{
			get;
			set;
		}

	}
}

