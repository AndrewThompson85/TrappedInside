using TrappedInside.Core.Characters;
using static TrappedInside.Core.Environment.RoomIdentifier;

namespace TrappedInside.Core;

public static class Invariants
{
	
	public static readonly GameState InitialState = new(
		[
			new AliveCharacter("Alex", Condition.Healthy , MasterBedroom ),
			new AliveCharacter("Sandra", Condition.Healthy, DiningRoom ),
			new AliveCharacter("Bill", Condition.Healthy, Kitchen),
			new AliveCharacter("Olivia", Condition.Healthy, DiningRoom)
		]
	);
}