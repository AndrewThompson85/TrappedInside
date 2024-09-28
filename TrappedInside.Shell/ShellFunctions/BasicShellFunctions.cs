using Spectre.Console;

namespace TrappedInside.Shell.ShellFunctions;

public static class BasicShellFunctions
{
	public static void ClearScreen() => AnsiConsole.Clear();
	public static void WriteLine(string value) => AnsiConsole.WriteLine(value);
}