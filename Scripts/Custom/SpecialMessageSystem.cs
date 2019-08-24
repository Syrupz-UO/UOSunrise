using System;
using Server;
using Server.Items;
using System.Text;


namespace Server.Items
{
	public class SpecialMessageSystem : Item
	{
		public override bool Decays{ get{ return false; } }
		public DateTime t_NextMessageTime;
		public bool b_switchon;
		[CommandProperty( AccessLevel.GameMaster )]
		public bool switchon { get { return b_switchon; } set { b_switchon = value; if (value) Restart_Message_Func(); } }
		public string b_specialmessage1;
		[CommandProperty( AccessLevel.GameMaster )]
		public string specialmessage1 { get { return b_specialmessage1; } set { b_specialmessage1 = value; } }
		public string b_specialmessage2;
		[CommandProperty( AccessLevel.GameMaster )]
		public string specialmessage2 { get { return b_specialmessage2; } set { b_specialmessage2 = value; } }
		public string b_specialmessage3;
		[CommandProperty( AccessLevel.GameMaster )]
		public string specialmessage3 { get { return b_specialmessage3; } set { b_specialmessage3 = value; } }
		public int b_specialmessageint;
		[CommandProperty( AccessLevel.GameMaster )]
		public int specialmessageint { get { return b_specialmessageint; } set { b_specialmessageint = value; } }

		[Constructable]
		public SpecialMessageSystem() : base(6434)
		{
			Name = "Special Message System";
			Visible = false;
			Movable = false;
			t_NextMessageTime = DateTime.UtcNow;
		}

		private void Restart_Message_Func()
		{
			I_Auto_Message_System tmr = new I_Auto_Message_System(this);
			tmr.Start();
		}

		public SpecialMessageSystem(Serial serial) : base(serial){}
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
			writer.Write( (bool) b_switchon);
			writer.Write( (string) b_specialmessage1);
			writer.Write( (string) b_specialmessage2);
			writer.Write( (string) b_specialmessage3);
			writer.Write( (int) b_specialmessageint );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
			b_switchon = reader.ReadBool();
			b_specialmessage1 = reader.ReadString();
			b_specialmessage2 = reader.ReadString();
			b_specialmessage3 = reader.ReadString();
			b_specialmessageint = reader.ReadInt();
			if (b_switchon)
			{
				I_Auto_Message_System tmr = new I_Auto_Message_System(this);
				tmr.Start();
			}
		}
	}

	public class I_Auto_Message_System : Timer
	{
		private SpecialMessageSystem item;
		public  I_Auto_Message_System(SpecialMessageSystem i) : base( TimeSpan.FromSeconds( 1.0 ), TimeSpan.FromSeconds( 1.0 ) )
		{
			item = i;
			Priority = TimerPriority.FiveSeconds;
		}

		protected override void OnTick()
		{
			if (item == null || item.Deleted ) { this.Stop(); return;}
			if (item.b_specialmessageint == null || item.b_specialmessageint < 1)  { this.Stop(); return; }
			else if (((SpecialMessageSystem)item).b_switchon == false) { this.Stop(); return; }
			if (DateTime.UtcNow >= item.t_NextMessageTime)
			{
				
				
				World.Broadcast( 0x22, true, item.b_specialmessage1 );
				World.Broadcast( 0x22, true, item.b_specialmessage2 );
				World.Broadcast( 0x22, true, item.b_specialmessage3 );
				item.t_NextMessageTime = DateTime.UtcNow + TimeSpan.FromMinutes( item.b_specialmessageint );
			}
		}
	}
}