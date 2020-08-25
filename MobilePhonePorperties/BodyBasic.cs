using System;
using System.Drawing;
using System.Linq;

namespace LabC
{
    public class BodyBasic
    {
        public BodyBasic(double weight, double width, double height, double depth, string color, BodyTypes type)
        {
            Weight = weight;
            Width = width;
            Height = height;
            Depth = depth;
            Color = color;
            BodyType = type;
        }
        public string Color
        {
            get { return vColor; }
            private set
            {
                if (vColors.Any(value.Contains))
                {
                    vColor = value;
                }
                else
                {
                    Error.Show(value);
                }
            }
        }
        public double Width
        {
            get { return vWidth; }
            private set { vWidth = value; }
        }
        public double Height
        {
            get { return vHeight; }
            private set { vHeight = value; }
        }
        public double Depth
        {
            get { return vDepth; }
            private set { vDepth = value; }
        }
        public double Weight
        {
            get { return vWeight; }
            private set { vWeight = value; }
        }

        public BodyTypes BodyType
        {
            get { return vBodyType; }
            private set { vBodyType = value; }
        }

        private double vWidth;
        private double vHeight;
        private double vDepth;
        private double vWeight;
        private string vColor;
        private string[] vColors = Enum.GetNames(typeof(KnownColor));
        private BodyTypes vBodyType;
        public enum BodyTypes { Flip, Bar };

        public override string ToString()
        {
            string returnmessage = $"{FormatDimensions(Width, Height, Depth)}\n";
            returnmessage += $"Weight:\t\t\t{ Weight.ToString() }\n";
            returnmessage += $"Type of body:\t\t{FormatBodyTypeMessage(BodyType)}\n";
            return returnmessage;
        }

        private string FormatDimensions(double width, double height, double depth)
        {
            string dimensions = $"Dimension:\t\t{height.ToString()}x{width.ToString()}x{depth.ToString()} mm";            
            return dimensions;
        }

        public string FormatBodyTypeMessage(BodyTypes bodytype)
        {
            string message;
            switch (bodytype)
            {
                case BodyTypes.Flip:
                    message = "This is a flip phone";
                    break;
                case BodyTypes.Bar:
                    message = "This is a flip phone";
                    break;
                default:
                    message = "Not supported type of phone body";
                    break;
            }            
            return message;
        }
    }
}