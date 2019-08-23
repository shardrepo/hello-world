using System;
using Server;

namespace Server.Items
{
	public class MidnightGloves : BoneGloves
	{
		public override int InitMinHits{ get{ return 80; } }
		public override int InitMaxHits{ get{ return 160; } }

		public override int LabelNumber{ get{ return 1061093; } } // Midnight Gloves

		public override int BasePhysicalResistance{ get{ return 19; } }

		[Constructable]
		public MidnightGloves()
		{
			Name = "Midnight Gloves";
			Hue = 0x455;
			SkillBonuses.SetValues( 0, SkillName.Necromancy, 5.0 );
			Attributes.SpellDamage = 10;
			ArmorAttributes.MageArmor = 1;
		}

        public override void AddNameProperties(ObjectPropertyList list)
		{
            base.AddNameProperties(list);
			list.Add( 1070722, "Artifact");
        }

		public MidnightGloves( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 1 );
		}
		
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();

			if ( version < 1 )
				PhysicalBonus = 0;
		}
	}
}