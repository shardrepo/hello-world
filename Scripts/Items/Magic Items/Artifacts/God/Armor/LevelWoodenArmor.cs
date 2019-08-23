using System;
using Server;
using Server.Misc;

namespace Server.Items
{
	[FlipableAttribute( 0x1411, 0x141a )]
	public class LevelWoodenPlateLegs : BaseLevelArmor ///////////////////////////////////////////////////////
	{
		public override int BasePhysicalResistance{ get{ return 5; } }
		public override int BaseFireResistance{ get{ return 1; } }
		public override int BaseColdResistance{ get{ return 2; } }
		public override int BasePoisonResistance{ get{ return 3; } }
		public override int BaseEnergyResistance{ get{ return 4; } }

		public override int InitMinHits{ get{ return 50; } }
		public override int InitMaxHits{ get{ return 65; } }

		public override int AosStrReq{ get{ return 70; } }

		public override int OldStrReq{ get{ return 60; } }
		public override int OldDexBonus{ get{ return -6; } }

		public override int ArmorBase{ get{ return 35; } }

		public override ArmorMaterialType MaterialType{ get{ return ArmorMaterialType.Plate; } }
		public override CraftResource DefaultResource{ get{ return CraftResource.RegularWood; } }

		[Constructable]
		public LevelWoodenPlateLegs() : base( 0x1411 )
		{
			Name = "Wooden Leggings";
			Hue = 0x840;
			Weight = 5.0;
		}

		public LevelWoodenPlateLegs( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}
		
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
	[FlipableAttribute( 0x1414, 0x1418 )]
	public class LevelWoodenPlateGloves : BaseLevelArmor ///////////////////////////////////////////////////
	{
		public override int Hue{ get { return 0x840; } }

		public override int BasePhysicalResistance{ get{ return 5; } }
		public override int BaseFireResistance{ get{ return 1; } }
		public override int BaseColdResistance{ get{ return 2; } }
		public override int BasePoisonResistance{ get{ return 3; } }
		public override int BaseEnergyResistance{ get{ return 4; } }

		public override int InitMinHits{ get{ return 50; } }
		public override int InitMaxHits{ get{ return 65; } }

		public override int AosStrReq{ get{ return 50; } }
		public override int OldStrReq{ get{ return 30; } }

		public override int OldDexBonus{ get{ return -2; } }

		public override int ArmorBase{ get{ return 30; } }

		public override ArmorMaterialType MaterialType{ get{ return ArmorMaterialType.Plate; } }
		public override CraftResource DefaultResource{ get{ return CraftResource.RegularWood; } }

		[Constructable]
		public LevelWoodenPlateGloves() : base( 0x1414 )
		{
			Name = "Wooden Gauntlets";
			Hue = 0x840;
			Weight = 1.0;
		}

		public LevelWoodenPlateGloves( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}
		
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
	public class LevelWoodenPlateGorget : BaseLevelArmor ///////////////////////////////////////////////////
	{
		public override int Hue{ get { return 0x840; } }

		public override int BasePhysicalResistance{ get{ return 5; } }
		public override int BaseFireResistance{ get{ return 1; } }
		public override int BaseColdResistance{ get{ return 2; } }
		public override int BasePoisonResistance{ get{ return 3; } }
		public override int BaseEnergyResistance{ get{ return 4; } }

		public override int InitMinHits{ get{ return 50; } }
		public override int InitMaxHits{ get{ return 65; } }

		public override int AosStrReq{ get{ return 25; } }
		public override int OldStrReq{ get{ return 30; } }

		public override int OldDexBonus{ get{ return -1; } }

		public override int ArmorBase{ get{ return 30; } }

		public override ArmorMaterialType MaterialType{ get{ return ArmorMaterialType.Plate; } }
		public override CraftResource DefaultResource{ get{ return CraftResource.RegularWood; } }

		[Constructable]
		public LevelWoodenPlateGorget() : base( 0x1413 )
		{
			Name = "Wooden Gorget";
			Hue = 0x840;
			Weight = 1.0;
		}

