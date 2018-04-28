using System;

namespace Core.LanguageProcessing.Java
{
	public partial class LexicalStructure : Core.LanguageProcessing.Analysis.Lexical.LexicalStructure
	{
		public string[] Tokens = null;

		public string[] TokensKeywords = new string[] 
		{
			"abstract",
			"as",
			"async",
			"await",
			"base",
			"bool",
			"break",
			"byte",
			"case",
			"catch",
			"char",
			"checked",
			"class",
			"const",
			"continue",
			"decimal",
			"default",
			"delegate",
			"do",
			"double",
			"else",
			"enum",
			"event",
			"explicit",
			"extern",
			"false",
			"finally",
			"fixed",
			"float",
			"for",
			"foreach",
			"goto",
			"if",
			"implicit",
			"in",
			"int",
			"interface",
			"internal",
			"is",
			"lock",
			"long",
			"namespace",
			"new",
			"null'",
			"object",
			"operator",	
			"out",	
			"override",
			"params",
			"private",
			"protected",
			"public",
			"readonly",
			"ref",
			"return",	
			"sbyte",
			"sealed",
			"short",
			"sizeof",
			"stackalloc",
			"static",
			"string",
			"struct",	
			"switch",
			"this",
			"throw",
			"true",
			"try",
			"typeof",
			"uint",
			"ulong",
			"unchecked",
			"unsafe",
			"ushort",
			"using",
			"virtual",
			"void",
			"volatile",
			"while",
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

