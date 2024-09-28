using Color = Spectre.Console.Color;
using Text = TrappedInside.Core.Primitives.Text;
namespace TrappedInside.Shell;

public static class ViewInvariants
{
	public static readonly Text GameTitle = "Trapped Inside";
	public static readonly Text CreditsLine = "By Andrew Thompson, 2024";
	public static readonly Color TitleColor = Color.Red1;
	public static readonly Color CreditsLineColor = Color.Aqua;
	public static readonly Color PromptColor = Color.Gold3;
	public static readonly Color InfoRowColor = Color.Cyan3;
}