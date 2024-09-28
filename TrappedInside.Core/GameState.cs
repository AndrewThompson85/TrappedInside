using System.Collections.Immutable;
using TrappedInside.Core.Characters;
using TrappedInside.Core.Environment;

namespace TrappedInside.Core;

public sealed record GameState(ImmutableArray<Character> Characters, Map Map);


