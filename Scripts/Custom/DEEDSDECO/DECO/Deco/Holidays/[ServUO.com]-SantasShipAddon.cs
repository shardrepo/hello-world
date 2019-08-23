
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
	public class SantasShipAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {19370, 1, -3, 19}, {6082, 2, -3, 20}, {6077, 2, -3, 19}// 4	5	18	
			, {6077, 1, -3, 19}, {6079, 0, -3, 19}, {6081, 0, -3, 19}// 19	20	21	
			, {6089, 1, -3, 19}, {6094, 0, -2, 22}, {6093, 1, 2, 4}// 22	32	33	
			, {6092, 0, 2, 4}, {6078, 2, 2, 4}, {6077, 0, 1, 4}// 37	38	39	
			, {9079, 2, 3, 3}, {6094, 3, 1, 2}, {6092, 0, 1, 4}// 41	47	48	
			, {6083, 2, -2, 20}, {6084, 0, -2, 19}, {6092, 0, 0, 4}// 50	51	52	
			, {6080, 1, 1, 4}, {6079, 2, 1, 4}, {6078, 2, 0, 4}// 53	54	58	
			, {6077, 1, 0, 4}, {6080, 0, 0, 4}, {19097, 2, -1, 3}// 59	60	63	
			, {6094, 2, -2, 21}, {6094, 1, 4, 2}, {6077, 2, -1, 4}// 64	65	86	
			, {6078, 1, -1, 4}, {6079, 0, -1, 4}, {6079, 1, 2, 4}// 87	88	89	
			, {6080, 0, 2, 4}, {6077, 0, 3, 4}, {6078, 1, 3, 4}// 90	91	92	
			, {6079, 2, 3, 4}, {6079, 2, -2, 19}, {6080, 1, -2, 19}// 93	94	95	
			, {6078, 0, -2, 19}, {6082, 2, -1, 4}, {6083, 2, 3, 4}// 96	97	98	
			, {6084, 0, 3, 4}, {6081, 0, -1, 4}, {6089, 1, -1, 4}// 99	100	101	
			, {6090, 2, 0, 4}, {6090, 2, 1, 4}, {6090, 2, 2, 4}// 102	103	104	
			, {6091, 1, 3, 4}, {6091, 1, -2, 19}, {6086, 1, 4, 7}// 105	106	118	
			, {6094, 1, 3, 7}, {6094, 1, 4, 5}// 119	120	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new SantasShipAddonDeed();
			}
		}

		[ Constructable ]
		public SantasShipAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 9005, 3, -3, 1, 1260, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 15, -1, -3, 0, 34, 1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 15, 2, -3, 0, 34, 1, "Santa's Ship", 1);// 3
			AddComplexComponent( (BaseAddon) this, 2254, 2, -4, 20, 1369, -1, "Santa's Ship", 1);// 6
			AddComplexComponent( (BaseAddon) this, 2254, 1, -4, 20, 1369, -1, "Santa's Ship", 1);// 7
			AddComplexComponent( (BaseAddon) this, 2252, 2, -3, 19, 1369, -1, "Santa's Ship", 1);// 8
			AddComplexComponent( (BaseAddon) this, 2252, -2, -4, 0, 1369, -1, "", 1);// 9
			AddComplexComponent( (BaseAddon) this, 2252, -1, -3, 20, 1369, -1, "Santa's Ship", 1);// 10
			AddComplexComponent( (BaseAddon) this, 2254, 0, -4, 20, 1369, -1, "Santa's Ship", 1);// 11
			AddComplexComponent( (BaseAddon) this, 14, 0, -4, 0, 34, 1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 14, 2, -4, 0, 34, 1, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 14, 1, -4, 0, 34, 1, "Santa's Ship", 1);// 14
			AddComplexComponent( (BaseAddon) this, 1173, 0, -3, 1, 1260, -1, "", 1);// 15
			AddComplexComponent( (BaseAddon) this, 1173, 1, -3, 1, 1260, -1, "", 1);// 16
			AddComplexComponent( (BaseAddon) this, 1173, 2, -3, 1, 1260, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 16010, 1, 3, 4, 1368, -1, "Santa's Ship", 1);// 23
			AddComplexComponent( (BaseAddon) this, 16010, 0, 3, 4, 1368, -1, "Santa's Ship", 1);// 24
			AddComplexComponent( (BaseAddon) this, 9004, 0, -1, 0, 1260, -1, "", 1);// 25
			AddComplexComponent( (BaseAddon) this, 18084, 0, -1, 4, 1172, -1, "", 1);// 26
			AddComplexComponent( (BaseAddon) this, 9002, 2, 0, 22, 1067, -1, "", 1);// 27
			AddComplexComponent( (BaseAddon) this, 18083, 0, 0, 4, 1172, -1, "", 1);// 28
			AddComplexComponent( (BaseAddon) this, 14983, 1, 0, 4, 0, -1, "Santa Sleigh", 1);// 29
			AddComplexComponent( (BaseAddon) this, 16049, 2, 2, 4, 1368, -1, "Santa's Ship", 1);// 30
			AddComplexComponent( (BaseAddon) this, 18085, 2, -2, 19, 2956, -1, "", 1);// 31
			AddComplexComponent( (BaseAddon) this, 21, 2, 0, 0, 33, -1, "Santa's Ship", 1);// 34
			AddComplexComponent( (BaseAddon) this, 15, -1, -2, 0, 34, 1, "Santa's Ship", 1);// 35
			AddComplexComponent( (BaseAddon) this, 15, 2, -2, 0, 34, 1, "Santa's Ship", 1);// 36
			AddComplexComponent( (BaseAddon) this, 14984, 1, -1, 4, 0, -1, "Santa Sleigh", 1);// 40
			AddComplexComponent( (BaseAddon) this, 16049, -1, 2, 5, 1368, -1, "Santa's Ship", 1);// 42
			AddComplexComponent( (BaseAddon) this, 9352, -1, 3, 5, 1368, -1, "", 1);// 43
			AddComplexComponent( (BaseAddon) this, 5357, 2, 0, 5, 0, -1, "Santa's List", 1);// 44
			AddComplexComponent( (BaseAddon) this, 16010, 2, 3, 4, 1368, -1, "", 1);// 45
			AddComplexComponent( (BaseAddon) this, 21, 2, 2, 0, 33, -1, "Santa's Ship", 1);// 46
			AddComplexComponent( (BaseAddon) this, 22, 0, 3, 0, 33, -1, "Santa's Ship", 1);// 49
			AddComplexComponent( (BaseAddon) this, 16064, 1, 4, 0, 37, -1, "Santa's Ship", 1);// 55
			AddComplexComponent( (BaseAddon) this, 16054, 0, 4, 0, 37, -1, "Santa's Ship", 1);// 56
			AddComplexComponent( (BaseAddon) this, 16052, 1, 5, 0, 37, -1, "Santa's Ship", 1);// 57
			AddComplexComponent( (BaseAddon) this, 9352, 2, 3, 4, 1368, -1, "", 1);// 61
			AddComplexComponent( (BaseAddon) this, 16049, 2, 3, 4, 1368, -1, "Santa's Ship", 1);// 62
			AddComplexComponent( (BaseAddon) this, 16053, 2, 4, 0, 37, -1, "Santa's Ship", 1);// 66
			AddComplexComponent( (BaseAddon) this, 22, 1, 3, 0, 33, -1, "Santa's Ship", 1);// 67
			AddComplexComponent( (BaseAddon) this, 20, 2, 3, 0, 33, -1, "Santa's Ship", 1);// 68
			AddComplexComponent( (BaseAddon) this, 2253, 2, -2, 19, 1369, -1, "Santa's Ship", 1);// 69
			AddComplexComponent( (BaseAddon) this, 2254, 0, -2, 19, 1369, -1, "Santa's Ship", 1);// 70
			AddComplexComponent( (BaseAddon) this, 2254, 1, -2, 19, 1369, -1, "Santa's Ship", 1);// 71
			AddComplexComponent( (BaseAddon) this, 2252, -1, -2, 20, 1369, -1, "Santa's Ship", 1);// 72
			AddComplexComponent( (BaseAddon) this, 21, -1, 3, 0, 33, -1, "Santa's Ship", 1);// 73
			AddComplexComponent( (BaseAddon) this, 21, -1, 2, 0, 33, -1, "Santa's Ship", 1);// 74
			AddComplexComponent( (BaseAddon) this, 21, -1, 1, 0, 33, -1, "Santa's Ship", 1);// 75
			AddComplexComponent( (BaseAddon) this, 21, -1, 0, 0, 33, -1, "Santa's Ship", 1);// 76
			AddComplexComponent( (BaseAddon) this, 21, -1, -1, 0, 33, -1, "", 1);// 77
			AddComplexComponent( (BaseAddon) this, 21, 2, -1, 0, 33, -1, "Santa's Ship", 1);// 78
			AddComplexComponent( (BaseAddon) this, 14, 1, -2, 0, 34, 1, "Santa's Ship", 1);// 79
			AddComplexComponent( (BaseAddon) this, 14, 0, -2, 0, 34, 1, "", 1);// 80
			AddComplexComponent( (BaseAddon) this, 1173, 0, -2, 1, 1260, -1, "", 1);// 81
			AddComplexComponent( (BaseAddon) this, 1173, 1, -2, 1, 1260, -1, "", 1);// 82
			AddComplexComponent( (BaseAddon) this, 1173, 2, -2, 1, 1260, -1, "", 1);// 83
			AddComplexComponent( (BaseAddon) this, 14951, 1, 1, 4, 0, -1, "Reindeer", 1);// 84
			AddComplexComponent( (BaseAddon) this, 14, 2, -2, 0, 34, 1, "Santa's Ship", 1);// 85
			AddComplexComponent( (BaseAddon) this, 16049, -1, -1, 5, 1368, -1, "Santa's Ship", 1);// 107
			AddComplexComponent( (BaseAddon) this, 16049, 2, 0, 4, 1368, -1, "Santa's Ship", 1);// 108
			AddComplexComponent( (BaseAddon) this, 16049, 2, -1, 4, 1368, -1, "Santa's Ship", 1);// 109
			AddComplexComponent( (BaseAddon) this, 14933, 1, 2, 4, 0, -1, "Reindeer", 1);// 110
			AddComplexComponent( (BaseAddon) this, 14951, 1, 3, 4, 0, -1, "Reindeer", 1);// 111
			AddComplexComponent( (BaseAddon) this, 16049, -1, 0, 5, 1368, -1, "Santa's Ship", 1);// 112
			AddComplexComponent( (BaseAddon) this, 16049, -1, 1, 5, 1368, -1, "Santa's Ship", 1);// 113
			AddComplexComponent( (BaseAddon) this, 9003, 0, -2, 19, 1096, -1, "", 1);// 114
			AddComplexComponent( (BaseAddon) this, 16049, -1, 3, 5, 1368, -1, "Santa's Ship", 1);// 115
			AddComplexComponent( (BaseAddon) this, 1827, 3, 1, 0, 1368, -1, "Santa's Ship", 1);// 116
			AddComplexComponent( (BaseAddon) this, 9002, 1, -2, 19, 1093, -1, "", 1);// 117

		}

		public SantasShipAddon( Serial serial ) : base( serial )
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

	public class SantasShipAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new SantasShipAddon();
			}
		}

		[Constructable]
		public SantasShipAddonDeed()
		{
			Name = "SantasShip";
		}

		public SantasShipAddonDeed( Serial serial ) : base( serial )
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