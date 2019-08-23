
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
	public class WeddingCarriageAddon : BaseAddon
	{
         
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new WeddingCarriageAddonDeed();
			}
		}

		[ Constructable ]
		public WeddingCarriageAddon()
		{



			AddComplexComponent( (BaseAddon) this, 3204, -1, 0, 29, 0, -1, "Wedding Carriage", 1);// 1
			AddComplexComponent( (BaseAddon) this, 11191, -1, 2, 7, 0, -1, "Wedding Carriage", 1);// 2
			AddComplexComponent( (BaseAddon) this, 11514, 2, -1, 8, 0, -1, "Wedding Carriage", 1);// 3
			AddComplexComponent( (BaseAddon) this, 11131, -2, -1, 7, 0, -1, "Wedding Carriage", 1);// 4
			AddComplexComponent( (BaseAddon) this, 11131, 1, 1, 7, 0, -1, "Wedding Carriage", 1);// 5
			AddComplexComponent( (BaseAddon) this, 3204, 0, -1, 28, 0, -1, "Wedding Carriage", 1);// 6
			AddComplexComponent( (BaseAddon) this, 11193, 1, 1, 27, 0, -1, "Wedding Carriage", 1);// 7
			AddComplexComponent( (BaseAddon) this, 11189, 0, 1, 27, 0, -1, "Wedding Carriage", 1);// 8
			AddComplexComponent( (BaseAddon) this, 11191, -1, 1, 7, 0, -1, "Wedding Carriage", 1);// 9
			AddComplexComponent( (BaseAddon) this, 11132, 1, 1, 7, 0, -1, "Wedding Carriage", 1);// 10
			AddComplexComponent( (BaseAddon) this, 11132, -1, 1, 7, 0, -1, "Wedding Carriage", 1);// 11
			AddComplexComponent( (BaseAddon) this, 1113, 1, 2, 7, 0, -1, "Wedding Carriage", 1);// 12
			AddComplexComponent( (BaseAddon) this, 5799, 1, -1, 0, 1150, -1, "wagonwheel", 1);// 13
			AddComplexComponent( (BaseAddon) this, 11189, 1, -1, 27, 0, -1, "Wedding Carriage", 1);// 14
			AddComplexComponent( (BaseAddon) this, 19597, 0, -1, 7, 0, -1, "Wedding Carriage", 1);// 15
			AddComplexComponent( (BaseAddon) this, 19599, 1, -1, 7, 0, -1, "Wedding Carriage", 1);// 16
			AddComplexComponent( (BaseAddon) this, 5535, 0, 2, 7, 1153, -1, "Wedding Carriage", 1);// 17
			AddComplexComponent( (BaseAddon) this, 11135, 1, 0, 7, 0, 0, "Wedding Carriage", 1);// 18
			AddComplexComponent( (BaseAddon) this, 1997, 1, 0, 6, 1153, -1, "Wedding Carriage", 1);// 19
			AddComplexComponent( (BaseAddon) this, 11189, 0, -1, 27, 0, -1, "Wedding Carriage", 1);// 20
			AddComplexComponent( (BaseAddon) this, 11189, 1, 1, 27, 0, -1, "Wedding Carriage", 1);// 21
			AddComplexComponent( (BaseAddon) this, 19598, -1, -1, 7, 0, -1, "Wedding Carriage", 1);// 22
			AddComplexComponent( (BaseAddon) this, 11131, 1, -1, 7, 0, -1, "Wedding Carriage", 1);// 23
			AddComplexComponent( (BaseAddon) this, 11135, -2, 0, 7, 0, 0, "Wedding Carriage", 1);// 24
			AddComplexComponent( (BaseAddon) this, 11189, 0, 0, 27, 0, -1, "Wedding Carriage", 1);// 25
			AddComplexComponent( (BaseAddon) this, 3204, 0, 1, 28, 0, -1, "Wedding Carriage", 1);// 26
			AddComplexComponent( (BaseAddon) this, 3203, 1, 1, 28, 0, -1, "Wedding Carriage", 1);// 27
			AddComplexComponent( (BaseAddon) this, 11189, 1, 0, 27, 0, -1, "Wedding Carriage", 1);// 28
			AddComplexComponent( (BaseAddon) this, 11191, -1, 0, 7, 0, -1, "Wedding Carriage", 1);// 29
			AddComplexComponent( (BaseAddon) this, 3203, 1, -1, 28, 0, -1, "Wedding Carriage", 1);// 30
			AddComplexComponent( (BaseAddon) this, 1113, -1, 2, 7, 0, -1, "Wedding Carriage", 1);// 31
			AddComplexComponent( (BaseAddon) this, 11193, -2, 0, 27, 0, -1, "Wedding Carriage", 1);// 32
			AddComplexComponent( (BaseAddon) this, 11132, -1, -2, 7, 0, -1, "Wedding Carriage", 1);// 33
			AddComplexComponent( (BaseAddon) this, 11189, -1, 1, 27, 0, -1, "Wedding Carriage", 1);// 34
			AddComplexComponent( (BaseAddon) this, 3203, -1, -1, 28, 0, -1, "Wedding Carriage", 1);// 35
			AddComplexComponent( (BaseAddon) this, 11191, -1, -1, 7, 0, -1, "Wedding Carriage", 1);// 36
			AddComplexComponent( (BaseAddon) this, 5534, -1, 1, 7, 1153, -1, "Wedding Carriage", 1);// 37
			AddComplexComponent( (BaseAddon) this, 3203, -1, 1, 28, 0, -1, "Wedding Carriage", 1);// 38
			AddComplexComponent( (BaseAddon) this, 5534, 2, 0, 7, 1153, -1, "Wedding Carriage", 1);// 39
			AddComplexComponent( (BaseAddon) this, 11516, 1, 2, 7, 0, -1, "Wedding Carriage", 1);// 40
			AddComplexComponent( (BaseAddon) this, 11191, 0, 1, 7, 0, -1, "Wedding Carriage", 1);// 41
			AddComplexComponent( (BaseAddon) this, 11132, 1, -2, 7, 0, -1, "Wedding Carriage", 1);// 42
			AddComplexComponent( (BaseAddon) this, 11191, 1, -1, 7, 0, -1, "Wedding Carriage", 1);// 43
			AddComplexComponent( (BaseAddon) this, 11131, -2, 1, 7, 0, -1, "Wedding Carriage", 1);// 44
			AddComplexComponent( (BaseAddon) this, 5534, -1, -1, 7, 1153, -1, "Wedding Carriage", 1);// 45
			AddComplexComponent( (BaseAddon) this, 10723, 0, 3, 0, 1153, -1, "hitch", 1);// 46
			AddComplexComponent( (BaseAddon) this, 10723, 0, 2, 0, 1153, -1, "hitch", 1);// 47
			AddComplexComponent( (BaseAddon) this, 10723, -1, 3, 0, 1153, -1, "hitch", 1);// 48
			AddComplexComponent( (BaseAddon) this, 11191, 0, -1, 7, 0, -1, "Wedding Carriage", 1);// 49
			AddComplexComponent( (BaseAddon) this, 11193, -2, -1, 27, 0, -1, "Wedding Carriage", 1);// 50
			AddComplexComponent( (BaseAddon) this, 5794, -1, -1, 0, 1150, -1, "Wedding Carriage", 1);// 51
			AddComplexComponent( (BaseAddon) this, 11191, 1, 0, 7, 0, -1, "Wedding Carriage", 1);// 52
			AddComplexComponent( (BaseAddon) this, 11133, 0, 1, 7, 0, 0, "Wedding Carriage", 1);// 53
			AddComplexComponent( (BaseAddon) this, 11191, 0, 0, 7, 0, -1, "Wedding Carriage", 1);// 54
			AddComplexComponent( (BaseAddon) this, 11191, 0, 2, 7, 0, -1, "Wedding Carriage", 1);// 55
			AddComplexComponent( (BaseAddon) this, 5794, -1, 1, 0, 1150, -1, "Wedding Carriage", 1);// 56
			AddComplexComponent( (BaseAddon) this, 3204, 1, 0, 28, 0, -1, "Wedding Carriage", 1);// 57
			AddComplexComponent( (BaseAddon) this, 5535, -1, -1, 7, 0, -1, "Wedding Carriage", 1);// 58
			AddComplexComponent( (BaseAddon) this, 1999, 0, 0, 6, 1153, -1, "Wedding Carriage", 1);// 59
			AddComplexComponent( (BaseAddon) this, 11516, -1, 2, 7, 0, -1, "Wedding Carriage", 1);// 60
			AddComplexComponent( (BaseAddon) this, 1999, 1, 1, 6, 1153, -1, "Wedding Carriage", 1);// 61
			AddComplexComponent( (BaseAddon) this, 11191, 1, 1, 7, 0, -1, "Wedding Carriage", 1);// 62
			AddComplexComponent( (BaseAddon) this, 5535, 1, -1, 7, 0, -1, "Wedding Carriage", 1);// 63
			AddComplexComponent( (BaseAddon) this, 10722, 0, 2, 0, 1153, -1, "hitch", 1);// 64
			AddComplexComponent( (BaseAddon) this, 2000, -1, 1, 6, 1153, -1, "Wedding Carriage", 1);// 65
			AddComplexComponent( (BaseAddon) this, 11189, -1, 0, 27, 0, -1, "Wedding Carriage", 1);// 66
			AddComplexComponent( (BaseAddon) this, 2000, 1, -1, 6, 1153, -1, "Wedding Carriage", 1);// 67
			AddComplexComponent( (BaseAddon) this, 3203, 0, 0, 28, 0, -1, "Wedding Carriage", 1);// 68
			AddComplexComponent( (BaseAddon) this, 5534, -1, 0, 7, 1153, -1, "Wedding Carriage", 1);// 69
			AddComplexComponent( (BaseAddon) this, 11191, 1, 2, 7, 0, -1, "Wedding Carriage", 1);// 70
			AddComplexComponent( (BaseAddon) this, 11189, -1, -1, 27, 0, -1, "Wedding Carriage", 1);// 71
			AddComplexComponent( (BaseAddon) this, 1998, -1, -1, 6, 1153, -1, "Wedding Carriage", 1);// 72
			AddComplexComponent( (BaseAddon) this, 10723, -1, 2, 0, 1153, -1, "hitch", 1);// 73
			AddComplexComponent( (BaseAddon) this, 11132, 0, -2, 7, 0, -1, "Wedding Carriage", 1);// 74
			AddComplexComponent( (BaseAddon) this, 1999, 0, -1, 6, 1153, -1, "Wedding Carriage", 1);// 75
			AddComplexComponent( (BaseAddon) this, 1997, -1, 0, 6, 1153, -1, "Wedding Carriage", 1);// 76
			AddComplexComponent( (BaseAddon) this, 11193, 1, 0, 27, 0, -1, "Wedding Carriage", 1);// 77
			AddComplexComponent( (BaseAddon) this, 5535, 0, -1, 7, 0, -1, "Wedding Carriage", 1);// 78
			AddComplexComponent( (BaseAddon) this, 5799, 1, 1, 0, 1150, -1, "wagonwheel", 1);// 79
			AddComplexComponent( (BaseAddon) this, 11514, 2, 1, 9, 0, -1, "Wedding Carriage", 1);// 80
			AddComplexComponent( (BaseAddon) this, 1997, 0, 1, 6, 1153, -1, "Wedding Carriage", 1);// 81
			AddComplexComponent( (BaseAddon) this, 11193, -2, 1, 27, 0, -1, "Wedding Carriage", 1);// 82
			AddComplexComponent( (BaseAddon) this, 11193, 1, -1, 27, 0, -1, "Wedding Carriage", 1);// 83
			AddComplexComponent( (BaseAddon) this, 11194, -1, -2, 27, 0, -1, "Wedding Carriage", 1);// 84
			AddComplexComponent( (BaseAddon) this, 11194, 0, -2, 27, 0, -1, "Wedding Carriage", 1);// 85
			AddComplexComponent( (BaseAddon) this, 11194, 1, -2, 27, 0, -1, "Wedding Carriage", 1);// 86
			AddComplexComponent( (BaseAddon) this, 11194, -1, 1, 27, 0, -1, "Wedding Carriage", 1);// 87
			AddComplexComponent( (BaseAddon) this, 11194, 0, 1, 27, 0, -1, "Wedding Carriage", 1);// 88
			AddComplexComponent( (BaseAddon) this, 11194, 1, 1, 27, 0, -1, "Wedding Carriage", 1);// 89
			AddComplexComponent( (BaseAddon) this, 11184, -2, -2, 27, 0, -1, "Wedding Carriage", 1);// 90

		}

		public WeddingCarriageAddon( Serial serial ) : base( serial )
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

	public class WeddingCarriageAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new WeddingCarriageAddon();
			}
		}

		[Constructable]
		public WeddingCarriageAddonDeed()
		{
			Name = "WeddingCarriage";
		}

		public WeddingCarriageAddonDeed( Serial serial ) : base( serial )
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