using TrappedInside.Core.Characters;
using TrappedInside.Core.Environment;

namespace TrappedInside.Core.Data;

public static class GameDataQueries
{
	public static Character GetCharacter(this GameData data, CharacterId id) => data.Characters.Single(s => s.Id == id);
	public static RoomIdentifier WhereIs(this GameData data, CharacterId id) => data.GetCharacter(id).Location;
}