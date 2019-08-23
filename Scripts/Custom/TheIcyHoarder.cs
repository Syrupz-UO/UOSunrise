using System;
using System.Collections;
using System.Collections.Generic;
using Server;
using Server.Items;
using Server.Mobiles;
using Server.Gumps;
using Server.Network;
using Server.ContextMenus;

namespace Server.Mobiles

{
	[CorpseName( "a Melted Puddle" )]
	public class TheIcyHoarder : BaseMount
	{
		[Constructable]
		public TheIcyHoarder() : this( "a hoarder" )
		{
		}

		public override bool SubdueBeforeTame{ get{ return true; } } // Must be beaten into submission
        public override bool HasBreath
        {
            get
            {
                return true;
            }
        }// fire breath enabled


		[Constructable]
		public TheIcyHoarder( string name ) : base( name, 0xA2, 0xA2, AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			
                this.BaseSoundID = 655;

			SetStr( 100 );
			SetDex( 110 );
			SetInt( 130 );
			this.SetHits(600, 1000);
		    	SetStam( 110 );
			SetMana( 500 );

			SetDamage( 20, 30 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 50, 60 );
			SetResistance( ResistanceType.Fire, 50, 55 );
			
			SetResistance( ResistanceType.Poison, 25, 30 );
			SetResistance( ResistanceType.Energy, 25, 30 );

			SetSkill( SkillName.Wrestling, 70.1, 75.0 );
			SetSkill( SkillName.Tactics, 50.0 );
		 this.SetSkill(SkillName.EvalInt, 75.1, 120.0);
            this.SetSkill(SkillName.Magery, 75.1, 120.0);
            this.SetSkill(SkillName.MagicResist, 60.1, 75.0);
            this.SetSkill(SkillName.Tactics, 60.1, 80.0);
            this.SetSkill(SkillName.Wrestling, 60.1, 80.0);
            this.Fame = 22500;
            this.Karma = -22500;

			Tamable = true;
			ControlSlots = 2;
			MinTameSkill = 90.0;

			Container pack = Backpack;

			if ( pack != null )
				pack.Delete();

			pack = new StrongBackpack();
			pack.Movable = false;

			AddItem( pack );

		} 
        public override int TreasureMapLevel
        {
            get
            {
                return 5;
            }
        }

        public override void OnDeath(Container c)
        {

            base.OnDeath(c);

           

        }

        public override void GenerateLoot()
        {
            this.AddLoot(LootPack.FilthyRich, 3);
            this.AddLoot(LootPack.Rich, 2);
            this.AddLoot(LootPack.MedScrolls);
            this.AddLoot(LootPack.Gems, 5);
            this.PackItem(new GargoylesPickaxe());
            
            this.PackItem(new Gold(100));

        }

        private DateTime m_NextPickup;

		public override void OnThink()
		{
			base.OnThink();

			if ( DateTime.Now < m_NextPickup )
				return;

			m_NextPickup = DateTime.Now + TimeSpan.FromSeconds( Utility.RandomMinMax( 0, 0 ) );

			Container pack = this.Backpack;

			if ( pack == null )
				return;

			ArrayList list = new ArrayList();

			foreach ( Item item in this.GetItemsInRange( 3 ) )
			{
				if ( item.Movable || item.Stackable )
					list.Add( item );
			}

			int pickedUp = 0;

			for ( int i = 0; i < list.Count; ++i )
			{
				Item item = (Item)list[i];

				if ( !pack.CheckHold( this, item, false, true ) )
					return;

				bool rejected;
				LRReason reject;

				NextActionTime = DateTime.Now;

				Lift( item, item.Amount, out rejected, out reject );

				if ( rejected )
					continue;

				Drop( this, Point3D.Zero );

				if ( ++pickedUp == 3 )
					break;
         }
	                
      }
          
		#region Pack Animal Methods
		public override bool OnBeforeDeath()
		{
			if ( !base.OnBeforeDeath() )
				return false;

			PackAnimal.CombineBackpacks( this );

			return true;
		}


		public override bool IsSnoop( Mobile from )
		{
			if ( PackAnimal.CheckAccess( this, from ) )
				return false;

			return base.IsSnoop( from );
		}

		public override bool OnDragDrop( Mobile from, Item item )
		{
			if ( CheckFeed( from, item ) )
				return true;

			if ( PackAnimal.CheckAccess( this, from ) )
			{
				AddToBackpack( item );
				return true;
			}

			return base.OnDragDrop( from, item );
		}

		public override bool CheckNonlocalDrop( Mobile from, Item item, Item target )
		{
			return PackAnimal.CheckAccess( this, from );
		}

		public override bool CheckNonlocalLift( Mobile from, Item item )
		{
			return PackAnimal.CheckAccess( this, from );
		}
                
        public override void OnDoubleClick( Mobile from )
		{
			PackAnimal.TryPackOpen( this, from );
		}

		public override void GetContextMenuEntries( Mobile from, List<ContextMenuEntry> list )
		{
			base.GetContextMenuEntries( from, list );

			PackAnimal.GetContextMenuEntries( this, from, list );
		}
		#endregion

                public TheIcyHoarder( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); 
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}