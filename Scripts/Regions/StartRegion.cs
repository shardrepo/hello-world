using System;
using System.Xml;
using Server;
using Server.Mobiles;
using Server.Gumps;
using Server.Spells;
using Server.Spells.Seventh;
using Server.Spells.Fourth;
using Server.Spells.Sixth;
using Server.Spells.Chivalry;
using System.Text;
using System.IO;

namespace Server.Regions
{
	public class StartRegion : BaseRegion
	{
		public StartRegion( XmlElement xml, Map map, Region parent ) : base( xml, map, parent )
		{
		}

		public override bool AllowHousing( Mobile from, Point3D p )
		{
			return false;
		}

		public override TimeSpan GetLogoutDelay( Mobile m )
		{
			return TimeSpan.Zero;
		}

		public override void AlterLightLevel( Mobile m, ref int global, ref int personal )
		{
			global = LightCycle.NightLevel;
		}

		public override bool AllowHarmful( Mobile from, Mobile target )
		{
			if (( from is PlayerMobile ) && ( target is PlayerMobile ))
				return false;
			else
				return true;
		}

		public override bool OnBeginSpellCast( Mobile m, ISpell s )
		{
			m.SendMessage( "That does not seem to work here." );
			return false;
		}
		
		public override void OnExit( Mobile m )
		{
			m.CloseGump( typeof( NameAlterGump ) );
		}								
	}
}