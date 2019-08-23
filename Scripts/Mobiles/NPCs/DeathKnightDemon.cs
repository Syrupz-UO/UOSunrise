using System;
using System.Collections;
using System.Collections.Generic;
using Server.Items;
using Server.ContextMenus;
using Server.Misc;
using Server.Network;
using Server.Gumps;

namespace Server.Mobiles
{
	public class DeathKnightDemon : BasePerson
	{
		[Constructable]
		public DeathKnightDemon() : base( )
		{
			Direction = Direction.East;
			Blessed = true;
			CantWalk = true;
			Name = NameList.RandomName( "devil" );
			SpeechHue = Utility.RandomDyedHue();
			NameHue = Utility.RandomRedHue();
			Body = 38;
			BaseSoundID = 357;
			Title = "of the Void";

			SetStr( 3000, 3000 );
			SetDex( 3000, 3000 );
			SetInt( 3000, 3000 );

			SetHits( 6000,6000 );
			SetDamage( 500, 900 );

			VirtualArmor = 3000;

			SetDamageType( ResistanceType.Physical, 40 );
			SetDamageType( ResistanceType.Cold, 60 );
			SetDamageType( ResistanceType.Energy, 60 );

			SetResistance( ResistanceType.Physical, 65, 75 );
			SetResistance( ResistanceType.Fire, 35, 40 );
			SetResistance( ResistanceType.Cold, 60, 70 );
			SetResistance( ResistanceType.Poison, 60, 70 );
			SetResistance( ResistanceType.Energy, 35, 40 );

			SetSkill( SkillName.EvalInt, 130.1, 140.0 );
			SetSkill( SkillName.Magery, 130.1, 140.0 );
			SetSkill( SkillName.Meditation, 110.1, 111.0 );
			SetSkill( SkillName.Poisoning, 110.1, 111.0 );
			SetSkill( SkillName.MagicResist, 185.2, 210.0 );
			SetSkill( SkillName.Tactics, 100.1, 110.0 );
			SetSkill( SkillName.Wrestling, 85.1, 110.0 );
			SetSkill( SkillName.Macing, 85.1, 110.0 );
		}

		public override bool BardImmune{ get{ return true; } }
		public override Poison PoisonImmune{ get{ return Poison.Deadly; } }
		public override bool Unprovokable { get { return true; } }
		public override bool Uncalmable{ get{ return true; } }

		public override bool OnDragDrop( Mobile from, Item dropped )
		{
			if ( dropped is Gold && dropped.Amount == 10000 && from.Karma <= -5000 && from.Skills[SkillName.Chivalry].Base >= 100 )
			{
				this.Say( "Take your steed and fill the world with dread." );
				from.AddToBackpack ( new DeathKnightWarhorse() );
			}
			else
			{
				from.AddToBackpack ( dropped );
			}

			return base.OnDragDrop( from, dropped );
		}

		public override void GetContextMenuEntries( Mobile from, List<ContextMenuEntry> list ) 
		{ 
			base.GetContextMenuEntries( from, list ); 
			list.Add( new SpeechGumpEntry( from, this ) ); 
		} 

		public class SpeechGumpEntry : ContextMenuEntry
		{
			private Mobile m_Mobile;
			private Mobile m_Giver;
			
			public SpeechGumpEntry( Mobile from, Mobile giver ) : base( 6146, 3 )
			{
				m_Mobile = from;
				m_Giver = giver;
			}

			public override void OnClick()
			{
			    if( !( m_Mobile is PlayerMobile ) )
				return;
				
				PlayerMobile mobile = (PlayerMobile) m_Mobile;
				{
					if ( ! mobile.HasGump( typeof( SpeechGump ) ) )
					{
						mobile.SendGump(new SpeechGump( "The Black Heart", SpeechFunctions.SpeechText( m_Giver.Name, m_Mobile.Name, "DeathKnight" ) ));
					}
				}
            }
        }

		public DeathKnightDemon( Serial serial ) : base( serial )
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