
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

namespace Gazeebo
{
	public class GazeeboAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {1848, -2, -2, 0}, {1848, -2, -1, 0}, {1848, -2, 0, 0}// 1	2	3	
			, {1848, -2, 1, 0}, {1848, -2, 2, 0}, {1848, -2, 3, 0}// 4	5	6	
			, {1190, -2, -2, 5}, {1190, -2, 3, 5}, {1190, -2, 1, 5}// 7	8	9	
			, {1190, -2, -1, 5}, {1190, -2, 0, 5}, {1190, -2, 2, 5}// 10	11	12	
			, {9, -3, -3, 5}, {9, -3, 3, 5}, {9163, -2, 4, 25}// 13	14	15	
			, {9167, -2, -2, 25}, {9157, -2, -1, 25}, {9157, -2, 0, 25}// 16	17	18	
			, {9157, -2, 1, 25}, {9157, -2, 2, 25}, {9157, -2, 3, 25}// 19	20	21	
			, {1848, -1, -2, 0}, {1848, -1, -1, 0}, {1848, -1, 0, 0}// 22	23	24	
			, {1848, -1, 1, 0}, {1848, -1, 2, 0}, {1848, 0, -2, 0}// 25	26	27	
			, {1848, 0, -1, 0}, {1848, 0, 0, 0}, {1848, 0, 1, 0}// 28	29	30	
			, {1848, 0, 2, 0}, {1848, 1, -2, 0}, {1848, 1, -1, 0}// 31	32	33	
			, {1848, 1, 0, 0}, {1848, 1, 1, 0}, {1848, 1, 2, 0}// 34	35	36	
			, {1848, 2, -2, 0}, {1848, 2, -1, 0}, {1848, 2, 0, 0}// 37	38	39	
			, {1848, 2, 1, 0}, {1848, 2, 2, 0}, {1848, 3, -2, 0}// 40	41	42	
			, {1848, 3, -1, 0}, {1848, 3, 0, 0}, {1848, 3, 1, 0}// 43	44	45	
			, {1848, 3, 2, 0}, {1848, -1, 3, 0}, {1848, 0, 3, 0}// 46	47	48	
			, {1848, 1, 3, 0}, {1848, 2, 3, 0}, {1848, 3, 3, 0}// 49	50	51	
			, {1850, 4, 0, 0}, {1850, 4, 1, 0}, {1190, -1, -2, 5}// 52	53	54	
			, {1190, 0, -2, 5}, {1190, 1, -2, 5}, {1190, 2, -2, 5}// 55	56	57	
			, {1190, 3, -2, 5}, {1190, 3, -1, 5}, {1190, 3, 0, 5}// 58	59	60	
			, {1190, 3, 1, 5}, {1190, 3, 2, 5}, {1190, 3, 3, 5}// 61	62	63	
			, {1190, 2, 3, 5}, {1190, 1, 3, 5}, {1190, 0, 3, 5}// 64	65	66	
			, {1190, -1, 3, 5}, {1190, -1, 2, 5}, {1190, -1, 1, 5}// 67	68	69	
			, {1190, -1, 0, 5}, {1190, -1, -1, 5}, {1190, 0, -1, 5}// 70	71	72	
			, {1190, 1, -1, 5}, {1190, 2, -1, 5}, {1190, 2, 0, 5}// 73	74	75	
			, {1190, 1, 0, 5}, {1190, 0, 0, 5}, {1190, 0, 2, 5}// 76	77	78	
			, {1190, 0, 1, 5}, {1190, 1, 2, 5}, {1190, 1, 1, 5}// 79	80	81	
			, {1190, 2, 2, 5}, {1190, 2, 1, 5}, {9, 3, 3, 5}// 82	83	84	
			, {9, 3, -3, 5}, {9155, 4, 3, 25}, {9161, 4, 4, 25}// 85	86	87	
			, {9155, 4, -1, 25}, {9155, 4, 0, 25}, {9155, 4, 1, 25}// 88	89	90	
			, {9155, 4, 2, 25}, {9155, 4, 3, 25}, {9153, -1, 4, 25}// 91	92	93	
			, {9153, 0, 4, 25}, {9153, 1, 4, 25}, {9153, 2, 4, 25}// 94	95	96	
			, {9153, 3, 4, 25}, {9165, 4, -2, 25}, {9159, -1, -2, 25}// 97	98	99	
			, {9159, 0, -2, 25}, {9159, 1, -2, 25}, {9159, 2, -2, 25}// 100	101	102	
			, {9159, 3, -2, 25}, {9161, 3, 3, 28}, {9163, -1, 3, 28}// 103	104	105	
			, {9165, 3, -1, 28}, {9167, -1, -1, 28}, {9159, 0, -1, 29}// 106	107	108	
			, {9159, 1, -1, 29}, {9159, 2, -1, 29}, {9153, 0, 3, 28}// 109	110	111	
			, {9153, 1, 3, 28}, {9153, 2, 3, 28}, {9155, 3, 0, 28}// 112	113	114	
			, {9155, 3, 1, 28}, {9155, 3, 2, 28}, {9157, -1, 0, 28}// 115	116	117	
			, {9157, -1, 1, 28}, {9157, -1, 2, 28}, {9161, 2, 2, 31}// 118	119	120	
			, {9163, 0, 2, 31}, {9165, 2, 0, 31}, {9167, 0, 0, 31}// 121	122	123	
			, {9159, 1, 0, 32}, {9157, 0, 1, 31}, {9153, 1, 2, 31}// 124	125	126	
			, {9155, 2, 1, 31}, {9151, 1, 1, 34}, {3203, 4, -2, 0}// 127	128	129	
			, {3203, 4, -1, 0}, {3203, 4, 2, 0}, {3203, 4, 3, 0}// 130	131	132	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new GazeeboAddonDeed();
			}
		}

		[ Constructable ]
		public GazeeboAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public GazeeboAddon( Serial serial ) : base( serial )
		{
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

	public class GazeeboAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new GazeeboAddon();
			}
		}

		[Constructable]
		public GazeeboAddonDeed()
		{
			Name = "Gazeebo";
		}

		public GazeeboAddonDeed( Serial serial ) : base( serial )
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