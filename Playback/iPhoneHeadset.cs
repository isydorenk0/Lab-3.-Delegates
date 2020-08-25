using System.Windows.Forms;

namespace LabC
{
    public class iPhoneHeadset : IPlayback
    {
        private IOutput Output;
        public iPhoneHeadset(IOutput output)
        {
            Output = output;
        }

        public void Display(TextBox data)
        {
            Output.DisplayLine(data, $"{nameof(iPhoneHeadset)} sound");
        }       
    }
}

