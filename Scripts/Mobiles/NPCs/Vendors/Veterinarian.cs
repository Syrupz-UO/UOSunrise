using System;
using System.Collections.Generic;
using Server;
using Server.Gumps;
using Server.Items;
using Server.Network;
using Server.Targeting;
using Server.ContextMenus;
using Server.Misc;

namespace Server.Mobiles
{
	public class Veterinarian : BaseVendor
	{
		private List<SBInfo> m_SBInfos = new List<SBInfo>();
		protected override List<SBInfo> SBInfos{ get { return m_SBInfos; } }

		public override NpcGuild NpcGuild{ get{ return NpcGuild.DruidsGuild; } }

		[Constructable]
		public Veterinarian() : base( "the vet" )
		{
			SetSkill( SkillName.AnimalLore, 85.0, 100.0 );
			SetSkill( SkillName.Veterinary, 90.0, 100.0 );
		}

		///////////////////////////////////////////////////////////////////////////
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
						mobile.SendGump(new SpeechGump( "Animal Companions", SpeechFunctions.SpeechText( m_Giver.Name, m_Mobile.Name, "Pets" ) ));
					}
				}
            }
        }
		///////////////////////////////////////////////////////////////////////////

		public override void InitSBInfo()
		{
			if ( Server.Misc.Worlds.GetMyWorld( this.Map, this.Location, this.X, this.Y ) == "the Serpent Island" )
			{
				m_SBInfos.Add( new SBGargoyleAnimalTrainer() );
			}
			else if ( Server.Misc.Worlds.GetMyWorld( this.Map, this.Location, this.X, this.Y ) == "the Land of Lodoria" )
			{
				m_SBInfos.Add( new SBElfAnimalTrainer() );
			}
			else if ( Server.Misc.Worlds.GetMyWorld( this.Map, this.Location, this.X, this.Y ) == "the Isles of Dread" )
			{
				m_SBInfos.Add( new SBBarbarianAnimalTrainer() );
			}
			else if ( Server.Misc.Worlds.GetMyWorld( this.Map, this.Location, this.X, this.Y ) == "the Savaged Empire" )
			{
				m_SBInfos.Add( new SBOrkAnimalTrainer() );
			}
			else
			{
				m_SBInfos.Add( new SBHumanAnimalTrainer() );
			}
			m_SBInfos.Add( new SBVeterinarian() ); 
			m_SBInfos.Add( new SBBuyArtifacts() ); 
		}

		public Veterinarian( Serial serial ) : base( serial )
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