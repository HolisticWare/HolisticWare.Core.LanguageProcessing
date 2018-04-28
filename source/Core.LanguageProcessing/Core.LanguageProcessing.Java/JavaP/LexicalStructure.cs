using System;

namespace Core.LanguageProcessing.JavaP
{
	public partial class LexicalStructure : Core.LanguageProcessing.Analysis.Lexical.LexicalStructure
	{
		public string[] Tokens = null;

		public string[] TokensKeywords = new string[] 
		{
		};
		


		public string[] TokensOperators = new string[] 
		{
			"+",
			"-",
			"*",
			"/",
			"%",
			"&",
			"|",
			"^",
			"!",
			"~",
			"=",
			"<",
			">",
			"?",
			"++",
			"--",
			"&&",
			"||",
			"<<",
			">>",
			"==",
			"!=",
			"<=",
			">=",
			"+=",
			"-=",
			"*=",
			"/=",
			"%=",
			"&=",
			"|=",
			"^=",
			"<<=",
			">>=",
			"->",
		};

		public string[] TokensIdentifiers = new string[] 
		{
		};

		public string[] TokensLiterals = new string[] 
		{
		};
			
		public string[] LiteralsBoolean = new string[] 
		{
			"true",
			"false",
		};

		public string[] TokensLiteralsString = new string[] 
		{
			"\"",
		};

		public string[] TokensLiteralsCharacter = new string[] 
		{
			"\'",
		};


		partial void InitializeWhiteSpace();
		partial void InitializePunctuatorsDelimiters();

		public LexicalStructure()
		{
			InitializeWhiteSpace ();
			InitializePunctuatorsDelimiters ();

			return;
		}

		partial void InitializeWhiteSpace()
		{
			return;
		}

		partial void InitializePunctuatorsDelimiters()
		{
			PunctuatorsDelimiters = new string[] 
			{
				"(",	// 40
				")",	// 41
				",",	// 44
				//".",	// 46
				":",	// 58
				";",	// 59
				"<",	// 60
				">",	// 62
				"[",	// 91
				"]",    // 93
				"{",	// 123
				"}",	// 125
			};
				
			return;
		}

	}
}

