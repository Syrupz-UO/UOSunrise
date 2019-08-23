using System;
using System.Collections;
using System.Collections.Generic;
using Server;
using Server.ContextMenus;
using Server.Gumps;
using Server.Items;
using Server.Network;
using Server.Targeting;
using Server.Misc;
using Server.Regions;
using Server.Engines.BulkOrders;

namespace Server.Mobiles
{
	public class AnimalTrainer : BaseVendor
	{
		private List<SBInfo> m_SBInfos = new List<SBInfo>();
		protected override List<SBInfo> SBInfos{ get { return m_SBInfos; } }

		public override NpcGuild NpcGuild{ get{ return NpcGuild.DruidsGuild; } }

		[Constructable]
		public AnimalTrainer() : base( "the animal trainer" )
		{
			SetSkill( SkillName.AnimalLore, 64.0, 100.0 );
			SetSkill( SkillName.AnimalTaming, 90.0, 100.0 );
			SetSkill( SkillName.Veterinary, 65.0, 88.0 );
		}

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
			m_SBInfos.Add( new SBAnimalTrainer() ); 
			m_SBInfos.Add( new SBBuyArtifacts() ); 
		}

		public override VendorShoeType ShoeType
		{
			get{ return Female ? VendorShoeType.ThighBoots : VendorShoeType.Boots; }
		}

		#region Bulk Orders
		public override Item CreateBulkOrder( Mobile from, bool fromContextMenu )
		{
			PlayerMobile pm = from as PlayerMobile;

			if ( pm != null && pm.NextTamingBulkOrder == TimeSpan.Zero && (fromContextMenu || 0.2 > Utility.RandomDouble()) )
			{
				double theirSkill = pm.Skills[SkillName.AnimalTaming].Base;

				if ( theirSkill >= 70.1 )
					pm.NextTamingBulkOrder = TimeSpan.FromMinutes( 0.0 );
				else if ( theirSkill >= 50.1 )
					pm.NextTamingBulkOrder = TimeSpan.FromMinutes( 0.0 );
				else
					pm.NextTamingBulkOrder = TimeSpan.FromMinutes( 0.0 );

				if ( theirSkill >= 70.1 && ((theirSkill - 40.0) / 300.0) > Utility.RandomDouble() )
					return new LargeTamingBOD();

				return SmallTamingBOD.CreateRandomFor( from );
			}

			return null;
		}

		public override bool IsValidBulkOrder( Item item )
		{
			return ( item is SmallTamingBOD || item is LargeTamingBOD );
		}

		public override bool SupportsBulkOrders( Mobile from )
		{
			return ( from is PlayerMobile && from.Skills[SkillName.AnimalTaming].Base > 0 && FSATS.EnableTamingBODs == true );
		}

		public override TimeSpan GetNextBulkOrder( Mobile from )
		{
			if ( from is PlayerMobile )
				return ((PlayerMobile)from).NextTamingBulkOrder;

			return TimeSpan.Zero;
		}
		#endregion
		

		public override int GetShoeHue()
		{
			return 0;
		}

		public override void InitOutfit()
		{
			base.InitOutfit();

			AddItem( Utility.RandomBool() ? (Item)new QuarterStaff() : (Item)new ShepherdsCrook() );
		}

		private class StableEntry : ContextMenuEntry
		{
			private AnimalTrainer m_Trainer;
			private Mobile m_From;

			public StableEntry( AnimalTrainer trainer, Mobile from ) : base( 6126, 12 )
			{
				m_Trainer = trainer;
				m_From = from;
			}

			public override void OnClick()
			{
				m_Trainer.BeginStable( m_From );
			}
		}

