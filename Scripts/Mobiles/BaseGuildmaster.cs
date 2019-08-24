using System;
using Server;
using Server.Misc;
using System.Collections.Generic;
using System.Collections;
using Server.Network;
using Server.Mobiles;
using Server.Items;

namespace Server.Mobiles
{
	public abstract class BaseGuildmaster : BaseVendor
	{
		private List<SBInfo> m_SBInfos = new List<SBInfo>();
		protected override List<SBInfo> SBInfos{ get { return m_SBInfos; } }

		public override bool IsActiveVendor{ get{ return true; } }

		public override bool ClickTitle{ get{ return true; } }

		public virtual int JoinCost{ get{ return 2000; } }

		public virtual TimeSpan JoinAge{ get{ return TimeSpan.FromDays( 0.0 ); } }
		public virtual TimeSpan JoinGameAge{ get{ return TimeSpan.FromDays( 0.0 ); } }
		public virtual TimeSpan QuitAge{ get{ return TimeSpan.FromDays( 7.0 ); } }
		public virtual TimeSpan QuitGameAge{ get{ return TimeSpan.FromDays( 0.0 ); } }

		public override void InitSBInfo()
		{
		}

		public virtual bool CheckCustomReqs( PlayerMobile pm )
		{
			return true;
		}

		public virtual void SayGuildTo( Mobile m )
		{
			SayTo( m, 1008055 + (int)NpcGuild );
		}

		public virtual void SayWelcomeTo( Mobile m )
		{
			SayTo( m, "Welcome to the guild! Thou shalt find it beneficial to your future endeavors." );
			// Welcome to the guild! Thou shalt find that fellow members shall grant thee lower prices in shops.
		}

		public virtual void SayPriceTo( Mobile m )
		{
			m.Send( new MessageLocalizedAffix( Serial, Body, MessageType.Regular, SpeechHue, 3, 1008052, Name, AffixType.Append, JoiningFee( m ).ToString(), "" ) );
		}

		public virtual int JoiningFee( Mobile m )
		{
			int fee = 2000;

			CharacterDatabase DB = Server.Items.CharacterDatabase.GetDB( m );

			if ( DB != null )
			{
				fee = DB.CharacterGuilds;
			}

			if ( fee < 2000 ){ fee = 2000; }

			return fee;
		}

		public virtual bool WasNamed( string speech )
		{
			string name = this.Name;

			return ( name != null && Insensitive.StartsWith( speech, name ) );
		}

		public override bool HandlesOnSpeech( Mobile from )
		{
			if ( from.InRange( this.Location, 2 ) )
				return true;

			return base.HandlesOnSpeech( from );
		}

		public override void OnSpeech( SpeechEventArgs e )
		{
			Mobile from = e.Mobile;

			if ( !e.Handled && from is PlayerMobile && !from.Blessed && from.InRange( this.Location, 6 ) && WasNamed( e.Speech ) && ((PlayerMobile)from).Profession != 1 )
			{
				PlayerMobile pm = (PlayerMobile)from;

				if ( e.HasKeyword( 0x0004 ) ) // *join* | *member*
				{
					if ( pm.NpcGuild == this.NpcGuild )
						SayTo( from, 501047 ); // Thou art already a member of our guild.
					else if ( pm.NpcGuild != NpcGuild.None )
						SayTo( from, 501046 ); // Thou must resign from thy other guild first.
					else if ( pm.GameTime < JoinGameAge || (pm.CreationTime + JoinAge) > DateTime.UtcNow )
						SayTo( from, 501048 ); // You are too young to join my guild...
					else if ( CheckCustomReqs( pm ) )
						SayPriceTo( from );

					e.Handled = true;
				}
				else if ( e.HasKeyword( 0x0005 ) ) // *resign* | *quit*
				{
					if ( pm.NpcGuild != this.NpcGuild )
					{
						SayTo( from, 501052 ); // Thou dost not belong to my guild!
					}
					else if ( (pm.NpcGuildJoinTime + QuitAge) > DateTime.UtcNow || (pm.NpcGuildGameTime + QuitGameAge) > pm.GameTime )
					{
						SayTo( from, 501053 ); // You just joined my guild! You must wait a week to resign.
					}
					else
					{
						SayTo( from, 501054 ); // I accept thy resignation.
						pm.NpcGuild = NpcGuild.None;

						CharacterDatabase DB = Server.Items.CharacterDatabase.GetDB( from );

						if ( DB.CharacterGuilds > 0 )
						{
							int fees = DB.CharacterGuilds;
							DB.CharacterGuilds = fees * 2;
						}
						else
						{
							DB.CharacterGuilds = 4000;
						}

						ArrayList targets = new ArrayList();
						foreach ( Item item in World.Items.Values )
						if ( item is GuildRings )
						{
							GuildRings guildring = (GuildRings)item;
							if ( guildring.RingOwner == from )
							{
								targets.Add( item );
							}
						}
						for ( int i = 0; i < targets.Count; ++i )
						{
							Item item = ( Item )targets[ i ];
							item.Delete();
						}
					}

					e.Handled = true;
				}
			}

			base.OnSpeech( e );
		}

