using TrappedInside.Core.Characters;
using static TrappedInside.Core.Environment.RoomIdentifier;

namespace TrappedInside.Core;

public static class Invariants
{
	public static readonly GameState InitialState = new(
		[
			new AliveCharacter("Alex", new Healthy(), MasterBedroom ),
			new AliveCharacter("Sandra", new Healthy(), DiningRoom ),
			new AliveCharacter("Bill", new Healthy(), Kitchen),
			new AliveCharacter("Olivia", new Healthy(), DiningRoom)
		]
	);
}