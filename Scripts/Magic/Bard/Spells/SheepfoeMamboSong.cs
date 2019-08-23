using System;
using System.Collections;
using Server;
using Server.Mobiles;
using Server.Network;
using Server.Items;
using Server.Targeting;
using Server.Gumps;
using Server.Spells;
using Server.Misc;

namespace Server.Spells.Song
{
	public class SheepfoeMamboSong : Song
	{
		
		private static SpellInfo m_Info = new SpellInfo(
				"Shepherd's Dance", "*plays a shepherd's dance*",
				//SpellCircle.First,
				//212,9041
				-1
			);

		private SongBook m_Book;
		public override TimeSpan CastDelayBase { get { return TimeSpan.FromSeconds( 2 ); } }
		public override double RequiredSkill{ get{ return 60.0; } }
		public override int RequiredMana{ get{ return 20; } }
		
		public SheepfoeMamboSong( Mobile caster, Item scroll) : base( caster, scroll, m_Info )
		{
		}

        public override void OnCast()
        {
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

			bool sings = false;
 
			if( CheckSequence() )
			{
				sings = true;
 
				ArrayList targets = new ArrayList();

				foreach ( Mobile m in Caster.GetMobilesInRange( 3 ) )
				{
					if ( Caster.CanBeBeneficial( m, false, true ) && !(m is Golem) )
						targets.Add( m );
				}

				for ( int i = 0; i < targets.Count; ++i )
				{
					Mobile m = (Mobile)targets[i];
					
					Mobile source = Caster;

                    double allvalue = Caster.Skills[SkillName.Musicianship].Value + Caster.Skills[SkillName.Provocation].Value + Caster.Skills[SkillName.Discordance].Value + Caster.Skills[SkillName.Peacemaking].Value;
                    int amount = (int)(Math.Max((Caster.Skills[SkillName.Musicianship].Value * 0.1), ((allvalue-360) * 0.15)));
					string dex = "dex";
						
					double duration = ( Caster.Skills[SkillName.Musicianship].Value  ); 
						
					StatMod mod = new StatMod( StatType.Dex, dex, + amount, TimeSpan.FromSeconds( duration ) );
						
					m.AddStatMod( mod );
						
					m.FixedParticles( 0x375A, 10, 15, 5017, 0x224, 3, EffectLayer.Waist );
				}
			}

			BardFunctions.UseBardInstrument( m_Book.Instrument, sings, Caster );
			FinishSequence();
		}
	}
}
