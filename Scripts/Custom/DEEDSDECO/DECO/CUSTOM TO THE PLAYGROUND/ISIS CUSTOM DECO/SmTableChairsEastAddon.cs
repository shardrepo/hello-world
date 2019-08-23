
////////////////////////////////////////
//                                     //
//   Generated by CEO's YAAAG - Ver 2  //
// (Yet Another Arya Addon Generator)  //
//    Modified by Hammerhand for       //
//      SA & High Seas content         //
//                                     //
////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class SmTableChairsEastAddon : BaseAddon
	{
         
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new SmTableChairsEastAddonDeed();
			}
		}

		[ Constructable ]
		public SmTableChairsEastAddon()
		{



			AddComplexComponent( (BaseAddon) this, 2894, -1, 0, 0, 1153, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 19667, 1, -1, 0, 1146, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 19668, 1, 1, 0, 1146, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 19670, 0, -1, 0, 1146, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 19671, 0, 0, 0, 1146, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 19669, 0, 1, 0, 1146, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 19666, 1, 0, 0, 1146, -1, "", 1);// 7
			AddComplexComponent( (BaseAddon) this, 2897, 2, 0, 0, 1153, -1, "", 1);// 8

		}

		public SmTableChairsEastAddon( Serial serial ) : base( serial )
		{
		}

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource)
        {
            AddComplexComponent(addon, item, xoffset, yoffset, zoffset, hue, lightsource, null, 1);
        }

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource, string name, int amount)
        {
            AddonComponent ac;
            ac = new AddonComponent(item);
            if (name != null && name.Length > 0)
                ac.Name = name;
            if (hue != 0)
                ac.Hue = hue;
            if (amount > 1)
            {
                ac.Stackable = true;
                ac.Amount = amount;
            }
            if (lightsource != -1)
                ac.Light = (LightType) lightsource;
            addon.AddComponent(ac, xoffset, yoffset, zoffset);
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

	public class SmTableChairsEastAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new SmTableChairsEastAddon();
			}
		}

		[Constructable]
		public SmTableChairsEastAddonDeed()
		{
			Name = "SmTableChairsEast";
		}

		public SmTableChairsEastAddonDeed( Serial serial ) : base( serial )
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