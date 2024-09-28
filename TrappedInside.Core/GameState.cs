using System.Collections.Immutable;
using TrappedInside.Core.Characters;
using TrappedInside.Core.Environment;

namespace TrappedInside.Core;

public sealed record GameData(ImmutableArray<Character> Characters, Map Map);


