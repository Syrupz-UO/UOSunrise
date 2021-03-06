
////////////////////////////////////////
//                                    //
//   Generated by CEO's YAAAG - V1.2  //
// (Yet Another Arya Addon Generator) //
//                                    //
////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class CastleAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {8910, 2, 2, 0}, {8912, 1, 2, 0}, {8914, 0, 2, 0}// 1	2	3	
			, {8919, -1, 2, 0}, {8911, 2, 1, 0}, {8913, 1, 1, 0}// 4	5	6	
			, {8916, 0, 1, 0}, {8921, -1, 1, 0}, {8915, 2, 0, 0}// 7	8	9	
			, {8917, 1, 0, 0}, {8918, 0, 0, 0}, {8923, -1, 0, 0}// 10	11	12	
			, {8920, 2, -1, 0}, {8922, 1, -1, 0}, {8924, 0, -1, 0}// 13	14	15	
			, {8925, -1, -1, 0}// 16	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new CastleAddonDeed();
			}
		}

		[ Constructable ]
		public CastleAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public CastleAddon( Serial serial ) : base( serial )
		{
		}


		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class CastleAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new CastleAddon();
			}
		}

		[Constructable]
		public CastleAddonDeed()
		{
			Name = "Castle";
		}

		public CastleAddonDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void	Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}