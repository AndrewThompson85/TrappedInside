using Spectre.Console;
using TrappedInside.Core.Actions;
using TrappedInside.Core.Information;
using TrappedInside.Core.States.CharacterActions;
using TrappedInside.Core.States.SelectingCharacter;
using TrappedInside.Shell.ShellFunctions;

namespace TrappedInside.Shell.Modes.InGame;

public sealed class ChoosingCharacterActionMode(CharacterActionState State, SelectingCharacterState SelectNextCharacters) : Mode
{
	public override Mode Run()
	{
		BasicShellFunctions.ClearScreen();
		BasicShellFunctions.WriteLine($"You are in {State.Location()}, and you have {State.RemainingActions} actions remaining.");

		var actions = State.GetAllAvailableActions();

		var chosenAction = AnsiConsole.Prompt(
			new SelectionPrompt<CharacterAction>()
				.Title("What do you want to do next?")
				.PageSize(10)
				.AddChoices(actions)
				.UseConverter(a => a.Description));

		var nextState = chosenAction.Function(State);

		foreach (var info in chosenAction.Information)
		{
			switch (info)
			{
				case BasicMessage basicMessage:
					BasicShellFunctions.WriteLine(basicMessage.Message);
					break;
			}
		}
		
		BasicShellFunctions.PromptForKey();
		
		if (nextState.RemainingActions > 0)
		{
			return new ChoosingCharacterActionMode(nextState, SelectNextCharacters);
		}
		
		BasicShellFunctions.PromptForKey();
		return new SelectingCharacterMode(SelectNextCharacters with { Data = State.Data });
	}
}