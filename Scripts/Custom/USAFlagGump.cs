#region References
using System;
#endregion

namespace Server.Gumps
{
	public class USAFlagGump : Gump
	{
		// Official colors
		private const int _Red = 0xB22234;
		private const int _White = 0xFFFFFF;
		private const int _Blue = 0x3C3B6E;

		// Aspect ratio 1.9
		private const int _Width = 618;
		private const int _Height = 325;

		private static readonly string _RedBG = String.Format("<bodybgcolor=#{0:X}> ", _Red);
		private static readonly string _WhiteBG = String.Format("<bodybgcolor=#{0:X}> ", _White);
		private static readonly string _BlueBG = String.Format("<bodybgcolor=#{0:X}> ", _Blue);

		private static readonly string _Star = String.Format("<basefont color=#{0:X}>\u2605", _White);

		public USAFlagGump(Mobile user)
			: base(0, 0)
		{
			if (user != null)
			{
				user.CloseGump(typeof(USAFlagGump));
			}

			Closable = true;
			Disposable = true;
			Dragable = true;
			Resizable = false;

			AddPage(0);

			var x = 0;
			var y = 0;
			var w = _Width + 20;
			var h = _Height + 20;

			AddBackground(x, y, w, h, 40000);
			
			x += 10;
			y += 10;
			w -= 20;
			h -= 20;

			var sh = h / 13;

			AddHtml(x, y, w, h, _RedBG, false, false);

			for (var r = 0; r < 13; r++)
			{
				if (r % 2 != 0)
				{
					AddHtml(x, y + (r * sh), w, sh, _WhiteBG, false, false);
				}
			}

			w /= 5;
			w *= 2;

			h /= 13;
			h *= 7;
			
			AddHtml(x, y, w, h, _BlueBG, false, false);

			w /= 12;
			h /= 10;

			x += w;
			x -= 8;

			y += h;
			y -= 8;

			for (var col = 0; col < 12; col += 2)
			{
				for (var row = 0; row < 10; row += 2)
				{
					AddHtml(x + (col * w), y + (row * h), 16, 16, _Star, false, false);
				}
			}

			for (var col = 1; col < 11; col += 2)
			{
				for (var row = 1; row < 9; row += 2)
				{
					AddHtml(x + (col * w), y + (row * h), 16, 16, _Star, false, false);
				}
			}
		}
	}
}