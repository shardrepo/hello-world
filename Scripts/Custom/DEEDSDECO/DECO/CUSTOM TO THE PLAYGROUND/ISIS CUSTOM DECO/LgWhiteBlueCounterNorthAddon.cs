
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
	public class LgWhiteBlueCounterNorthAddon : BaseAddon
	{
         
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new LgWhiteBlueCounterNorthAddonDeed();
			}
		}

		[ Constructable ]
		public LgWhiteBlueCounterNorthAddon()
		{



			AddComplexComponent( (BaseAddon) this, 1801, -1, -2, 5, 1153, -1, "Counter", 1);// 1
			AddComplexComponent( (BaseAddon) this, 1801, -1, -1, 5, 1153, -1, "Counter", 1);// 2
			AddComplexComponent( (BaseAddon) this, 1801, -1, 0, 5, 1153, -1, "Counter", 1);// 3
			AddComplexComponent( (BaseAddon) this, 1801, -1, 1, 5, 1153, -1, "Counter", 1);// 4
			AddComplexComponent( (BaseAddon) this, 1801, -1, 2, 5, 1153, -1, "Counter", 1);// 5
			AddComplexComponent( (BaseAddon) this, 1801, 0, 2, 5, 1153, -1, "Counter", 1);// 6
			AddComplexComponent( (BaseAddon) this, 1801, 1, 2, 5, 1153, -1, "Counter", 1);// 7
			AddComplexComponent( (BaseAddon) this, 1801, 2, 2, 5, 1153, -1, "Counter", 1);// 8
			AddComplexComponent( (BaseAddon) this, 1801, 3, 2, 5, 1153, -1, "Counter", 1);// 9
			AddComplexComponent( (BaseAddon) this, 1180, -1, -2, 10, 1165, -1, "Counter", 1);// 10
			AddComplexComponent( (BaseAddon) this, 1180, -1, -1, 10, 1165, -1, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 1180, -1, 0, 10, 1165, -1, "Counter", 1);// 12
			AddComplexComponent( (BaseAddon) this, 1180, -1, 1, 10, 1165, -1, "Counter", 1);// 13
			AddComplexComponent( (BaseAddon) this, 1180, -1, 2, 10, 1165, -1, "Counter", 1);// 14
			AddComplexComponent( (BaseAddon) this, 1180, 0, 2, 10, 1165, -1, "Counter", 1);// 15
			AddComplexComponent( (BaseAddon) this, 1180, 1, 2, 10, 1165, -1, "Counter", 1);// 16
			AddComplexComponent( (BaseAddon) this, 1180, 2, 2, 10, 1165, -1, "Counter", 1);// 17
			AddComplexComponent( (BaseAddon) this, 1180, 3, 2, 10, 1165, -1, "Counter", 1);// 18
			AddComplexComponent( (BaseAddon) this, 272, -2, -2, 9, 1153, -1, "Counter", 1);// 19
			AddComplexComponent( (BaseAddon) this, 272, -2, -1, 9, 1153, -1, "Counter", 1);// 20
			AddComplexComponent( (BaseAddon) this, 272, -2, 0, 9, 1153, -1, "Counter", 1);// 21
			AddComplexComponent( (BaseAddon) this, 272, -2, 1, 9, 1153, -1, "Counter", 1);// 22
			AddComplexComponent( (BaseAddon) this, 272, -2, 2, 9, 1153, -1, "Counter", 1);// 23
			AddComplexComponent( (BaseAddon) this, 9232, 0, -2, 0, 1150, -1, "door", 1);// 24
			AddComplexComponent( (BaseAddon) this, 9232, 0, -1, 0, 1150, -1, "door", 1);// 25
			AddComplexComponent( (BaseAddon) this, 9232, 0, 0, 0, 1150, -1, "door", 1);// 26
			AddComplexComponent( (BaseAddon) this, 9232, 0, 1, 0, 1150, -1, "door", 1);// 27
			AddComplexComponent( (BaseAddon) this, 271, -1, 2, 9, 1153, -1, "counter", 1);// 28
			AddComplexComponent( (BaseAddon) this, 271, 0, 2, 9, 1153, -1, "counter", 1);// 29
			AddComplexComponent( (BaseAddon) this, 271, 1, 2, 9, 1153, -1, "counter", 1);// 30
			AddComplexComponent( (BaseAddon) this, 271, 2, 2, 9, 1153, -1, "counter", 1);// 31
			AddComplexComponent( (BaseAddon) this, 271, 3, 2, 9, 1153, -1, "counter", 1);// 32

		}

		public LgWhiteBlueCounterNorthAddon( Serial serial ) : base( serial )
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

	public class LgWhiteBlueCounterNorthAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new LgWhiteBlueCounterNorthAddon();
			}
		}

		[Constructable]
		public LgWhiteBlueCounterNorthAddonDeed()
		{
			Name = "LgWhiteBlueCounterNorth";
		}

		public LgWhiteBlueCounterNorthAddonDeed( Serial serial ) : base( serial )
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