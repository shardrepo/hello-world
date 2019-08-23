
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
	public class WagonWAddon : BaseAddon
	{
         
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new WagonWAddonDeed();
			}
		}

		[ Constructable ]
		public WagonWAddon()
		{



			AddComplexComponent( (BaseAddon) this, 10722, -4, 0, 0, 0, -1, "hitch", 1);// 1
			AddComplexComponent( (BaseAddon) this, 21, -2, 0, 7, 0, -1, "wagon", 1);// 2
			AddComplexComponent( (BaseAddon) this, 21, -2, 0, 12, 0, -1, "wagon", 1);// 3
			AddComplexComponent( (BaseAddon) this, 21, -2, 2, 12, 0, -1, "wagon", 1);// 4
			AddComplexComponent( (BaseAddon) this, 21, -2, 2, 7, 0, -1, "wagon", 1);// 5
			AddComplexComponent( (BaseAddon) this, 24, -1, -1, 7, 0, -1, "wagon", 1);// 6
			AddComplexComponent( (BaseAddon) this, 24, -1, -1, 11, 0, -1, "wagon", 1);// 7
			AddComplexComponent( (BaseAddon) this, 5831, -1, 0, 0, 0, -1, "wagon", 1);// 8
			AddComplexComponent( (BaseAddon) this, 1995, -2, 0, 6, 0, -1, "wagon", 1);// 9
			AddComplexComponent( (BaseAddon) this, 1993, -2, 1, 6, 0, -1, "wagon", 1);// 10
			AddComplexComponent( (BaseAddon) this, 5836, -1, 2, 0, 0, -1, "wagonwheel", 1);// 11
			AddComplexComponent( (BaseAddon) this, 1996, -2, 2, 6, 0, -1, "wagon", 1);// 12
			AddComplexComponent( (BaseAddon) this, 24, -1, 2, 6, 0, -1, "wagon", 1);// 13
			AddComplexComponent( (BaseAddon) this, 24, -1, 2, 10, 0, -1, "wagon", 1);// 14
			AddComplexComponent( (BaseAddon) this, 24, 0, -1, 7, 0, -1, "wagon", 1);// 15
			AddComplexComponent( (BaseAddon) this, 24, 0, -1, 11, 0, -1, "wagon", 1);// 16
			AddComplexComponent( (BaseAddon) this, 1996, -1, 0, 6, 0, -1, "wagon", 1);// 17
			AddComplexComponent( (BaseAddon) this, 1995, -1, 1, 6, 0, -1, "wagon", 1);// 18
			AddComplexComponent( (BaseAddon) this, 24, 0, 2, 10, 0, -1, "wagon", 1);// 19
			AddComplexComponent( (BaseAddon) this, 1994, -1, 2, 6, 0, -1, "wagon", 1);// 20
			AddComplexComponent( (BaseAddon) this, 24, 0, 2, 6, 0, -1, "wagon", 1);// 21
			AddComplexComponent( (BaseAddon) this, 24, 1, -1, 11, 0, -1, "wagon", 1);// 22
			AddComplexComponent( (BaseAddon) this, 24, 1, -1, 7, 0, -1, "wagon", 1);// 23
			AddComplexComponent( (BaseAddon) this, 1993, 0, 0, 6, 0, -1, "wagon", 1);// 24
			AddComplexComponent( (BaseAddon) this, 1996, 0, 1, 6, 0, -1, "wagon", 1);// 25
			AddComplexComponent( (BaseAddon) this, 24, 1, 2, 10, 0, -1, "wagon", 1);// 26
			AddComplexComponent( (BaseAddon) this, 1995, 0, 2, 6, 0, -1, "wagon", 1);// 27
			AddComplexComponent( (BaseAddon) this, 24, 1, 2, 6, 0, -1, "wagon", 1);// 28
			AddComplexComponent( (BaseAddon) this, 24, 2, -1, 11, 0, -1, "wagon", 1);// 29
			AddComplexComponent( (BaseAddon) this, 24, 2, -1, 7, 0, -1, "wagon", 1);// 30
			AddComplexComponent( (BaseAddon) this, 1994, 1, 0, 6, 0, -1, "wagon", 1);// 31
			AddComplexComponent( (BaseAddon) this, 1995, 1, 1, 6, 0, -1, "wagon", 1);// 32
			AddComplexComponent( (BaseAddon) this, 24, 2, 2, 6, 0, -1, "wagon", 1);// 33
			AddComplexComponent( (BaseAddon) this, 24, 2, 2, 10, 0, -1, "wagon", 1);// 34
			AddComplexComponent( (BaseAddon) this, 1993, 1, 2, 6, 0, -1, "wagon", 1);// 35
			AddComplexComponent( (BaseAddon) this, 24, 3, -1, 7, 0, -1, "wagon", 1);// 36
			AddComplexComponent( (BaseAddon) this, 24, 3, -1, 11, 0, -1, "wagon", 1);// 37
			AddComplexComponent( (BaseAddon) this, 1995, 2, 0, 6, 0, -1, "wagon", 1);// 38
			AddComplexComponent( (BaseAddon) this, 1996, 2, 1, 6, 0, -1, "wagon", 1);// 39
			AddComplexComponent( (BaseAddon) this, 24, 3, 2, 6, 0, -1, "wagon", 1);// 40
			AddComplexComponent( (BaseAddon) this, 24, 3, 2, 10, 0, -1, "wagon", 1);// 41
			AddComplexComponent( (BaseAddon) this, 1995, 2, 2, 6, 0, -1, "wagon", 1);// 42
			AddComplexComponent( (BaseAddon) this, 24, 4, -1, 7, 0, -1, "wagon", 1);// 43
			AddComplexComponent( (BaseAddon) this, 24, 4, -1, 11, 0, -1, "wagon", 1);// 44
			AddComplexComponent( (BaseAddon) this, 2188, -2, -1, 7, 0, 0, "wagon", 1);// 45
			AddComplexComponent( (BaseAddon) this, 21, 4, 0, 12, 0, -1, "wagon", 1);// 46
			AddComplexComponent( (BaseAddon) this, 21, 4, 0, 7, 0, -1, "wagon", 1);// 47
			AddComplexComponent( (BaseAddon) this, 5831, 3, 0, 0, 0, -1, "wagon", 1);// 48
			AddComplexComponent( (BaseAddon) this, 1994, 3, 0, 6, 0, -1, "wagon", 1);// 49
			AddComplexComponent( (BaseAddon) this, 21, 4, 1, 12, 0, -1, "wagon", 1);// 50
			AddComplexComponent( (BaseAddon) this, 21, 4, 1, 7, 0, -1, "wagon", 1);// 51
			AddComplexComponent( (BaseAddon) this, 1996, 3, 1, 6, 0, -1, "wagon", 1);// 52
			AddComplexComponent( (BaseAddon) this, 24, 4, 2, 6, 0, -1, "wagon", 1);// 53
			AddComplexComponent( (BaseAddon) this, 1993, 3, 2, 6, 0, -1, "wagon", 1);// 54
			AddComplexComponent( (BaseAddon) this, 21, 4, 2, 7, 0, -1, "wagon", 1);// 55
			AddComplexComponent( (BaseAddon) this, 21, 4, 2, 12, 0, -1, "wagon", 1);// 56
			AddComplexComponent( (BaseAddon) this, 24, 4, 2, 10, 0, -1, "wagon", 1);// 57
			AddComplexComponent( (BaseAddon) this, 5836, 3, 2, 0, 0, -1, "wagonwheel", 1);// 58
			AddComplexComponent( (BaseAddon) this, 2188, -2, 2, 7, 0, 0, "wagon", 1);// 59
			AddComplexComponent( (BaseAddon) this, 1994, 4, 0, 6, 0, -1, "wagon", 1);// 60
			AddComplexComponent( (BaseAddon) this, 2860, -2, 0, 7, 0, -1, "wagon", 1);// 61
			AddComplexComponent( (BaseAddon) this, 2860, -2, 1, 7, 0, -1, "wagon", 1);// 62
			AddComplexComponent( (BaseAddon) this, 1995, 4, 1, 6, 0, -1, "wagon", 1);// 63
			AddComplexComponent( (BaseAddon) this, 1996, 4, 2, 6, 0, -1, "wagon", 1);// 64
			AddComplexComponent( (BaseAddon) this, 2860, -2, 2, 7, 0, -1, "wagon", 1);// 65
			AddComplexComponent( (BaseAddon) this, 21, -2, 1, 7, 0, -1, "wagon", 1);// 66
			AddComplexComponent( (BaseAddon) this, 21, -2, 1, 12, 0, -1, "wagon", 1);// 67
			AddComplexComponent( (BaseAddon) this, 10722, -2, 1, 0, 0, -1, "hitch", 1);// 68
			AddComplexComponent( (BaseAddon) this, 10722, -2, 0, 0, 0, -1, "hitch", 1);// 69
			AddComplexComponent( (BaseAddon) this, 10722, -2, -1, 0, 0, -1, "hitch", 1);// 70
			AddComplexComponent( (BaseAddon) this, 10723, -3, 1, 0, 0, -1, "hitch", 1);// 71
			AddComplexComponent( (BaseAddon) this, 10723, -3, 0, 0, 0, -1, "hitch", 1);// 72
			AddComplexComponent( (BaseAddon) this, 10722, -3, 0, 0, 0, -1, "hitch", 1);// 73

		}

		public WagonWAddon( Serial serial ) : base( serial )
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

	public class WagonWAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new WagonWAddon();
			}
		}

		[Constructable]
		public WagonWAddonDeed()
		{
			Name = "WagonW";
		}

		public WagonWAddonDeed( Serial serial ) : base( serial )
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