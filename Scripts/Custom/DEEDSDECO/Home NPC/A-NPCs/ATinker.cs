using System;
using System.Collections;
using System.Collections.Generic;
using Server;

namespace Server.Mobiles
{
	public class ATinker : BaseVendor
	{
		private List<SBInfo> m_SBInfos = new List<SBInfo>();
        protected override List<SBInfo> SBInfos { get { return m_SBInfos; } }
public override bool NoHouseRestrictions{ get{ return true; } }
		[Constructable]
		public ATinker() : base( "The Tinker" )
		{
		    CantWalk = true;
		
			SetSkill( SkillName.Lockpicking, 60.0, 83.0 );
			SetSkill( SkillName.RemoveTrap, 75.0, 98.0 );
			SetSkill( SkillName.Tinkering, 64.0, 100.0 );
		}

		public override void InitSBInfo()
		{
			m_SBInfos.Add( new SBTinker() );
		}

		public ATinker( Serial serial ) : base( serial )
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