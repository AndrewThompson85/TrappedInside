using Spectre.Console;
using TrappedInside.Core.Characters;
using TrappedInside.Core.States;
using TrappedInside.Core.States.SelectingCharacter;
using static TrappedInside.Shell.ShellFunctions.BasicShellFunctions;

namespace TrappedInside.Shell.Modes.InGame;

public sealed class NewTurnMode(NewTurnState State) : Mode
{
	public override Mode Run()
	{
		ClearScreen();
		DrawRule("Start of turn 56", Color.Fuchsia);
		BlankLines(2);
		return new SelectingCharacterMode(new SelectingCharacterState(State.Data, []));
	}
}