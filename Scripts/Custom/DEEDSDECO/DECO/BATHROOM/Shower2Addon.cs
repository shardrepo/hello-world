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
	public class Shower2Addon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new Shower2AddonDeed();
			}
		}

		[ Constructable ]
		public Shower2Addon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 250 );
			AddComponent( ac, -2, -1, 0 );
			ac = new AddonComponent( 249 );
			AddComponent( ac, 1, -2, 0 );
			ac = new AddonComponent( 250 );
			AddComponent( ac, -2, 0, 0 );
			ac = new AddonComponent( 250 );
			AddComponent( ac, -2, 1, 0 );
			ac = new AddonComponent( 249 );
			AddComponent( ac, 0, -2, 0 );
			ac = new AddonComponent( 249 );
			AddComponent( ac, -1, -2, 0 );
			ac = new AddonComponent( 251 );
			AddComponent( ac, -2, -2, 0 );
			ac = new AddonComponent( 1084 );
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 1082 );
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 1080 );
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 1293 );
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 1293 );
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 1293 );
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 1293 );
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 1293 );
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 1293 );
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 1293 );
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 1293 );
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 4838 );
			AddComponent( ac, 0, 2, 0 );
			ac = new AddonComponent( 4831 );
			AddComponent( ac, 2, 0, 0 );
			ac = new AddonComponent( 6039 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 13555 );
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 13585 );
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 3842 );
			ac.Name = "Conditioner";
			AddComponent( ac, 1, 0, 2 );
			ac = new AddonComponent( 3841 );
			ac.Name = "Shampoo";
			AddComponent( ac, 1, 0, 1 );
			ac = new AddonComponent( 5154 );
			ac.Name = "Soap";
			AddComponent( ac, 0, 1, 1 );
			ac = new AddonComponent( 4979 );
			AddComponent( ac, 0, 1, 1 );

		}

		public Shower2Addon( Serial serial ) : base( serial )
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

	public class Shower2AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new Shower2Addon();
			}
		}

		[Constructable]
		public Shower2AddonDeed()
		{
			Name = "Shower2";
		}

		public Shower2AddonDeed( Serial serial ) : base( serial )
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