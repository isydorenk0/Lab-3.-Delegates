using System.Collections.Generic;
using System.Linq;

namespace LabC
{
    public class BatteryBasic
    {
        public BatteryBasic(bool builtinb, int capacity, bool wirelesschargeb, BatteryTypes batterytype)
        {
            Builtinb = builtinb;
            Capacity = capacity;
            Wirelesschrgb = wirelesschargeb;                            
            BatteryType = batterytype;            
        }
        public bool Builtinb
        {
            get { return vBuiltinb; }
            private set { vBuiltinb = value; }
        }
        public BatteryTypes BatteryType
        {
            get { return vBatterType; }
            private set { vBatterType = value; }
        }

        public int Capacity
        {
            get { return vCapacity; }
            private set { vCapacity = value; }
        }
        public bool Wirelesschrgb
        {
            get { return vWirelesschrgb; }
            private set { vWirelesschrgb = value; }
        }
        public override string ToString()
        {
            string returnmessage = $"Battery type:\t\t {BatteryType.ToString()}\n";
            returnmessage += $"Capacity:\t\t {Capacity}\n";
            returnmessage += $"Is built-in:\t\t {Builtinb}\n";
            returnmessage += $"Is Wireless charged:\t {Wirelesschrgb}\n";
            return returnmessage;
        }
        public enum BatteryTypes { PoLiBattery, LiIonBattery };
        private BatteryTypes vBatterType;        
        private int vCapacity;
        private bool vBuiltinb;
        private bool vWirelesschrgb;
    }

}