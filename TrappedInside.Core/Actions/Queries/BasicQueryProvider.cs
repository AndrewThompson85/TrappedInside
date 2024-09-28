using System.Collections.Immutable;
using TrappedInside.Core.Characters;
using TrappedInside.Core.Data;
using TrappedInside.Core.Information;
using TrappedInside.Core.States.CharacterActions;

namespace TrappedInside.Core.Actions.Queries;

public static class BasicQueryProvider
{
	public static ImmutableArray<CharacterAction> GetAvailableQueries(this CharacterActionState state) =>
	[
		GetInventoryQuery(state),
	];

	private static CharacterAction GetInventoryQuery(CharacterActionState state)
	{
		var character = state.Data.GetCharacter(state.Character);
		if (character is not AliveCharacter alive)
		{
			return new CharacterAction(ActionCategory.Query, actionState => actionState, "Inventory", []);
		}

		var inventory = alive.Inventory;

		return new CharacterAction(ActionCategory.Query, a => a, "Inventory",
			[..inventory.Items.Select(i => new BasicMessage(i.Identifier.ToString()))]);
	}
}