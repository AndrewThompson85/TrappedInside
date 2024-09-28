using System.Collections.Immutable;
using TrappedInside.Core.Characters;
using TrappedInside.Core.Data;
using TrappedInside.Core.Environment;
using TrappedInside.Core.Items;
using static TrappedInside.Core.Characters.CharacterId;
using static TrappedInside.Core.Items.Inventory;
using static TrappedInside.Core.Environment.RoomIdentifier;

namespace TrappedInside.Core;

public static class StartingGameData
{
	public static readonly GameData InitialData = new(
		[
			new AliveCharacter(Alex, Condition.Healthy , MasterBedroom , Empty.AddCarryable(Carryable.Shotgun)),
			new AliveCharacter(Sandra, Condition.Healthy, DiningRoom, Empty.AddCarryable(Carryable.Pickaxe).AddKey(Key.MasterBedroomKey) ),
			new AliveCharacter(Bill, Condition.Healthy, Kitchen, Empty),
			new AliveCharacter(Olivia, Condition.Healthy, DiningRoom, Empty)
		], 
		Map,
		1
	);

	public static Map Map => new(Rooms, Connections);

	private static ImmutableDictionary<RoomIdentifier, Room> Rooms => new Dictionary<RoomIdentifier, Room>
	{
		{ Kitchen, new Room()},
		{ MasterBedroom, new Room()},
		{ DiningRoom, new Room()}
	}.ToImmutableDictionary();

	private static ImmutableArray<RoomConnection> Connections =>
	[
		new OpenPassage(Kitchen, DiningRoom)
	];

}