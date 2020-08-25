using System.Collections.Generic;

namespace LabC
{

    public class ESimCard : SimCardBasic
    {
        public ESimCard(string carrier, string phoneNumber)
        {
            esimCardPhoneNumber = new ESimCardPhoneNumbers(carrier, phoneNumber);
        }
        public void AddNew(string newCarrier, string newPhoneNumber)
        {
            esimCardPhoneNumber.Add(newCarrier, newPhoneNumber);
        }
        public string ReturnCarrier(int index)
        {
            if (index <= esimCardPhoneNumber.Carrier.Count && index >= 0)
            {
                var returnstring = esimCardPhoneNumber.Carrier[index];
                return returnstring;
            }
            else
            {
                var returnstring = $"{index} out of range!";
                return returnstring;
            }
        }
        public string ReturnPhone(int index)
        {
            if (index <= esimCardPhoneNumber.Carrier.Count && index >= 0)
            {
                var returnstring = esimCardPhoneNumber.PhoneNumber[index];
                return returnstring;
            }
            else
            {
                var returnstring = $"{index} out of range!";
                return returnstring;
            }
        }
        public override string ToString()
        {
            string returnmessage = $"SimCard type {simtype}\n";
            returnmessage += ReturnLockStatus() + "\n";
            for (int i = 0; i < esimCardPhoneNumber.Carrier.Count; i++)
            {
                returnmessage += $"Carrier {i+1}: {esimCardPhoneNumber.Carrier[i]};\t Phone Number: {esimCardPhoneNumber.PhoneNumber[i]}\n";
            }
            return returnmessage;
        }

        const string simtype = "ESimType";
        private ESimCardPhoneNumbers esimCardPhoneNumber;
    }
}