
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
	public class PinkBRSouthAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {3332, -2, 0, 15}, {16452, 0, -1, 10}, {4104, 0, -1, 10}// 9	18	19	
			, {11846, 3, -1, 9}// 22	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new PinkBRSouthAddonDeed();
			}
		}

		[ Constructable ]
		public PinkBRSouthAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 5170, -1, -1, 14, 1166, 0, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 2808, 2, 1, 5, 1153, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 2669, 3, -1, 11, 1150, -1, "Towel", 1);// 3
			AddComplexComponent( (BaseAddon) this, 62, 0, -2, 8, 1153, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 62, -1, -2, 8, 1153, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 2756, -2, 2, 5, 1153, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 17076, 1, -1, 10, 0, -1, "Perfume", 1);// 7
			AddComplexComponent( (BaseAddon) this, 62, 1, -2, 8, 1153, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 4551, -2, 0, 12, 1150, -1, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 3347, -2, 0, 17, 41, -1, "mums", 1);// 11
			AddComplexComponent( (BaseAddon) this, 2669, 3, -1, 12, 1166, -1, "Towel", 1);// 12
			AddComplexComponent( (BaseAddon) this, 2807, -1, 0, 5, 1153, -1, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 1801, 0, -1, 5, 1166, -1, "", 1);// 14
			AddComplexComponent( (BaseAddon) this, 2755, -2, 0, 5, 1153, -1, "", 1);// 15
			AddComplexComponent( (BaseAddon) this, 2807, 0, 0, 5, 1153, -1, "", 1);// 16
			AddComplexComponent( (BaseAddon) this, 2751, 1, 1, 5, 1166, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 9231, 1, 0, 0, 1150, -1, "door", 1);// 20
			AddComplexComponent( (BaseAddon) this, 2757, 2, 0, 5, 1153, -1, "", 1);// 21
			AddComplexComponent( (BaseAddon) this, 2751, -1, 1, 5, 1166, -1, "", 1);// 23
			AddComplexComponent( (BaseAddon) this, 2751, 0, 1, 5, 1166, -1, "", 1);// 24
			AddComplexComponent( (BaseAddon) this, 2806, -2, 1, 5, 1153, -1, "", 1);// 25
			AddComplexComponent( (BaseAddon) this, 9231, 0, 0, 0, 1150, -1, "door", 1);// 26
			AddComplexComponent( (BaseAddon) this, 1801, -1, -1, 5, 1166, -1, "", 1);// 27
			AddComplexComponent( (BaseAddon) this, 2754, 2, 2, 5, 1153, -1, "", 1);// 28
			AddComplexComponent( (BaseAddon) this, 4978, -1, -1, 10, 1150, -1, "", 1);// 29
			AddComplexComponent( (BaseAddon) this, 9231, -1, 0, 0, 1150, -1, "door", 1);// 30
			AddComplexComponent( (BaseAddon) this, 2815, 3, -1, 5, 1153, -1, "stand", 1);// 31
			AddComplexComponent( (BaseAddon) this, 2669, 3, -1, 10, 1150, -1, "Towel", 1);// 32
			AddComplexComponent( (BaseAddon) this, 2813, 3, -1, 5, 1153, -1, "stand", 1);// 33
			AddComplexComponent( (BaseAddon) this, 2809, -1, 2, 5, 1153, -1, "", 1);// 34
			AddComplexComponent( (BaseAddon) this, 2807, 1, 0, 5, 1153, -1, "", 1);// 35
			AddComplexComponent( (BaseAddon) this, 2809, 1, 2, 5, 1153, -1, "", 1);// 36
			AddComplexComponent( (BaseAddon) this, 2809, 0, 2, 5, 1153, -1, "", 1);// 37
			AddComplexComponent( (BaseAddon) this, 1801, 1, -1, 5, 1166, -1, "", 1);// 38
			AddComplexComponent( (BaseAddon) this, 2669, 3, -1, 9, 1166, -1, "Towel", 1);// 39

		}

		public PinkBRSouthAddon( Serial serial ) : base( serial )
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

	public class PinkBRSouthAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new PinkBRSouthAddon();
			}
		}

		[Constructable]
		public PinkBRSouthAddonDeed()
		{
			Name = "PinkBRSouth";
		}

		public PinkBRSouthAddonDeed( Serial serial ) : base( serial )
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