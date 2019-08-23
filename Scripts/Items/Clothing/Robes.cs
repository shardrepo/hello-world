using System;

namespace Server.Items
{
	[Flipable( 0x2B6B, 0x3162 )]
	public class JokerRobe : BaseOuterTorso
	{
		[Constructable]
		public JokerRobe() : this( 0 )
		{
		}

		[Constructable]
		public JokerRobe( int hue ) : base( 0x2B6B, hue )
		{
			Name = "jester coat";
			Weight = 3.0;
		}

		public JokerRobe( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	[Flipable( 0x2B69, 0x3160 )]
	public class AssassinRobe : BaseOuterTorso
	{
		[Constructable]
		public AssassinRobe() : this( 0 )
		{
		}

		[Constructable]
		public AssassinRobe( int hue ) : base( 0x2B69, hue )
		{
			Name = "assassin robe";
			Weight = 3.0;
			if ( Hue == 0 ){ Hue = 0x96B; }
		}

		public AssassinRobe( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	[Flipable( 0x201D, 0x201E )]
	public class VampireRobe : BaseOuterTorso
	{
		[Constructable]
		public VampireRobe() : this( 0 )
		{
		}

		[Constructable]
		public VampireRobe( int hue ) : base( 0x201D, hue )
		{
			Name = "vampire robe";
			Weight = 3.0;
		}

		public VampireRobe( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	[Flipable( 0x201B, 0x201C )]
	public class DragonRobe : BaseOuterTorso
	{
		[Constructable]
		public DragonRobe() : this( 0 )
		{
		}

		[Constructable]
		public DragonRobe( int hue ) : base( 0x201B, hue )
		{
			Name = "dragon robe";
			Weight = 3.0;
		}

		public DragonRobe( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	[Flipable( 0x201F, 0x2020 )]
	public class ChaosRobe : BaseOuterTorso
	{
		[Constructable]
		public ChaosRobe() : this( 0 )
		{
		}

		[Constructable]
		public ChaosRobe( int hue ) : base( 0x201F, hue )
		{
			Name = "chaos robe";
			Weight = 3.0;
		}

		public ChaosRobe( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	[Flipable( 0x2B6A, 0x3161 )]
	public class FancyRobe : BaseOuterTorso
	{
		[Constructable]
		public FancyRobe() : this( 0 )
		{
		}

		[Constructable]
		public FancyRobe( int hue ) : base( 0x2B6A, hue )
		{
			Name = "fancy robe";
			Weight = 3.0;
		}

		public FancyRobe( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	[Flipable( 0x2B6C, 0x3163 )]
	public class GildedRobe : BaseOuterTorso
	{
		[Constructable]
		public GildedRobe() : this( 0 )
		{
		}

		[Constructable]
		public GildedRobe( int hue ) : base( 0x2B6C, hue )
		{
			Name = "gilded robe";
			Weight = 3.0;
			if ( Hue == 0 ){ Hue = 0x967; }
		}

		public GildedRobe( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	[Flipable( 0x2B6E, 0x3165 )]
	public class OrnateRobe : BaseOuterTorso
	{
		[Constructable]
		public OrnateRobe() : this( 0 )
		{
		}

		[Constructable]
		public OrnateRobe( int hue ) : base( 0x2B6E, hue )
		{
			Name = "ornate robe";
			Weight = 3.0;
		}

		public OrnateRobe( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	[Flipable( 0x2B70, 0x3167 )]
	public class MagistrateRobe : BaseOuterTorso
	{
		[Constructable]
		public MagistrateRobe() : this( 0 )
		{
		}

		[Constructable]
		public MagistrateRobe( int hue ) : base( 0x2B70, hue )
		{
			Name = "magistrate robe";
			Weight = 3.0;
			if ( Hue == 0 ){ Hue = 0xA4B; }
		}

		public MagistrateRobe( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	[Flipable( 0x2B73, 0x316A )]
	public class RoyalRobe : BaseOuterTorso
	{
		[Constructable]
		public RoyalRobe() : this( 0 )
		{
		}

		[Constructable]
		public RoyalRobe( int hue ) : base( 0x2B73, hue )
		{
			Name = "royal robe";
			Weight = 3.0;
		}

		public RoyalRobe( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	[Flipable( 0x3175, 0x3178 )]
	public class SorcererRobe : BaseOuterTorso
	{
		[Constructable]
		public SorcererRobe() : this( 0 )
		{
		}

		[Constructable]
		public SorcererRobe( int hue ) : base( 0x3175, hue )
		{
			Name = "sorcerer robe";
			Weight = 3.0;
		}

		public SorcererRobe( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	[Flipable( 0x2FB9, 0x3173 )]
	public class AssassinShroud : BaseOuterTorso
	{
		[Constructable]
		public AssassinShroud() : this( 0 )
		{
		}

		[Constructable]
		public AssassinShroud( int hue ) : base( 0x2FB9, hue )
		{
			Name = "assassin shroud";
			Weight = 3.0;
			if ( Hue == 0 ){ Hue = 0x96B; }
		}

		public AssassinShroud( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	[Flipable( 0x2FBA, 0x3174 )]
	public class NecromancerRobe : BaseOuterTorso
	{
		[Constructable]
		public NecromancerRobe() : this( 0 )
		{
		}

		[Constructable]
		public NecromancerRobe( int hue ) : base( 0x2FBA, hue )
		{
			Name = "necromancer robe";
			Weight = 3.0;
		}

		public NecromancerRobe( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	[Flipable( 0x2FC6, 0x2FC7 )]
	public class SpiderRobe : BaseOuterTorso
	{
		[Constructable]
		public SpiderRobe() : this( 0 )
		{
		}

		[Constructable]
		public SpiderRobe( int hue ) : base( 0x2FC6, hue )
		{
			Name = "spider robe";
			Weight = 3.0;
			if ( Hue == 0 ){ Hue = 0x96B; }
		}

		public SpiderRobe( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}