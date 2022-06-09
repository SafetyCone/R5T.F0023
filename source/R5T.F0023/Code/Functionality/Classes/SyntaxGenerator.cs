using System;


namespace R5T.F0023
{
	public class SyntaxGenerator : ISyntaxGenerator
	{
    	#region Infrastructure

	    public static SyntaxGenerator Instance { get; } = new();

	    private SyntaxGenerator()
	    {
	    }

    	#endregion
	}
}