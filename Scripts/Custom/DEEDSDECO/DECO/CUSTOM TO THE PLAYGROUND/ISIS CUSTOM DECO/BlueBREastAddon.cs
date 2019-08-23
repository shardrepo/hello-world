
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
	public class BlueBREastAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {4104, -1, 0, 11}, {3332, -1, -2, 17}// 21	24	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new BlueBREastAddonDeed();
			}
		}

		[ Constructable ]
		public BlueBREastAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 5170, -1, -1, 14, 201, 0, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 2669, -1, 3, 9, 1165, -1, "Towel", 1);// 2
			AddComplexComponent( (BaseAddon) this, 4979, -1, -1, 10, 1150, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 6420, -1, 3, 10, 201, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 2806, 0, -1, 5, 1153, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 16453, -1, 0, 12, 0, -1, "Mirror", 1);// 6
			AddComplexComponent( (BaseAddon) this, 3347, -1, -2, 19, 1153, -1, "mums", 1);// 7
			AddComplexComponent( (BaseAddon) this, 2669, -1, 3, 12, 1165, -1, "Towel", 1);// 8
			AddComplexComponent( (BaseAddon) this, 2806, 0, 1, 5, 1153, -1, "", 1);// 9
			AddComplexComponent( (BaseAddon) this, 2806, 0, 0, 5, 1153, -1, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 2669, -1, 3, 11, 1153, -1, "Towel", 1);// 11
			AddComplexComponent( (BaseAddon) this, 2755, 0, -2, 5, 1153, -1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 1801, -1, 0, 5, 201, -1, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 2756, 0, 2, 5, 1153, -1, "", 1);// 14
			AddComplexComponent( (BaseAddon) this, 9232, 0, 1, 0, 1150, -1, "Door", 1);// 15
			AddComplexComponent( (BaseAddon) this, 2815, -1, 3, 5, 1153, -1, "", 1);// 16
			AddComplexComponent( (BaseAddon) this, 4551, -1, -2, 14, 1150, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 1801, -1, -1, 5, 201, -1, "", 1);// 18
			AddComplexComponent( (BaseAddon) this, 2669, -1, 3, 10, 1153, -1, "Towel", 1);// 19
			AddComplexComponent( (BaseAddon) this, 11846, -1, 3, 9, 0, -1, "Stand", 1);// 20
			AddComplexComponent( (BaseAddon) this, 9232, 0, -1, 0, 1150, -1, "Door", 1);// 22
			AddComplexComponent( (BaseAddon) this, 9232, 0, 0, 0, 1150, -1, "Door", 1);// 23
			AddComplexComponent( (BaseAddon) this, 2813, -1, 3, 5, 1153, -1, "Stand", 1);// 25
			AddComplexComponent( (BaseAddon) this, 17076, -1, 1, 10, 0, -1, "Cologne", 1);// 26
			AddComplexComponent( (BaseAddon) this, 1801, -1, 1, 5, 201, -1, "", 1);// 27
			AddComplexComponent( (BaseAddon) this, 2809, 1, 2, 5, 1153, -1, "", 1);// 28
			AddComplexComponent( (BaseAddon) this, 2751, 1, 1, 5, 1165, -1, "", 1);// 29
			AddComplexComponent( (BaseAddon) this, 2751, 1, 0, 5, 1165, -1, "", 1);// 30
			AddComplexComponent( (BaseAddon) this, 2751, 1, -1, 5, 1165, -1, "", 1);// 31
			AddComplexComponent( (BaseAddon) this, 2807, 1, -2, 5, 1153, -1, "", 1);// 32
			AddComplexComponent( (BaseAddon) this, 2754, 2, 2, 5, 1153, -1, "", 1);// 33
			AddComplexComponent( (BaseAddon) this, 2808, 2, 1, 5, 1153, -1, "", 1);// 34
			AddComplexComponent( (BaseAddon) this, 2808, 2, 0, 5, 1153, -1, "", 1);// 35
			AddComplexComponent( (BaseAddon) this, 2808, 2, -1, 5, 1153, -1, "", 1);// 36
			AddComplexComponent( (BaseAddon) this, 2757, 2, -2, 5, 1153, -1, "", 1);// 37
			AddComplexComponent( (BaseAddon) this, 63, -2, 0, 8, 201, -1, "", 1);// 38
			AddComplexComponent( (BaseAddon) this, 63, -2, -1, 8, 201, -1, "", 1);// 39
			AddComplexComponent( (BaseAddon) this, 63, -2, 1, 8, 201, -1, "", 1);// 40

		}

		public BlueBREastAddon( Serial serial ) : base( serial )
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

	public class BlueBREastAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new BlueBREastAddon();
			}
		}

		[Constructable]
		public BlueBREastAddonDeed()
		{
			Name = "BlueBREast";
		}

		public BlueBREastAddonDeed( Serial serial ) : base( serial )
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