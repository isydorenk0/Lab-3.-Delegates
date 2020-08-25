using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabC
{
    class SimCard : SimCardBasic
    {
        public SimCard(string carrier, SimcardTypes simtype, string phonenumber)
        {
            Carrier = carrier;
            SimCardType = simtype.ToString();
            PhoneNumber = phonenumber;
        }
        public string Carrier
        {
            get { return vCarrier; }
            private set { vCarrier = value; }
        }
        public string PhoneNumber
        {
            get { return vPhoneNumber; }
            private set { vPhoneNumber = value; }
        }
        public string SimCardType
        {
            get { return vSimCardType; }
            private set { vSimCardType = value; }
        }
        public override string ToString()
        {
            string returnmessage = $"SimCard type {SimCardType}";
            returnmessage += ReturnLockStatus();
            returnmessage += $"Carrier: {Carrier} Phone Number: {PhoneNumber}";        
            return returnmessage;
        }

        private string vSimCardType;
        private string vCarrier;
        private string vPhoneNumber;
        public enum SimcardTypes
        {
            ESimCard, StandardSIM, MicroSIM, NanoSIM
        }
    }
}
