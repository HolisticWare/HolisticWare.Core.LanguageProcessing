using System;

namespace Core.LanguageProcessing
{
	public struct Token 
	{
		public readonly Kind kind;
		public readonly double nval;

		public string Value
		{
			get;
			set;
		}
			
		private Token(Kind k) 
			: this()
		{ 
			Value = String.Empty;
			kind = k; 
			nval = 0; 

			return;
		}

		private Token(double n)
			: this()
		{
			Value = String.Empty;
			kind = Kind.NUM; 
			nval = n;
		}

		public override string ToString() 
		{
			if (kind == Kind.NUM)
			{
				return "NUM(" + nval + ")";
			}
			else
			{
				return kind.ToString ();
			}
		}

		// Factory methods
		static public Token FromKind(Kind k) 
		{ 
			return new Token(k); 
		}

		static public Token FromDouble(double d) 
		{ 
			return new Token(d); 
		}
	}
}

