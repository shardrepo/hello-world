using System;
using Server;
using Server.Misc;

namespace Server.Items
{
	public class MagicTalisman : GoldRing
	{
		[Constructable]
		public MagicTalisman()
		{
			Name = "talisman";
			ItemID = 0x2F58;

			int trinket = Utility.RandomMinMax( 0, 41 );

			switch ( trinket ) 
			{
				case 0 :	Name = "talisman"; 						ItemID = 0x2F58; 		break;
				case 1 :	Name = "idol"; 							ItemID = 0x2F59; 		break;
				case 2 :	Name = "totem"; 						ItemID = 0x2F5A; 		break;
				case 3 :	Name = "symbol"; 						ItemID = 0x2F5B; 		break;
				case 4 : 											ItemID = 0x2C7E;				// Pouch
					switch ( Utility.RandomMinMax( 0, 2 ) ) 
					{
						case 0 : Name = "bag"; break;
						case 1 : Name = "pouch"; break;
						case 2 : Name = "sack"; break;
					}
					break;
				case 5 : 	Name = "ankh";							ItemID = 0x2C7F;		break;	// Ankh
				case 6 : 	Name = "censer";						ItemID = 0x2C80;		break;	// Censer
				case 7 : 	Name = "cube";							ItemID = 0x2C81;		break;	// Cube
				case 8 : 	Name = "lamp";							ItemID = 0x2C82;		break;	// Lamp
				case 9 : 											ItemID = 0x2C83;				// Chest
					switch ( Utility.RandomMinMax( 0, 3 ) ) 
					{
						case 0 : Name = "box"; break;
						case 1 : Name = "chest"; break;
						case 2 : Name = "casket"; break;
						case 3 : Name = "coffer"; break;
					}
					break;
				case 10 : 											ItemID = 0x2C84;				// Crystal Ball
					switch ( Utility.RandomMinMax( 0, 2 ) ) 
					{
						case 0 : Name = "ball"; break;
						case 1 : Name = "orb"; break;
						case 2 : Name = "sphere"; break;
					}
					break;
				case 11 : 	Name = "dice";							ItemID = 0x2C85;		break;	// Dice
				case 12 : 	Name = "eye";							ItemID = 0x2C86;		break;	// Eye
				case 13 : 											ItemID = 0x2C87;				// Emerald
					switch ( Utility.RandomMinMax( 0, 2 ) ) 
					{
						case 0 : Name = "gem"; break;
						case 1 : Name = "crystal"; break;
						case 2 : Name = "jewel"; break;
					}
					break;
				case 14 : 	Name = "unicorn horn";					ItemID = 0x2C88;		break;	// Unicorn Horn
				case 15 : 	Name = "rose";							ItemID = 0x2C89;		break;	// Rose
					switch ( Utility.RandomMinMax( 0, 1 ) ) 
					{
						case 0 : Name = "rose"; break;
						case 1 : Name = "flower"; break;
					}
					break;
				case 16 :											ItemID = 0x2C8A;				// Medal
					switch ( Utility.RandomMinMax( 0, 2 ) ) 
					{
						case 0 : Name = "medal"; break;
						case 1 : Name = "badge"; break;
						case 2 : Name = "medallion"; break;
					}
					break;
				case 17 :											ItemID = 0x2C8B;				// Mug
					switch ( Utility.RandomMinMax( 0, 2 ) ) 
					{
						case 0 : Name = "mug"; break;
						case 1 : Name = "tankard"; break;
						case 2 : Name = "stein"; break;
					}
					break;
				case 18 : 	Name = "mushroom";						ItemID = 0x2C8C;		break;	// Mushroom
				case 19 :											ItemID = 0x2C8D;				// Pearl
					switch ( Utility.RandomMinMax( 0, 3 ) ) 
					{
						case 0 : Name = "pearl"; break;
						case 1 : Name = "orb"; break;
						case 2 : Name = "stone"; break;
						case 3 : Name = "sphere"; break;
					}
					break;
				case 20 :											ItemID = 0x2C8E;				// Plant
					switch ( Utility.RandomMinMax( 0, 4 ) ) 
					{
						case 0 : Name = "plant"; break;
						case 1 : Name = "flower"; break;
						case 2 : Name = "weed"; break;
						case 3 : Name = "vine"; break;
						case 4 : Name = "herb"; break;
					}
					break;
				case 21 : 	Name = "tablet";						ItemID = 0x2C8F;		break;	// Tablet
				case 22 : 	Name = "flask";							ItemID = 0x2C90;		break;	// Bottle
				case 23 : 	Name = "rune";							ItemID = 0x2C91;		break;	// Rune
				case 24 : 	Name = "rune";							ItemID = 0x2C92;		break;	// Rune
				case 25 :											ItemID = 0x2C93;				// Scroll
					switch ( Utility.RandomMinMax( 0, 1 ) ) 
					{
						case 0 : Name = "scroll"; break;
						case 1 : Name = "parchment"; break;
					}
					break;
				case 26 :											ItemID = 0x2C94;				// Scroll
					switch ( Utility.RandomMinMax( 0, 1 ) ) 
					{
						case 0 : Name = "scroll"; break;
						case 1 : Name = "parchment"; break;
					}
					break;
				case 27 : 	Name = "skull";							ItemID = 0x2C95;		break;	// Skull
				case 28 : 											ItemID = 0x2C96;				// Stone
					switch ( Utility.RandomMinMax( 0, 1 ) ) 
					{
						case 0 : Name = "rock"; break;
						case 1 : Name = "stone"; break;
					}
					break;
				case 29 :											ItemID = 0x2C97;				// Urn
					switch ( Utility.RandomMinMax( 0, 4 ) ) 
					{
						case 0 : Name = "urn"; break;
						case 1 : Name = "vase"; break;
						case 2 : Name = "jar"; break;
						case 3 : Name = "pot"; break;
						case 4 : Name = "ewer"; break;
					}
					break;
				case 30 : 	Name = "vial";							ItemID = 0x2C98;		break;	// Vial
				case 31 : 	Name = "bone";							ItemID = 0x2C99;		break;	// Bone
				case 32 : 	Name = "eye";							ItemID = 0x2C9A;		break;	// Evil Eye
				case 33 :											ItemID = 0x2C9B;				// Frog
					switch ( Utility.RandomMinMax( 0, 1 ) ) 
					{
						case 0 : Name = "frog"; break;
						case 1 : Name = "toad"; break;
					}
					break;
				case 34 :											ItemID = 0x2C9C;				// Goblet
					switch ( Utility.RandomMinMax( 0, 3 ) ) 
					{
						case 0 : Name = "chalice"; break;
						case 1 : Name = "goblet"; break;
						case 2 : Name = "cup"; break;
						case 3 : Name = "grail"; break;
					}
					break;
				case 35 : 											ItemID = 0x2C9D;				// Ruby
					switch ( Utility.RandomMinMax( 0, 2 ) ) 
					{
						case 0 : Name = "gem"; break;
						case 1 : Name = "crystal"; break;
						case 2 : Name = "jewel"; break;
					}
					break;
				case 36 : 	Name = "skull";							ItemID = 0x2C9E;		break;	// Monster Skull
				case 37 : 																			// Book
					ItemID = Utility.RandomList( 0x27B5, 0x27B6, 0x27B7, 0x27B8, 0x27B9, 0x27BA, 0x27BB, 0x27BC, 0x27BD );
					Name = Server.Misc.RandomThings.GetRandomBookType(0);
					break;
				case 38 : 	Name = "doll";							ItemID = 0x2D81;		break;	// Doll
				case 39 :											ItemID = 0x2D7F;				// Hand or Claw
					switch ( Utility.RandomMinMax( 0, 1 ) ) 
					{
						case 0 : Name = "hand"; break;
						case 1 : Name = "claw"; break;
					}
					break;
				case 40 : 	Name = "heart";							ItemID = 0x2D7E;		break;	// Heart
				case 41 : 	Name = "foot";							ItemID = 0x2D80;		break;	// Rabbit's Foot
			}

			Resource = CraftResource.None;
			Layer = Layer.Talisman;
			Weight = 1.0;
			Hue = 0; if ( Utility.RandomMinMax( 0, 4 ) == 1 ){ Hue = RandomThings.GetRandomColor(0); }

			//Name = LootPackEntry.MagicItemAdj( "start", false, false, ItemID ) + " " + Name;
		}

        public override void AddNameProperties(ObjectPropertyList list)
		{
            base.AddNameProperties(list);
			list.Add( 1070722, "Trinket");
        }

		public override void OnDoubleClick( Mobile from )
		{
			from.SendMessage( "Trinkets are worn in the upper right slot." );
			return;
		}

		public MagicTalisman( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 1 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}