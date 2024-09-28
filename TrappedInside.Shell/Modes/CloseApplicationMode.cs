using Spectre.Console;

namespace TrappedInside.Shell.Modes;

public sealed class CloseApplicationMode : Mode
{
	public override Mode Run()
	{
		AnsiConsole.WriteLine("Press any key to exit.");
		Console.ReadKey(true);
		return this;
	}
}