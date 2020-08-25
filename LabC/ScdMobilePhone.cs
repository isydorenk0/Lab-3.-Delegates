namespace LabC
{
    internal class ScdMobilePhone : MobilePhone
    {
        public override ESimCard ESimCard { get { return vESimCard; } }
        public override BatteryBasic BatteryBasic { get { return vBatteryBasic; } }
        public override DisplayTouch TouchDisplay { get { return vTouchDisplay; } }
        public override BodyBasic Body { get { return vBody; } }
        public ScdMobilePhone()
        {
            vESimCard = new ESimCard("TMobile", "+1123456789");
            vESimCard.AddNew("AT&T", "+1987654321");
            vESimCard.Unlock("SUPERUSER");

            vBatteryBasic = new BatteryBasic(false, 10000, true, BatteryBasic.BatteryTypes.LiIonBattery);
            vTouchDisplay = new DisplayTouch(750, 1334, 300, 5, 5.5, true, true, DisplayBasic.vPanelTypes.LCD);
            vBody = new BodyBasic(100, 60.5, 140.9, 5, "Blue", BodyBasic.BodyTypes.Bar);
        }
        private readonly ESimCard vESimCard;
        private readonly BatteryBasic vBatteryBasic;
        private readonly DisplayTouch vTouchDisplay;
        private readonly BodyBasic vBody;
    }
}