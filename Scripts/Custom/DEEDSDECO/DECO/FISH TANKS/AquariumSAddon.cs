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
	public class AquariumSAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new AquariumSAddonDeed();
			}
		}

		[ Constructable ]
		public AquariumSAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 12384 );
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 12385 );
			AddComponent( ac, 0, 0, 0 );

		}

		public AquariumSAddon( Serial serial ) : base( serial )
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

	public class AquariumSAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new AquariumSAddon();
			}
		}

		[Constructable]
		public AquariumSAddonDeed()
		{
			Name = "AquariumS";
		}

		public AquariumSAddonDeed( Serial serial ) : base( serial )
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