/*  _________________________________
 -=(_)_______________________________)=-
   /   .   .   . ____  . ___      _/
  /~ /    /   / /     / /   )2005 /
 (~ (____(___/ (____ / /___/     (
  \ ----------------------------- \
   \     lucidnagual@gmail.com     \
    \_     ===================      \
     \   -Admin of "The Conjuring"-  \
      \_     ===================     ~\
       )      Advanced Archery         )
      /~      Version [2].0.1        _/
    _/_______________________________/
 -=(_)_______________________________)=-
 */
using System;

namespace Server.Items
{
	public class ArmorPiercingArrow : Arrow
	{
		[Constructable]
		public ArmorPiercingArrow() : this( 1 )
		{
		}

		[Constructable]
		public ArmorPiercingArrow( int amount ) : base( 0xF3F )
		{
			Stackable = true;
			Name = "Armor Piercing Arrow";
			Hue = 1153;
			Weight = 0.1;
			Amount = amount;
		}

		public ArmorPiercingArrow( Serial serial ) : base( serial )
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
