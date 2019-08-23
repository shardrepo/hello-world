using System;
using Server;
using System.Collections;
using Server.Network;
using Server.Targeting;
using Server.Prompts;

namespace Server.Items
{
	public class DDRelicDrink : Item
	{
		public int RelicGoldValue;
		
		[CommandProperty(AccessLevel.Owner)]
		public int Relic_Value { get { return RelicGoldValue; } set { RelicGoldValue = value; InvalidateProperties(); } }

		[Constructable]
		public DDRelicDrink() : base( 0x9C7 )
		{
			string sType = " bottle of ";

			RelicGoldValue = Server.Misc.RelicItems.RelicValue();

			if ( Utility.RandomMinMax( 0, 4 ) == 1 )
			{
				Weight = 5;
				ItemID = Utility.RandomList( 0x9C7, 0x99B, 0x99F );
				Hue = Server.Misc.RandomThings.GetRandomColor(0);
				sType = " bottle of ";
			}
			else if ( Utility.RandomMinMax( 0, 2 ) == 1 )
			{
				Weight = 100;
				ItemID = 0xFAE;
				sType = " barrel of ";
			}
			else
			{
				Weight = 50;
				ItemID = Utility.RandomList( 0x1940, 0x1AD6, 0x1AD7 );
				Hue = 0x96D;
				sType = " keg of ";

			}

			string sLook = "a rare";
			switch ( Utility.RandomMinMax( 0, 18 ) )
			{
				case 0:	sLook = "a rare";	break;
				case 1:	sLook = "a nice";	break;
				case 2:	sLook = "a pretty";	break;
				case 3:	sLook = "a superb";	break;
				case 4:	sLook = "a delightful";	break;
				case 5:	sLook = "an elegant";	break;
				case 6:	sLook = "an exquisite";	break;
				case 7:	sLook = "a fine";	break;
				case 8:	sLook = "a gorgeous";	break;
				case 9:	sLook = "a lovely";	break;
				case 10:sLook = "a magnificent";	break;
				case 11:sLook = "a marvelous";	break;
				case 12:sLook = "a splendid";	break;
				case 13:sLook = "a wonderful";	break;
				case 14:sLook = "an extraordinary";	break;
				case 15:sLook = "a strange";	break;
				case 16:sLook = "an odd";	break;
				case 17:sLook = "a unique";	break;
				case 18:sLook = "an unusual";	break;
			}

			string sLiquid = "ale";
			switch ( Utility.RandomMinMax( 0, 7 ) ) 
			{
				case 0: sLiquid = "ale"; break;
				case 1: sLiquid = "wine"; break;
				case 2: sLiquid = "rum"; break;
				case 3: sLiquid = "beer"; break;
				case 4: sLiquid = "grog"; break;
				case 5: sLiquid = "brandy"; break;
				case 6: sLiquid = "whiskey"; break;
				case 7: sLiquid = "brandy"; break;
			}

			Name = sLook + sType + sLiquid;
		}

		public override void OnDoubleClick( Mobile from )
		{
			Target t;
			int number;

				// increase characters thirst value based on type of drink
				if ( from.Thirst < 20 )
				{
					// DJERYV DID THIS SO YOU GET A LITTLE EXTRA WHILE DRINKING
					int nEatStam = from.StamMax / 5;
					if ( from.Stam < from.StamMax )
						from.Stam += nEatStam;

					from.Thirst += 5;
					// Send message to character about their current thirst value
					int iThirst = from.Thirst;
					if ( iThirst < 5 )
						from.SendMessage( "You drink the water but are still extremely thirsty" );
					else if ( iThirst < 10 )
						from.SendMessage( "You drink the water and feel less thirsty" );
					else if ( iThirst < 15 )
						from.SendMessage( "You drink the water and feel much less thirsty" ); 
					else
						from.SendMessage( "You drink the water and are no longer thirsty" );

					this.Consume();
					from.PlaySound( Utility.RandomList( 0x30, 0x2D6 ) );
				}
				else
				{
					from.SendMessage( "You are simply too quenched to drink anymore" );
					from.Thirst = 20;
				}
		}

		public DDRelicDrink(Serial serial) : base(serial)
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
            writer.Write( (int) 0 ); // version
            writer.Write( RelicGoldValue );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
            int version = reader.ReadInt();
            RelicGoldValue = reader.ReadInt();
		}
	}
}