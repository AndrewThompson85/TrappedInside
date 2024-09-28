using TrappedInside.Shell.Widgets;
using static TrappedInside.Shell.ShellFunctions.BasicShellFunctions;

namespace TrappedInside.Shell.Modes;

public sealed class IntroMode : Mode
{
	public override Mode Run()
	{
		ClearScreen();
		IntroWidget.DrawGameTitle();
		IntroWidget.DrawGameCredits();
		return new CloseApplicationMode();
	}
}