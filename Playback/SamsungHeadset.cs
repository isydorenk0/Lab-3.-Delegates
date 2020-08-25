using System.Windows.Forms;

namespace LabC
{
    public class SamsungHeadset : IPlayback
    {
        private IOutput Output;
        public SamsungHeadset(IOutput output)
        {
            Output = output;
        }
        public void Display(TextBox data)
        {
            Output.DisplayLine(data, $"{nameof(SamsungHeadset)} sound");
        } 
    }
}
