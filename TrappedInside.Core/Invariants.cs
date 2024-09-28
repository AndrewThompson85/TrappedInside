using TrappedInside.Core.Characters;
using TrappedInside.Core.Primitives;
using static TrappedInside.Core.Characters.CharacterId;

namespace TrappedInside.Core;

public static class Invariants
{
	public const uint ActionsPerTurn = 3;
	
	public static Text Name(this CharacterId character) => character switch
	{
		Alex => "Alex",
		Bill => "Bill",
		Olivia => "Olivia",
		Sandra => "Sandra"
	};
	
	
}