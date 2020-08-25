using System;
using System.Collections.Generic;

namespace LabC
{
    internal class ESimCardPhoneNumbers
    {
        public ESimCardPhoneNumbers(string carrier, string phoneNumber){
            VCarrier.Add(carrier);
            VPhoneNumber.Add(phoneNumber);
        }

        public List<string> Carrier
        {
            get { return VCarrier; }
        }
        public List<string> PhoneNumber
        {
            get { return VPhoneNumber; }
        }

        public List<string> VCarrier
        {
            get { return vCarrier; }
            set { vCarrier = value; }
        }

        public List<string> VPhoneNumber
        {
            get { return vPhoneNumber; }
            set { vPhoneNumber = value; }
        }

        internal void Add(string newCarrier, string newPhoneNumber)
        {
            if (VCarrier.Contains(newCarrier))
            {
                Error.ShowAlreadyExists(newCarrier);
            }
            else
            {
                VCarrier.Add(newCarrier);
                VPhoneNumber.Add(newPhoneNumber);
            }
        }
        private List<string> vCarrier = new List<string>();
        private List<string> vPhoneNumber = new List<string>();        
    }
}