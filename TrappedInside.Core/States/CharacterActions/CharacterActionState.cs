using TrappedInside.Core.Characters;
using TrappedInside.Core.Data;

namespace TrappedInside.Core.States.CharacterActions;

public sealed record CharacterActionState(GameData Data, CharacterId Character, uint RemainingActions) : State(Data)
{
	public static CharacterActionState New(GameData data, CharacterId character) =>
		new(data, character, Invariants.ActionsPerTurn);
}