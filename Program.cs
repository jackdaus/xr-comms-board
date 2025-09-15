using StereoKit;

namespace xr_comms_board;

class Program
{
	static void Main(string[] args)
	{
		// Initialize StereoKit
		SKSettings settings = new SKSettings
		{
			appName = "XR Communication Board",
			blendPreference = DisplayBlend.AnyTransparent
		};
		if (!SK.Initialize(settings))
			return;


		// Create assets used by the app
		Pose  windowPose = new Pose(0, 0, -0.5f, Quat.LookDir(0,0,1));

		// Core application loop
		string composedText = "";
		const float buttonSize = 0.035f;

		SK.Run(() => {
			UI.WindowBegin("Letter Board", ref windowPose);
			float inputLayoutWidth = UI.LayoutRemaining.x;
			float backspaceWidth = 50 * U.mm; // A fixed width for the backspace button
			float inputWidth = inputLayoutWidth - backspaceWidth - UI.Settings.gutter;

			// Display the composed text
			UI.Input("text-entry", ref composedText, new Vec2(inputWidth, 0));
			UI.SameLine();
			if (UI.Button("⬅ Back", new Vec2(backspaceWidth, 0)))
			{
				if (composedText.Length > 0)
				{
					composedText = composedText.Substring(0, composedText.Length - 1);
				}
			}

			string[] letterRows = [
				"abcdef",
				"ghijkl",
				"mnopqr",
				"stuvwx",
				"yz"
			];

			for (int i = 0; i < letterRows.Length; i++)
			{
				foreach (char letter in letterRows[i])
				{
					if (UI.Button(letter.ToString(), new Vec2(buttonSize, buttonSize)))
					{
						composedText += letter;
					}
					UI.SameLine();
				}
				UI.NextLine();
			}

			UI.NextLine();
			if (UI.Button("Space", new Vec2(0, buttonSize)))
			{
				composedText += " ";
			}

			UI.WindowEnd();
		});
	}
}