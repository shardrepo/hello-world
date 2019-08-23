using System;
 
namespace Server.Items
{
    public class WhiteGrandfatherClockS : Item
    {
        [Constructable]
        public WhiteGrandfatherClockS() : base( 18644 )
        {
            this.Name = "White Grandfather Clock S";
            this.Hue = 0;
        }
 
        public WhiteGrandfatherClockS( Serial serial ) : base( serial )
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
