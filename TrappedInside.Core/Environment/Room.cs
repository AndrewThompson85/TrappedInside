using System.Collections.Immutable;

namespace TrappedInside.Core.Environment;

public enum RoomIdentifier
{
	MasterBedroom,
	HallWay,
	GuestBedroom,
	Bathroom,
	LivingRoom,
	DiningRoom,
	Kitchen,
	Study,
	Garage
}

public sealed record Room;

public sealed record Map(ImmutableDictionary<RoomIdentifier, Room> Rooms, ImmutableArray<RoomConnection> Connections);