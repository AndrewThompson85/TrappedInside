using TrappedInside.Core.Environment;
using TrappedInside.Core.Primitives;

namespace TrappedInside.Core.Characters;

public enum CharacterId
{
	Alex,
	Sandra,
	Bill,
	Olivia
}

public abstract record Character(CharacterId Id);

public sealed record AliveCharacter(CharacterId Id, Condition Condition, RoomIdentifier Location) : Character(Id);


