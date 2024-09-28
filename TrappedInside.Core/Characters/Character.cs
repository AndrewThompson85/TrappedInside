using TrappedInside.Core.Environment;
using TrappedInside.Core.Items;
using TrappedInside.Core.Primitives;

namespace TrappedInside.Core.Characters;

public enum CharacterId
{
	Alex,
	Sandra,
	Bill,
	Olivia
}

public abstract record Character(CharacterId Id, RoomIdentifier Location);

public sealed record AliveCharacter(CharacterId Id, Condition Condition, RoomIdentifier Location, Inventory Inventory) : Character(Id, Location);


