/////////////////////////////////////////////////
//                                             //
// Automatically generated by the              //
// AddonGenerator script by Arya               //
//                                             //
/////////////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class GreyToiletAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new GreyToiletAddonDeed();
			}
		}

		[ Constructable ]
		public GreyToiletAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 5372 );
			ac.Hue = 1150;
			ac.Name = "Handle";
			AddComponent( ac, 1, 0, 15 );
			ac = new AddonComponent( 4632 );
			ac.Hue = 1150;
			ac.Name = "Toilet";
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 7608 );
			ac.Hue = 1150;
			ac.Name = "ToiletSeatLid";
			AddComponent( ac, 0, 0, 4 );

		}

		public GreyToiletAddon( Serial serial ) : base( serial )
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

	public class GreyToiletAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new GreyToiletAddon();
			}
		}

		[Constructable]
		public GreyToiletAddonDeed()
		{
			Name = "GreyToilet";
		}

		public GreyToiletAddonDeed( Serial serial ) : base( serial )
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