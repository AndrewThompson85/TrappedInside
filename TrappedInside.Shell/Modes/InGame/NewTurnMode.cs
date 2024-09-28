using Spectre.Console;
using TrappedInside.Core.Characters;
using TrappedInside.Core.States;
using TrappedInside.Shell.ShellFunctions;

namespace TrappedInside.Shell.Modes.InGame;

public sealed class NewTurnMode(NewTurnState State) : Mode
{
	public override Mode Run()
	{
		BasicShellFunctions.ClearScreen();
		BasicShellFunctions.DrawRule("Start of turn 56", Color.Fuchsia);

		return new SelectingCharacterMode(new SelectingCharacterState(State.Data, State.Data.AliveCharacters().Ids()));
	}
}