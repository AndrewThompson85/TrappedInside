using System.Collections.Immutable;
using TrappedInside.Core.Characters;
using TrappedInside.Core.Environment;
using static TrappedInside.Core.Characters.CharacterId;
using static TrappedInside.Core.Environment.RoomIdentifier;

namespace TrappedInside.Core;

public static class StartingGameData
{
	public static readonly GameData InitialData = new(
		[
			new AliveCharacter(Alex, Condition.Healthy , MasterBedroom ),
			new AliveCharacter(Sandra, Condition.Healthy, DiningRoom ),
			new AliveCharacter(Bill, Condition.Healthy, Kitchen),
			new AliveCharacter(Olivia, Condition.Healthy, DiningRoom)
		], Map
	);

	public static readonly Map Map = new(Rooms, Connections);

	public static readonly ImmutableDictionary<RoomIdentifier, Room> Rooms = new Dictionary<RoomIdentifier, Room>
	{
		{ Kitchen, new Room()},
		{ MasterBedroom, new Room()},
		{ DiningRoom, new Room()}
	}.ToImmutableDictionary();
	
	public static readonly ImmutableArray<RoomConnection> Connections = 
	[
		new OpenPassage(Kitchen, DiningRoom)
	];

}