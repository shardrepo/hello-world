
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
	public class epicnictableAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {2911, -1, 2, 0}, {2913, -1, 1, 0}, {2913, -1, 0, 0}// 1	2	3	
			, {2912, -1, -1, 0}, {2934, 0, -1, 0}, {2933, 0, 2, 0}// 4	5	6	
			, {2938, 0, 1, 0}, {2938, 0, 0, 0}, {2911, 1, 2, 0}// 7	8	9	
			, {2912, 1, -1, 0}, {2913, 1, 1, 0}, {2913, 1, 0, 0}// 10	11	12	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new epicnictableAddonDeed();
			}
		}

		[ Constructable ]
		public epicnictableAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public epicnictableAddon( Serial serial ) : base( serial )
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

	public class epicnictableAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new epicnictableAddon();
			}
		}

		[Constructable]
		public epicnictableAddonDeed()
		{
			Name = "epicnictable";
		}

		public epicnictableAddonDeed( Serial serial ) : base( serial )
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