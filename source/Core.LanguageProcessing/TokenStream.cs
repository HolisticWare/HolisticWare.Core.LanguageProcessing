using System;
using System.Collections.Generic;

namespace Core.LanguageProcessing
{
	public partial class TokenStream 
		: 
		// IObservable<Token> 						// not recommended
		// System.Reactive.Subjects.Subject<Token> 	// sealed class
		IEnumerable<Token>
	{
		List<Token> token_list = new List<Token>();

		public Token this[int index]  
		{  
			get { return token_list[index]; }  
			set { token_list.Insert(index, value); }  
		} 

		public IEnumerator<Token> GetEnumerator()
		{
			return token_list.GetEnumerator();
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}	}
}

