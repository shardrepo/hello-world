
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
	public class WagonJailAddon : BaseAddon
	{
         
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new WagonJailAddonDeed();
			}
		}

		[ Constructable ]
		public WagonJailAddon()
		{



			AddComplexComponent( (BaseAddon) this, 5799, 2, -3, 0, 0, -1, "wagon wheel", 1);// 1
			AddComplexComponent( (BaseAddon) this, 5799, 2, 2, 0, 0, -1, "wagon wheel", 1);// 2
			AddComplexComponent( (BaseAddon) this, 5794, -1, 2, 0, 0, -1, "Wagon", 1);// 3
			AddComplexComponent( (BaseAddon) this, 5794, -1, -3, 0, 0, -1, "Wagon", 1);// 4
			AddComplexComponent( (BaseAddon) this, 1997, -1, -3, 6, 0, -1, "Wagon", 1);// 5
			AddComplexComponent( (BaseAddon) this, 1997, 1, -2, 6, 0, -1, "Wagon", 1);// 6
			AddComplexComponent( (BaseAddon) this, 1997, 0, -1, 6, 0, -1, "Wagon", 1);// 7
			AddComplexComponent( (BaseAddon) this, 1997, 2, 2, 6, 0, -1, "Wagon", 1);// 8
			AddComplexComponent( (BaseAddon) this, 1998, 2, 1, 6, 0, -1, "Wagon", 1);// 9
			AddComplexComponent( (BaseAddon) this, 1998, 1, 0, 6, 0, -1, "Wagon", 1);// 10
			AddComplexComponent( (BaseAddon) this, 1998, 0, 0, 6, 0, -1, "Wagon", 1);// 11
			AddComplexComponent( (BaseAddon) this, 1998, 1, -3, 6, 0, -1, "Wagon", 1);// 12
			AddComplexComponent( (BaseAddon) this, 1998, -1, 2, 6, 0, -1, "Wagon", 1);// 13
			AddComplexComponent( (BaseAddon) this, 1999, 0, 2, 6, 0, -1, "Wagon", 1);// 14
			AddComplexComponent( (BaseAddon) this, 1999, 0, 1, 6, 0, -1, "Wagon", 1);// 15
			AddComplexComponent( (BaseAddon) this, 1999, 1, 1, 6, 0, -1, "Wagon", 1);// 16
			AddComplexComponent( (BaseAddon) this, 1999, 2, 0, 6, 0, -1, "Wagon", 1);// 17
			AddComplexComponent( (BaseAddon) this, 1999, 2, -2, 6, 0, -1, "Wagon", 1);// 18
			AddComplexComponent( (BaseAddon) this, 1999, -1, -2, 6, 0, -1, "Wagon", 1);// 19
			AddComplexComponent( (BaseAddon) this, 2000, -1, -1, 6, 0, -1, "Wagon", 1);// 20
			AddComplexComponent( (BaseAddon) this, 2000, 1, -1, 6, 0, -1, "Wagon", 1);// 21
			AddComplexComponent( (BaseAddon) this, 2000, 2, -1, 6, 0, -1, "Wagon", 1);// 22
			AddComplexComponent( (BaseAddon) this, 2000, 0, -3, 6, 0, -1, "Wagon", 1);// 23
			AddComplexComponent( (BaseAddon) this, 2000, 2, -3, 7, 0, -1, "Wagon", 1);// 24
			AddComplexComponent( (BaseAddon) this, 1997, 0, -2, 6, 0, -1, "Wagon", 1);// 25
			AddComplexComponent( (BaseAddon) this, 1997, -1, 1, 6, 0, -1, "Wagon", 1);// 26
			AddComplexComponent( (BaseAddon) this, 1998, -1, 0, 6, 0, -1, "Wagon", 1);// 27
			AddComplexComponent( (BaseAddon) this, 1999, -1, 3, 6, 0, -1, "Wagon", 1);// 28
			AddComplexComponent( (BaseAddon) this, 1998, 0, 3, 6, 0, -1, "Wagon", 1);// 29
			AddComplexComponent( (BaseAddon) this, 1997, 1, 2, 6, 0, -1, "Wagon", 1);// 30
			AddComplexComponent( (BaseAddon) this, 2000, 2, 3, 6, 0, -1, "Wagon", 1);// 31
			AddComplexComponent( (BaseAddon) this, 20793, -2, -3, 7, 0, -1, "Wagon", 1);// 32
			AddComplexComponent( (BaseAddon) this, 20793, -2, -2, 7, 0, -1, "Wagon", 1);// 33
			AddComplexComponent( (BaseAddon) this, 20793, -2, -1, 7, 0, -1, "Wagon", 1);// 34
			AddComplexComponent( (BaseAddon) this, 20793, -2, 0, 7, 0, -1, "Wagon", 1);// 35
			AddComplexComponent( (BaseAddon) this, 20793, -2, 1, 7, 0, -1, "Wagon", 1);// 36
			AddComplexComponent( (BaseAddon) this, 20793, -2, 2, 7, 0, -1, "Wagon", 1);// 37
			AddComplexComponent( (BaseAddon) this, 20779, -2, -4, 7, 0, -1, "Wagon", 1);// 38
			AddComplexComponent( (BaseAddon) this, 20788, -1, -4, 7, 0, -1, "Wagon", 1);// 39
			AddComplexComponent( (BaseAddon) this, 20788, 0, -4, 7, 0, -1, "Wagon", 1);// 40
			AddComplexComponent( (BaseAddon) this, 20788, 2, -4, 7, 0, -1, "Wagon", 1);// 41
			AddComplexComponent( (BaseAddon) this, 20788, -1, 2, 7, 0, -1, "Wagon", 1);// 42
			AddComplexComponent( (BaseAddon) this, 20788, 0, 2, 7, 0, -1, "Wagon", 1);// 43
			AddComplexComponent( (BaseAddon) this, 20788, 1, 2, 7, 0, -1, "Wagon", 1);// 44
			AddComplexComponent( (BaseAddon) this, 20788, 1, -4, 7, 0, -1, "Wagon", 1);// 45
			AddComplexComponent( (BaseAddon) this, 20793, 2, -3, 7, 0, -1, "Wagon", 1);// 46
			AddComplexComponent( (BaseAddon) this, 20793, 2, -2, 7, 0, -1, "Wagon", 1);// 47
			AddComplexComponent( (BaseAddon) this, 20793, 2, -1, 7, 0, -1, "Wagon", 1);// 48
			AddComplexComponent( (BaseAddon) this, 20793, 2, 1, 7, 0, -1, "Wagon", 1);// 49
			AddComplexComponent( (BaseAddon) this, 20780, 2, 2, 7, 0, -1, "Wagon", 1);// 50
			AddComplexComponent( (BaseAddon) this, 5741, -1, -3, 7, 0, -1, "Wagon", 1);// 51
			AddComplexComponent( (BaseAddon) this, 5741, -1, -1, 7, 0, -1, "Wagon", 1);// 52
			AddComplexComponent( (BaseAddon) this, 20776, 2, 0, 7, 0, -1, "Wagon", 1);// 53
			AddComplexComponent( (BaseAddon) this, 6663, -1, -2, 7, 0, -1, "Wagon", 1);// 54
			AddComplexComponent( (BaseAddon) this, 6663, -1, 0, 7, 0, -1, "Wagon", 1);// 55
			AddComplexComponent( (BaseAddon) this, 6663, -1, 2, 7, 0, -1, "Wagon", 1);// 56
			AddComplexComponent( (BaseAddon) this, 6663, -1, 1, 7, 0, -1, "Wagon", 1);// 57
			AddComplexComponent( (BaseAddon) this, 6664, -1, -3, 7, 0, -1, "Wagon", 1);// 58
			AddComplexComponent( (BaseAddon) this, 6664, 0, -3, 7, 0, -1, "Wagon", 1);// 59
			AddComplexComponent( (BaseAddon) this, 6664, 2, -3, 7, 0, -1, "Wagon", 1);// 60
			AddComplexComponent( (BaseAddon) this, 6664, 1, -3, 7, 0, -1, "Wagon", 1);// 61
			AddComplexComponent( (BaseAddon) this, 1999, 1, 3, 6, 0, -1, "Wagon", 1);// 62
			AddComplexComponent( (BaseAddon) this, 10723, 0, 3, 0, 0, -1, "Wagon", 1);// 63
			AddComplexComponent( (BaseAddon) this, 10723, -1, 3, 0, 0, -1, "Wagon", 1);// 64
			AddComplexComponent( (BaseAddon) this, 10723, 1, 3, 0, 0, -1, "Wagon", 1);// 65
			AddComplexComponent( (BaseAddon) this, 10722, 0, 3, 0, 0, -1, "wagon hitch", 1);// 66
			AddComplexComponent( (BaseAddon) this, 10722, 1, 3, 0, 0, -1, "wagon hitch", 1);// 67
			AddComplexComponent( (BaseAddon) this, 10723, 0, 4, 0, 0, -1, "wagon hitch", 1);// 68
			AddComplexComponent( (BaseAddon) this, 10723, 0, 5, 0, 0, -1, "wagon hitch", 1);// 69
			AddComplexComponent( (BaseAddon) this, 15871, -1, 3, 7, 0, -1, "wagon bench", 1);// 70
			AddComplexComponent( (BaseAddon) this, 15871, 0, 3, 7, 0, -1, "wagon bench", 1);// 71
			AddComplexComponent( (BaseAddon) this, 15871, 1, 3, 7, 0, -1, "wagon bench", 1);// 72
			AddComplexComponent( (BaseAddon) this, 15871, 2, 3, 7, 0, -1, "wagon bench", 1);// 73
			AddComplexComponent( (BaseAddon) this, 5562, -2, 4, 15, 2580, -1, "banner", 1);// 74
			AddComplexComponent( (BaseAddon) this, 11377, -2, -4, 26, 0, -1, "Wagon", 1);// 75
			AddComplexComponent( (BaseAddon) this, 11377, -2, -3, 26, 0, -1, "Wagon", 1);// 76
			AddComplexComponent( (BaseAddon) this, 11377, -2, -2, 26, 0, -1, "Wagon", 1);// 77
			AddComplexComponent( (BaseAddon) this, 11377, -2, -1, 26, 0, -1, "Wagon", 1);// 78
			AddComplexComponent( (BaseAddon) this, 11377, -2, 0, 26, 0, -1, "Wagon", 1);// 79
			AddComplexComponent( (BaseAddon) this, 11377, -2, 1, 26, 0, -1, "Wagon", 1);// 80
			AddComplexComponent( (BaseAddon) this, 11377, -2, 2, 26, 0, -1, "Wagon", 1);// 81
			AddComplexComponent( (BaseAddon) this, 11377, -2, 3, 26, 0, -1, "Wagon", 1);// 82
			AddComplexComponent( (BaseAddon) this, 11377, -1, -4, 29, 0, -1, "Wagon", 1);// 83
			AddComplexComponent( (BaseAddon) this, 11377, -1, -3, 30, 0, -1, "Wagon", 1);// 84
			AddComplexComponent( (BaseAddon) this, 11377, -1, -2, 29, 0, -1, "Wagon", 1);// 85
			AddComplexComponent( (BaseAddon) this, 11377, -1, -1, 29, 0, -1, "Wagon", 1);// 86
			AddComplexComponent( (BaseAddon) this, 11377, -1, 0, 29, 0, -1, "Wagon", 1);// 87
			AddComplexComponent( (BaseAddon) this, 11377, -1, 1, 29, 0, -1, "Wagon", 1);// 88
			AddComplexComponent( (BaseAddon) this, 11377, -1, 2, 29, 0, -1, "Wagon", 1);// 89
			AddComplexComponent( (BaseAddon) this, 11377, -1, 3, 29, 0, -1, "Wagon", 1);// 90
			AddComplexComponent( (BaseAddon) this, 11377, 0, -4, 32, 0, -1, "Wagon", 1);// 91
			AddComplexComponent( (BaseAddon) this, 11377, 0, -3, 32, 0, -1, "Wagon", 1);// 92
			AddComplexComponent( (BaseAddon) this, 11377, 0, -2, 32, 0, -1, "Wagon", 1);// 93
			AddComplexComponent( (BaseAddon) this, 11377, 0, -1, 33, 0, -1, "Wagon", 1);// 94
			AddComplexComponent( (BaseAddon) this, 11377, 0, 0, 32, 0, -1, "Wagon", 1);// 95
			AddComplexComponent( (BaseAddon) this, 11377, 0, 1, 32, 0, -1, "Wagon", 1);// 96
			AddComplexComponent( (BaseAddon) this, 11377, 0, 2, 32, 0, -1, "Wagon", 1);// 97
			AddComplexComponent( (BaseAddon) this, 11377, 0, 3, 32, 0, -1, "Wagon", 1);// 98
			AddComplexComponent( (BaseAddon) this, 11375, 1, -3, 35, 0, -1, "Wagon", 1);// 99
			AddComplexComponent( (BaseAddon) this, 11375, 1, -2, 35, 0, -1, "Wagon", 1);// 100
			AddComplexComponent( (BaseAddon) this, 11375, 1, -1, 35, 0, -1, "Wagon", 1);// 101
			AddComplexComponent( (BaseAddon) this, 11375, 1, 0, 35, 0, -1, "Wagon", 1);// 102
			AddComplexComponent( (BaseAddon) this, 11375, 1, 1, 35, 0, -1, "Wagon", 1);// 103
			AddComplexComponent( (BaseAddon) this, 11375, 1, 2, 35, 0, -1, "Wagon", 1);// 104
			AddComplexComponent( (BaseAddon) this, 11375, 1, 3, 35, 0, -1, "Wagon", 1);// 105
			AddComplexComponent( (BaseAddon) this, 11376, 2, -4, 32, 0, -1, "Wagon", 1);// 106
			AddComplexComponent( (BaseAddon) this, 11376, 2, -3, 32, 0, -1, "Wagon", 1);// 107
			AddComplexComponent( (BaseAddon) this, 11376, 2, -2, 32, 0, -1, "Wagon", 1);// 108
			AddComplexComponent( (BaseAddon) this, 11376, 2, -1, 32, 0, -1, "Wagon", 1);// 109
			AddComplexComponent( (BaseAddon) this, 11376, 2, 0, 32, 0, -1, "Wagon", 1);// 110
			AddComplexComponent( (BaseAddon) this, 11376, 2, 1, 32, 0, -1, "Wagon", 1);// 111
			AddComplexComponent( (BaseAddon) this, 11376, 2, 2, 32, 0, -1, "Wagon", 1);// 112
			AddComplexComponent( (BaseAddon) this, 11376, 2, 3, 32, 0, -1, "Wagon", 1);// 113
			AddComplexComponent( (BaseAddon) this, 11375, 1, -4, 35, 0, -1, "Wagon", 1);// 114
			AddComplexComponent( (BaseAddon) this, 10731, 2, 3, 7, 0, -1, "Wagon", 1);// 115
			AddComplexComponent( (BaseAddon) this, 10731, -2, 3, 7, 0, -1, "Wagon", 1);// 116
			AddComplexComponent( (BaseAddon) this, 10731, -2, 3, 20, 0, -1, "Wagon", 1);// 117
			AddComplexComponent( (BaseAddon) this, 10731, 2, 3, 19, 0, -1, "Wagon", 1);// 118
			AddComplexComponent( (BaseAddon) this, 10723, 2, 4, 26, 0, -1, "Wagon", 1);// 119
			AddComplexComponent( (BaseAddon) this, 2581, 2, 4, 18, 0, 0, "lantern", 1);// 120
			AddComplexComponent( (BaseAddon) this, 6663, 3, 1, 4, 0, -1, "Wagon", 1);// 121
			AddComplexComponent( (BaseAddon) this, 6663, 3, 2, 3, 0, -1, "Wagon", 1);// 122
			AddComplexComponent( (BaseAddon) this, 6663, 3, -2, 3, 0, -1, "Wagon", 1);// 123
			AddComplexComponent( (BaseAddon) this, 6663, 3, -1, 4, 0, -1, "Wagon", 1);// 124
			AddComplexComponent( (BaseAddon) this, 6663, 3, -3, 4, 0, -1, "Wagon", 1);// 125
			AddComplexComponent( (BaseAddon) this, 11376, 3, -4, 29, 0, -1, "Wagon", 1);// 126
			AddComplexComponent( (BaseAddon) this, 11376, 3, -3, 29, 0, -1, "Wagon", 1);// 127
			AddComplexComponent( (BaseAddon) this, 11376, 3, -2, 29, 0, -1, "Wagon", 1);// 128
			AddComplexComponent( (BaseAddon) this, 11376, 3, -1, 29, 0, -1, "Wagon", 1);// 129
			AddComplexComponent( (BaseAddon) this, 11376, 3, 0, 29, 0, -1, "Wagon", 1);// 130
			AddComplexComponent( (BaseAddon) this, 11376, 3, 1, 29, 0, -1, "Wagon", 1);// 131
			AddComplexComponent( (BaseAddon) this, 11376, 3, 2, 29, 0, -1, "Wagon", 1);// 132
			AddComplexComponent( (BaseAddon) this, 11376, 3, 3, 29, 0, -1, "Wagon", 1);// 133

		}

		public WagonJailAddon( Serial serial ) : base( serial )
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

	public class WagonJailAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new WagonJailAddon();
			}
		}

		[Constructable]
		public WagonJailAddonDeed()
		{
			Name = "WagonJail";
		}

		public WagonJailAddonDeed( Serial serial ) : base( serial )
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