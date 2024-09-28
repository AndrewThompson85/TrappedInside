using TrappedInside.Shell.Modes;

namespace TrappedInside.Shell;

internal class Program
{
	private static void Main()
	{
		Mode mode = new IntroMode();

		while (true)
		{
			mode = mode.Run();

			if (mode is CloseApplicationMode closeApplicationMode)
			{
				closeApplicationMode.Run();
				return;
			}
		}
	}
}