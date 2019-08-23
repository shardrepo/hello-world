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
	public class PotterWestCampionFlowersAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new PotterWestCampionFlowersAddonDeed();
			}
		}

		[ Constructable ]
		public PotterWestCampionFlowersAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 9345 );
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 9344 );
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 9344 );
			AddComponent( ac, 0, 0, 1 );
			ac = new AddonComponent( 9352 );
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 9344 );
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 9344 );
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 9345 );
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 3203 );
			AddComponent( ac, 1, 1, 6 );
			ac = new AddonComponent( 3203 );
			AddComponent( ac, 1, 0, 5 );

		}

		public PotterWestCampionFlowersAddon( Serial serial ) : base( serial )
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

	public class PotterWestCampionFlowersAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new PotterWestCampionFlowersAddon();
			}
		}

		[Constructable]
		public PotterWestCampionFlowersAddonDeed()
		{
			Name = "PotterWestCampionFlowers";
		}

		public PotterWestCampionFlowersAddonDeed( Serial serial ) : base( serial )
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