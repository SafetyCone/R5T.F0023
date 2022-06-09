using System;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

using R5T.T0132;


namespace R5T.F0023
{
	[FunctionalityMarker]
	public interface ISyntaxGenerator : IFunctionalityMarker,
		F0007.ISyntaxGenerator
	{
		public DocumentationCommentTriviaSyntax SummaryDocumentationCommentSyntax(string text)
        {
			var documentationSummaryText =
$@"
/// <summary>
/// {text}
/// </summary>
";
			var output = Instances.SyntaxParser.ParseDocumentation(documentationSummaryText);
			return output;
		}

		public SyntaxTrivia SummaryDocumentationComment(string text)
        {
			var syntax = this.SummaryDocumentationCommentSyntax(text);

			var output = this.Trivia(syntax);
			return output;
        }
	}
}