using System;
using Server;
using Server.Items;

namespace Server.Mobiles
{
	[CorpseName( "a ghostly corpse" )]
	public class DragonGhost : BaseCreature
	{
		public override int BreathPhysicalDamage{ get{ return 20; } }
		public override int BreathFireDamage{ get{ return 20; } }
		public override int BreathColdDamage{ get{ return 20; } }
		public override int BreathPoisonDamage{ get{ return 20; } }
		public override int BreathEnergyDamage{ get{ return 20; } }
		public override int BreathEffectHue{ get{ return 0x9C1; } }
		public override int BreathEffectSound{ get{ return 0x653; } }
		public override int BreathEffectItemID{ get{ return 0x37BC; } }
		public override bool ReacquireOnMovement{ get{ return !Controlled; } }
		public override bool HasBreath{ get{ return true; } }
		public override double BreathEffectDelay{ get{ return 0.1; } }
		public override void BreathDealDamage( Mobile target, int form ){ base.BreathDealDamage( target, 25 ); }

		[Constructable]
		public DragonGhost () : base( AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = "a ghostly dragon";
			Body = 139;
			BaseSoundID = 362;
			Hue = 0x9C2;

			SetStr( 796, 825 );
			SetDex( 86, 105 );
			SetInt( 436, 475 );

			SetHits( 478, 495 );

			SetDamage( 16, 22 );

			SetDamageType( ResistanceType.Physical, 75 );
			SetDamageType( ResistanceType.Poison, 25 );

			SetResistance( ResistanceType.Physical, 55, 65 );
			SetResistance( ResistanceType.Fire, 60, 70 );
			SetResistance( ResistanceType.Cold, 30, 40 );
			SetResistance( ResistanceType.Poison, 25, 35 );
			SetResistance( ResistanceType.Energy, 35, 45 );

			SetSkill( SkillName.Poisoning, 90.1, 100.0 );
			SetSkill( SkillName.EvalInt, 30.1, 40.0 );
			SetSkill( SkillName.Magery, 30.1, 40.0 );
			SetSkill( SkillName.MagicResist, 99.1, 100.0 );
			SetSkill( SkillName.Tactics, 97.6, 100.0 );
			SetSkill( SkillName.Wrestling, 90.1, 92.5 );

			Fame = 15000;
			Karma = -15000;

			VirtualArmor = 60;

			AddItem( new LighterSource() );
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.FilthyRich, 4 );
			AddLoot( LootPack.Gems, 8 );
		}

		public override bool OnBeforeDeath()
		{
			this.Body = 13;
			this.Hue = 0x482;
			this.BaseSoundID = 768;
			return base.OnBeforeDeath();
		}

		public override int GetAttackSound(){ return 0x61A; }	// A
		public override int GetDeathSound(){ return 0x61B; }	// D
		public override int GetHurtSound(){ return 0x61C; }		// H
		public override int TreasureMapLevel{ get{ return 4; } }
		public override bool BleedImmune{ get{ return true; } }
		public override Poison PoisonImmune{ get{ return Poison.Deadly; } }
		public override bool AutoDispel{ get{ return true; } }

		public override void OnGaveMeleeAttack( Mobile m )
		{
			base.OnGaveMeleeAttack( m );

			if ( 0.1 >= Utility.RandomDouble() && this.Fame > 15000 )
				DoSpecialAbility( m );
		}

		public override void OnGotMeleeAttack( Mobile m )
		{
			base.OnGotMeleeAttack( m );

			if ( 0.1 >= Utility.RandomDouble() && this.Fame > 15000 )
				DoSpecialAbility( m );
		}

		public void DoSpecialAbility( Mobile target )
		{
			if ( target == null || target.Deleted ) //sanity
				return;

			if ( 0.25 >= Utility.RandomDouble() ) // 25% chance
				SpawnCreature( target );
		}

		public void SpawnCreature( Mobile target )
		{
			Map map = this.Map;

			if ( map == null )
				return;

			int monsters = 0;

			foreach ( Mobile m in this.GetMobilesInRange( 4 ) )
			{
				if ( m is Spectre )
					++monsters;
			}

			if ( monsters < 6 )
			{
				PlaySound( 0x216 );

				int newmonsters = Utility.RandomMinMax( 1, 3 );

				for ( int i = 0; i < newmonsters; ++i )
				{
					BaseCreature monster;

					monster = new Spectre();

					monster.Team = this.Team;

					bool validLocation = false;
					Point3D loc = this.Location;

					for ( int j = 0; !validLocation && j < 10; ++j )
					{
						int x = X + Utility.Random( 3 ) - 1;
						int y = Y + Utility.Random( 3 ) - 1;
						int z = map.GetAverageZ( x, y );

						if ( validLocation = map.CanFit( x, y, this.Z, 16, false, false ) )
							loc = new Point3D( x, y, Z );
						else if ( validLocation = map.CanFit( x, y, z, 16, false, false ) )
							loc = new Point3D( x, y, z );
					}

					monster.ControlSlots = 666; // WIZARD ADDED FOR MONSTER CLEANUP
					monster.MoveToWorld( loc, map );
					monster.Combatant = target;
				}
			}
		}

		public DragonGhost( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}