using TrappedInside.Core.Data;
using TrappedInside.Core.Environment;

namespace TrappedInside.Core.States.CharacterActions;

public static class CharacterActionStateFunctions
{
	public static RoomIdentifier Location(this CharacterActionState state) => state.Data.WhereIs(state.Character);

	public static CharacterActionState ConsumeAnAction(this CharacterActionState state) =>
		state with { RemainingActions = state.RemainingActions - 1 };
}