using Spectre.Console;

namespace TrappedInside.Shell.ShellFunctions;

public static class BasicShellFunctions
{
	public static void ClearScreen() => AnsiConsole.Clear();
	public static void WriteLine(TrappedInside.Core.Primitives.Text value) => AnsiConsole.WriteLine(value.Value);

	public static void BlankLines(uint amount = 0)
	{
		for (var x = 0; x < amount; x++)
		{
			AnsiConsole.WriteLine(string.Empty);
		}
	}

	public static void PromptForKey(uint whitespace = 0)
	{
		BlankLines(whitespace);
		DrawRule("Push any key to continue", ViewInvariants.PromptColor);
		Console.ReadKey(true);
	}

	public static void DrawRule(string text, Color color)
	{
		var rule = new Rule(text).Centered();
		rule.Style = new Style(color);
		AnsiConsole.Write(rule);
	}
}