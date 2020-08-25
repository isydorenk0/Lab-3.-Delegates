using System.Collections.Generic;

namespace LabC
{
    class Screen
    {
        public interface IScreenImage
        {
            int ImageSize { get; set; }
            List<string> Type { get; set; }
        }
        public abstract class ScreenBase
        {
            public abstract void Show(IScreenImage screenImage);
            public abstract void Show(IScreenImage screenImage, int brightness);
        }
        public class MonochromeScreen : ScreenBase
        {
            public override void Show(IScreenImage screenImage)
            {
            }
            public override void Show(IScreenImage screenImage, int brightness)
            {
            }
            public override string ToString()
            {
             return "Monochrome screen";                
            }
        }
        public class ColorfulScreen : ScreenBase
        {
            public override void Show(IScreenImage screenImage)
            {
            }
            public override void Show(IScreenImage screenImage, int brightness)
            {
            }
            public override string ToString()
            {
                return "Colorful screen";
            }
        }
        public class OLEDScreen : ColorfulScreen
        {
            public override void Show(IScreenImage screenImage)
            {
            }
            public override void Show(IScreenImage screenImage, int brightness)
            {
            }
            public override string ToString()
            {
                return "OLED screen";
            }
        }
        public class RetinaScreen : ColorfulScreen
        {
            public override void Show(IScreenImage screenImage)
            {
            }
            public override void Show(IScreenImage screenImage, int brightness)
            {
            }
            public override string ToString()
            {
                return "Retina screen";
            }
        }
    }
}