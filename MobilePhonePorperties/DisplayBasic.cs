using System;
using System.Collections.Generic;

namespace LabC
{
    public class DisplayBasic 
    {
        public DisplayBasic(int horiz, int vert, int dpi, double diagonal, vPanelTypes type)
        {
            PanelType = type;
            Pixels = new DisplayResolution(horiz, vert, dpi, diagonal);            
        }

        public DisplayResolution Pixels
        {
            get { return vPixels; }
            set { vPixels = value; }
        }

        public vPanelTypes PanelType {
            get { return vPanelType;  } 
            private set { vPanelType = value; }
        }

        public enum vPanelTypes { OLED, AMOLED, LCD };
        private DisplayResolution vPixels;
        private vPanelTypes vPanelType;
        
        public string ReturnBasicInfo()
        {
            string returninfo;
            returninfo = $"Display:\t\t{Pixels.ReturnResolution()}\n";
            returninfo += $"Type:\t\t\t{PanelType.ToString()}";
            return returninfo;
        }
    }  
}