using TrappedInside.Core.Primitives;

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
	Study
}

public sealed record Room(RoomIdentifier Id, Text Name);