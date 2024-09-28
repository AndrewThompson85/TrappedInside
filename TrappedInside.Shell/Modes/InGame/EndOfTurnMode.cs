using TrappedInside.Core.Data;
using TrappedInside.Core.States;
using TrappedInside.Shell.ShellFunctions;

namespace TrappedInside.Shell.Modes.InGame;

public sealed class EndOfTurnMode(GameData Data) : Mode
{
	public override Mode Run()
	{
		BasicShellFunctions.WriteLine("End Of Turn");
		BasicShellFunctions.PromptForKey();
		
		return new NewTurnMode(new NewTurnState(Data.NextTurn()));
	}
}