
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
	public class FallFenceAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {4967, 1, 0, 0}, {2141, 2, -1, 0}, {2141, 1, -1, 0}// 1	2	3	
			, {2141, 0, -1, 0}, {2143, -1, -1, 0}, {3255, 2, 0, 0}// 4	5	6	
			, {3178, 1, 1, 0}, {3179, 0, 1, 0}, {3186, 0, 1, 0}// 7	8	9	
			, {3235, 0, 0, 0}, {3197, 2, 0, 0}// 10	11	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new FallFenceAddonDeed();
			}
		}

		[ Constructable ]
		public FallFenceAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public FallFenceAddon( Serial serial ) : base( serial )
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

	public class FallFenceAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new FallFenceAddon();
			}
		}

		[Constructable]
		public FallFenceAddonDeed()
		{
			Name = "FallFence";
		}

		public FallFenceAddonDeed( Serial serial ) : base( serial )
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