		///////////////////////////////////////////////////////////////////////////
		public override void GetContextMenuEntries( Mobile from, List<ContextMenuEntry> list ) 
		{ 
			base.GetContextMenuEntries( from, list ); 
			list.Add( new ClaimingGumpEntry( from, this ) ); 
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

		public class ClaimingGumpEntry : ContextMenuEntry
		{
			private Mobile m_Mobile;
			private AnimalTrainer m_Giver;
			
			public ClaimingGumpEntry( Mobile from, AnimalTrainer giver ) : base( 6165, 3 )
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
					m_Giver.BeginClaimList( m_Mobile );
				}
            }
        }

		///////////////////////////////////////////////////////////////////////////

		private class ClaimListGump : Gump
		{
			private AnimalTrainer m_Trainer;
			private Mobile m_From;
			private List<BaseCreature> m_List;

			public ClaimListGump( AnimalTrainer trainer, Mobile from, List<BaseCreature> list ) : base( 50, 50 )
			{
				m_Trainer = trainer;
				m_From = from;
				m_List = list;

				from.CloseGump( typeof( ClaimListGump ) );

				this.Closable=true;
				this.Disposable=true;
				this.Dragable=true;
				this.Resizable=false;

				AddPage(0);
				AddImage(0, 0, 155);
				AddImage(300, 0, 155);
				AddImage(0, 300, 155);
				AddImage(300, 300, 155);
				AddImage(2, 2, 129);
				AddImage(298, 2, 129);
				AddImage(2, 298, 129);
				AddImage(298, 298, 129);
				AddImage(7, 8, 133);
				AddImage(218, 47, 132);
				AddImage(380, 8, 134);
				AddImage(164, 551, 140);
				AddImage(8, 517, 139);
				AddImage(269, 342, 147);
				AddHtml( 174, 68, 200, 20, @"<BODY><BASEFONT Color=White><BIG>PETS IN THE STABLE</BIG></BASEFONT></BODY>", (bool)false, (bool)false);

				int y = 95;

				for ( int i = 0; i < list.Count; ++i )
				{
					BaseCreature pet = list[i];

					if ( pet == null || pet.Deleted )
						continue;

					y = y + 35;

					AddHtml( 145, y, 425, 20, @"<BODY><BASEFONT Color=#FCFF00><BIG>" + pet.Name + "</BIG></BASEFONT></BODY>", (bool)false, (bool)false);
					AddButton(105, y, 4005, 4005, (i + 1), GumpButtonType.Reply, 0);
				}
			}

			public override void OnResponse( NetState sender, RelayInfo info )
			{
				int index = info.ButtonID - 1;

				if ( index >= 0 && index < m_List.Count )
					m_Trainer.EndClaimList( m_From, m_List[index] );
			}
		}

		private class ClaimAllEntry : ContextMenuEntry
		{
			private AnimalTrainer m_Trainer;
			private Mobile m_From;

			public ClaimAllEntry( AnimalTrainer trainer, Mobile from ) : base( 6127, 12 )
			{
				m_Trainer = trainer;
				m_From = from;
			}

			public override void OnClick()
			{
				m_Trainer.Claim( m_From );
			}
		}

		public override void AddCustomContextEntries( Mobile from, List<ContextMenuEntry> list )
		{
			if ( from.Alive )
			{
				list.Add( new StableEntry( this, from ) );

				if ( from.Stabled.Count > 0 )
					list.Add( new ClaimAllEntry( this, from ) );
			}

			base.AddCustomContextEntries( from, list );
		}

		public static int GetMaxStabled( Mobile from )
		{
			double taming = from.Skills[SkillName.AnimalTaming].Value;
			double anlore = from.Skills[SkillName.AnimalLore].Value;
			double vetern = from.Skills[SkillName.Veterinary].Value;
			double herd = from.Skills[SkillName.Herding].Value;
			double sklsum = taming + anlore + vetern + herd;

			int max;

			if ( sklsum >= 400.0 )
				max = 7;
			else if ( sklsum >= 300.0 )
				max = 6;
			else if ( sklsum >= 240.0 )
				max = 5;
			else if ( sklsum >= 200.0 )
				max = 4;
			else if ( sklsum >= 160.0 )
				max = 3;
			else
				max = 2;

			if ( taming >= 100.0 )
				max += (int)((taming - 90.0) / 10);

			if ( anlore >= 100.0 )
				max += (int)((anlore - 90.0) / 10);

			if ( vetern >= 100.0 )
				max += (int)((vetern - 90.0) / 10);

			if ( herd >= 100.0 )
				max += (int)((herd - 90.0) / 10);

			return max;
		}

		private class StableTarget : Target
		{
			private AnimalTrainer m_Trainer;

			public StableTarget( AnimalTrainer trainer ) : base( 12, false, TargetFlags.None )
			{
				m_Trainer = trainer;
			}

			protected override void OnTarget( Mobile from, object targeted )
			{
				if ( targeted is BaseCreature )
					m_Trainer.EndStable( from, (BaseCreature)targeted );
				else if ( targeted == from )
					m_Trainer.SayTo( from, 502672 ); // HA HA HA! Sorry, I am not an inn.
				else
					m_Trainer.SayTo( from, 1048053 ); // You can't stable that!
			}
		}
		
		private void CloseClaimList( Mobile from )
		{
			from.CloseGump( typeof( ClaimListGump ) );
		}

		public static void DismountPlayer( Mobile m )
		{
			CleanClaimList( m );

			if ( m.Mount is EtherealMount )
			{
				Server.Mobiles.EtherealMount.Dismount( m );
				m.SendMessage( "Your mount has moved to your pack." );
			}
			else if ( m.Mount is BaseMount )
			{
				BaseCreature pet = (BaseCreature)(m.Mount);
				Server.Mobiles.BaseMount.Dismount( m );

				pet.ControlTarget = null;
				//pet.ControlOrder = OrderType.Stay;
				pet.Internalize();
				pet.SetControlMaster( null );
				pet.SummonMaster = null;
				pet.IsStabled = true;
				pet.Loyalty = BaseCreature.MaxLoyalty;
				pet.Language = "mount";

				m.Stabled.Add( pet );

				m.SendMessage( "Your mount is safely waiting for you elsewhere." );
			}
		}

		public static void CleanClaimList( Mobile from )
		{
			List<BaseCreature> list = new List<BaseCreature>();

			for ( int i = 0; i < from.Stabled.Count; ++i )
			{
				BaseCreature pet = from.Stabled[i] as BaseCreature;

				if ( pet == null || pet.Deleted )
				{
					pet.IsStabled = false;
					from.Stabled.RemoveAt( i );
					--i;
					continue;
				}
				else { pet.Language = null; }
			}
		}

		public static void GetLastMounted( Mobile from )
		{
			List<BaseCreature> list = new List<BaseCreature>();

			BaseCreature bc = null;
			bool claimed = false;
			int stabled = 0;

			for ( int i = 0; i < from.Stabled.Count; ++i )
			{
				BaseCreature pet = from.Stabled[i] as BaseCreature;

				if ( pet == null || pet.Deleted )
				{
					pet.IsStabled = false;
					from.Stabled.RemoveAt( i );
					--i;
					continue;
				}
				else if ( pet.Language == "mount" )
				{
					bc = pet;
				}
			}

			for ( int i = 0; i < from.Stabled.Count; ++i )
			{
				BaseCreature pet = from.Stabled[i] as BaseCreature;

				++stabled;

				if ( CanGetLastMounted( from, pet ) && pet is BaseMount && pet == bc )
				{
					pet.SetControlMaster( from );
					pet.ControlTarget = from;
					pet.MoveToWorld( from.Location, from.Map );
					pet.IsStabled = false;
					pet.Loyalty = BaseCreature.MaxLoyalty; // Wonderfully Happy

					from.Stabled.RemoveAt( i );
					--i;

					claimed = true;
					((Mobile)pet).Language = null;
					((BaseMount)pet).Rider = from;
				}
				else if ( pet == bc )
				{
					((Mobile)pet).Language = null;
				}
			}

			Server.Mobiles.AnimalTrainer.CleanClaimList( from );
		}

		public static bool CanGetLastMounted( Mobile from, BaseCreature pet )
		{
			return ((from.Followers + pet.ControlSlots) <= from.FollowersMax);
		}

		public static bool IsNoMountRegion( Region reg )
		{
			if ( reg is CaveRegion || reg is BardDungeonRegion || reg is PirateRegion || reg is MoonCore || reg is GargoyleRegion || reg is UmbraRegion || reg is DungeonRegion )
					return true;

			return false;
		}

		public void BeginClaimList( Mobile from )
		{
			if ( Deleted || !from.CheckAlive() )
				return;

			List<BaseCreature> list = new List<BaseCreature>();

			for ( int i = 0; i < from.Stabled.Count; ++i )
			{
				BaseCreature pet = from.Stabled[i] as BaseCreature;

				if ( pet == null || pet.Deleted )
				{
					pet.IsStabled = false;
					from.Stabled.RemoveAt( i );
					--i;
					continue;
				}

				list.Add( pet );
			}

			if ( list.Count > 0 )
				from.SendGump( new ClaimListGump( this, from, list ) );
			else
				SayTo( from, 502671 ); // But I have no animals stabled with me at the moment!
		}

		public void EndClaimList( Mobile from, BaseCreature pet )
		{
			if ( pet == null || pet.Deleted || from.Map != this.Map || !from.Stabled.Contains( pet ) || !from.CheckAlive() )
				return;
			
			if ( !from.InRange( this, 14 ) )
			{
				from.SendLocalizedMessage( 500446 ); // That is too far away.
				return;
			}

			if ( CanClaim( from, pet ) )
			{
				DoClaim( from, pet );

				from.Stabled.Remove( pet );
			}
			else
			{
				SayTo( from, 1049612, pet.Name ); // ~1_NAME~ remained in the stables because you have too many followers.
			}
		}

		public void BeginStable( Mobile from )
		{
			if ( Deleted || !from.CheckAlive() )
				return;

			Container bank = from.FindBankNoCreate();
			
			if ( ( from.Backpack == null || from.Backpack.GetAmount( typeof( Gold ) ) < 30 ) && ( bank == null || bank.GetAmount( typeof( Gold ) ) < 30 ) )
			{
				SayTo( from, 1042556 ); // Thou dost not have enough gold, not even in thy bank account.
			}
			else
			{
				/* I charge 30 gold per pet for a real week's stable time.
				 * I will withdraw it from thy bank account.
				 * Which animal wouldst thou like to stable here?
				 */
				from.SendLocalizedMessage(1042558);

				from.Target = new StableTarget( this );
			}
		}

		public void EndStable( Mobile from, BaseCreature pet )
		{
			if ( Deleted || !from.CheckAlive() )
				return;

			if ( pet.Body.IsHuman )
			{
				SayTo( from, 502672 ); // HA HA HA! Sorry, I am not an inn.
			}
			else if ( !pet.Controlled )
			{
				SayTo( from, 1048053 ); // You can't stable that!
			}
			else if ( pet.ControlMaster != from )
			{
				SayTo( from, 1042562 ); // You do not own that pet!
			}
			else if ( pet.IsDeadPet )
			{
				SayTo( from, 1049668 ); // Living pets only, please.
			}
			else if ( pet.Summoned )
			{
				SayTo( from, 502673 ); // I can not stable summoned creatures.
			}
			else if ( (pet is PackLlama || pet is PackHorse || pet is Beetle) && (pet.Backpack != null && pet.Backpack.Items.Count > 0) )
			{
				SayTo( from, 1042563 ); // You need to unload your pet.
			}
			else if ( pet.Combatant != null && pet.InRange( pet.Combatant, 12 ) && pet.Map == pet.Combatant.Map )
			{
				SayTo( from, 1042564 ); // I'm sorry.  Your pet seems to be busy.
			}
			else if ( from.Stabled.Count >= GetMaxStabled( from ) )
			{
				SayTo( from, 1042565 ); // You have too many pets in the stables!
			}
			else
			{
				Container bank = from.FindBankNoCreate();

				if ( ( from.Backpack != null && from.Backpack.ConsumeTotal( typeof( Gold ), 30 ) ) || ( bank != null && bank.ConsumeTotal( typeof( Gold ), 30 ) ) )
				{
					pet.Language = null;
					pet.ControlTarget = null;
					pet.ControlOrder = OrderType.Stay;
					pet.Internalize();

					pet.SetControlMaster( null );
					pet.SummonMaster = null;

					pet.IsStabled = true;

					if ( Core.SE )	
						pet.Loyalty = BaseCreature.MaxLoyalty; // Wonderfully happy

					from.Stabled.Add( pet );

					SayTo( from, Core.AOS ? 1049677 : 502679 ); // [AOS: Your pet has been stabled.] Very well, thy pet is stabled. Thou mayst recover it by saying 'claim' to me. In one real world week, I shall sell it off if it is not claimed!
				}
				else
				{
					SayTo( from, 502677 ); // But thou hast not the funds in thy bank account!
				}
			}
		}

		public void Claim( Mobile from )
		{
			Claim( from, null );
		}

		public void Claim( Mobile from, string petName )
		{
			if ( Deleted || !from.CheckAlive() )
				return;

			bool claimed = false;
			int stabled = 0;
			
			bool claimByName = ( petName != null );

			for ( int i = 0; i < from.Stabled.Count; ++i )
			{
				BaseCreature pet = from.Stabled[i] as BaseCreature;

				if ( pet == null || pet.Deleted )
				{
					pet.IsStabled = false;
					from.Stabled.RemoveAt( i );
					--i;
					continue;
				}

				++stabled;

				if ( claimByName && !Insensitive.Equals( pet.Name, petName ) )
					continue;

				if ( CanClaim( from, pet ) )
				{
					DoClaim( from, pet );

					from.Stabled.RemoveAt( i );
					--i;

					claimed = true;
				}
				else
				{
					SayTo( from, 1049612, pet.Name ); // ~1_NAME~ remained in the stables because you have too many followers.
				}
			}

			if ( claimed )
				SayTo( from, 1042559 ); // Here you go... and good day to you!
			else if ( stabled == 0 )
				SayTo( from, 502671 ); // But I have no animals stabled with me at the moment!
			else if ( claimByName )
				BeginClaimList( from );
		}

		public bool CanClaim( Mobile from, BaseCreature pet )
		{
			return ((from.Followers + pet.ControlSlots) <= from.FollowersMax);
		}

		private void DoClaim( Mobile from, BaseCreature pet )
		{
			pet.SetControlMaster( from );

			if ( pet.Summoned )
				pet.SummonMaster = from;

			pet.Language = null;
			pet.ControlTarget = from;
			pet.ControlOrder = OrderType.Follow;

			pet.MoveToWorld( from.Location, from.Map );

			pet.IsStabled = false;

			if ( Core.SE )
				pet.Loyalty = BaseCreature.MaxLoyalty; // Wonderfully Happy
		}

		public override bool HandlesOnSpeech( Mobile from )
		{
			return true;
		}

		public override void OnSpeech( SpeechEventArgs e )
		{
			if ( !e.Handled && e.HasKeyword( 0x0008 ) ) // *stable*
			{
				e.Handled = true;
				
				CloseClaimList( e.Mobile );				
				BeginStable( e.Mobile );
			}
			else if ( !e.Handled && e.HasKeyword( 0x0009 ) ) // *claim*
			{
				e.Handled = true;
				
				CloseClaimList( e.Mobile );
				
				int index = e.Speech.IndexOf( ' ' );

				if ( index != -1 )
					Claim( e.Mobile, e.Speech.Substring( index ).Trim() );
				else
					Claim( e.Mobile );
			}
			else
			{
				base.OnSpeech( e );
			}
		}

		public AnimalTrainer( Serial serial ) : base( serial )
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