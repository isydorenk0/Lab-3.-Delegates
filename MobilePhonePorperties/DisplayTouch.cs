namespace LabC
{
    public class DisplayTouch : DisplayBasic
    {
        public DisplayTouch(int horiz, int vert, int dpi, int numbertouches, double diagonal, bool beepontouch, bool taptowake, vPanelTypes type) : base(horiz, vert, dpi, diagonal, type)
        {
            NumberTouches = numbertouches;
            TouchSettings = new DisplayTouchSettings(beepontouch, taptowake);
        }

        public int NumberTouches
        {
            get { return vNumberTouches; }
            private set { vNumberTouches = value; }
        }
        public DisplayTouchSettings TouchSettings
        {
            get { return vTouchSettings; }
            set { vTouchSettings = value; }
        }

        private int vNumberTouches;
        private DisplayTouchSettings vTouchSettings;

        public override string ToString()
        {
            string returnmessage = $"{ReturnBasicInfo()}\n";
            returnmessage += $"Number of touches:\t{ NumberTouches.ToString() }\n";
            returnmessage += $"Touch settings:\n{TouchSettings.ReturnTouchSettings()}\n";            
            return returnmessage;
        }
    }
}



