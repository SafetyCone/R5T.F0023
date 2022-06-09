using System;


namespace R5T.F0023
{
	public class SyntaxParser : ISyntaxParser
	{
    	#region Infrastructure

	    public static SyntaxParser Instance { get; } = new();

	    private SyntaxParser()
	    {
	    }

    	#endregion
	}
}