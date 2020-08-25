using System;

namespace LabC
{
    public class DisplayTouchSettings
    {
        public DisplayTouchSettings(bool beepontouch, bool taptowake)
        {
            BeepOnTouch = beepontouch;
            TapToWake = taptowake;
        }
        public bool BeepOnTouch
        {
            get { return vBeepOnTouch; }
            private set { vBeepOnTouch = value; }
        }
        public bool TapToWake
        {
            get { return vTapToWake; }
            private set { vTapToWake = value; }
        }

        private bool vTapToWake;
        private bool vBeepOnTouch;

        public string ReturnTouchSettings()
        {
            string returnsettings;
            if (BeepOnTouch)
            {
                returnsettings = "\tBeep on touch is activated\n";
            }
            else
            {
                returnsettings = "\tBeep on touch is not activated\n";
            }

            if (BeepOnTouch)
            {
                returnsettings += "\tTap to wake is actived";
            }
            else
            {
                returnsettings += "\tTap to wake is not activated";
            }
            return returnsettings;
        }
    }
}