using System.Collections.Immutable;
using TrappedInside.Core.Characters;
using TrappedInside.Core.Data;
using TrappedInside.Core.Environment;
using TrappedInside.Core.Information;
using TrappedInside.Core.States.CharacterActions;
using static TrappedInside.Core.Actions.ActionCategory;

namespace TrappedInside.Core.Actions;

public static class MoveActionsProvider
{
	public static ImmutableArray<CharacterAction> GetAvailableMoves(this CharacterActionState state)
	{
		var connections = state.Data.Map.Connections;
		var location = state.Location();
		var availableMoves = connections
			.OfType<OpenPassage>()
			.Where(c => c.Left == location || c.Right == location)
			.Select(c => location switch
			{
				var x when x == c.Left => c.Right,
				_ => c.Left
			}).ToImmutableArray();

		
		return [..availableMoves.Select(dest => new CharacterAction( Move,CreateMoveCharacterActionFunction(state.Character, dest), $"Move to {dest}", [new BasicMessage($"You moved to the {dest}")]).UsesAnAction())];
	}

	private static CharacterActionFunction CreateMoveCharacterActionFunction(CharacterId character, RoomIdentifier destination) =>
		state => state with {Data = state.Data.MoveCharacterTo(character, destination)};

}