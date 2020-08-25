using System.Collections.Generic;

namespace LabC
{
    public class SimCardBasic
    {
        public bool Locked
        {
            get { return locked; }
        }
        public void Unlock(string user)
        {
            if (user == "SUPERUSER")
            {
                locked = false;
            }
        }
        public string ReturnLockStatus()
        {
            string returnmessage = "Network unlocked SIM card";
            if (Locked)
            {
                returnmessage = "Network locked SIM card";
            }
            return returnmessage;
        }
        private bool locked = true;
    }
}