using TrappedInside.Core.Environment;
using TrappedInside.Core.Primitives;

namespace TrappedInside.Core.Characters;

public abstract record Character(Text Name);

public sealed record AliveCharacter(Text Name, Condition Condition, RoomIdentifier Location) : Character(Name);


