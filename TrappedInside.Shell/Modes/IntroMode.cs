using TrappedInside.Core;
using TrappedInside.Core.States;
using TrappedInside.Shell.Modes.InGame;
using static TrappedInside.Shell.ShellFunctions.BasicShellFunctions;
using static TrappedInside.Shell.Widgets.IntroWidget;

namespace TrappedInside.Shell.Modes;

public sealed class IntroMode : Mode
{
	public override Mode Run()
	{
		ClearScreen();
		DrawGameTitle();
		DrawGameCredits();
		PromptForKey(PushKeyWhitespace);
		return new InGameMode(new NewTurnState(StartingGameData.InitialData));
	}
}