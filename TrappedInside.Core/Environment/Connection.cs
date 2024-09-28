using TrappedInside.Core.Items;

namespace TrappedInside.Core.Environment;

public abstract record RoomConnection(RoomIdentifier Left, RoomIdentifier Right);

public sealed record OpenPassage(RoomIdentifier Left, RoomIdentifier Right) : RoomConnection(Left, Right);

public abstract record BlockedPassage(RoomIdentifier Left, RoomIdentifier Right) : RoomConnection(Left, Right);

public abstract record LockedDoor(RoomIdentifier Left, RoomIdentifier Right, KeyIdentifier RequiredKey);