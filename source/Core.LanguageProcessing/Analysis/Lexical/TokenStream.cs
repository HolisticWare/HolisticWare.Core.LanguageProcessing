using System;
using System.Collections.Generic;

namespace Core.LanguageProcessing.Analysis.Lexical
{
	public partial class TokenStream 
		: 
		// IObservable<Token> 						// not recommended
		// System.Reactive.Subjects.Subject<Token> 	// sealed class
		IEnumerable<Lexeme>
	{
		List<Lexeme> token_list = new List<Lexeme>();

		public Lexeme this[int index]  
		{  
			get { return token_list[index]; }  
			set { token_list.Insert(index, value); }  
		} 

		public IEnumerator<Lexeme> GetEnumerator()
		{
			return token_list.GetEnumerator();
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}	}
}

