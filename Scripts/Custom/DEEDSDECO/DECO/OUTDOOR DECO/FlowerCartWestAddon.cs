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
	public class AG_FlowerCartWestAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new AG_FlowerCartWestAddonDeed();
			}
		}

		[ Constructable ]
		public AG_FlowerCartWestAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 6791 );
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 6792 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 6795 );
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 3203 );
			AddComponent( ac, 0, 0, 3 );

		}

		public AG_FlowerCartWestAddon( Serial serial ) : base( serial )
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

	public class AG_FlowerCartWestAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new AG_FlowerCartWestAddon();
			}
		}

		[Constructable]
		public AG_FlowerCartWestAddonDeed()
		{
			Name = "AG_FlowerCartWest";
		}

		public AG_FlowerCartWestAddonDeed( Serial serial ) : base( serial )
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