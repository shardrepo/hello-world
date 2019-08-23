
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
	public class BabyCarriageGirlAddon : BaseAddon
	{
         
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new BabyCarriageGirlAddonDeed();
			}
		}

		[ Constructable ]
		public BabyCarriageGirlAddon()
		{



			AddComplexComponent( (BaseAddon) this, 191, 0, -1, 5, 2631, -1, "Baby Carriage", 1);// 1
			AddComplexComponent( (BaseAddon) this, 1217, 0, 0, 5, 2631, -1, "Baby Carriage", 1);// 2
			AddComplexComponent( (BaseAddon) this, 6277, 0, 1, 3, 0, -1, "Baby Carriage", 1);// 3
			AddComplexComponent( (BaseAddon) this, 192, 0, 0, 11, 2631, -1, "Baby Carriage", 1);// 4
			AddComplexComponent( (BaseAddon) this, 1445, 0, 0, 10, 2631, -1, "Baby Carriage", 1);// 5
			AddComplexComponent( (BaseAddon) this, 189, 0, 0, 5, 2631, -1, "Baby Carriage", 1);// 6
			AddComplexComponent( (BaseAddon) this, 190, -1, 0, 5, 2631, -1, "Baby Carriage", 1);// 7
			AddComplexComponent( (BaseAddon) this, 6277, 1, 1, 4, 0, -1, "Baby Carriage", 1);// 8
			AddComplexComponent( (BaseAddon) this, 6791, 1, 0, 3, 2631, -1, "Baby Carriage", 1);// 9
			AddComplexComponent( (BaseAddon) this, 192, 0, -1, 10, 2631, -1, "Baby Carriage", 1);// 10
			AddComplexComponent( (BaseAddon) this, 6277, 0, 0, 3, 0, -1, "Baby Carriage", 1);// 11
			AddComplexComponent( (BaseAddon) this, 6277, 1, 0, 3, 0, -1, "Baby Carriage", 1);// 12
			AddComplexComponent( (BaseAddon) this, 5038, 0, 0, 9, 2631, -1, "Baby Carriage", 1);// 13
			AddComplexComponent( (BaseAddon) this, 5535, 0, 1, 0, 0, -1, "Baby Carriage", 1);// 14
			AddComplexComponent( (BaseAddon) this, 5535, 0, 0, 1, 0, -1, "Baby Carriage", 1);// 15
			AddComplexComponent( (BaseAddon) this, 5534, 1, 0, 1, 0, -1, "Baby Carriage", 1);// 16

		}

		public BabyCarriageGirlAddon( Serial serial ) : base( serial )
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

	public class BabyCarriageGirlAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new BabyCarriageGirlAddon();
			}
		}

		[Constructable]
		public BabyCarriageGirlAddonDeed()
		{
			Name = "BabyCarriageGirl";
		}

		public BabyCarriageGirlAddonDeed( Serial serial ) : base( serial )
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