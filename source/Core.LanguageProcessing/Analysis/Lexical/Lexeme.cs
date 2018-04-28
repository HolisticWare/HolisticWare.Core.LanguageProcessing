using System;

namespace Core.LanguageProcessing.Analysis.Lexical
{
	/// <summary>
	/// Lexeme.
	/// </summary>
	/// <see cref="https://en.wikipedia.org/wiki/Lexical_analysis#Lexeme"/>
	public partial class Lexeme<LexemeType> 
	{
		public string Value
		{
			get;
			set;
		}
			
		public override string ToString() 
		{
			return Value;
		}

	}

	public partial class Lexeme : Lexeme<string> 
	{
		public string Value
		{
			get;
			set;
		}

		public override string ToString() 
		{
			return Value;
		}

	}
}

