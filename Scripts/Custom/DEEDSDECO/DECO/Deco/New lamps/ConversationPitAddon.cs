
////////////////////////////////////////
//                                    //
//   Generated by CEO's YAAAG - V1.2  //
// (Yet Another Arya Addon Generator) //
//                                    //
////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class ConversationPitAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {6809, -3, 3, 9}, {11599, 1, 2, 15}, {9246, -3, 3, 6}// 24	29	54	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new ConversationPitAddonDeed();
			}
		}

		[ Constructable ]
		public ConversationPitAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 2805, -1, 3, 2, 1117, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 2805, 1, 3, 2, 1117, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 2330, -2, -1, 15, 1150, -1, "lampshade", 1);// 3
			AddComplexComponent( (BaseAddon) this, 2796, -2, -1, 2, 1116, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 4632, -1, -1, 0, 1117, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 1848, 3, -1, 1, 1117, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 2796, -1, 1, 2, 1116, -1, "", 1);// 7
			AddComplexComponent( (BaseAddon) this, 7386, 0, 1, 10, 1150, -1, "frosted glass", 1);// 8
			AddComplexComponent( (BaseAddon) this, 7386, 1, 2, 10, 1150, -1, "frosted glass", 1);// 9
			AddComplexComponent( (BaseAddon) this, 1848, 3, 3, 1, 1117, -1, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 2721, -1, 1, 2, 0, -1, "table leg", 1);// 11
			AddComplexComponent( (BaseAddon) this, 1848, 3, 2, 1, 1117, -1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 1848, 3, 1, 1, 1117, -1, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 2796, -2, 3, 2, 1116, -1, "", 1);// 14
			AddComplexComponent( (BaseAddon) this, 1848, 3, 0, 1, 1117, -1, "", 1);// 15
			AddComplexComponent( (BaseAddon) this, 2796, -2, 1, 2, 1116, -1, "", 1);// 16
			AddComplexComponent( (BaseAddon) this, 2796, -2, 2, 2, 1116, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 2796, -2, 0, 2, 1116, -1, "", 1);// 18
			AddComplexComponent( (BaseAddon) this, 2796, -1, 0, 2, 1116, -1, "", 1);// 19
			AddComplexComponent( (BaseAddon) this, 1848, 2, 3, 1, 1117, -1, "", 1);// 20
			AddComplexComponent( (BaseAddon) this, 2796, -1, -1, 1, 1116, -1, "", 1);// 21
			AddComplexComponent( (BaseAddon) this, 1848, 1, -2, 1, 1117, -1, "", 1);// 22
			AddComplexComponent( (BaseAddon) this, 2720, 0, 2, 2, 0, -1, "table leg", 1);// 23
			AddComplexComponent( (BaseAddon) this, 7386, 1, 1, 10, 1150, -1, "frosted glass", 1);// 25
			AddComplexComponent( (BaseAddon) this, 1848, 0, -2, 1, 1117, -1, "", 1);// 26
			AddComplexComponent( (BaseAddon) this, 1848, 2, -1, 1, 1117, -1, "", 1);// 27
			AddComplexComponent( (BaseAddon) this, 2719, 1, 1, 2, 0, -1, "table  leg", 1);// 28
			AddComplexComponent( (BaseAddon) this, 1848, -1, -2, 1, 1117, -1, "", 1);// 30
			AddComplexComponent( (BaseAddon) this, 2840, 1, 2, 2, 0, -1, "table leg", 1);// 31
			AddComplexComponent( (BaseAddon) this, 1848, 2, -2, 1, 1117, -1, "", 1);// 32
			AddComplexComponent( (BaseAddon) this, 2796, 1, -1, 2, 1116, -1, "", 1);// 33
			AddComplexComponent( (BaseAddon) this, 2805, 0, 3, 2, 1117, -1, "", 1);// 34
			AddComplexComponent( (BaseAddon) this, 2796, 0, 2, 2, 1116, -1, "", 1);// 35
			AddComplexComponent( (BaseAddon) this, 2796, 0, 1, 2, 1116, -1, "", 1);// 36
			AddComplexComponent( (BaseAddon) this, 2796, 0, 0, 2, 1116, -1, "", 1);// 37
			AddComplexComponent( (BaseAddon) this, 2796, 0, -1, 2, 1116, -1, "", 1);// 38
			AddComplexComponent( (BaseAddon) this, 2724, 1, 0, 2, 0, -1, "table leg", 1);// 39
			AddComplexComponent( (BaseAddon) this, 11676, 3, -1, 14, 1150, -1, "", 1);// 40
			AddComplexComponent( (BaseAddon) this, 2796, -1, 2, 2, 1116, -1, "", 1);// 41
			AddComplexComponent( (BaseAddon) this, 2796, 2, 3, 2, 1116, -1, "", 1);// 42
			AddComplexComponent( (BaseAddon) this, 2796, 1, 0, 2, 1116, -1, "", 1);// 43
			AddComplexComponent( (BaseAddon) this, 2796, 2, 2, 2, 1116, -1, "", 1);// 44
			AddComplexComponent( (BaseAddon) this, 2725, -1, 2, 2, 0, -1, "table leg", 1);// 45
			AddComplexComponent( (BaseAddon) this, 2796, 2, 1, 2, 1116, -1, "", 1);// 46
			AddComplexComponent( (BaseAddon) this, 2796, 2, 0, 2, 1116, -1, "", 1);// 47
			AddComplexComponent( (BaseAddon) this, 1848, 3, -2, 1, 1117, -1, "", 1);// 48
			AddComplexComponent( (BaseAddon) this, 2796, 1, 2, 2, 1116, -1, "", 1);// 49
			AddComplexComponent( (BaseAddon) this, 2796, 1, 1, 2, 1116, -1, "", 1);// 50
			AddComplexComponent( (BaseAddon) this, 7386, 0, 2, 10, 1150, -1, "frosted glass", 1);// 51
			AddComplexComponent( (BaseAddon) this, 2723, -1, 0, 2, 0, -1, "table leg", 1);// 52
			AddComplexComponent( (BaseAddon) this, 2722, 0, 0, 2, 0, -1, "table leg", 1);// 53
			AddComplexComponent( (BaseAddon) this, 4635, 2, 1, 1, 1117, -1, "", 1);// 55
			AddComplexComponent( (BaseAddon) this, 4635, 2, 0, 1, 1117, -1, "", 1);// 56
			AddComplexComponent( (BaseAddon) this, 4632, 1, -1, 1, 1117, -1, "", 1);// 57
			AddComplexComponent( (BaseAddon) this, 4632, 0, -1, 1, 1117, -1, "", 1);// 58
			AddComplexComponent( (BaseAddon) this, 4633, -2, 2, 1, 1117, -1, "", 1);// 59
			AddComplexComponent( (BaseAddon) this, 2796, 2, -1, 2, 1116, -1, "", 1);// 60
			AddComplexComponent( (BaseAddon) this, 4633, -2, 1, 1, 1117, -1, "", 1);// 61
			AddComplexComponent( (BaseAddon) this, 4633, -2, 0, 1, 1117, -1, "", 1);// 62
			AddComplexComponent( (BaseAddon) this, 4635, 2, 2, 1, 1117, -1, "", 1);// 63
			AddComplexComponent( (BaseAddon) this, 2519, -2, -1, 9, 1150, -1, "lamp", 1);// 64
			AddComplexComponent( (BaseAddon) this, 1848, -2, 3, 2, 1117, -1, "", 1);// 65
			AddComplexComponent( (BaseAddon) this, 1848, -3, 3, 1, 1117, -1, "", 1);// 66
			AddComplexComponent( (BaseAddon) this, 1848, -3, 2, 1, 1117, -1, "", 1);// 67
			AddComplexComponent( (BaseAddon) this, 1848, -3, 1, 1, 1116, -1, "", 1);// 68
			AddComplexComponent( (BaseAddon) this, 1848, -3, 0, 1, 1117, -1, "", 1);// 69
			AddComplexComponent( (BaseAddon) this, 1848, -2, -1, 3, 1117, -1, "", 1);// 70
			AddComplexComponent( (BaseAddon) this, 1848, -3, -1, 1, 1117, -1, "", 1);// 71
			AddComplexComponent( (BaseAddon) this, 1848, -2, -2, 1, 1117, -1, "", 1);// 72
			AddComplexComponent( (BaseAddon) this, 1848, -3, -2, 1, 1117, -1, "", 1);// 73
			AddComplexComponent( (BaseAddon) this, 2594, -2, -1, 13, 0, 1, "lamp", 1);// 74
			AddComplexComponent( (BaseAddon) this, 2886, -2, -1, 11, 1150, -1, "lamp", 1);// 75

		}

		public ConversationPitAddon( Serial serial ) : base( serial )
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

	public class ConversationPitAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new ConversationPitAddon();
			}
		}

		[Constructable]
		public ConversationPitAddonDeed()
		{
			Name = "ConversationPit";
		}

		public ConversationPitAddonDeed( Serial serial ) : base( serial )
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