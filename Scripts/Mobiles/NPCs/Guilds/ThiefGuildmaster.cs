using System;
using System.Collections.Generic;
using Server;
using Server.Targeting;
using Server.Items;
using Server.Network;
using Server.ContextMenus;
using Server.Gumps;
using Server.Misc;
using Server.Mobiles;

namespace Server.Mobiles
{
	public class ThiefGuildmaster : BaseGuildmaster
	{
		public override NpcGuild NpcGuild{ get{ return NpcGuild.ThievesGuild; } }

		public override TimeSpan JoinAge{ get{ return TimeSpan.FromDays( 1.0 ); } }

		[Constructable]
		public ThiefGuildmaster() : base( "thief" )
		{
			SetSkill( SkillName.DetectHidden, 75.0, 98.0 );
			SetSkill( SkillName.Hiding, 65.0, 88.0 );
			SetSkill( SkillName.Lockpicking, 85.0, 100.0 );
			SetSkill( SkillName.Snooping, 90.0, 100.0 );
			SetSkill( SkillName.Stealing, 90.0, 100.0 );
			SetSkill( SkillName.Fencing, 75.0, 98.0 );
			SetSkill( SkillName.Stealth, 85.0, 100.0 );
			SetSkill( SkillName.RemoveTrap, 85.0, 100.0 );
		}

		public override void InitSBInfo()
		{
			SBInfos.Add( new SBThiefGuild() ); 
			SBInfos.Add( new SBBuyArtifacts() ); 
		}

		public override void InitOutfit()
		{
			base.InitOutfit();

			AddItem( new Server.Items.Bandana( Utility.RandomNeutralHue() ) );

			if ( Utility.RandomBool() )
				AddItem( new Server.Items.Kryss() );
			else
				AddItem( new Server.Items.Dagger() );
		}

		public override void SayWelcomeTo( Mobile m )
		{
			SayTo( m, 1008053 ); // Welcome to the guild! Stay to the shadows, friend.
		}

		private class JobEntry : ContextMenuEntry
		{
			private ThiefGuildmaster m_ThiefGuildmaster;
			private Mobile m_From;

			public JobEntry( ThiefGuildmaster ThiefGuildmaster, Mobile from ) : base( 2078, 3 )
			{
				m_ThiefGuildmaster = ThiefGuildmaster;
				m_From = from;
			}

			public override void OnClick()
			{
				m_ThiefGuildmaster.FindMessage( m_From );
			}
		}

        public void FindMessage( Mobile m )
        {
            if ( Deleted || !m.Alive )
                return;

			Item note = Server.Items.ThiefNote.GetMyCurrentJob( m );

			if ( note != null )
			{
				ThiefNote job = (ThiefNote)note;
				m.AddToBackpack( note );
				m.PlaySound( 0x249 );
				SayTo(m, "Hmmm...you already have a job from " + job.NoteItemPerson + ". Here is a copy if you lost it.");
			}
			else
			{
				ThiefNote task = new ThiefNote();
				Server.Items.ThiefNote.SetupNote( task, m );
				m.AddToBackpack( task );
				m.PlaySound( 0x249 );
				SayTo(m, "Here is something I think you can handle.");
            }
        }

		public override void AddCustomContextEntries( Mobile from, List<ContextMenuEntry> list )
		{
			if ( from.Alive && !from.Blessed )
			{
				list.Add( new JobEntry( this, from ) );
			}

			base.AddCustomContextEntries( from, list );
		}

		public ThiefGuildmaster( Serial serial ) : base( serial )
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