		public LevelWoodenPlateGorget( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}
		
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
	[FlipableAttribute( 0x1410, 0x1417 )]
	public class LevelWoodenPlateArms : BaseLevelArmor ///////////////////////////////////////////////////////
	{
		public override int Hue{ get { return 0x840; } }

		public override int BasePhysicalResistance{ get{ return 5; } }
		public override int BaseFireResistance{ get{ return 1; } }
		public override int BaseColdResistance{ get{ return 2; } }
		public override int BasePoisonResistance{ get{ return 3; } }
		public override int BaseEnergyResistance{ get{ return 4; } }

		public override int InitMinHits{ get{ return 50; } }
		public override int InitMaxHits{ get{ return 65; } }

		public override int AosStrReq{ get{ return 60; } }
		public override int OldStrReq{ get{ return 40; } }

		public override int OldDexBonus{ get{ return -2; } }

		public override int ArmorBase{ get{ return 30; } }

		public override ArmorMaterialType MaterialType{ get{ return ArmorMaterialType.Plate; } }
		public override CraftResource DefaultResource{ get{ return CraftResource.RegularWood; } }

		[Constructable]
		public LevelWoodenPlateArms() : base( 0x1410 )
		{
			Name = "Wooden Arms";
			Hue = 0x840;
			Weight = 8.0;
		}

		public LevelWoodenPlateArms( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}
		
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
	[FlipableAttribute( 0x1415, 0x1416 )]
	public class LevelWoodenPlateChest : BaseLevelArmor /////////////////////////////////////////////////////
	{
		public override int Hue{ get { return 0x840; } }

		public override int BasePhysicalResistance{ get{ return 5; } }
		public override int BaseFireResistance{ get{ return 1; } }
		public override int BaseColdResistance{ get{ return 2; } }
		public override int BasePoisonResistance{ get{ return 3; } }
		public override int BaseEnergyResistance{ get{ return 4; } }

		public override int InitMinHits{ get{ return 50; } }
		public override int InitMaxHits{ get{ return 65; } }

		public override int AosStrReq{ get{ return 75; } }
		public override int OldStrReq{ get{ return 60; } }

		public override int OldDexBonus{ get{ return -8; } }

		public override int ArmorBase{ get{ return 30; } }

		public override ArmorMaterialType MaterialType{ get{ return ArmorMaterialType.Plate; } }
		public override CraftResource DefaultResource{ get{ return CraftResource.RegularWood; } }

		[Constructable]
		public LevelWoodenPlateChest() : base( 0x1415 )
		{
			Name = "Wooden Tunic";
			Hue = 0x840;
			Weight = 8.0;
		}

		public LevelWoodenPlateChest( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}
		
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
	public class LevelWoodenPlateHelm : BaseLevelArmor ///////////////////////////////////////////////////////
	{
		public override int Hue{ get { return 0x840; } }

		public override int BasePhysicalResistance{ get{ return 5; } }
		public override int BaseFireResistance{ get{ return 1; } }
		public override int BaseColdResistance{ get{ return 2; } }
		public override int BasePoisonResistance{ get{ return 3; } }
		public override int BaseEnergyResistance{ get{ return 4; } }

		public override int InitMinHits{ get{ return 50; } }
		public override int InitMaxHits{ get{ return 65; } }

		public override int AosStrReq{ get{ return 60; } }
		public override int OldStrReq{ get{ return 40; } }

		public override int OldDexBonus{ get{ return -1; } }

		public override int ArmorBase{ get{ return 30; } }

		public override ArmorMaterialType MaterialType{ get{ return ArmorMaterialType.Plate; } }
		public override CraftResource DefaultResource{ get{ return CraftResource.RegularWood; } }

		[Constructable]
		public LevelWoodenPlateHelm() : base( 0x1412 )
		{
			Name = "Wooden Helm";
			Hue = 0x840;
			Weight = 1.0;
		}

		public LevelWoodenPlateHelm( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}
		
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}