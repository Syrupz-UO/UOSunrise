using System; 
using System.Collections.Generic; 
using Server; 
using Server.Misc;
using Server.ContextMenus;
using Server.Gumps;

namespace Server.Mobiles 
{ 
	public class Shipwright : BaseVendor 
	{ 
		private List<SBInfo> m_SBInfos = new List<SBInfo>(); 
		protected override List<SBInfo> SBInfos{ get { return m_SBInfos; } } 

		public override NpcGuild NpcGuild{ get{ return NpcGuild.FishermensGuild; } }

		[Constructable]
		public Shipwright() : base( "the shipwright" ) 
		{ 
			SetSkill( SkillName.Carpentry, 60.0, 83.0 );
			SetSkill( SkillName.Macing, 36.0, 68.0 );
		} 

		public override void InitSBInfo() 
		{ 
			m_SBInfos.Add( new SBShipwright() ); 
			m_SBInfos.Add( new SBBuyArtifacts() ); 
		}

		public override void InitOutfit()
		{
			base.InitOutfit();

			AddItem( new Server.Items.SmithHammer() );
			AddItem( new Server.Items.TricorneHat() );
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
						mobile.SendGump(new SpeechGump( "The High Seas", SpeechFunctions.SpeechText( m_Giver.Name, m_Mobile.Name, "Shipwright" ) ));
					}
				}
            }
        }
		///////////////////////////////////////////////////////////////////////////

		public Shipwright( Serial serial ) : base( serial ) 
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