using static TrappedInside.Shell.ShellFunctions.BasicShellFunctions;

namespace TrappedInside.Shell.Modes;

public sealed class IntroMode : Mode
{
	public override Mode Run()
	{
		ClearScreen();
		WriteLine("Hello World");
		return new CloseApplicationMode();
	}
}