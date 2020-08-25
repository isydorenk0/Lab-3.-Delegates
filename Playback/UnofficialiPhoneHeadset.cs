using System.Windows.Forms;

namespace LabC
{
    public class UnofficialiPhoneHeadset : IPlayback
    {
        private IOutput Output;
        public UnofficialiPhoneHeadset(IOutput output)
        {
            Output = output;
        }
        public void Display(TextBox data)
        {
            Output.DisplayLine(data, $"{nameof(UnofficialiPhoneHeadset)} sound");
        }
    }
}
