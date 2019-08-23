//Browser Stone by Tresdni
//http://www.uofreedom.com
/*Usage Example
	[add BrowserStone "RunUO" "Visit the RunUO Site!" "http://www.runuo.com/"
*/
using System;
using System.Collections.Generic;

using Server;

namespace Server.Items
{
    public class BrowserStone : Item
    {
        private string m_Url;
		private string m_Description;
        
        [CommandProperty( AccessLevel.GameMaster )]
        public string Url
        {
            get
            {
                return m_Url;
            }
            set
            {
                m_Url = value;
            }
        }
		
		[CommandProperty( AccessLevel.GameMaster )]
        public string Description
        {
            get
            {
                return m_Description;
            }
            set
            {
                m_Description = value; InvalidateProperties();
            }
        }

        [Constructable]
        public BrowserStone() : this( "Generic Web Stone" )
        {
			Movable = false;
			Hue = 1922;
			Description = "Double Click to Use";
        }

        [Constructable]
        public BrowserStone( string name ) : base( 0xED4 )
        {
            Name = name;
			Movable = false;
			Hue = 1922;
			Description = "Double Click to Use";
        }
		
		 [Constructable]
        public BrowserStone( string name, string description ) : base( 0xED4 )
        {
            Name = name;
			Description = description;
			Movable = false;
			Hue = 1922;
        }
		
		 [Constructable]
        public BrowserStone( string name, string description, string url ) : base( 0xED4 )
        {
            Name = name;
			Description = description;
			Url = url;
			Movable = false;
			Hue = 1922;
        }

        public override void OnDoubleClick( Mobile from )
        {
            from.LaunchBrowser( m_Url );
        }

        public override void GetProperties( ObjectPropertyList list )
        {
            base.GetProperties( list );

            list.Add( m_Description );
        }

        public BrowserStone( Serial serial ) : base( serial )
        {
        }

        public override void Deserialize( GenericReader reader )
        {
            base.Deserialize( reader );

            int version = reader.ReadInt();
            m_Url = reader.ReadString();
			m_Description = reader.ReadString();
        }

        public override void Serialize( GenericWriter writer )
        {
            base.Serialize( writer );

            writer.Write( (int)0 );
            writer.Write( (string)m_Url );
			writer.Write( (string)m_Description );
        }
    }
}