		public override bool OnGoldGiven( Mobile from, Gold dropped )
		{
			PlayerMobile pm = (PlayerMobile)from;

			if ( from is PlayerMobile && !from.Blessed && dropped.Amount == JoiningFee( from ) && ((PlayerMobile)from).Profession != 1 )
			{
				if ( pm.NpcGuild == this.NpcGuild )
				{
					SayTo( from, 501047 ); // Thou art already a member of our guild.
				}
				else if ( pm.NpcGuild != NpcGuild.None )
				{
					SayTo( from, 501046 ); // Thou must resign from thy other guild first.
				}
				else if ( pm.GameTime < JoinGameAge || (pm.CreationTime + JoinAge) > DateTime.UtcNow )
				{
					SayTo( from, 501048 ); // You are too young to join my guild...
				}
				else if ( CheckCustomReqs( pm ) )
				{
					SayWelcomeTo( from );

					pm.NpcGuild = this.NpcGuild;
					pm.NpcGuildJoinTime = DateTime.UtcNow;
					pm.NpcGuildGameTime = pm.GameTime;

					dropped.Delete();

					ArrayList targets = new ArrayList();
					foreach ( Item item in World.Items.Values )
					if ( item is GuildRings )
					{
						GuildRings guildring = (GuildRings)item;
						if ( guildring.RingOwner == from )
						{
							targets.Add( item );
						}
					}
					for ( int i = 0; i < targets.Count; ++i )
					{
						Item item = ( Item )targets[ i ];
						item.Delete();
					}

					int GuildType = 1;
					if ( this.NpcGuild == NpcGuild.MagesGuild ){ GuildType = 1; }
					else if ( this.NpcGuild == NpcGuild.WarriorsGuild ){ GuildType = 2; }
					else if ( this.NpcGuild == NpcGuild.ThievesGuild ){ GuildType = 3; }
					else if ( this.NpcGuild == NpcGuild.RangersGuild ){ GuildType = 4; }
					else if ( this.NpcGuild == NpcGuild.HealersGuild ){ GuildType = 5; }
					else if ( this.NpcGuild == NpcGuild.MinersGuild ){ GuildType = 6; }
					else if ( this.NpcGuild == NpcGuild.MerchantsGuild ){ GuildType = 7; }
					else if ( this.NpcGuild == NpcGuild.TinkersGuild ){ GuildType = 8; }
					else if ( this.NpcGuild == NpcGuild.TailorsGuild ){ GuildType = 9; }
					else if ( this.NpcGuild == NpcGuild.FishermensGuild ){ GuildType = 10; }
					else if ( this.NpcGuild == NpcGuild.BardsGuild ){ GuildType = 11; }
					else if ( this.NpcGuild == NpcGuild.BlacksmithsGuild ){ GuildType = 12; }
					else if ( this.NpcGuild == NpcGuild.NecromancersGuild ){ GuildType = 13; }
					else if ( this.NpcGuild == NpcGuild.AlchemistsGuild ){ GuildType = 14; }
					else if ( this.NpcGuild == NpcGuild.DruidsGuild ){ GuildType = 15; }
					else if ( this.NpcGuild == NpcGuild.ArchersGuild ){ GuildType = 16; }
					else if ( this.NpcGuild == NpcGuild.CarpentersGuild ){ GuildType = 17; }
					else if ( this.NpcGuild == NpcGuild.CartographersGuild ){ GuildType = 18; }
					else if ( this.NpcGuild == NpcGuild.LibrariansGuild ){ GuildType = 19; }
					else if ( this.NpcGuild == NpcGuild.CulinariansGuild ){ GuildType = 20; }
					else if ( this.NpcGuild == NpcGuild.AssassinsGuild ){ GuildType = 21; }

					from.AddToBackpack( new GuildRings( from, GuildType ) );
					from.SendSound( 0x3D );

					return true;
				}

				return false;
			}

			if ( from is PlayerMobile && dropped.Amount == 400 && pm.NpcGuild == this.NpcGuild )
			{
				dropped.Delete();

				ArrayList targets = new ArrayList();
				foreach ( Item item in World.Items.Values )
				if ( item is GuildRings )
				{
					GuildRings guildring = (GuildRings)item;
					if ( guildring.RingOwner == from )
					{
						targets.Add( item );
					}
				}
				for ( int i = 0; i < targets.Count; ++i )
				{
					Item item = ( Item )targets[ i ];
					item.Delete();
				}

				int GuildType = 1;
				if ( this.NpcGuild == NpcGuild.MagesGuild ){ GuildType = 1; }
				else if ( this.NpcGuild == NpcGuild.WarriorsGuild ){ GuildType = 2; }
				else if ( this.NpcGuild == NpcGuild.ThievesGuild ){ GuildType = 3; }
				else if ( this.NpcGuild == NpcGuild.RangersGuild ){ GuildType = 4; }
				else if ( this.NpcGuild == NpcGuild.HealersGuild ){ GuildType = 5; }
				else if ( this.NpcGuild == NpcGuild.MinersGuild ){ GuildType = 6; }
				else if ( this.NpcGuild == NpcGuild.MerchantsGuild ){ GuildType = 7; }
				else if ( this.NpcGuild == NpcGuild.TinkersGuild ){ GuildType = 8; }
				else if ( this.NpcGuild == NpcGuild.TailorsGuild ){ GuildType = 9; }
				else if ( this.NpcGuild == NpcGuild.FishermensGuild ){ GuildType = 10; }
				else if ( this.NpcGuild == NpcGuild.BardsGuild ){ GuildType = 11; }
				else if ( this.NpcGuild == NpcGuild.BlacksmithsGuild ){ GuildType = 12; }
				else if ( this.NpcGuild == NpcGuild.NecromancersGuild ){ GuildType = 13; }
				else if ( this.NpcGuild == NpcGuild.AlchemistsGuild ){ GuildType = 14; }
				else if ( this.NpcGuild == NpcGuild.DruidsGuild ){ GuildType = 15; }
				else if ( this.NpcGuild == NpcGuild.ArchersGuild ){ GuildType = 16; }
				else if ( this.NpcGuild == NpcGuild.CarpentersGuild ){ GuildType = 17; }
				else if ( this.NpcGuild == NpcGuild.CartographersGuild ){ GuildType = 18; }
				else if ( this.NpcGuild == NpcGuild.LibrariansGuild ){ GuildType = 19; }
				else if ( this.NpcGuild == NpcGuild.CulinariansGuild ){ GuildType = 20; }
				else if ( this.NpcGuild == NpcGuild.AssassinsGuild ){ GuildType = 21; }

				this.Say( "Here is your replacement ring." );

				return true;
			}

			return base.OnGoldGiven( from, dropped );
		}

		public BaseGuildmaster( string title ) : base( title )
		{
			Title = String.Format( "the {0} {1}", title, Female ? "guildmistress" : "guildmaster" );
		}

		public BaseGuildmaster( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}