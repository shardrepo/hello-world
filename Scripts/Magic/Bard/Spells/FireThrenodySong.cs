using System;
using Server.Targeting;
using Server.Network;
using Server.Mobiles;
using Server.Items;
using Server.Misc;

namespace Server.Spells.Song
{
	public class FireThrenodySong : Song
	{
		
		private static SpellInfo m_Info = new SpellInfo(
				"Fire Threnody", "*plays a fire threnody*",
				//SpellCircle.First,
				//212,9041
				-1
			);
		
		public FireThrenodySong( Mobile caster, Item scroll) : base( caster, scroll, m_Info )
		{
		}

		private SongBook m_Book;
		//public override double CastDelay{ get{ return 2; } }
		public override TimeSpan CastDelayBase { get { return TimeSpan.FromSeconds( 5 ); } }
		public override double RequiredSkill{ get{ return 70.0; } }
		public override int RequiredMana{ get{ return 25; } }

		public override void OnCast()
		{
			Caster.Target = new InternalTarget( this );
		}

		public virtual bool CheckSlayer( BaseInstrument instrument, Mobile defender )
		{
			SlayerEntry atkSlayer = SlayerGroup.GetEntryByName( instrument.Slayer );
			SlayerEntry atkSlayer2 = SlayerGroup.GetEntryByName( instrument.Slayer2 );

			if ( atkSlayer != null && atkSlayer.Slays( defender )  || atkSlayer2 != null && atkSlayer2.Slays( defender ) )
				return true;

			return false;
		}

		public void Target( Mobile m )
		{
			PlayerMobile p = m as PlayerMobile;
			bool sings = false;

			if ( !Caster.CanSee( m ) )
			{
				Caster.SendLocalizedMessage( 500237 ); // Target can not be seen.
			}
             else if ( CheckHSequence( m ) )
			{
				sings = true;

            //get songbook instrument
            Spellbook book = Spellbook.Find(Caster, -1, SpellbookType.Song);
            if (book == null)
               {
                return;
               }
            m_Book = (SongBook)book;
            if (m_Book.Instrument == null || !(Caster.InRange(m_Book.Instrument.GetWorldLocation(), 1)))
            {
                Caster.SendMessage("Your instrument is missing! You can select another from your song book.");
                return;
            }

				Mobile source = Caster;
				SpellHelper.Turn( source, m );

				bool IsSlayer = false;
				if ( m is BaseCreature ){ IsSlayer = CheckSlayer( m_Book.Instrument, m ); }

                int amount = (int)((Caster.Skills[SkillName.Musicianship].Value + Caster.Skills[SkillName.Peacemaking].Value + Caster.Skills[SkillName.Provocation].Value + Caster.Skills[SkillName.Discordance].Value) / 4 * .167);
				TimeSpan duration = TimeSpan.FromSeconds( Caster.Skills[SkillName.Musicianship].Value * 0.3 ); 

				if ( IsSlayer == true )
				{
					amount = amount * 2;
					duration = TimeSpan.FromSeconds( Caster.Skills[SkillName.Musicianship].Value * 0.6 );
				}

				m.SendMessage( "Your resistance to fire has decreased." );
				ResistanceMod mod1 = new ResistanceMod( ResistanceType.Fire, - amount );
				
				m.FixedParticles( 0x374A, 10, 30, 5013, 0x489, 2, EffectLayer.Waist );
				
				m.AddResistanceMod( mod1 );

				ExpireTimer timer1 = new ExpireTimer( m, mod1, duration );
				timer1.Start();
			}

			BardFunctions.UseBardInstrument( m_Book.Instrument, sings, Caster );
			FinishSequence();
		}

		private class ExpireTimer : Timer
		{
			private Mobile m_Mobile;
			private ResistanceMod m_Mods;

			public ExpireTimer( Mobile m, ResistanceMod mod, TimeSpan delay ) : base( delay )
			{
				m_Mobile = m;
				m_Mods = mod;
			}

			public void DoExpire()
			{
				PlayerMobile p = m_Mobile as PlayerMobile;
				m_Mobile.RemoveResistanceMod( m_Mods );
				
				Stop();
			}

			protected override void OnTick()
			{
				if ( m_Mobile != null )
				{
					m_Mobile.SendMessage( "The effect of the fire threnody wears off." );
					DoExpire();
				}
			}
		}

		private class InternalTarget : Target
		{
			private FireThrenodySong m_Owner;

			public InternalTarget( FireThrenodySong owner ) : base( 12, false, TargetFlags.Harmful )
			{
				m_Owner = owner;
			}

			protected override void OnTarget( Mobile from, object o )
			{
				if ( o is Mobile )
					m_Owner.Target( (Mobile)o );
			}

			protected override void OnTargetFinish( Mobile from )
			{
				m_Owner.FinishSequence();
			}
		}
	}
}
