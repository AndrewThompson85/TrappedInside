using Spectre.Console;

namespace TrappedInside.Shell.ShellFunctions;

public static class BasicShellFunctions
{
	public static void ClearScreen() => AnsiConsole.Clear();
	public static void WriteLine(string value) => AnsiConsole.WriteLine(value);
	
	public static void DrawRule(string text, Color color)
	{
		var rule = new Rule(text).Centered();
		rule.Style = new Style(color);
		AnsiConsole.Write(rule);
	}
}