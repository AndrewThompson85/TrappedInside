using Spectre.Console;
using TrappedInside.Shell.ShellFunctions;
using static TrappedInside.Shell.ViewInvariants;

namespace TrappedInside.Shell.Widgets;

public static class IntroWidget
{
	public static void DrawGameTitle() =>
		AnsiConsole.Write(new FigletText(GameTitle).Centered().Color(TitleColor));

	public static void DrawGameCredits() => BasicShellFunctions.DrawRule(CreditsLine, CreditsLineColor);

	public static uint PushKeyWhitespace = 2;
}