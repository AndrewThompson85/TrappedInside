using Spectre.Console;
using TrappedInside.Core.Actions;
using TrappedInside.Core.Information;
using TrappedInside.Core.States.CharacterActions;
using TrappedInside.Core.States.SelectingCharacter;
using TrappedInside.Shell.ShellFunctions;
using TrappedInside.Shell.Widgets;

namespace TrappedInside.Shell.Modes.InGame;

public sealed class ChoosingCharacterActionMode(CharacterActionState State, SelectingCharacterState SelectNextCharacters) : Mode
{
	public override Mode Run()
	{
		BasicShellFunctions.ClearScreen();
		BasicShellFunctions.WriteLine($"You are in {State.Location()}, and you have {State.RemainingActions} actions remaining.");

		var actions = State.GetAllAvailableActions();

		var groups = actions.GroupBy(a => a.Category);

		var actionMenu = new SelectionPrompt<CharacterAction>()
			.Title("What do you want to do next?")
			.PageSize(10)
			.UseConverter(a => a.Description);

		foreach (var group in groups)
		{
			actionMenu.AddChoiceGroup(new CharacterAction(group.Key, a => a, group.Key.ToString(), []),group).UseConverter(g => g.Description);
		}
			
		
		var chosenAction = AnsiConsole.Prompt(actionMenu);

		var nextState = chosenAction.Function(State);

		foreach (var info in chosenAction.Information)
		{
			switch (info)
			{
				case BasicMessage basicMessage:
					BasicShellFunctions.WriteLine(basicMessage.Message);
					break;
				case InventoryListing inventoryListing:
					InventoryWidget.DrawInventoryWidget(inventoryListing.inventory);
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