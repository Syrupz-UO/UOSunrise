#region Header
//   Vorspire    _,-'/-'/  SuperGump_Tooltips.cs
//   .      __,-; ,'( '/
//    \.    `-.__`-._`:_,-._       _ , . ``
//     `:-._,------' ` _,`--` -: `_ , ` ,' :
//        `---..__,,--'  (C) 2018  ` -'. -'
//        #  Vita-Nex [http://core.vita-nex.com]  #
//  {o)xxx|===============-   #   -===============|xxx(o}
//        #        The MIT License (MIT)          #
#endregion

#region References
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

using Server;
using Server.Network;

using VitaNex.Collections;
using VitaNex.Network;
#endregion

namespace VitaNex.SuperGumps
{
	public abstract partial class SuperGump
	{
		private Dictionary<string, Spoof> _TextTooltips;

		public void AddTooltip(string text)
		{
			AddTooltip(text, Color.Empty);
		}

		public void AddTooltip(string text, Color color)
		{
			AddTooltip(String.Empty, text, Color.Empty, color);
		}

		public void AddTooltip(string title, string text)
		{
			AddTooltip(title, text, Color.Empty, Color.Empty);
		}

		public void AddTooltip(string title, string text, Color titleColor, Color textColor)
		{
			title = title ?? String.Empty;
			text = text ?? String.Empty;

			if (titleColor.IsEmpty || titleColor == Color.Transparent)
			{
				titleColor = Color.Yellow;
			}

			if (textColor.IsEmpty || textColor == Color.Transparent)
			{
				textColor = Color.White;
			}

			Spoof spoof;

			if (!_TextTooltips.TryGetValue(text, out spoof) || spoof == null || spoof.Deleted)
			{
				spoof = Spoof.Acquire();
			}

			if (!String.IsNullOrWhiteSpace(title))
			{
				spoof.Text = String.Concat(title.WrapUOHtmlColor(titleColor, false), '\n', text.WrapUOHtmlColor(textColor, false));
			}
			else
			{
				spoof.Text = text.WrapUOHtmlColor(textColor, false);
			}

			AddProperties(spoof);
		}

		private sealed class Spoof : Entity
		{
			private static readonly char[] _Split = {'\n'};

			private static int _UID = -1;

			private static int NewUID
			{
				get
				{
					if (_UID == Int32.MinValue)
					{
						_UID = -1;
					}

					return --_UID;
				}
			}

			private static readonly ObjectPool<Spoof> _Pool = new ObjectPool<Spoof>();

			public static Spoof Acquire()
			{
				return _Pool.Acquire();
			}

			public static void Free(Spoof spoof)
			{
				_Pool.Free(spoof);
			}

			public static void Free(ref Spoof spoof)
			{
				_Pool.Free(ref spoof);
			}

			public int UID { get { return Serial.Value; } private set { this.SetPropertyValue("Serial", value); } }

			private ObjectPropertyList _PropertyList;

			public ObjectPropertyList PropertyList
			{
				get
				{
					if (_PropertyList == null)
					{
						_PropertyList = new ObjectPropertyList(this);

						if (Text != null)
						{
							var text = Text.StripHtmlBreaks(true);

							if (text.IndexOf('\n') >= 0)
							{
								var lines = text.Split(_Split, StringSplitOptions.RemoveEmptyEntries);

								_PropertyList.Add(lines[0]);

								ExtendedOPL.AddTo(_PropertyList, lines.Skip(1));
							}
							else
							{
								_PropertyList.Add(text);
							}
						}

						_PropertyList.Terminate();
						_PropertyList.SetStatic();
					}

					return _PropertyList;
				}
			}

			private string _Text = String.Empty;

			public string Text
			{
				get { return _Text ?? String.Empty; }
				set
				{
					if (_Text != value)
					{
						_Text = value;

						Packet.Release(ref _PropertyList);
					}
				}
			}

			public Spoof()
				: base(NewUID, Point3D.Zero, Map.Internal)
			{ }
		}
	}
}