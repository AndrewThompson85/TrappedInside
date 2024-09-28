using TrappedInside.Core.Characters;

namespace TrappedInside.Core;

public class Invariants
{
	public static GameState InitialState = new GameState
	(
		[
			new AliveCharacter("Alex"),
			new AliveCharacter("Sandra"),
			new AliveCharacter("Bill"),
			new AliveCharacter("Olivia")
		]
	);
}