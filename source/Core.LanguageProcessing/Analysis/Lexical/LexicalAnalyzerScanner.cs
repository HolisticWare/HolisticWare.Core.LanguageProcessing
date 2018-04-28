using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reactive.Linq;
using System.Diagnostics;
using System.IO;
using System.ComponentModel;
using System.Text;

namespace Core.LanguageProcessing.Analysis.Lexical
{
	public partial class LexicalAnalyzerScanner 
		: 
		IScanner
		//INotifyPropertyChanged
	{
		public LexicalAnalyzerScanner ()
		{
			//Run Parse when SearchText property changes
			//this.PropertyChanges(scanner => scanner.Text).Subscribe(Parse);

			return;
		}
			
		public ObservableCollection<string> Results 
		{ 
			get; 
		}

		public string Text
		{
			get;
		}

		public bool IsParsing 
		{ 
			get; 
			protected set; 
		}

		public string Error 
		{ 
			get; 
			protected set; 
		}

		public string TokenLexemCurrent
		{
			get;
			private set;
		}

		public LexicalStructure LexicalStructure
		{
			get;
			set;
		}

		StringBuilder sb_token_lexem_current = null;

		public IEnumerable<Lexeme> Scan(TextReader reader) 
		{
			char character_current_next = (char) reader.Peek ();
			char character_current = default(char);

			while ( character_current_next != '\uffff' ) 
			{
				character_current = (char) reader.Read ();
				sb_token_lexem_current = new StringBuilder ();

				character_current_next = (char) reader.Peek ();

				bool is_whitespace = LexicalStructure.IsWhiteSpace (character_current_next);
				bool is_delimiter_punctutator = LexicalStructure.IsDelimiter (character_current_next);

				if ( is_whitespace || is_delimiter_punctutator )
				{
					sb_token_lexem_current.Append (character_current);

					Lexeme token_lexem = new Lexeme ()
					{
						Value = sb_token_lexem_current.ToString ()
					};

					yield return token_lexem;
				}

			}

			yield return default(Lexeme);
		}

		private void Search(string searchText)
		{
			/*
			using (_currentSearch) { }
			IsParsing = true;
			Results.Clear();
			Error = null;
			_currentSearch = 
				_memberSearchModel
					.SearchMembers(searchText)
					.Timeout(TimeSpan.FromSeconds(2))
					.SubscribeOn(_schedulerProvider.TaskPool)
					.ObserveOn(_schedulerProvider.Dispatcher)
					.Subscribe
						(
							Results.Add, 	// OnNext
							ex =>			// OnError
								{
									IsParsing = false;
									Error = ex.Message;
								},
							() => 			// OnFinished
								{
									IsParsing = false; 
								}
						);

			*/
			return;
		}
	}
}

