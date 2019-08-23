using System;
using Server;

namespace Server.Items
{
	public class ManaPotion : BaseManaRefreshPotion
	{
		public override int MinMana { get{ return 75; } }
		public override int MaxMana { get{ return 125; } }
		public override double Delay { get{ return 4; } }

		[Constructable]
		public ManaPotion( ) : base( PotionEffect.Mana )
		{
			Name = "mana potion";
			Hue = Server.Items.PotionKeg.GetPotionColor( this );
		}

		public ManaPotion( Serial serial ) : base( serial )
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
